using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.HotKey;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UnityCore
{
    internal sealed class UnityTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>
        (T_GAMECONTEXT gameContext, HookWinMsgService hook, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args) : UnityTaskState<T_GAMECONTEXT>(gameContext, hook)
    where T_GAMECONTEXT : MonoCollectorContext
    where T_ARGS : notnull
      where T_RETURN : notnull
    {
        public Func<T_GAMECONTEXT, T_ARGS, T_RETURN> Func { get; } = func;
        public T_ARGS Args { get; } = args;

        public T_RETURN? ReturnValue { set; get; }

        public bool TryGetValue([MaybeNullWhen(false)] out T_RETURN val)
        {
            val = this.ReturnValue;
            return this.ExecSuccess;
        }

        public void Execute()
        {
            this.ReturnValue = this.Func.Invoke(this.GameContext, this.Args);
            this.ExecSuccess = true;
        }

    }

}
