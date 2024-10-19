namespace Maple.MonoGameAssistant.AndroidCore
{
    public interface IAndroidTaskScheduler<T_CONTEXT> where T_CONTEXT : class
    {
        T_CONTEXT Context { get; }
        TaskScheduler Scheduler { get; }

    }



}
