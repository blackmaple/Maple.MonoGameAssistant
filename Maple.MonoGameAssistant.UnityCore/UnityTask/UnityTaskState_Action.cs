using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal sealed class UnityTaskState_Action<T_GAMECONTEXT>(T_GAMECONTEXT gameContext, HookWinMsgService hook, Action<T_GAMECONTEXT> action)
        : UnityTaskState<T_GAMECONTEXT>(gameContext, hook)
        where T_GAMECONTEXT : MonoCollectorContext
    {
        public Action<T_GAMECONTEXT> Action { get; } = action;

        public void Execute()
        {
            this.Action.Invoke(this.GameContext);
            this.ExecSuccess = true;
        }

    }
}
