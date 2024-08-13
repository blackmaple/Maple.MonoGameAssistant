using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal abstract class UnityTaskState
    {
        public bool ExecSuccess { set; get; }
        public void Execute()
        {
            this.ExecuteImp();
            this.ExecSuccess = true;
        }

        protected abstract void ExecuteImp();

    }

    internal class UnityTaskState<T_GAMECONTEXT>(T_GAMECONTEXT gameContext, HookWinMsgService hook): UnityTaskState
        where T_GAMECONTEXT : MonoCollectorContext
    {
        public HookWinMsgService Hook { get; } = hook;
        public T_GAMECONTEXT GameContext { get; } = gameContext;

        protected override void ExecuteImp()
        {
            
        }
    }

}
