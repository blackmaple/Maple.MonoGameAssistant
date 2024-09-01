namespace Maple.MonoGameAssistant.UITask
{
    internal sealed class UITaskState_Action<T_GAMECONTEXT>(T_GAMECONTEXT gameContext, Action<T_GAMECONTEXT> action)
        : UITaskState<T_GAMECONTEXT>(gameContext)
        where T_GAMECONTEXT : class
    {
        public Action<T_GAMECONTEXT> Action { get; } = action;

        protected override void ExecuteImp()
        {
            this.Action.Invoke(this.GameContext);
        }

    }
}
