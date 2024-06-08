using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal class UnityTaskState<T_GAMECONTEXT>(T_GAMECONTEXT gameContext, HookWinMsgService hook) where T_GAMECONTEXT : MonoCollectorContext
    {
        public HookWinMsgService Hook { get; } = hook;
        public T_GAMECONTEXT GameContext { get; } = gameContext;
        public bool ExecSuccess { set; get; } = false;
    }

}
