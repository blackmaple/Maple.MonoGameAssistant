using Maple.MonoGameAssistant.TaskSchedulerCore;

namespace Maple.MonoGameAssistant.MonoTask
{
    public static class MonoTaskSchedulerExtensions
    {

        public static Task<T_RETURN> MonoTaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this IMonoTaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
            where T_GAMECONTEXT : class
            where T_ARGS : notnull
        {
            var taskState = new MonoTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>(taskScheduler.GameContext, func, args);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.Scheduler);

            static T_RETURN ExecCodeProc(object? state)
            {
                if (state is not MonoTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN> taskState)
                {
                    return TaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(MonoTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>)}");
                }
                return taskState.Execute();
            }
        }

        public static Task<T_RETURN> MonoTaskAsync<T_GAMECONTEXT, T_RETURN>(this IMonoTaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_RETURN> func)
            where T_GAMECONTEXT : class
        {
            var taskState = new MonoTaskState_Func<T_GAMECONTEXT, T_RETURN>(taskScheduler.GameContext, func);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.Scheduler);

            static T_RETURN ExecCodeProc(object? state)
            {
                if (state is not MonoTaskState_Func<T_GAMECONTEXT, T_RETURN> taskState)
                {
                    return TaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(MonoTaskState_Func<T_GAMECONTEXT, T_RETURN>)}");
                }
                return taskState.Execute();
            }
        }

        public static Task<bool> MonoTaskAsync<T_GAMECONTEXT>(this IMonoTaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT> action)
            where T_GAMECONTEXT : class
        {
            var taskState = new MonoTaskState_Action<T_GAMECONTEXT>(taskScheduler.GameContext, action);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.Scheduler);

            static bool ExecCodeProc(object? state)
            {
                if (state is not MonoTaskState_Action<T_GAMECONTEXT> taskState)
                {
                    return default;
                }
                return taskState.Execute();

            }
        }

        public static Task<bool> MonoTaskAsync<T_GAMECONTEXT, T_ARGS>(this IMonoTaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT, T_ARGS> action, T_ARGS args)
           where T_GAMECONTEXT : class
           where T_ARGS : notnull
        {
            var taskState = new MonoTaskState_ActionArgs<T_GAMECONTEXT, T_ARGS>(taskScheduler.GameContext, action, args);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.Scheduler);

            static bool ExecCodeProc(object? state)
            {
                if (state is not MonoTaskState_ActionArgs<T_GAMECONTEXT, T_ARGS> taskState)
                {
                    return default;
                }
                return taskState.Execute();
            }
        }

    }
}
