using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.MonoTask
{
    internal sealed class MonoTaskState_FuncArgs<T_GAMECONTEXT, T_ARGS, T_RETURN>
    (T_GAMECONTEXT gameContext, Func<T_GAMECONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
        : MonoTaskState<T_GAMECONTEXT>(gameContext)
        where T_GAMECONTEXT : MonoCollectorContext
        where T_ARGS : notnull
  //    where T_RETURN : notnull
    {
        public Func<T_GAMECONTEXT, T_ARGS, T_RETURN> Func { get; } = func;
        public T_ARGS Args { get; } = args;



        public T_RETURN Execute()
        {
            return this.Func.Invoke(this.GameContext, Args);

        }

    }

}
