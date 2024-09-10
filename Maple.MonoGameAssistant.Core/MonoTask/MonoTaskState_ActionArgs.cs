using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.Core
{
    internal sealed class MonoTaskState_ActionArgs<T_CONTEXT, T_Args>(T_CONTEXT context, Action<T_CONTEXT, T_Args> action, T_Args args)
    : MonoTaskState<T_CONTEXT>(context)
    where T_CONTEXT : class
    where T_Args : notnull
    {
        public Action<T_CONTEXT, T_Args> Action { get; } = action;
        public T_Args Args { get; } = args;

        public bool Execute()
        {
            this.Action.Invoke(this.Context, this.Args);
            return true;
        }
    }

}
