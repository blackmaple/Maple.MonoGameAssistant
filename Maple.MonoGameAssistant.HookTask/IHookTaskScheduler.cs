using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey.Abstractions;
using Maple.MonoGameAssistant.TaskSchedulerCore;

namespace Maple.MonoGameAssistant.HookTask
{
    public interface IHookTaskScheduler<T_GAMECONTEXT> : ITaskSchedulerCore<T_GAMECONTEXT> where T_GAMECONTEXT : MonoCollectorContext
    {
        IHookWinMsgService Hook { get; }
    }
}
