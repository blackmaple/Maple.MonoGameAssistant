using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Windows.HotKey.ThreadMessage;
using Maple.MonoGameAssistant.Windows.WinRT;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage
{
    using unsafe CallbackWndProc = delegate* unmanaged[Stdcall]<nint, EnumWindowMessage, nint, nint, nint>;
    using unsafe ExecUnmanagedCodeProc = delegate*<nint, void>;
    public sealed unsafe class HookWinMsgService
    {
        NotifyThreadMessage? ThreadMessage { get; set; }
        MapleObjectUnmanaged ObjectUnmanaged { get; }
        nint HookWindowHandle { get; }
        nint OldCallbackWndProc { set; get; }
        nint OldUserData { set; get; }

        public HookWinMsgService(nint hWnd)
        {
            HookWindowHandle = hWnd;
            OldCallbackWndProc = nint.Zero;
            OldUserData = nint.Zero;
            ObjectUnmanaged = new MapleObjectUnmanaged(this);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)])]
        static unsafe nint CallbackWndProc(nint hWnd, EnumWindowMessage msg, nint wParam, nint lParam)
        {
            if (TryGetHookWindowMessage(hWnd, out var hookWindowMessage))
            {
                var pCallback = hookWindowMessage.OldCallbackWndProc;
                if (pCallback != nint.Zero)
                {
                    if (msg == EnumWindowMessage.WM_KEYDOWN)
                    {
                        hookWindowMessage.ThreadMessage?.TrySendThreadMsg(msg, wParam, lParam);
                    }
                    else if (msg == EnumWindowMessage.USER_EXEC_CODE)
                    {
                        ExecUnmanagedCode(wParam, lParam);
                    }
                    else if (msg == EnumWindowMessage.WM_CLOSE)
                    {
                        hookWindowMessage.ThreadMessage?.TryExit();
                    }
                    return WindowsRuntime.CallWindowProc(pCallback, hWnd, msg, wParam, lParam);
                }
            }
            return WindowsRuntime.DefWindowProc(hWnd, msg, wParam, lParam);


        }

        static bool TryGetHookWindowMessage(nint hWnd, [MaybeNullWhen(false)] out HookWinMsgService hookWindowMessage)
        {
            hookWindowMessage = default;
            if (WindowsRuntime.TryGetWindowUserData(hWnd, out var pUserData))
            {
                return MapleObjectUnmanaged.TryGet(pUserData, out hookWindowMessage);
            }
            return false;
        }


        public bool SetHook()
        {
            if (OldCallbackWndProc != nint.Zero)
            {
                UnHook();
            }
            if (WindowsRuntime.TrySetWindowUserData(HookWindowHandle, ObjectUnmanaged.ToIntPtr(), out var userData))
            {
                CallbackWndProc callbackWndProc = &CallbackWndProc;
                OldUserData = userData;
                OldCallbackWndProc = WindowsRuntime.SetWindowLongPtr(HookWindowHandle, EnumWindowLongPtrIndex.GWLP_WNDPROC, (nint)callbackWndProc);
            }
            return OldCallbackWndProc != nint.Zero;
        }

        public bool SetHook(IWinMsgNotifyService winMsgNotify, bool managedThreadMessage = true)
        {
            var b = SetHook();
            if (b)
            {
                ThreadMessage = managedThreadMessage ? new ManagedThreadMessage(winMsgNotify) : new UnmanagedThreadMessage(winMsgNotify);
                _ = ThreadMessage.RunAsync();
            }
            return b;
        }


        public void UnHook()
        {
            if (OldCallbackWndProc != nint.Zero)
            {

                WindowsRuntime.SetWindowLongPtr(HookWindowHandle, EnumWindowLongPtrIndex.GWLP_WNDPROC, OldCallbackWndProc);
                WindowsRuntime.TrySetWindowUserData(HookWindowHandle, OldUserData, out _);
                OldCallbackWndProc = nint.Zero;
                OldUserData = nint.Zero;
                ThreadMessage?.TryExit();
            }
        }

        public void Dispose()
        {
            UnHook();
            ObjectUnmanaged.Dispose();

        }

        //public bool TrySendExecUnmanagedCode<T_RETURN>(ExecUnmanagedCodeProc execCode, scoped ref ExecUnmanagedCodeContext<T_RETURN> execCodeContext)
        //    where T_RETURN : unmanaged
        //{
        //    nint lParam = ExecUnmanagedCodeContextExtensions.SetCodeContext(ref execCodeContext);
        //    return TrySendExecUnmanagedCode(execCode, lParam);
        //}
        public bool TrySendExecUnmanagedCode(ExecUnmanagedCodeProc execCode, nint pArgs)
        {
            nint wParam = new(execCode);
            nint lParam = pArgs;
            return WindowsRuntime.SendMessageTimeout(HookWindowHandle, EnumWindowMessage.USER_EXEC_CODE, wParam, lParam, WindowsRuntime.SMTO_BLOCK, 5000, out _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ExecUnmanagedCode(nint pProc, nint pArgs)
        {
            var execCode = (ExecUnmanagedCodeProc)pProc;
            execCode(pArgs);
        }

    }
}
