using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.TaskSchedulerCore;
using Maple.MonoGameAssistant.WinApi;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.UITask
{
    public static class UITaskSchedulerExtensions
    {
        public static async ValueTask<T_RETURN> UITaskAsync<T_GAMECONTEXT, T_RETURN>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_RETURN> func)
            where T_GAMECONTEXT : class
        {
            var taskState = new UITaskState_Func<T_GAMECONTEXT, T_RETURN>(taskScheduler.GameContext, func);
            if (await ExecSetTimerAsync(taskState).ConfigureAwait(false))
            {
                return taskState.ReturnValue!;
            }
            return TaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(ExecSetTimerAsync)}");
        }


        public static async ValueTask<T_RETURN> UITaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
            where T_GAMECONTEXT : class
            where T_ARGS : notnull
        {
            var taskState = new UITaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>(taskScheduler.GameContext, func, args);
            if (await ExecSetTimerAsync(taskState).ConfigureAwait(false))
            {
                return taskState.ReturnValue!;
            }
            return TaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(ExecSetTimerAsync)}");
        }


        public static async ValueTask<bool> UITaskAsync<T_GAMECONTEXT>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT> action)
            where T_GAMECONTEXT : class
        {
            var taskState = new UITaskState_Action<T_GAMECONTEXT>(taskScheduler.GameContext, action);
            if (await ExecSetTimerAsync(taskState).ConfigureAwait(false))
            {
                return true;
            }
            return TaskStateException.Throw<bool>($"EXEC ERROR {nameof(ExecSetTimerAsync)}");
        }


        public static async ValueTask<bool> UITaskAsync<T_GAMECONTEXT, T_ARGS>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT, T_ARGS> action, T_ARGS args)
            where T_GAMECONTEXT : class
            where T_ARGS : notnull
        {
            var taskState = new UITaskState_ActionArgs<T_GAMECONTEXT, T_ARGS>(taskScheduler.GameContext, action, args);
            if (await  ExecSetTimerAsync(taskState).ConfigureAwait(false))
            {
                return true;
            }
            return TaskStateException.Throw<bool>($"EXEC ERROR {nameof(ExecSetTimerAsync)}");

        }
     

        static async ValueTask<bool> ExecSetTimerAsync(UITaskState taskState)
        {

            var hwnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            if (hwnd == nint.Zero)
            {
                return TaskStateException.Throw<bool>("NOT FOUND MainWindowHandle");
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
