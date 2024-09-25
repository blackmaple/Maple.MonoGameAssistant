using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.HotKey.Abstractions;
using Maple.MonoGameAssistant.WinApi;

namespace Maple.MonoGameAssistant.HotKey
{
    internal sealed class ManagedThreadMessage(IWinMsgNotifyService notifyService) : NotifyThreadMessage(notifyService)
    {


        public sealed override bool TrySendThreadMsg(EnumWindowMessage msg, nint wParam, nint lParam)
        {
            return !this.PostedQuit && this.NotifyChannel.Writer.TryWrite(new WinMsgNotifyDTO() { Msg = (uint)msg, WParam = wParam, LParam = lParam });
        }
    }
}
