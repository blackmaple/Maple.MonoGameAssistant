using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Windows.UITask
{
    internal sealed class UITaskState_FuncArgs<T_CONTEXT, T_ARGS, T_RETURN>
        (T_CONTEXT gameContext, Func<T_CONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
        : UITaskState<T_CONTEXT>(gameContext)
    where T_CONTEXT : class
    where T_ARGS : notnull
    {
        public Func<T_CONTEXT, T_ARGS, T_RETURN> Func { get; } = func;
        public T_ARGS Args { get; } = args;

        public T_RETURN? ReturnValue { set; get; }

        public bool TryGetValue([MaybeNullWhen(false)] out T_RETURN val)
        {
            val = ReturnValue;
            return ExecSuccess;
        }

        protected override void ExecuteImp()
        {
            ReturnValue = Func.Invoke(Context, Args);

        }

    }

}
