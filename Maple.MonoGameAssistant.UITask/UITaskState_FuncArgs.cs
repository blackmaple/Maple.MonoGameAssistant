using Maple.MonoGameAssistant.Core;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UITask
{
    internal sealed class UITaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>
        (T_GAMECONTEXT gameContext, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
        : UITaskState<T_GAMECONTEXT>(gameContext)
    where T_GAMECONTEXT : MonoCollectorContext
    where T_ARGS : notnull
    {
        public Func<T_GAMECONTEXT, T_ARGS, T_RETURN> Func { get; } = func;
        public T_ARGS Args { get; } = args;

        public T_RETURN? ReturnValue { set; get; }

        public bool TryGetValue([MaybeNullWhen(false)] out T_RETURN val)
        {
            val = this.ReturnValue;
            return this.ExecSuccess;
        }

        protected override void ExecuteImp()
        {
            this.ReturnValue = this.Func.Invoke(this.GameContext, this.Args);
            
        }

    }

}
