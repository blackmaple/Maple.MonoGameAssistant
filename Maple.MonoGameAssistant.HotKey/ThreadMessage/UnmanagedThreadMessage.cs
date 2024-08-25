using Maple.MonoGameAssistant.Common;
using Microsoft.Extensions.Logging;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.HotKey
{
    internal class UnmanagedThreadMessage
    {
        int ThreadId { set; get; }

        volatile bool PostedQuit;

        Channel<WinMsgNotifyDTO> NotifyChannel { get; }

        public ChannelReader<WinMsgNotifyDTO> NotifyReader => NotifyChannel.Reader;
        ILogger Logger => MsgNotifyService.Logger;
        IWinMsgNotifyService MsgNotifyService { get; }
        public UnmanagedThreadMessage(IWinMsgNotifyService winMsgNotifyService)
        {
            this.MsgNotifyService = winMsgNotifyService;
            this.NotifyChannel = Channel.CreateUnbounded<WinMsgNotifyDTO>();
            var taskThreadMessageLoop = new Task(ThreadMessageLoop, CancellationToken.None, TaskCreationOptions.LongRunning);
            taskThreadMessageLoop.Start();
        }



        void ThreadMessageLoop()
        {
            using (Logger.Running())
            {

                this.ThreadId = WinApi.GetCurrentThreadId();

                WinApi.MSG msg = default;
                while (!PostedQuit)
                {

                    if (WinApi.PeekMessage(ref msg, WinApi.MessageThreadHandle, 0, 0, WinApi.PM_NOREMOVE))
                    {
                        if (PostedQuit)
                        {
                            break;
                        }
                        WinApi.GetMessage(ref msg, WinApi.MessageThreadHandle, 0, 0);
                        if (PostedQuit)
                        {
                            break;
                        }
                        this.NotifyChannel.Writer.TryWrite(new WinMsgNotifyDTO() { Msg = msg.message, WParam = msg.wParam, LParam = msg.lParam });
                    }
                    else
                    {
                        if (PostedQuit)
                        {
                            break;
                        }
                        //WaitMessage 可能会失败 所以不判断返回值
                        WinApi.WaitMessage();
                        if (PostedQuit)
                        {
                            break;
                        }
                    }
                }
                this.NotifyChannel.Writer.Complete();

            }
        }

        public bool TrySendThreadMsg(EnumWindowMessage Msg, nint wParam, nint lParam)
        {
            return !this.PostedQuit && this.ThreadId != 0 && WinApi.PostThreadMessage(this.ThreadId, Msg, wParam, lParam);
        }
        public void TryExit()
        {
            this.PostedQuit = true;
            //  this.TrySendThreadMsg(EnumWindowMessage.WM_QUIT, 0, 0);
        }

        public Task RunAsync()
           => NotifyHotKeyLoopAsync();


        private async Task NotifyHotKeyLoopAsync()
        {
            using (this.Logger.Running())
            {
                await foreach (var notifyDTO in this.NotifyChannel.Reader.ReadAllAsync().ConfigureAwait(false))
                {
                    if (this.PostedQuit)
                    {
                        return;
                    }
                    await this.MsgNotifyService.NotifyAsync(notifyDTO).ConfigureAwait(false);
                }
            }
        }

        //[Obsolete("remove...")]
        //private async Task NotifyHotKeyLoop()
        //{
        //    using (this.Logger.Running())
        //    {
        //        await foreach (var notifyDTO in this.NotifyChannel.Reader.ReadAllAsync().ConfigureAwait(false))
        //        {
        //            if (this.PostedQuit)
        //            {
        //                return;
        //            }

        //            using (this.MsgNotifyService.RuntimeContext.CreateAttachContext())
        //            {
        //                this.MsgNotifyService.Notify(notifyDTO);
        //            }
        //        }
        //    }
        //}

    }
}
