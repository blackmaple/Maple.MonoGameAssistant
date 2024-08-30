using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey.Abstractions;
using Maple.MonoGameAssistant.TaskSchedulerCore;
using System.Runtime.Versioning;

namespace Maple.MonoGameAssistant.HookTask
{
    [SupportedOSPlatform("windows")]
    public static class HookTaskSchedulerExtensions
    {
        public static Task<T_RETURN> HookTasksync<T_GAMECONTEXT, T_RETURN>(this IHookTaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_RETURN> func)
            where T_GAMECONTEXT : MonoCollectorContext
            //      where T_RETURN : notnull
        {
            return HookTaskAsync(taskScheduler.GameContext, taskScheduler.Hook, func);
        }
        public static Task<T_RETURN> HookTaskAsync<T_GAMECONTEXT, T_RETURN>(this T_GAMECONTEXT gameContext, IHookWinMsgService hook, Func<T_GAMECONTEXT, T_RETURN> func)
            where T_GAMECONTEXT : MonoCollectorContext
            //         where T_RETURN : notnull
        {
            return Task.Factory.StartNew(SendExecUnmanagedCode, new HookTaskState_Func<T_GAMECONTEXT, T_RETURN>(gameContext, hook, func));

            static unsafe T_RETURN SendExecUnmanagedCode(object? state)
            {
                if (state is not HookTaskState_Func<T_GAMECONTEXT, T_RETURN> taskState)
                {
                    return TaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(HookTaskState_Func<T_GAMECONTEXT, T_RETURN>)}");
                }

                using var unmanagedRef = new MapleObjectUnmanaged_Ref(taskState);
                if (taskState.Hook.TrySendExecUnmanagedCode(&ExecUnmanagedCode, unmanagedRef.ToIntPtr()))
                {
                    if (taskState.TryGetValue(out var val))
                    {
                        return val;
                    }
                }
                return TaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(ExecUnmanagedCode)}");
            }
            static void ExecUnmanagedCode(nint pArgs)
            {
                if (MapleObjectUnmanaged_Ref.TryGet<HookTaskState_Func<T_GAMECONTEXT, T_RETURN>>(pArgs, out var taskState))
                {
                   
                    taskState.Execute();
                }
            }

        }

        public static Task<T_RETURN> UnityTaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this IHookTaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
            where T_GAMECONTEXT : MonoCollectorContext
            where T_ARGS : notnull
            //  where T_RETURN : notnull
        {
            return UnityTaskAsync(taskScheduler.GameContext, taskScheduler.Hook, func, args);
        }
        public static Task<T_RETURN> UnityTaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this T_GAMECONTEXT gameContext, IHookWinMsgService hook, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
                    where T_GAMECONTEXT : MonoCollectorContext
                    where T_ARGS : notnull
            //          where T_RETURN : notnull
        {
            var taskState = new HookTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>(gameContext, hook, func, args);
            return Task.Factory.StartNew(SendExecUnmanagedCode, taskState);

            static unsafe T_RETURN SendExecUnmanagedCode(object? state)
            {
                if (state is not HookTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN> taskState)
                {
                    return TaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(HookTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>)}");
                }

                using var unmanagedRef = new MapleObjectUnmanaged_Ref(taskState);
                if (taskState.Hook.TrySendExecUnmanagedCode(&ExecUnmanagedCode, unmanagedRef.ToIntPtr()))
                {
                    if (taskState.TryGetValue(out var val))
                    {
                        return val;
                    }
                }
                return TaskStateException.Throw<T_RETURN>($"EXEC ERROR {nameof(ExecUnmanagedCode)}");
            }

            static void ExecUnmanagedCode(nint pArgs)
            {
                if (MapleObjectUnmanaged_Ref.TryGet<HookTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>>(pArgs, out var taskState))
                {
                    taskState.Execute();
                }
            }

        }

        public static Task<bool> UnityTaskAsync<T_GAMECONTEXT>(this IHookTaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT> action)
            where T_GAMECONTEXT : MonoCollectorContext
        {
            return UnityTaskAsync(taskScheduler.GameContext, taskScheduler.Hook, action);
        }
        public static Task<bool> UnityTaskAsync<T_GAMECONTEXT>(this T_GAMECONTEXT gameContext, IHookWinMsgService hook, Action<T_GAMECONTEXT> action)
                    where T_GAMECONTEXT : MonoCollectorContext
        {
            return Task.Factory.StartNew(SendExecUnmanagedCode, new HookTaskState_Action<T_GAMECONTEXT>(gameContext, hook, action));

            static unsafe bool SendExecUnmanagedCode(object? state)
            {
                if (state is not HookTaskState_Action<T_GAMECONTEXT> taskState)
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
                if (MapleObjectUnmanaged_Ref.TryGet<HookTaskState_Action<T_GAMECONTEXT>>(pArgs, out var taskState))
                {
                    taskState.Execute();
                }
            }
        }

        public static Task<bool> UnityTaskAsync<T_GAMECONTEXT, T_ARGS>(this IHookTaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT, T_ARGS> action, T_ARGS args)
            where T_GAMECONTEXT : MonoCollectorContext
            where T_ARGS : notnull
        {
            return UnityTaskAsync(taskScheduler.GameContext, taskScheduler.Hook, action, args);
        }
        public static Task<bool> UnityTaskAsync<T_GAMECONTEXT, T_ARGS>(this T_GAMECONTEXT gameContext, IHookWinMsgService hook, Action<T_GAMECONTEXT, T_ARGS> action, T_ARGS args)
                    where T_GAMECONTEXT : MonoCollectorContext
                    where T_ARGS : notnull
        {
            return Task.Factory.StartNew(SendExecUnmanagedCode, new HookTaskState_ActionArgs<T_GAMECONTEXT, T_ARGS>(gameContext, hook, action, args));

            static unsafe bool SendExecUnmanagedCode(object? state)
            {
                if (state is not HookTaskState_ActionArgs<T_GAMECONTEXT, T_ARGS> taskState)
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
                if (MapleObjectUnmanaged_Ref.TryGet<HookTaskState_ActionArgs<T_GAMECONTEXT, T_ARGS>>(pArgs, out var taskState))
                {
                    taskState.Execute();
                }
            }
        }


    }
}
