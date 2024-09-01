using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.HookTask
{
    internal class HookTaskState_Func<T_GAMECONTEXT, T_RETURN>(IHookTaskScheduler<T_GAMECONTEXT> taskScheduler, Func<T_GAMECONTEXT, T_RETURN> func) 
        : HookTaskState<T_GAMECONTEXT>(taskScheduler)
        where T_GAMECONTEXT : class
    {
        public Func<T_GAMECONTEXT, T_RETURN> Func { get; } = func;

        public T_RETURN? ReturnValue { set; get; }

        public bool TryGetValue([MaybeNullWhen(false)] out T_RETURN val)
        {
            val = ReturnValue;
            return ExecSuccess;
        }

        protected override void ExecuteImp()
        {
            ReturnValue = Func.Invoke(GameContext);
        }
    }

}
