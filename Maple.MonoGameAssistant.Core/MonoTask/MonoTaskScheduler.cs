using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.Hosting;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.Core
{
    public sealed class MonoTaskScheduler : TaskScheduler, IDisposable
    {
        Channel<Task> TaskChannel { get; }
        MonoRuntimeContext RuntimeContext { get; }
        MonoTaskScheduler(MonoRuntimeContext runtimeContext, int concurrencyLevel)
        {
            this.RuntimeContext = runtimeContext;
            this.TaskChannel = Channel.CreateBounded<Task>(new BoundedChannelOptions(128)
            {
                FullMode = BoundedChannelFullMode.Wait
            });
            if (IsAndroidEnvironment())
            {
                this.CreateTasks_Android(concurrencyLevel);
            }
            else
            {
               this.CreateTasks_Default(concurrencyLevel);
            }
        }
        public MonoTaskScheduler(MonoRuntimeContext runtimeContext) : this(runtimeContext, Environment.ProcessorCount)
        { }

        static bool IsAndroidEnvironment()
            => string.IsNullOrEmpty(Environment.GetEnvironmentVariable(nameof(MonoTaskScheduler))) == false;
        public static void SetAndroidEnvironment()
        {
            Environment.SetEnvironmentVariable(nameof(MonoTaskScheduler), nameof(MonoTaskScheduler));
        }
        public static void SetDefaultEnvironment()
        {
            Environment.SetEnvironmentVariable(nameof(MonoTaskScheduler), string.Empty);
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
        private void CreateTasks_Android(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                _ = Task.Factory.StartNew(ExecTaskProc, this, TaskCreationOptions.LongRunning);
            }

            static void ExecTaskProc(object? taskScheduler)
            {
                if (taskScheduler is not MonoTaskScheduler monoTaskScheduler)
                {
                    return;
                }
                using (monoTaskScheduler.RuntimeContext.CreateAttachContext())
                {
                    while (true)
                    {
                        SpinWait.SpinUntil(() => monoTaskScheduler.TaskChannel.Reader.TryPeek(out _));
                        if (!monoTaskScheduler.TaskChannel.Reader.TryRead(out var item))
                        {
                            continue;
                        }
                        monoTaskScheduler.TryExecuteTask(item);
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
