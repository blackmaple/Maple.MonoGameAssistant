namespace Maple.MonoGameAssistant.AndroidCore.AndroidTask
{

    internal class AndroidTaskState<T_CONTEXT>(T_CONTEXT ctx)
        where T_CONTEXT : class
    {
        public T_CONTEXT Context { get; } = ctx;
    }

}
