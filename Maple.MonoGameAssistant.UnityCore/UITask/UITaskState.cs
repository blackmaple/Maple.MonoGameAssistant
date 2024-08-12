using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal class UITaskState<T_GAMECONTEXT>(T_GAMECONTEXT gameContext)
        where T_GAMECONTEXT : MonoCollectorContext
    {
        public T_GAMECONTEXT GameContext { get; } = gameContext;
        public bool ExecSuccess { set; get; } = false;

    }



}
