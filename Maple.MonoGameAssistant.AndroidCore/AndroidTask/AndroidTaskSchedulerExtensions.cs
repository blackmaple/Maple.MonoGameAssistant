using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
namespace Maple.MonoGameAssistant.AndroidCore
{
    public static class AndroidTaskSchedulerExtensions
    {

        public static Task<T_RETURN> AndroidTaskAsync<T_CONTEXT, T_ARGS, T_RETURN>(this IAndroidTaskScheduler<T_CONTEXT> taskScheduler, Func<T_CONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
            where T_CONTEXT : class
            where T_ARGS : notnull
        {
            var taskState = new AndroidTaskState_FuncArgs<T_CONTEXT, T_ARGS, T_RETURN>(taskScheduler.Context, func, args);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.AndroidScheduler);

            static T_RETURN ExecCodeProc(object? state)
            {
                if (state is not AndroidTaskState_FuncArgs<T_CONTEXT, T_ARGS, T_RETURN> taskState)
                {
                    return AndroidTaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(AndroidTaskState_FuncArgs<T_CONTEXT, T_ARGS, T_RETURN>)}");
                }
                return taskState.Execute();
            }
        }

        public static Task<T_RETURN> AndroidTaskAsync<T_CONTEXT, T_RETURN>(this IAndroidTaskScheduler<T_CONTEXT> taskScheduler, Func<T_CONTEXT, T_RETURN> func)
            where T_CONTEXT : class
        {
            var taskState = new AndroidTaskState_Func<T_CONTEXT, T_RETURN>(taskScheduler.Context, func);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.AndroidScheduler);

            static T_RETURN ExecCodeProc(object? state)
            {
                if (state is not AndroidTaskState_Func<T_CONTEXT, T_RETURN> taskState)
                {
                    return AndroidTaskStateException.Throw<T_RETURN>($"NOT FOUND {nameof(AndroidTaskState_Func<T_CONTEXT, T_RETURN>)}");
                }
                return taskState.Execute();
            }
        }

        public static Task<bool> AndroidTaskAsync<T_CONTEXT>(this IAndroidTaskScheduler<T_CONTEXT> taskScheduler, Action<T_CONTEXT> action)
            where T_CONTEXT : class
        {
            var taskState = new AndroidTaskState_Action<T_CONTEXT>(taskScheduler.Context, action);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.AndroidScheduler);

            static bool ExecCodeProc(object? state)
            {
                if (state is not AndroidTaskState_Action<T_CONTEXT> taskState)
                {
                    return default;
                }
                return taskState.Execute();

            }
        }

        public static Task<bool> AndroidTaskAsync<T_CONTEXT, T_ARGS>(this IAndroidTaskScheduler<T_CONTEXT> taskScheduler, Action<T_CONTEXT, T_ARGS> action, T_ARGS args)
           where T_CONTEXT : class
           where T_ARGS : notnull
        {
            var taskState = new AndroidTaskState_ActionArgs<T_CONTEXT, T_ARGS>(taskScheduler.Context, action, args);
            return Task.Factory.StartNew(ExecCodeProc, taskState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, taskScheduler.AndroidScheduler);

            static bool ExecCodeProc(object? state)
            {
                if (state is not AndroidTaskState_ActionArgs<T_CONTEXT, T_ARGS> taskState)
                {
                    return default;
                }
                return taskState.Execute();
            }
        }



      
    }
}
