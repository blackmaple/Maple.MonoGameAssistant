using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.UnityCore
{
    //public sealed class MonoTaskScheduler : TaskScheduler, IDisposable
    //{
    //    BlockingCollection<Task> TaskCollection { get; }
    //    MonoRuntimeContext RuntimeContext { get; }
    //    public MonoTaskScheduler(MonoRuntimeContext runtimeContext, int concurrencyLevel)
    //    {
    //        this.RuntimeContext = runtimeContext;
    //        this.TaskCollection = [];
    //        this.CreateTasks(concurrencyLevel);

    //    }
    //    public MonoTaskScheduler(MonoRuntimeContext runtimeContext) : this(runtimeContext, Environment.ProcessorCount)
    //    { }


    //    private void CreateTasks(int count)
    //    {
    //        for (int i = 0; i < count; ++i)
    //        {
    //            var task = Task.Factory.StartNew(ExecTaskProc, TaskCreationOptions.LongRunning);
    //        }
    //        void ExecTaskProc()
    //        {
    //            foreach (var task in this.TaskCollection.GetConsumingEnumerable())
    //            {
    //                using (this.RuntimeContext.CreateAttachContext())
    //                {
    //                    this.TryExecuteTask(task);
    //                }
    //            }
    //        }
    //    }

    //    protected override IEnumerable<Task>? GetScheduledTasks()
    //    {
    //        return default;
    //    }

    //    protected override void QueueTask(Task task)
    //    {
    //        this.TaskCollection.Add(task);
    //    }

    //    protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
    //    {
    //        return false;
    //    }

    //    public void Dispose()
    //    {
    //        this.TaskCollection.CompleteAdding();
    //        this.TaskCollection.Dispose();
    //    }
    //}

    public sealed class MonoTaskScheduler : TaskScheduler, IDisposable
    {
        Channel<Task> TaskChannel { get; }
        MonoRuntimeContext RuntimeContext { get; }
        public MonoTaskScheduler(MonoRuntimeContext runtimeContext, int concurrencyLevel)
        {
            this.RuntimeContext = runtimeContext;
            this.TaskChannel = Channel.CreateBounded<Task>(new BoundedChannelOptions(128)
            {
                FullMode = BoundedChannelFullMode.Wait
            });
            this.CreateTasks(concurrencyLevel);

        }
        public MonoTaskScheduler(MonoRuntimeContext runtimeContext) : this(runtimeContext, Environment.ProcessorCount)
        { }


        private void CreateTasks(int count)
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
