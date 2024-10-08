﻿using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.Core
{
    internal sealed class MonoTaskState_FuncArgs<T_CONTEXT, T_ARGS, T_RETURN>
    (T_CONTEXT context, Func<T_CONTEXT, T_ARGS, T_RETURN> func, T_ARGS args)
        : MonoTaskState<T_CONTEXT>(context)
        where T_CONTEXT : class
        where T_ARGS : notnull
    {
        public Func<T_CONTEXT, T_ARGS, T_RETURN> Func { get; } = func;
        public T_ARGS Args { get; } = args;



        public T_RETURN Execute()
        {
            return this.Func.Invoke(this.Context, Args);

        }

    }

}
