using Maple.MonoGameAssistant.TaskSchedulerCore;

namespace Maple.MonoGameAssistant.MonoTask
{
    public interface IMonoTaskScheduler<T_GAMECONTEXT>: ITaskSchedulerCore<T_GAMECONTEXT> where T_GAMECONTEXT : class
    {
        TaskScheduler Scheduler { get; }

    }



}
