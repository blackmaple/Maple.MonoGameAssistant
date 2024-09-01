using Maple.MonoGameAssistant.TaskSchedulerCore;

namespace Maple.MonoGameAssistant.UITask
{
    public interface IUITaskScheduler<T_GAMECONTEXT>: ITaskSchedulerCore<T_GAMECONTEXT> where T_GAMECONTEXT : class
    {

    }
}
