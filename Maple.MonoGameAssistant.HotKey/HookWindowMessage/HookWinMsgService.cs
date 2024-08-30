using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.HotKey.Abstractions;
using Maple.MonoGameAssistant.WinApi;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.HotKey
{
    using unsafe ExecUnmanagedCodeProc = delegate*<nint, void>;

    using unsafe CallbackWndProc = delegate* unmanaged[Stdcall]<nint, EnumWindowMessage, nint, nint, nint>;
    internal sealed unsafe class HookWinMsgService : IHookWinMsgService
    {
        UnmanagedThreadMessage? ThreadMessage { get; set; }
        MapleObjectUnmanaged ObjectUnmanaged { get; }
        nint HookWindowHandle { get; }
        nint OldCallbackWndProc { set; get; }
        nint OldUserData { set; get; }

        public HookWinMsgService(nint hWnd)
        {
            this.HookWindowHandle = hWnd;

            this.OldCallbackWndProc = nint.Zero;
            this.OldUserData = nint.Zero;
            this.ObjectUnmanaged = new MapleObjectUnmanaged(this);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)])]
        static unsafe nint CallbackWndProc(nint hWnd, EnumWindowMessage msg, nint wParam, nint lParam)
        {
            if (hWnd.TryGetHookWindowMessage(out var hookWindowMessage))
            {
                var pCallback = (nint)hookWindowMessage.OldCallbackWndProc;
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

        public bool SetHook()
        {
            if (this.OldCallbackWndProc != nint.Zero)
            {
                this.UnHook();
            }
            if (this.HookWindowHandle.TrySetWindowUserData(this.ObjectUnmanaged.ToIntPtr(), out var userData))
            {
                CallbackWndProc callbackWndProc = &CallbackWndProc;
                this.OldUserData = userData;
                this.OldCallbackWndProc = WindowsRuntime.SetWindowLongPtr(this.HookWindowHandle, EnumWindowLongPtrIndex.GWLP_WNDPROC, (nint)callbackWndProc);
            }
            return this.OldCallbackWndProc != nint.Zero;
        }

        public bool SetHook(IWinMsgNotifyService winMsgNotify)
        {
            var b = this.SetHook();
            if (b)
            {
                this.ThreadMessage = new UnmanagedThreadMessage(winMsgNotify);
                _ = this.ThreadMessage.RunAsync();
            }
            return b;
        }


        public void UnHook()
        {
            if (this.OldCallbackWndProc != nint.Zero)
            {

                WindowsRuntime.SetWindowLongPtr(this.HookWindowHandle, EnumWindowLongPtrIndex.GWLP_WNDPROC, this.OldCallbackWndProc);
                this.HookWindowHandle.TrySetWindowUserData(this.OldUserData, out _);
                this.OldCallbackWndProc = nint.Zero;
                this.OldUserData = nint.Zero;
                this.ThreadMessage?.TryExit();
            }
        }

        public void Dispose()
        {
            this.UnHook();
            this.ObjectUnmanaged.Dispose();

        }

        public bool TrySendExecUnmanagedCode<T_RETURN>(ExecUnmanagedCodeProc execCode, scoped ref ExecUnmanagedCodeContext<T_RETURN> execCodeContext)
            where T_RETURN : unmanaged
        {
            nint lParam = ExecUnmanagedCodeContextExtensions.SetCodeContext(ref execCodeContext);
            return TrySendExecUnmanagedCode(execCode, lParam);
        }
        public bool TrySendExecUnmanagedCode(ExecUnmanagedCodeProc execCode, nint pArgs)
        {
            nint wParam = new(execCode);
            nint lParam = pArgs;
            return WindowsRuntime.SendMessageTimeout(this.HookWindowHandle, EnumWindowMessage.USER_EXEC_CODE, wParam, lParam, WindowsRuntime.SMTO_BLOCK, 5000, out _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ExecUnmanagedCode(nint pProc, nint pArgs)
        {
            var execCode = (ExecUnmanagedCodeProc)pProc;
            execCode(pArgs);
        }

    }
}
