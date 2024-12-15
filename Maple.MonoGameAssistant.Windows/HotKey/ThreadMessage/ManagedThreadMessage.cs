using Maple.MonoGameAssistant.Windows.WinRT;

namespace Maple.MonoGameAssistant.Windows.HotKey.ThreadMessage
{
    internal sealed class ManagedThreadMessage(IWinMsgNotifyService notifyService) : NotifyThreadMessage(notifyService)
    {


        public sealed override bool TrySendThreadMsg(EnumWindowMessage msg, nint wParam, nint lParam)
        {
            return !PostedQuit && NotifyChannel.Writer.TryWrite(new WinMsgNotifyDTO() { Msg = (uint)msg, WParam = wParam, LParam = lParam });
        }
    }
}
