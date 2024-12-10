using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.Hosting;
using System.Collections.Concurrent;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.Core
{
    public class MonoTaskScheduler(MonoRuntimeContext runtimeContext) : TaskScheduler
    {

        protected MonoRuntimeContext RuntimeContext { get; } = runtimeContext;

        protected sealed override IEnumerable<Task>? GetScheduledTasks()
        {
            return default;
        }

        protected override void QueueTask(Task task)
        {

        }

        protected sealed override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            return false;
        }


    }

    public sealed class MonoTaskScheduler_Default : MonoTaskScheduler, IDisposable
    {
        Channel<Task> TaskChannel { get; }

        public MonoTaskScheduler_Default(MonoRuntimeContext runtimeContext) : base(runtimeContext)
        {
            this.TaskChannel = Channel.CreateBounded<Task>(new BoundedChannelOptions(Environment.ProcessorCount)
            {
                FullMode = BoundedChannelFullMode.Wait
            });
            this.CreateTasks_Default(Environment.ProcessorCount);
        }

        private void CreateTasks_Default(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                var task = Task.Run(ExecTaskProc);
            }

            async Task ExecTaskProc()
            {
                await foreach (var task in this.TaskChannel.Reader.ReadAllAsync().ConfigureAwait(false))
                {
                    using (this.RuntimeContext.CreateAttachContext())
                    {
                        this.TryExecuteTask(task);
                    }
                }
            }
        }

        protected override void QueueTask(Task task)
        {
            this.TaskChannel.Writer.TryWrite(task);
        }

        public void Dispose()
        {
            this.TaskChannel.Writer.Complete();
        }

    }

    public sealed class MonoTaskScheduler_Android : MonoTaskScheduler, IDisposable
    {
        BlockingCollection<Task> TaskCollection { get; }

        public MonoTaskScheduler_Android(MonoRuntimeContext runtimeContext) : base(runtimeContext)
        {
            this.TaskCollection = new BlockingCollection<Task>(Environment.ProcessorCount);
            this.CreateTasks_Android(Environment.ProcessorCount);
        }

        private void CreateTasks_Android(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                _ = Task.Factory.StartNew(ExecTaskProc, this, TaskCreationOptions.LongRunning);
            }

            static void ExecTaskProc(object? taskScheduler)
            {
                if (taskScheduler is not MonoTaskScheduler_Android monoTaskScheduler)
                {
                    return;
                }
                using (monoTaskScheduler.RuntimeContext.CreateAttachContext())
                {
                    while (!monoTaskScheduler.TaskCollection.IsCompleted)
                    {
                        foreach (var task in monoTaskScheduler.TaskCollection.GetConsumingEnumerable())
                        {
                            monoTaskScheduler.TryExecuteTask(task);
                        }

                    }
                }

            }
        }

        protected override void QueueTask(Task task)
        {
            this.TaskCollection.Add(task);

        }

        public void Dispose()
        {
            this.TaskCollection.CompleteAdding();

        }
    }

}
