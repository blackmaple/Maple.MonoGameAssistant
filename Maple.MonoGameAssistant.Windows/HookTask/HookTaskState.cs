using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;

namespace Maple.MonoGameAssistant.Windows.HookTask
{
    internal abstract class HookTaskState(HookWinMsgService hook)
    {
        public HookWinMsgService Hook { get; } = hook;

        public bool ExecSuccess { set; get; }
        public void Execute()
        {
            ExecuteImp();
            ExecSuccess = true;
        }

        protected abstract void ExecuteImp();

    }

    internal class HookTaskState<T_CONTEXT>(IHookTaskScheduler<T_CONTEXT> taskScheduler) : HookTaskState(taskScheduler.Hook)
        where T_CONTEXT : class
    {
        public T_CONTEXT Context { get; } = taskScheduler.Context;

        protected override void ExecuteImp()
        {

        }
    }
}
