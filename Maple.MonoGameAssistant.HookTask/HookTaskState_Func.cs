using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey.Abstractions;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.HookTask
{
    internal class HookTaskState_Func<T_GAMECONTEXT, T_RETURN>(T_GAMECONTEXT gameContext, IHookWinMsgService hook, Func<T_GAMECONTEXT, T_RETURN> func) : HookTaskState<T_GAMECONTEXT>(gameContext, hook)
        where T_GAMECONTEXT : MonoCollectorContext
        //     where T_RETURN : notnull
    {
        public Func<T_GAMECONTEXT, T_RETURN> Func { get; } = func;

        public T_RETURN? ReturnValue { set; get; }

        public bool TryGetValue([MaybeNullWhen(false)] out T_RETURN val)
        {
            val = ReturnValue;
            return ExecSuccess;
        }

        protected override void ExecuteImp()
        {
            ReturnValue = Func.Invoke(GameContext);
        }
    }

}
