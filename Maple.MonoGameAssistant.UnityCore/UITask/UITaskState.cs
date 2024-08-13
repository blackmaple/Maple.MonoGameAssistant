using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal abstract class UITaskState
    {
        public bool ExecSuccess { set; get; }
        public TaskCompletionSource<bool> TaskCompletionSource { get; } = new TaskCompletionSource<bool>();
        public void Execute()
        {
            this.ExecuteImp();
            this.ExecSuccess = true;
            this.TaskCompletionSource.SetResult(true);
        }

        protected abstract void ExecuteImp();

        public Task<bool> WaitAsync() => this.TaskCompletionSource.Task.WaitAsync(TimeSpan.FromSeconds(5));
    }

    internal class UITaskState<T_GAMECONTEXT>(T_GAMECONTEXT gameContext) : UITaskState
        where T_GAMECONTEXT : MonoCollectorContext
    {
        public T_GAMECONTEXT GameContext { get; } = gameContext;

        protected override void ExecuteImp()
        {

        }
    }



}
