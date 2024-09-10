namespace Maple.MonoGameAssistant.Core
{
    public interface IMonoTaskScheduler<T_CONTEXT> where T_CONTEXT : class
    {
        T_CONTEXT Context { get; }
        TaskScheduler Scheduler { get; }

    }



}
