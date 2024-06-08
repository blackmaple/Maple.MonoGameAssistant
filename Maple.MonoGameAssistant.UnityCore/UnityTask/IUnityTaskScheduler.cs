using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;

namespace Maple.MonoGameAssistant.UnityCore
{
    public interface IUnityTaskScheduler<T_GAMECONTEXT> where T_GAMECONTEXT : MonoCollectorContext
    {
        T_GAMECONTEXT GameContext { get; }
        HookWinMsgService Hook { get; }
    }
}
