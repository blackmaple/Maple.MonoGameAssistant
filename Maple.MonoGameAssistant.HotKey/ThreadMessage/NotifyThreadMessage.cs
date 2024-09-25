using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.HotKey.Abstractions;
using Maple.MonoGameAssistant.WinApi;
using Microsoft.Extensions.Logging;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.HotKey
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
            this.PostedQuit = true;
        }
        public abstract bool TrySendThreadMsg(EnumWindowMessage msg, nint wParam, nint lParam);
        protected async Task NotifyHotKeyLoopAsync()
        {
            using (this.Logger.Running())
            {
                await foreach (var dto in this.NotifyChannel.Reader.ReadAllAsync().ConfigureAwait(false))
                {
                    if (this.PostedQuit)
                    {
                        return;
                    }
                    await this.MsgNotifyService.NotifyAsync(dto).ConfigureAwait(false);
                }
            }
        }
    }
}