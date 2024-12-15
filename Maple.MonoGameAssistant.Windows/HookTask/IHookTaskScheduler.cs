using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;

namespace Maple.MonoGameAssistant.Windows.HookTask
{
    public interface IHookTaskScheduler<T_CONTEXT> where T_CONTEXT : class
    {
        T_CONTEXT Context { get; }
        HookWinMsgService Hook { get; }
    }
}
