using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.HookTask
{
    internal sealed class HookTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>
        ( IHookTaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args) 
        : HookTaskState<T_GAMECONTEXT>(taskScheduler)
    where T_GAMECONTEXT : class
    where T_ARGS : notnull
        //    where T_RETURN : notnull
    {
        public Func<T_GAMECONTEXT, T_ARGS, T_RETURN> Func { get; } = func;
        public T_ARGS Args { get; } = args;

        public T_RETURN? ReturnValue { set; get; }

        public bool TryGetValue([MaybeNullWhen(false)] out T_RETURN val)
        {
            val = ReturnValue;
            return ExecSuccess;
        }

        protected override void ExecuteImp()
        {
            ReturnValue = Func.Invoke(GameContext, Args);
        }

    }

}
