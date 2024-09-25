using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.WinApi;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.UITask
{
    public static class UITaskSchedulerExtensions
    {
        public static async ValueTask<T_RETURN> UITaskAsync<T_CONTEXT, T_RETURN>(this IUITaskScheduler<T_CONTEXT> taskScheduler, Func<T_CONTEXT, T_RETURN> func)
            where T_CONTEXT : class
        {
            var taskState = new UITaskState_Func<T_CONTEXT, T_RETURN>(taskScheduler.Context, func);
            if (await ExecSetTimerAsync(taskState).ConfigureAwait(false))
            {
                return taskState.ReturnValue!;
            }
            return UITaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(ExecSetTimerAsync)}");
        }


        public static async ValueTask<T_RETURN> UITaskAsync<T_CONTEXT, T_ARGS, T_RETURN>(this IUITaskScheduler<T_CONTEXT> taskScheduler, Func<T_CONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
            where T_CONTEXT : class
            where T_ARGS : notnull
        {
            var taskState = new UITaskState_FuncArgs<T_CONTEXT, T_ARGS, T_RETURN>(taskScheduler.Context, func, args);
            if (await ExecSetTimerAsync(taskState).ConfigureAwait(false))
            {
                return taskState.ReturnValue!;
            }
            return UITaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(ExecSetTimerAsync)}");
        }


        public static async ValueTask<bool> UITaskAsync<T_CONTEXT>(this IUITaskScheduler<T_CONTEXT> taskScheduler, Action<T_CONTEXT> action)
            where T_CONTEXT : class
        {
            var taskState = new UITaskState_Action<T_CONTEXT>(taskScheduler.Context, action);
            if (await ExecSetTimerAsync(taskState).ConfigureAwait(false))
            {
                return true;
            }
            return UITaskStateException.Throw<bool>($"EXEC ERROR {nameof(ExecSetTimerAsync)}");
        }


        public static async ValueTask<bool> UITaskAsync<T_CONTEXT, T_ARGS>(this IUITaskScheduler<T_CONTEXT> taskScheduler, Action<T_CONTEXT, T_ARGS> action, T_ARGS args)
            where T_CONTEXT : class
            where T_ARGS : notnull
        {
            var taskState = new UITaskState_ActionArgs<T_CONTEXT, T_ARGS>(taskScheduler.Context, action, args);
            if (await  ExecSetTimerAsync(taskState).ConfigureAwait(false))
            {
                return true;
            }
            return UITaskStateException.Throw<bool>($"EXEC ERROR {nameof(ExecSetTimerAsync)}");

        }
     

        static async ValueTask<bool> ExecSetTimerAsync(UITaskState taskState)
        {

            var hwnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            if (hwnd == nint.Zero)
            {
                return UITaskStateException.Throw<bool>("NOT FOUND MainWindowHandle");
            }
            using var objectUnmanaged = new MapleObjectUnmanaged(taskState);
            var id = (nuint)objectUnmanaged.ToIntPtr();
            SetTimer(hwnd, id);
            return await taskState.WaitAsync().ConfigureAwait(false) && taskState.ExecSuccess;

            unsafe static void SetTimer(nint hwnd, nuint id)
            {
                const uint USER_TIMER_MINIMUM = 0xa;
                //  const uint USER_TIMER_MAXIMUM = 0x7FFFFFFF;

                WindowsRuntime.SetTimer(hwnd, id, USER_TIMER_MINIMUM, &TimerProc);
            }

        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)])]
        static void TimerProc(nint hwnd, uint message, nuint nIDEvent, uint dwTime)
        {
            WindowsRuntime.KillTimer(hwnd, nIDEvent);
            if (MapleObjectUnmanaged.TryGet<UITaskState>((nint)nIDEvent, out var taskState))
            {
                taskState.Execute();
            }
        }
    }
}
