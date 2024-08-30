using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;
using Maple.MonoGameAssistant.HotKey.Abstractions;

namespace Maple.MonoGameAssistant.HookTask
{
    internal sealed class HookTaskState_Action<T_GAMECONTEXT>(T_GAMECONTEXT gameContext, IHookWinMsgService hook, Action<T_GAMECONTEXT> action)
        : HookTaskState<T_GAMECONTEXT>(gameContext, hook)
        where T_GAMECONTEXT : MonoCollectorContext
    {
        public Action<T_GAMECONTEXT> Action { get; } = action;

        protected override void ExecuteImp()
        {
            Action.Invoke(GameContext);
        }

    }
}
