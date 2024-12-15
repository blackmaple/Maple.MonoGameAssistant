namespace Maple.MonoGameAssistant.Windows.UITask
{

    //[Obsolete("remove...")]
    //public sealed class UITaskScheduler : TaskScheduler, IDisposable
    //{
    //    Channel<Task> TaskChannel { get; }
    //    MonoRuntimeContext RuntimeContext { get; }
    //    public UITaskScheduler(MonoRuntimeContext runtimeContext, int concurrencyLevel)
    //    {
    //        this.RuntimeContext = runtimeContext;
    //        this.TaskChannel = Channel.CreateBounded<Task>(new BoundedChannelOptions(128)
    //        {
    //            FullMode = BoundedChannelFullMode.Wait
    //        });
    //        this.CreateTasks(concurrencyLevel);

    //    }
    //    public UITaskScheduler(MonoRuntimeContext runtimeContext) : this(runtimeContext, Environment.ProcessorCount)
    //    { }


    //    private void CreateTasks(int count)
    //    {
    //        for (int i = 0; i < count; ++i)
    //        {
    //            var task = Task.Run(ExecTaskProc);
    //        }

    //        async Task ExecTaskProc()
    //        {
    //            await foreach (var task in this.TaskChannel.Reader.ReadAllAsync().ConfigureAwait(false))
    //            {
    //                this.TryExecuteTask(task);
    //            }
    //        }
    //    }

    //    protected override IEnumerable<Task>? GetScheduledTasks()
    //    {
    //        return default;
    //    }

    //    protected override void QueueTask(Task task)
    //    {
    //        this.TaskChannel.Writer.TryWrite(task);
    //    }

    //    protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
    //    {
    //        return false;
    //    }

    //    public void Dispose()
    //    {
    //        this.TaskChannel.Writer.Complete();

    //    }
    //}
}
