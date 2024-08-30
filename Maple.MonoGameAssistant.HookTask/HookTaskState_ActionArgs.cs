using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey.Abstractions;

namespace Maple.MonoGameAssistant.HookTask
{
    internal sealed class HookTaskState_ActionArgs<T_GAMECONTEXT, T_Args>(T_GAMECONTEXT gameContext, IHookWinMsgService hook, Action<T_GAMECONTEXT, T_Args> action, T_Args args)
        : HookTaskState<T_GAMECONTEXT>(gameContext, hook)
        where T_GAMECONTEXT : MonoCollectorContext
        where T_Args : notnull
    {
        public Action<T_GAMECONTEXT, T_Args> Action { get; } = action;
        public T_Args Args { get; } = args;

        protected override void ExecuteImp()
        {
            Action.Invoke(GameContext, Args);
        }
    }
}
