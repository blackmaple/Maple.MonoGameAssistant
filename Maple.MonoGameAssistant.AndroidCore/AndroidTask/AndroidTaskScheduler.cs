using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using System.Collections.Concurrent;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.AndroidCore.AndroidTask
{
    public sealed class AndroidTaskScheduler : TaskScheduler, IDisposable
    {
        BlockingCollection<Task> TaskCollection { get; }
        AndroidApiContext ApiContext { get; }
        JavaVirtualMachineContext VirtualMachineContext => ApiContext.VirtualMachineContext;

        ThreadLocal<JniEnvironmentContext> TheadJniEnv { get; } = new ThreadLocal<JniEnvironmentContext>();
        public JniEnvironmentContext CurrJniEnv
        {
            get => TheadJniEnv.Value;
            private set => TheadJniEnv.Value = value;
        }

        AndroidTaskScheduler(AndroidApiContext apiContext, int concurrencyLevel)
        {
            this.ApiContext = apiContext;
            this.TaskCollection = new BlockingCollection<Task>(concurrencyLevel);
            this.CreateTasks_Default(concurrencyLevel);

        }
        public AndroidTaskScheduler(AndroidApiContext apiContext) : this(apiContext, Environment.ProcessorCount)
        { }


        private void CreateTasks_Default(int count)
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
                    androidTaskScheduler.TheadJniEnv.Value = jniEnvironmentContext;
                    using (jniEnvironmentContext)
                    {
                        while (!androidTaskScheduler.TaskCollection.IsCompleted)
                        {
                            foreach(var task in androidTaskScheduler.TaskCollection.GetConsumingEnumerable())
                            {
                                androidTaskScheduler.TryExecuteTask(task);
                            }
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
            this.TaskCollection.Add(task);
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            return false;
        }

        public void Dispose()
        {
            this.TaskCollection.CompleteAdding();

        }
    }
}
