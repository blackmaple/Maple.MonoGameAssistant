namespace Maple.MonoGameAssistant.HotKey.Abstractions
{
    public interface IHookWinMsgService : IDisposable
    {

        bool SetHook();
        bool SetHook(IWinMsgNotifyService winMsgNotify);
        unsafe bool TrySendExecUnmanagedCode(delegate*<nint, void> execCode, nint pArgs);
        unsafe bool TrySendExecUnmanagedCode<T_RETURN>(delegate*<nint, void> execCode, ref ExecUnmanagedCodeContext<T_RETURN> execCodeContext) where T_RETURN : unmanaged;
        void UnHook();
    }
}