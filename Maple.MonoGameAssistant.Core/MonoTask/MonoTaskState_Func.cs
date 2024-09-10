using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.Core
{
    internal class MonoTaskState_Func<T_CONTEXT, T_RETURN>(T_CONTEXT context,  Func<T_CONTEXT, T_RETURN> func) 
        : MonoTaskState<T_CONTEXT>(context)
        where T_CONTEXT : class
    {
        public Func<T_CONTEXT, T_RETURN> Func { get; } = func;

 
 
        public T_RETURN Execute()
        {
            return this.Func.Invoke(this.Context);
            
        }

 
    }

}
