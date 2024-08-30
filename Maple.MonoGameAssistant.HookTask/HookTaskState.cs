using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey.Abstractions;

namespace Maple.MonoGameAssistant.HookTask
{
    internal abstract class HookTaskState
    {
        public bool ExecSuccess { set; get; }
        public void Execute()
        {
            ExecuteImp();
            ExecSuccess = true;
        }

        protected abstract void ExecuteImp();

    }

    internal class HookTaskState<T_GAMECONTEXT>(T_GAMECONTEXT gameContext, IHookWinMsgService hook) : HookTaskState
        where T_GAMECONTEXT : MonoCollectorContext
    {
        public IHookWinMsgService Hook { get; } = hook;
        public T_GAMECONTEXT GameContext { get; } = gameContext;

        protected override void ExecuteImp()
        {

        }
    }

}
