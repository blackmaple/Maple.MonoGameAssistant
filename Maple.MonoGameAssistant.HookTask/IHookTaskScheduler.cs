using Maple.MonoGameAssistant.HotKey.Abstractions;
using Maple.MonoGameAssistant.TaskSchedulerCore;

namespace Maple.MonoGameAssistant.HookTask
{
    public interface IHookTaskScheduler<T_GAMECONTEXT>: ITaskSchedulerCore<T_GAMECONTEXT> where T_GAMECONTEXT  :class 
    {
        IHookWinMsgService Hook { get; }
    }
}
