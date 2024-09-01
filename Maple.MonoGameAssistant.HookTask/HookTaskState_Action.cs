namespace Maple.MonoGameAssistant.HookTask
{
    internal sealed class HookTaskState_Action<T_GAMECONTEXT>(IHookTaskScheduler<T_GAMECONTEXT> taskScheduler, Action<T_GAMECONTEXT> action)
        : HookTaskState<T_GAMECONTEXT>(taskScheduler)
        where T_GAMECONTEXT : class
    {
        public Action<T_GAMECONTEXT> Action { get; } = action;

        protected override void ExecuteImp()
        {
            Action.Invoke(GameContext);
        }

    }
}
