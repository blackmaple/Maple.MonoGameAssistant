namespace Maple.MonoGameAssistant.Windows.UITask
{
    internal abstract class UITaskState
    {
        public bool ExecSuccess { set; get; }
        /// <summary>
        /// 执行完成
        /// </summary>
        public TaskCompletionSource<bool> Executed { get; } = new TaskCompletionSource<bool>();
        /// <summary>
        /// 开始执行
        /// </summary>
        public TaskCompletionSource<bool> Executing { get; } = new TaskCompletionSource<bool>();

        public void Execute()
        {
            try
            {
                Executing.SetResult(true);
                ExecuteImp();
                ExecSuccess = true;

            }
            finally
            {
                Executed.SetResult(true);
            }
        }

        protected abstract void ExecuteImp();

        public async Task<bool> WaitAsync()
        {
            //等待timer执行 5秒内未执行 则丢出time out
            if (await Executing.Task.WaitAsync(TimeSpan.FromSeconds(5L)).ConfigureAwait(false))
            {
                //等待执行完毕 不设置time out
                return await Executed.Task.ConfigureAwait(false);
            }
            return false;
        }
    }

    internal class UITaskState<T_CONTEXT>(T_CONTEXT context) : UITaskState
        where T_CONTEXT : class
    {
        public T_CONTEXT Context { get; } = context;

        protected override void ExecuteImp()
        {

        }
    }



}
