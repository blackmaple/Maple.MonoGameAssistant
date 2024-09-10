using Microsoft.Extensions.DependencyInjection;

namespace Maple.MonoGameAssistant.Core
{
    public static class MonoTaskSchedulerExtensions
    {

        public static Task<T_RETURN> MonoTaskAsync<T_CONTEXT, T_ARGS, T_RETURN>(this IMonoTaskScheduler<T_CONTEXT> taskScheduler, Func<T_CONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
            where T_CONTEXT : class
            where T_ARGS : notnull
        {
            var taskState = new MonoTaskState_FuncArgs<T_CONTEXT, T_ARGS, T_RETURN>(taskScheduler.Context, func, args);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.Scheduler);

            static T_RETURN ExecCodeProc(object? state)
            {
                if (state is not MonoTaskState_FuncArgs<T_CONTEXT, T_ARGS, T_RETURN> taskState)
                {
                    return MonoTaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(MonoTaskState_FuncArgs<T_CONTEXT, T_ARGS, T_RETURN>)}");
                }
                return taskState.Execute();
            }
        }

        public static Task<T_RETURN> MonoTaskAsync<T_CONTEXT, T_RETURN>(this IMonoTaskScheduler<T_CONTEXT> taskScheduler, Func<T_CONTEXT, T_RETURN> func)
            where T_CONTEXT : class
        {
            var taskState = new MonoTaskState_Func<T_CONTEXT, T_RETURN>(taskScheduler.Context, func);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.Scheduler);

            static T_RETURN ExecCodeProc(object? state)
            {
                if (state is not MonoTaskState_Func<T_CONTEXT, T_RETURN> taskState)
                {
                    return MonoTaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(MonoTaskState_Func<T_CONTEXT, T_RETURN>)}");
                }
                return taskState.Execute();
            }
        }

        public static Task<bool> MonoTaskAsync<T_CONTEXT>(this IMonoTaskScheduler<T_CONTEXT> taskScheduler, Action<T_CONTEXT> action)
            where T_CONTEXT : class
        {
            var taskState = new MonoTaskState_Action<T_CONTEXT>(taskScheduler.Context, action);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.Scheduler);

            static bool ExecCodeProc(object? state)
            {
                if (state is not MonoTaskState_Action<T_CONTEXT> taskState)
                {
                    return default;
                }
                return taskState.Execute();

            }
        }

        public static Task<bool> MonoTaskAsync<T_CONTEXT, T_ARGS>(this IMonoTaskScheduler<T_CONTEXT> taskScheduler, Action<T_CONTEXT, T_ARGS> action, T_ARGS args)
           where T_CONTEXT : class
           where T_ARGS : notnull
        {
            var taskState = new MonoTaskState_ActionArgs<T_CONTEXT, T_ARGS>(taskScheduler.Context, action, args);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.Scheduler);

            static bool ExecCodeProc(object? state)
            {
                if (state is not MonoTaskState_ActionArgs<T_CONTEXT, T_ARGS> taskState)
                {
                    return default;
                }
                return taskState.Execute();
            }
        }



        public static IServiceCollection AddMonoTaskScheduler(this IServiceCollection serviceDescriptors)
        {
            return serviceDescriptors.AddSingleton<MonoTaskScheduler>();
        }
    }
}
