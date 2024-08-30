using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.HotKey.Abstractions
{
    public interface IWinMsgNotifyService
    {
        ILogger Logger { get; }
        ValueTask NotifyAsync(WinMsgNotifyDTO msgNotify) => ValueTask.CompletedTask;
    }
}
