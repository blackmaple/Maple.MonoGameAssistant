using Maple.MonoGameAssistant.AndroidCore;

namespace Maple.MonoGameAssistant.AndroidCore
{
    internal class AndroidTaskState_Func<T_CONTEXT, T_RETURN>(T_CONTEXT context,  Func<T_CONTEXT, T_RETURN> func) 
        : AndroidTaskState<T_CONTEXT>(context)
        where T_CONTEXT : class
    {
        public Func<T_CONTEXT, T_RETURN> Func { get; } = func;

 
 
        public T_RETURN Execute()
        {
            return this.Func.Invoke(this.Context);
            
        }

 
    }

}
