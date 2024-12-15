using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Windows.WinRT;
using Microsoft.Extensions.Logging;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.Windows.HotKey.ThreadMessage
{
    internal abstract class NotifyThreadMessage(IWinMsgNotifyService notifyService)
    {
        protected volatile bool PostedQuit;

        protected Channel<WinMsgNotifyDTO> NotifyChannel { get; } = Channel.CreateUnbounded<WinMsgNotifyDTO>();
        protected IWinMsgNotifyService MsgNotifyService { get; } = notifyService;
        protected ILogger Logger => MsgNotifyService.Logger;

        public Task RunAsync() => NotifyHotKeyLoopAsync();
        public void TryExit()
        {
            PostedQuit = true;
        }
        public abstract bool TrySendThreadMsg(EnumWindowMessage msg, nint wParam, nint lParam);
        protected async Task NotifyHotKeyLoopAsync()
        {
            using (Logger.Running())
            {
                await foreach (var dto in NotifyChannel.Reader.ReadAllAsync().ConfigureAwait(false))
                {
                    if (PostedQuit)
                    {
                        return;
                    }
                    await MsgNotifyService.NotifyAsync(dto).ConfigureAwait(false);
                }
            }
        }
    }
}