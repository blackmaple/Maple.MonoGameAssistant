using Maple.MonoGameAssistant.Common;
using System.Runtime.Versioning;

namespace Maple.MonoGameAssistant.Windows.HookTask
{
    /// <summary>
    /// 利用HOOK WINMSG 发送函数到主线程执行
    /// </summary>
    [SupportedOSPlatform("windows")]
    public static class HookTaskSchedulerExtensions
    {

        public static async Task<T_RETURN> HookTaskAsync<T_CONTEXT, T_RETURN>(this IHookTaskScheduler<T_CONTEXT> taskScheduler, Func<T_CONTEXT, T_RETURN> func)
            where T_CONTEXT : class
        {
            var hookState = new HookTaskState_Func<T_CONTEXT, T_RETURN>(taskScheduler, func);
            if (await Task.Factory.StartNew(SendExecUnmanagedCode, hookState).ConfigureAwait(false))
            {
                return hookState.ReturnValue!;
            }
            return HookTaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(SendExecUnmanagedCode)}");

        }

        public static async Task<T_RETURN> HookTaskAsync<T_CONTEXT, T_ARGS, T_RETURN>(this IHookTaskScheduler<T_CONTEXT> taskScheduler, Func<T_CONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
            where T_CONTEXT : class
            where T_ARGS : notnull
        {
            var hookState = new HookTaskState_FuncArgs<T_CONTEXT, T_ARGS, T_RETURN>(taskScheduler, func, args);
            if (await Task.Factory.StartNew(SendExecUnmanagedCode, hookState).ConfigureAwait(false))
            {
                return hookState.ReturnValue!;
            }
            return HookTaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(SendExecUnmanagedCode)}");
        }

        public static async Task<bool> HookTaskAsync<T_CONTEXT>(this IHookTaskScheduler<T_CONTEXT> taskScheduler, Action<T_CONTEXT> action)
            where T_CONTEXT : class
        {
            var hookState = new HookTaskState_Action<T_CONTEXT>(taskScheduler, action);
            if (await Task.Factory.StartNew(SendExecUnmanagedCode, hookState))
            {
                return true;
            }
            return HookTaskStateException.Throw<bool>($"EXEC ERROR {nameof(SendExecUnmanagedCode)}");

        }

        public static async Task<bool> HookTaskAsync<T_CONTEXT, T_ARGS>(this IHookTaskScheduler<T_CONTEXT> taskScheduler, Action<T_CONTEXT, T_ARGS> action, T_ARGS args)
            where T_CONTEXT : class
            where T_ARGS : notnull
        {
            var hookState = new HookTaskState_ActionArgs<T_CONTEXT, T_ARGS>(taskScheduler, action, args);
            if (await Task.Factory.StartNew(SendExecUnmanagedCode, hookState))
            {
                return true;
            }
            return HookTaskStateException.Throw<bool>($"EXEC ERROR {nameof(SendExecUnmanagedCode)}");

        }

        static unsafe bool SendExecUnmanagedCode(object? state)
        {
            if (state is not HookTaskState taskState)
            {
                return false;
            }

            using var unmanagedRef = new MapleObjectUnmanaged_Ref(taskState);
            if (taskState.Hook.TrySendExecUnmanagedCode(&ExecUnmanagedCode, unmanagedRef.ToIntPtr()))
            {
                return taskState.ExecSuccess;
            }
            return false;

        }

        static void ExecUnmanagedCode(nint pArgs)
        {
            if (MapleObjectUnmanaged_Ref.TryGet<HookTaskState>(pArgs, out var taskState))
            {
                taskState.Execute();
            }
        }

    }
}
