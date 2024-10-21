using Maple.MonoGameAssistant.AndroidJNI.Context;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.AndroidCore.AndroidTask
{
    public sealed class AndroidTaskScheduler : TaskScheduler, IDisposable
    {
        Channel<Task> TaskChannel { get; }
        JavaVirtualMachineContext RuntimeContext { get; }
        AndroidTaskScheduler(JavaVirtualMachineContext runtimeContext, int concurrencyLevel)
        {
            this.RuntimeContext = runtimeContext;
            this.TaskChannel = Channel.CreateBounded<Task>(new BoundedChannelOptions(128)
            {
                FullMode = BoundedChannelFullMode.Wait
            });
            this.CreateTasks(concurrencyLevel);

        }
        public AndroidTaskScheduler(JavaVirtualMachineContext runtimeContext) : this(runtimeContext, Environment.ProcessorCount)
        { }


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
                    if (this.RuntimeContext.TryAttachThread(out var environmentContext, nameof(AndroidTaskScheduler)))
                    {
                        using (environmentContext)
                        {
                            this.TryExecuteTask(task);
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
