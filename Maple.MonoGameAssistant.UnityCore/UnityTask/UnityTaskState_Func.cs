using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal class UnityTaskState_Func<T_GAMECONTEXT, T_RETURN>(T_GAMECONTEXT gameContext, HookWinMsgService hook, Func<T_GAMECONTEXT, T_RETURN> func) : UnityTaskState<T_GAMECONTEXT>(gameContext, hook)
        where T_GAMECONTEXT : MonoCollectorContext
        //     where T_RETURN : notnull
    {
        public Func<T_GAMECONTEXT, T_RETURN> Func { get; } = func;

        public T_RETURN? ReturnValue { set; get; }

        public bool TryGetValue([MaybeNullWhen(false)]out T_RETURN val)
        {
            val = ReturnValue;
            return this.ExecSuccess;
        }

        protected override void ExecuteImp()
        {
            this.ReturnValue = this.Func.Invoke(this.GameContext);
        }
    }

}
