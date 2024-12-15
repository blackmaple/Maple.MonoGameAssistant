using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.Windows.HotKey
{
    public interface IWinMsgNotifyService
    {
        ILogger Logger { get; }
        ValueTask NotifyAsync(WinMsgNotifyDTO msgNotify) => ValueTask.CompletedTask;
    }
}
