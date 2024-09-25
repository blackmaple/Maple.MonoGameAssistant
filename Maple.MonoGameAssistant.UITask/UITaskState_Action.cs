namespace Maple.MonoGameAssistant.UITask
{
    internal sealed class UITaskState_Action<T_CONTEXT>(T_CONTEXT context, Action<T_CONTEXT> action)
        : UITaskState<T_CONTEXT>(context)
        where T_CONTEXT : class
    {
        public Action<T_CONTEXT> Action { get; } = action;

        protected override void ExecuteImp()
        {
            this.Action.Invoke(this.Context);
        }

    }
}
