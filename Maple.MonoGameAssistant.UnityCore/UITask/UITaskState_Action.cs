using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal sealed class UITaskState_Action<T_GAMECONTEXT>(T_GAMECONTEXT gameContext, Action<T_GAMECONTEXT> action)
        : UITaskState<T_GAMECONTEXT>(gameContext)
        where T_GAMECONTEXT : MonoCollectorContext
    {
        public Action<T_GAMECONTEXT> Action { get; } = action;

        protected override void ExecuteImp()
        {
            this.Action.Invoke(this.GameContext);
        }

    }
}
