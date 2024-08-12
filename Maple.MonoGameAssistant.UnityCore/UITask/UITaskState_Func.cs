using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal class UITaskState_Func<T_GAMECONTEXT, T_RETURN>(T_GAMECONTEXT gameContext, Func<T_GAMECONTEXT, T_RETURN> func)
        : UITaskState<T_GAMECONTEXT>(gameContext)
        where T_GAMECONTEXT : MonoCollectorContext
    {
        public Func<T_GAMECONTEXT, T_RETURN> Func { get; } = func;

        public T_RETURN? ReturnValue { set; get; }

        public bool TryGetValue([MaybeNullWhen(false)] out T_RETURN val)
        {
            val = ReturnValue;
            return this.ExecSuccess;
        }

        public void Execute()
        {
            this.ReturnValue = this.Func.Invoke(this.GameContext);
            this.ExecSuccess = true;
        }
    }

}
