using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UITask
{
    internal class UITaskState_Func<T_GAMECONTEXT, T_RETURN>(T_GAMECONTEXT gameContext, Func<T_GAMECONTEXT, T_RETURN> func)
        : UITaskState<T_GAMECONTEXT>(gameContext)
        where T_GAMECONTEXT : class
    {
        public Func<T_GAMECONTEXT, T_RETURN> Func { get; } = func;

        public T_RETURN? ReturnValue { set; get; }

        public bool TryGetValue([MaybeNullWhen(false)] out T_RETURN val)
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
