namespace Maple.MonoGameAssistant.TaskSchedulerCore
{

    public interface ITaskSchedulerCore<T_GAMECONTEXT> where T_GAMECONTEXT : class
    {
        T_GAMECONTEXT GameContext { get; }
    }
}
