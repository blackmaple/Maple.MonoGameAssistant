using Maple.MonoGameAssistant.HotKey.Abstractions;

namespace Maple.MonoGameAssistant.HookTask
{
    internal abstract class HookTaskState(IHookWinMsgService hook)
    {
        public IHookWinMsgService Hook { get; } = hook;

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
