using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.Core
{
    internal sealed class MonoTaskState_Action<T_CONTEXT>(T_CONTEXT context, Action<T_CONTEXT> action)
    : MonoTaskState<T_CONTEXT>(context)
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
