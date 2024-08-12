//using Maple.MonoGameAssistant.Common;
//using Maple.MonoGameAssistant.Core;
//using Maple.MonoGameAssistant.HotKey;
//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;

//namespace Maple.MonoGameAssistant.UnityCore
//{
//    public static class UITaskSchedulerExtensions
//    {
//        public static Task<T_RETURN> UITaskAsync<T_GAMECONTEXT, T_RETURN>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_RETURN> func)
//            where T_GAMECONTEXT : MonoCollectorContext
//            //      where T_RETURN : notnull
//        {
//            return UITaskAsync(taskScheduler.GameContext, func);
//        }
//        public static Task<T_RETURN> UITaskAsync<T_GAMECONTEXT, T_RETURN>(this T_GAMECONTEXT gameContext, Func<T_GAMECONTEXT, T_RETURN> func)
//            where T_GAMECONTEXT : MonoCollectorContext
//            //         where T_RETURN : notnull
//        {
//            return Task.Factory.StartNew(SendExecUnmanagedCode, new UnityTaskState_Func<T_GAMECONTEXT, T_RETURN>(gameContext, hook, func));

//            static unsafe T_RETURN SendExecUnmanagedCode(object? state)
//            {
//                if (state is not UnityTaskState_Func<T_GAMECONTEXT, T_RETURN> taskState)
//                {
//                    return TaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(UnityTaskState_Func<T_GAMECONTEXT, T_RETURN>)}");
//                }

//                using var unmanagedRef = new MapleObjectUnmanaged_Ref(taskState);
//                if (taskState.Hook.TrySendExecUnmanagedCode(&ExecUnmanagedCode, unmanagedRef.ToIntPtr()))
//                {
//                    if (taskState.TryGetValue(out var val))
//                    {
//                        return val;
//                    }
//                }
//                return TaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(ExecUnmanagedCode)}");
//            }
//            static void ExecUnmanagedCode(nint pArgs)
//            {
//                if (MapleObjectUnmanaged_Ref.TryGet<UnityTaskState_Func<T_GAMECONTEXT, T_RETURN>>(pArgs, out var taskState))
//                {
//                    taskState.Execute();
//                }
//            }

//        }

//        public static Task<T_RETURN> UITaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
//            where T_GAMECONTEXT : MonoCollectorContext
//            where T_ARGS : notnull
//            //  where T_RETURN : notnull
//        {
//            return UITaskAsync(taskScheduler.GameContext, func, args);
//        }
//        public static Task<T_RETURN> UITaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this T_GAMECONTEXT gameContext, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
//                    where T_GAMECONTEXT : MonoCollectorContext
//                    where T_ARGS : notnull
//            //          where T_RETURN : notnull
//        {
//            var taskState = new UITaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>(gameContext, func, args);
//            return Task.Factory.StartNew(ExecSetTimer, taskState);

//            static unsafe T_RETURN ExecSetTimer(object? state)
//            {
//                if (state is not UITaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN> taskState)
//                {
//                    return TaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(UITaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>)}");
//                }

//                using var unmanagedRef = new MapleObjectUnmanaged_Ref(taskState);
//                nuint id = (nuint)unmanagedRef.ToIntPtr();
//                if (WinApi.SetTimer())
//                {
//                    if (taskState.TryGetValue(out var val))
//                    {
//                        return val;
//                    }
//                }
//                return TaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(ExecUnmanagedCode)}");
//            }

//            static void ExecUnmanagedCode(nint pArgs)
//            {
//                if (MapleObjectUnmanaged_Ref.TryGet<UnityTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>>(pArgs, out var taskState))
//                {
//                    taskState.Execute();
//                }
//            }

//        }

//        public static Task<bool> UITaskAsync<T_GAMECONTEXT>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT> action)
//            where T_GAMECONTEXT : MonoCollectorContext
//        {
//            return UITaskAsync(taskScheduler.GameContext, action);
//        }
//        public static Task<bool> UITaskAsync<T_GAMECONTEXT>(this T_GAMECONTEXT gameContext, Action<T_GAMECONTEXT> action)
//                    where T_GAMECONTEXT : MonoCollectorContext
//        {
//            return Task.Factory.StartNew(SendExecUnmanagedCode, new UITaskState_Action<T_GAMECONTEXT>(gameContext, action));

//            static unsafe bool SendExecUnmanagedCode(object? state)
//            {
//                if (state is not UITaskState_Action<T_GAMECONTEXT> taskState)
//                {
//                    return false;
//                }

//                using var unmanagedRef = new MapleObjectUnmanaged_Ref(taskState);
//                if (taskState.Hook.TrySendExecUnmanagedCode(&ExecUnmanagedCode, unmanagedRef.ToIntPtr()))
//                {
//                    return taskState.ExecSuccess;
//                }
//                return false;

//            }
//            static void ExecUnmanagedCode(nint pArgs)
//            {
//                if (MapleObjectUnmanaged_Ref.TryGet<UnityTaskState_Action<T_GAMECONTEXT>>(pArgs, out var taskState))
//                {
//                    taskState.Execute();
//                }
//            }
//        }

//        public static Task<bool> UITaskAsync<T_GAMECONTEXT, T_ARGS>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT, T_ARGS> action, T_ARGS args)
//            where T_GAMECONTEXT : MonoCollectorContext
//            where T_ARGS : notnull
//        {
//            return UITaskAsync(taskScheduler.GameContext,   action, args);
//        }
//        public static Task<bool> UITaskAsync<T_GAMECONTEXT, T_ARGS>(this T_GAMECONTEXT gameContext, Action<T_GAMECONTEXT, T_ARGS> action, T_ARGS args)
//                    where T_GAMECONTEXT : MonoCollectorContext
//                    where T_ARGS : notnull
//        {
//            return Task.Factory.StartNew(SendExecUnmanagedCode, new UITaskState_ActionArgs<T_GAMECONTEXT, T_ARGS>(gameContext,   action, args));

//            static unsafe bool SendExecUnmanagedCode(object? state)
//            {
//                if (state is not UITaskState_ActionArgs<T_GAMECONTEXT, T_ARGS> taskState)
//                {
//                    return false;
//                }

//                using var unmanagedRef = new MapleObjectUnmanaged_Ref(taskState);
//                if (taskState.Hook.TrySendExecUnmanagedCode(&ExecUnmanagedCode, unmanagedRef.ToIntPtr()))
//                {
//                    return taskState.ExecSuccess;
//                }
//                return false;

//            }
//            static void ExecUnmanagedCode(nint pArgs)
//            {
//                if (MapleObjectUnmanaged_Ref.TryGet<UITaskState_ActionArgs<T_GAMECONTEXT, T_ARGS>>(pArgs, out var taskState))
//                {
//                    taskState.Execute();
//                }
//            }
//        }

//        const uint USER_TIMER_MINIMUM = 0xa;
//        const uint USER_TIMER_MAXIMUM = 0x7FFFFFFF;

//       unsafe static bool ExecSetTimer<T_UITaskState, T_GAMECONTEXT>(T_UITaskState taskState) where T_UITaskState:UITaskState<T_GAMECONTEXT>
//            where T_GAMECONTEXT : MonoCollectorContext
//        {
//            var hwnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
//            if (hwnd == IntPtr.Zero)
//            {
//                return TaskStateException.Throw<bool>("NOT FOUND MainWindowHandle");

//            }
//            using var unmanagedRef = new MapleObjectUnmanaged_Ref(taskState);
//            var id = (nuint)unmanagedRef.ToIntPtr();
//            WinApi.SetTimer(hwnd, id, USER_TIMER_MINIMUM, &TimerProc);
//            return false;

           
//        }

//     //   [UnmanagedFunctionPointer(CallingConvention.StdCall)]
//        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
//    //    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)])]
//        static void TimerProc(nint hwnd, uint message, nuint nIDEvent, uint dwTime)
//        {
//            WinApi.KillTimer(hwnd, nIDEvent);
//            if(MapleObjectUnmanaged_Ref.TryGet((nint)nIDEvent,out var UITaskState_ActionArgs< T_GAMECONTEXT, T_ARGS >))
//        }
//    }
//}
