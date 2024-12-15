namespace Maple.MonoGameAssistant.Windows.HookTask
{
    internal sealed class HookTaskState_Action<T_CONTEXT>(IHookTaskScheduler<T_CONTEXT> taskScheduler, Action<T_CONTEXT> action)
        : HookTaskState<T_CONTEXT>(taskScheduler)
        where T_CONTEXT : class
    {
        public Action<T_CONTEXT> Action { get; } = action;

        protected override void ExecuteImp()
        {
            Action.Invoke(Context);
        }

    }
}
