using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.HotKey
{
    public interface IWinMsgNotifyService
    {
        ILogger Logger { get; }
        MonoRuntimeContext RuntimeContext { get; }

        //[Obsolete("remove...")]
        //void Notify(in WinMsgNotifyDTO msgNotify) { }
        ValueTask NotifyAsync(WinMsgNotifyDTO msgNotify) => ValueTask.CompletedTask;
    }
}
