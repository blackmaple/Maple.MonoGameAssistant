using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.UnityCore
{
    public static class UITaskSchedulerExtensions
    {
        public static ValueTask<T_RETURN> UITaskAsync<T_GAMECONTEXT, T_RETURN>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_RETURN> func)
            where T_GAMECONTEXT : MonoCollectorContext
            //      where T_RETURN : notnull
        {
            return UITaskAsync(taskScheduler.GameContext, func);
        }
        public static async ValueTask<T_RETURN> UITaskAsync<T_GAMECONTEXT, T_RETURN>(this T_GAMECONTEXT gameContext, Func<T_GAMECONTEXT, T_RETURN> func)
            where T_GAMECONTEXT : MonoCollectorContext
            //         where T_RETURN : notnull
        {
            var taskState = new UITaskState_Func<T_GAMECONTEXT, T_RETURN>(gameContext, func);
            if (await ExecSetTimerAsync(taskState).ConfigureAwait(false))
            {
                if (taskState.TryGetValue(out var val))
                {
                    return val;
                }
            }
            return TaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(ExecSetTimerAsync)}");

        }

        public static ValueTask<T_RETURN> UITaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
            where T_GAMECONTEXT : MonoCollectorContext
            where T_ARGS : notnull
            //  where T_RETURN : notnull
        {
            return UITaskAsync(taskScheduler.GameContext, func, args);
        }
        public static async ValueTask<T_RETURN> UITaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this T_GAMECONTEXT gameContext, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
                    where T_GAMECONTEXT : MonoCollectorContext
                    where T_ARGS : notnull
            //          where T_RETURN : notnull
        {
            var taskState = new UITaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>(gameContext, func, args);
            if (await ExecSetTimerAsync(taskState).ConfigureAwait(false))
            {
                if (taskState.TryGetValue(out var val))
                {
                    return val;
                }
            }
            return TaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(ExecSetTimerAsync)}");


        }

        public static ValueTask<bool> UITaskAsync<T_GAMECONTEXT>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT> action)
            where T_GAMECONTEXT : MonoCollectorContext
        {
            return UITaskAsync(taskScheduler.GameContext, action);
        }
        public static ValueTask<bool> UITaskAsync<T_GAMECONTEXT>(this T_GAMECONTEXT gameContext, Action<T_GAMECONTEXT> action)
                    where T_GAMECONTEXT : MonoCollectorContext
        {
            var objState = new UITaskState_Action<T_GAMECONTEXT>(gameContext, action);
            return ExecSetTimerAsync(objState);
        }

        public static ValueTask<bool> UITaskAsync<T_GAMECONTEXT, T_ARGS>(this IUITaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT, T_ARGS> action, T_ARGS args)
            where T_GAMECONTEXT : MonoCollectorContext
            where T_ARGS : notnull
        {
            return UITaskAsync(taskScheduler.GameContext, action, args);
        }
        public static ValueTask<bool> UITaskAsync<T_GAMECONTEXT, T_ARGS>(this T_GAMECONTEXT gameContext, Action<T_GAMECONTEXT, T_ARGS> action, T_ARGS args)
                    where T_GAMECONTEXT : MonoCollectorContext
                    where T_ARGS : notnull
        {
            var objectState = new UITaskState_ActionArgs<T_GAMECONTEXT, T_ARGS>(gameContext, action, args);
            return ExecSetTimerAsync(objectState);
        }

        const uint USER_TIMER_MINIMUM = 0xa;
        const uint USER_TIMER_MAXIMUM = 0x7FFFFFFF;

        static async ValueTask<bool> ExecSetTimerAsync(UITaskState taskState)
        {
            var hwnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            if (hwnd == IntPtr.Zero)
            {
                return TaskStateException.Throw<bool>("NOT FOUND MainWindowHandle");
            }
            using var objectUnmanaged = new MapleObjectUnmanaged(taskState);
            var id = (nuint)objectUnmanaged.ToIntPtr();
            SetTimer(hwnd, id);
            return await taskState.WaitAsync().ConfigureAwait(false);

            unsafe static void SetTimer(nint hwnd, nuint id)
            {
                WinApi.SetTimer(hwnd, id, USER_TIMER_MINIMUM, &TimerProc);
            }

        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)])]
        static void TimerProc(nint hwnd, uint message, nuint nIDEvent, uint dwTime)
        {
            WinApi.KillTimer(hwnd, nIDEvent);
            if (MapleObjectUnmanaged.TryGet<UITaskState>((nint)nIDEvent, out var taskState))
            {
                taskState.Execute();
            }
        }
    }
}
