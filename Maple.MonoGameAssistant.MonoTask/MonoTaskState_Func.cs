using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.MonoTask
{
    internal class MonoTaskState_Func<T_GAMECONTEXT, T_RETURN>(T_GAMECONTEXT gameContext,  Func<T_GAMECONTEXT, T_RETURN> func) 
        : MonoTaskState<T_GAMECONTEXT>(gameContext)
        where T_GAMECONTEXT : class
    {
        public Func<T_GAMECONTEXT, T_RETURN> Func { get; } = func;

 
 
        public T_RETURN Execute()
        {
            return this.Func.Invoke(this.GameContext);
            
        }

 
    }

}
