namespace Maple.MonoGameAssistant.UITask
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
                this.Executing.SetResult(true);
                this.ExecuteImp();
                this.ExecSuccess = true;

            }
            finally
            {
                this.Executed.SetResult(true);
            }
        }

        protected abstract void ExecuteImp();

        public async Task<bool> WaitAsync()
        {
            //等待timer执行 5秒内未执行 则丢出timerout
            if (await this.Executing.Task.WaitAsync(TimeSpan.FromSeconds(5)).ConfigureAwait(false))
            {
                //等待执行完毕 不设置timerout
                return await this.Executed.Task.ConfigureAwait(false);
            }
            return false;
        }
    }

    internal class UITaskState<T_GAMECONTEXT>(T_GAMECONTEXT gameContext) : UITaskState
        where T_GAMECONTEXT : class
    {
        public T_GAMECONTEXT GameContext { get; } = gameContext;

        protected override void ExecuteImp()
        {

        }
    }



}
