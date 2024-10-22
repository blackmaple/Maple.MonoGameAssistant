using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.AndroidCore.AndroidTask
{
    public sealed class AndroidTaskScheduler : TaskScheduler, IDisposable
    {
        Channel<Task> TaskChannel { get; }
        AndroidApiContext ApiContext { get; }
        JavaVirtualMachineContext VirtualMachineContext => ApiContext.VirtualMachineContext;

        AndroidTaskScheduler(AndroidApiContext apiContext, int concurrencyLevel)
        {
            this.ApiContext = apiContext;
            this.TaskChannel = Channel.CreateBounded<Task>(new BoundedChannelOptions(128)
            {
                FullMode = BoundedChannelFullMode.Wait
            });
            this.CreateTasks2(concurrencyLevel);

        }
        public AndroidTaskScheduler(AndroidApiContext apiContext) : this(apiContext, Environment.ProcessorCount)
        { }

        [Obsolete("remove...")]
        private void CreateTasks(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                _ = Task.Run(ExecTaskProc);
            }

            async Task ExecTaskProc()
            {
                await foreach (var task in this.TaskChannel.Reader.ReadAllAsync().ConfigureAwait(false))
                {
                    if (this.VirtualMachineContext.TryAttachThread(out var environmentContext, nameof(AndroidTaskScheduler)))
                    {
                        using (environmentContext)
                        {
                            this.TryExecuteTask(task);
                        }
                    }
                }
            }
        }

        private void CreateTasks2(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                _ = Task.Factory.StartNew(ExecTaskProc, this, TaskCreationOptions.LongRunning);
            }

            static void ExecTaskProc(object? taskScheduler)
            {
                if (taskScheduler is not AndroidTaskScheduler androidTaskScheduler)
                {
                    return;
                }
                if (androidTaskScheduler.VirtualMachineContext.TryAttachThreadAsDaemon(out var jniEnvironmentContext))
                {
                    using (jniEnvironmentContext)
                    {
                        while (true)
                        {
                            SpinWait.SpinUntil(() => androidTaskScheduler.TaskChannel.Reader.TryPeek(out _));
                            if (!androidTaskScheduler.TaskChannel.Reader.TryRead(out var item))
                            {
                                continue;
                            }
                            androidTaskScheduler.TryExecuteTask(item);
                        }
                    }
                }

            }
        }


        protected override IEnumerable<Task>? GetScheduledTasks()
        {
            return default;
        }

        protected override void QueueTask(Task task)
        {
            this.TaskChannel.Writer.TryWrite(task);
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            return false;
        }

        public void Dispose()
        {
            this.TaskChannel.Writer.Complete();

        }
    }
}
