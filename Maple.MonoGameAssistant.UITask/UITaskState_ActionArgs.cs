namespace Maple.MonoGameAssistant.UITask
{
    internal sealed class UITaskState_ActionArgs<T_CONTEXT, T_Args>(T_CONTEXT context, Action<T_CONTEXT, T_Args> action, T_Args args)
        : UITaskState<T_CONTEXT>(context)
        where T_CONTEXT : class
        where T_Args : notnull
    {
        public Action<T_CONTEXT, T_Args> Action { get; } = action;
        public T_Args Args { get; } = args;

        protected override void ExecuteImp()
        {
            this.Action.Invoke(this.Context, this.Args);
        }
    }
}
