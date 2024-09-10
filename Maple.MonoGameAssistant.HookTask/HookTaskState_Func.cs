using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.HookTask
{
    internal class HookTaskState_Func<T_CONTEXT, T_RETURN>(IHookTaskScheduler<T_CONTEXT> taskScheduler, Func<T_CONTEXT, T_RETURN> func) 
        : HookTaskState<T_CONTEXT>(taskScheduler)
        where T_CONTEXT : class
    {
        public Func<T_CONTEXT, T_RETURN> Func { get; } = func;

        public T_RETURN? ReturnValue { set; get; }

        public bool TryGetValue([MaybeNullWhen(false)] out T_RETURN val)
        {
            val = ReturnValue;
            return ExecSuccess;
        }

        protected override void ExecuteImp()
        {
            ReturnValue = Func.Invoke(Context);
        }
    }

}
