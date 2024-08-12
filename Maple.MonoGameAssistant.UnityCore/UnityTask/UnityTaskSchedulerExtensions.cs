using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;

namespace Maple.MonoGameAssistant.UnityCore
{
    public static class UnityTaskSchedulerExtensions
    {
        public static Task<T_RETURN> UnityTaskAsync<T_GAMECONTEXT, T_RETURN>(this IUnityTaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_RETURN> func)
            where T_GAMECONTEXT : MonoCollectorContext
      //      where T_RETURN : notnull
        {
            return UnityTaskAsync(taskScheduler.GameContext, taskScheduler.Hook, func);
        }
        public static Task<T_RETURN> UnityTaskAsync<T_GAMECONTEXT, T_RETURN>(this T_GAMECONTEXT gameContext, HookWinMsgService hook, Func<T_GAMECONTEXT, T_RETURN> func)
            where T_GAMECONTEXT : MonoCollectorContext
   //         where T_RETURN : notnull
        {
            return Task.Factory.StartNew(SendExecUnmanagedCode, new UnityTaskState_Func<T_GAMECONTEXT, T_RETURN>(gameContext, hook, func));

            static unsafe T_RETURN SendExecUnmanagedCode(object? state)
            {
                if (state is not UnityTaskState_Func<T_GAMECONTEXT, T_RETURN> taskState)
                {
                    return TaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(UnityTaskState_Func<T_GAMECONTEXT, T_RETURN>)}");
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
                if (MapleObjectUnmanaged_Ref.TryGet<UnityTaskState_Func<T_GAMECONTEXT, T_RETURN>>(pArgs, out var taskState))
                {
                    taskState.Execute();
                }
            }

        }

        public static Task<T_RETURN> UnityTaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this IUnityTaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
            where T_GAMECONTEXT : MonoCollectorContext
            where T_ARGS : notnull
          //  where T_RETURN : notnull
        {
            return UnityTaskAsync(taskScheduler.GameContext, taskScheduler.Hook, func, args);
        }
        public static Task<T_RETURN> UnityTaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this T_GAMECONTEXT gameContext, HookWinMsgService hook, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
                    where T_GAMECONTEXT : MonoCollectorContext
                    where T_ARGS : notnull
           //          where T_RETURN : notnull
        {
            var taskState = new UnityTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>(gameContext, hook, func, args);
            return Task.Factory.StartNew(SendExecUnmanagedCode, taskState);

            static unsafe T_RETURN SendExecUnmanagedCode(object? state)
            {
                if (state is not UnityTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN> taskState)
                {
                    return TaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(UnityTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>)}");
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
                if (MapleObjectUnmanaged_Ref.TryGet<UnityTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>>(pArgs, out var taskState))
                {
                    taskState.Execute();
                }
            }

        }

        public static Task<bool> UnityTaskAsync<T_GAMECONTEXT>(this IUnityTaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT> action)
            where T_GAMECONTEXT : MonoCollectorContext
        {
            return UnityTaskAsync(taskScheduler.GameContext, taskScheduler.Hook, action);
        }
        public static Task<bool> UnityTaskAsync<T_GAMECONTEXT>(this T_GAMECONTEXT gameContext, HookWinMsgService hook, Action<T_GAMECONTEXT> action)
                    where T_GAMECONTEXT : MonoCollectorContext
        {
            return Task.Factory.StartNew(SendExecUnmanagedCode, new UnityTaskState_Action<T_GAMECONTEXT>(gameContext, hook, action));

            static unsafe bool SendExecUnmanagedCode(object? state)
            {
                if (state is not UnityTaskState_Action<T_GAMECONTEXT> taskState)
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
                if (MapleObjectUnmanaged_Ref.TryGet<UnityTaskState_Action<T_GAMECONTEXT>>(pArgs, out var taskState))
                {
                    taskState.Execute();
                }
            }
        }

        public static Task<bool> UnityTaskAsync<T_GAMECONTEXT, T_ARGS>(this IUnityTaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT, T_ARGS> action, T_ARGS args)
            where T_GAMECONTEXT : MonoCollectorContext
            where T_ARGS : notnull
        {
            return UnityTaskAsync(taskScheduler.GameContext, taskScheduler.Hook, action, args);
        }
        public static Task<bool> UnityTaskAsync<T_GAMECONTEXT, T_ARGS>(this T_GAMECONTEXT gameContext, HookWinMsgService hook, Action<T_GAMECONTEXT, T_ARGS> action, T_ARGS args)
                    where T_GAMECONTEXT : MonoCollectorContext
                    where T_ARGS : notnull
        {
            return Task.Factory.StartNew(SendExecUnmanagedCode, new UnityTaskState_ActionArgs<T_GAMECONTEXT, T_ARGS>(gameContext, hook, action, args));

            static unsafe bool SendExecUnmanagedCode(object? state)
            {
                if (state is not UnityTaskState_ActionArgs<T_GAMECONTEXT, T_ARGS> taskState)
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
                if (MapleObjectUnmanaged_Ref.TryGet<UnityTaskState_ActionArgs<T_GAMECONTEXT, T_ARGS>>(pArgs, out var taskState))
                {
                    taskState.Execute();
                }
            }
        }


    }
}
