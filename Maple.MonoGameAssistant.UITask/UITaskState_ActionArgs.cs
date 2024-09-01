namespace Maple.MonoGameAssistant.UITask
{
    internal sealed class UITaskState_ActionArgs<T_GAMECONTEXT, T_Args>(T_GAMECONTEXT gameContext, Action<T_GAMECONTEXT, T_Args> action, T_Args args)
        : UITaskState<T_GAMECONTEXT>(gameContext)
        where T_GAMECONTEXT : class
        where T_Args : notnull
    {
        public Action<T_GAMECONTEXT, T_Args> Action { get; } = action;
        public T_Args Args { get; } = args;

        protected override void ExecuteImp()
        {
            this.Action.Invoke(this.GameContext, this.Args);
        }
    }
}
