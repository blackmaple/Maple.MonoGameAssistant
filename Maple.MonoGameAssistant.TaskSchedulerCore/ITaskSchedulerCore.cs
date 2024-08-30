using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.TaskSchedulerCore
{

    public interface ITaskSchedulerCore<T_GAMECONTEXT> where T_GAMECONTEXT : MonoCollectorContext
    {
        T_GAMECONTEXT GameContext { get; }
    }
}
