using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.Core
{
    //internal class MonoTaskState
    //{ 

    //}

    internal class MonoTaskState<T_CONTEXT>(T_CONTEXT   ctx)
        where T_CONTEXT : class
    {
        public T_CONTEXT Context { get; } = ctx;
    }

}
