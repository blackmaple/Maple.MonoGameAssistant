using Maple.MonoGameAssistant.AndroidCore;

namespace Maple.MonoGameAssistant.AndroidCore
{
    internal sealed class AndroidTaskState_Action<T_CONTEXT>(T_CONTEXT context, Action<T_CONTEXT> action)
    : AndroidTaskState<T_CONTEXT>(context)
    where T_CONTEXT : class
    {
        public Action<T_CONTEXT> Action { get; } = action;

        public bool Execute()
        {
            this.Action.Invoke(this.Context);
            return true;
        }

    }

}
