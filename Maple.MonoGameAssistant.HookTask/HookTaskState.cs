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

    internal class HookTaskState<T_GAMECONTEXT>(IHookTaskScheduler<T_GAMECONTEXT> taskScheduler) : HookTaskState(taskScheduler.Hook)
        where T_GAMECONTEXT : class
    {
        public T_GAMECONTEXT GameContext { get; } = taskScheduler.GameContext;

        protected override void ExecuteImp()
        {

        }
    }

}
