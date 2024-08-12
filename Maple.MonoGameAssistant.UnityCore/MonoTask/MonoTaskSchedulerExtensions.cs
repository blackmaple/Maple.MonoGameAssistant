using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.UnityCore
{
    public static class MonoTaskSchedulerExtensions
    {

        public static Task<T_RETURN> MonoTaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this IMonoTaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
            where T_GAMECONTEXT : MonoCollectorContext
            where T_ARGS : notnull
     //       where T_RETURN : notnull
            => MonoTaskAsync(taskScheduler.GameContext, taskScheduler.Scheduler, func, args);
        public static Task<T_RETURN> MonoTaskAsync<T_GAMECONTEXT, T_ARGS, T_RETURN>(this T_GAMECONTEXT gameContext, MonoTaskScheduler scheduler, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
            where T_GAMECONTEXT : MonoCollectorContext
            where T_ARGS : notnull
       //    where T_RETURN : notnull
        {
            return Task.Factory.StartNew(ExecCodeProc, new MonoTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>(gameContext, func, args), CancellationToken.None, TaskCreationOptions.DenyChildAttach, scheduler);

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
            where T_GAMECONTEXT : MonoCollectorContext
      //      where T_RETURN : notnull
            => MonoTaskAsync(taskScheduler.GameContext, taskScheduler.Scheduler, func);
        public static Task<T_RETURN> MonoTaskAsync<T_GAMECONTEXT, T_RETURN>(this T_GAMECONTEXT gameContext, MonoTaskScheduler scheduler, Func<T_GAMECONTEXT, T_RETURN> func)
            where T_GAMECONTEXT : MonoCollectorContext
      //      where T_RETURN : notnull
        {
            return Task.Factory.StartNew(ExecCodeProc, new MonoTaskState_Func<T_GAMECONTEXT, T_RETURN>(gameContext, func), CancellationToken.None, TaskCreationOptions.DenyChildAttach, scheduler);

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
            where T_GAMECONTEXT : MonoCollectorContext
            => MonoTaskAsync(taskScheduler.GameContext, taskScheduler.Scheduler, action);
        public static Task<bool> MonoTaskAsync<T_GAMECONTEXT>(this T_GAMECONTEXT gameContext, MonoTaskScheduler scheduler, Action<T_GAMECONTEXT> action)
            where T_GAMECONTEXT : MonoCollectorContext
        {
            return Task.Factory.StartNew(ExecCodeProc, new MonoTaskState_Action<T_GAMECONTEXT>(gameContext, action), CancellationToken.None, TaskCreationOptions.DenyChildAttach, scheduler);

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
            where T_GAMECONTEXT : MonoCollectorContext
            where T_ARGS : notnull
            => MonoTaskAsync(taskScheduler.GameContext, taskScheduler.Scheduler, action, args);
        public static Task<bool> MonoTaskAsync<T_GAMECONTEXT, T_ARGS>(this T_GAMECONTEXT gameContext, MonoTaskScheduler scheduler, Action<T_GAMECONTEXT, T_ARGS> action, T_ARGS args)
            where T_GAMECONTEXT : MonoCollectorContext
            where T_ARGS : notnull
        {
            return Task.Factory.StartNew(ExecCodeProc, new MonoTaskState_ActionArgs<T_GAMECONTEXT, T_ARGS>(gameContext, action, args), CancellationToken.None, TaskCreationOptions.DenyChildAttach, scheduler);

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
