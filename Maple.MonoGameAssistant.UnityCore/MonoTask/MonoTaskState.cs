using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal class MonoTaskState<T_GAMECONTEXT>(T_GAMECONTEXT gameContext)
        where T_GAMECONTEXT : MonoCollectorContext
    {
        public T_GAMECONTEXT GameContext { get; } = gameContext;
    }



}
