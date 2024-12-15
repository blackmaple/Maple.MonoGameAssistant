namespace Maple.MonoGameAssistant.Windows.HookTask
{
    internal sealed class HookTaskState_ActionArgs<T_CONTEXT, T_Args>(IHookTaskScheduler<T_CONTEXT> taskScheduler, Action<T_CONTEXT, T_Args> action, T_Args args)
        : HookTaskState<T_CONTEXT>(taskScheduler)
        where T_CONTEXT : class
        where T_Args : notnull
    {
        public Action<T_CONTEXT, T_Args> Action { get; } = action;
        public T_Args Args { get; } = args;

        protected override void ExecuteImp()
        {
            Action.Invoke(Context, Args);
        }
    }
}
