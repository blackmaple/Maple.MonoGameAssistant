namespace Maple.MonoGameAssistant.HookTask
{
    internal sealed class HookTaskState_ActionArgs<T_GAMECONTEXT, T_Args>(IHookTaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT, T_Args> action, T_Args args)
        : HookTaskState<T_GAMECONTEXT>(taskScheduler)
        where T_GAMECONTEXT : class
        where T_Args : notnull
    {
        public Action<T_GAMECONTEXT, T_Args> Action { get; } = action;
        public T_Args Args { get; } = args;

        protected override void ExecuteImp()
        {
            Action.Invoke(GameContext, Args);
        }
    }
}
