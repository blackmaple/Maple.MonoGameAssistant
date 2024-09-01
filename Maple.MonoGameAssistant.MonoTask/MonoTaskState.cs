using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.MonoTask
{
    //internal class MonoTaskState
    //{ 
        
    //}

    internal class MonoTaskState<T_GAMECONTEXT>(T_GAMECONTEXT gameContext)
        where T_GAMECONTEXT : class
    {
        public T_GAMECONTEXT GameContext { get; } = gameContext;
    }



}
