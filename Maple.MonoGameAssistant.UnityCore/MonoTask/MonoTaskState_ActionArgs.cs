using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal sealed class MonoTaskState_ActionArgs<T_GAMECONTEXT, T_Args>(T_GAMECONTEXT gameContext, Action<T_GAMECONTEXT, T_Args> action, T_Args args)
    : MonoTaskState<T_GAMECONTEXT>(gameContext)
    where T_GAMECONTEXT : MonoCollectorContext
    where T_Args : notnull
    {
        public Action<T_GAMECONTEXT, T_Args> Action { get; } = action;
        public T_Args Args { get; } = args;

        public bool Execute()
        {
            this.Action.Invoke(this.GameContext, this.Args);
            return true;
        }
    }

}
