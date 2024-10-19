using Maple.MonoGameAssistant.AndroidCore;

namespace Maple.MonoGameAssistant.AndroidCore
{

    internal class AndroidTaskState<T_CONTEXT>(T_CONTEXT   ctx)
        where T_CONTEXT : class
    {
        public T_CONTEXT Context { get; } = ctx;
    }

}
