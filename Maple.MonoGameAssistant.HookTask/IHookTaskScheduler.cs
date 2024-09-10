using Maple.MonoGameAssistant.HotKey.Abstractions;

namespace Maple.MonoGameAssistant.HookTask
{
    public interface IHookTaskScheduler<T_CONTEXT> where T_CONTEXT : class
    {
        T_CONTEXT Context { get; }
        IHookWinMsgService Hook { get; }
    }
}
