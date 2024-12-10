namespace Maple.MonoGameAssistant.AndroidCore.AndroidTask
{
    internal class AndroidTaskState_Func<T_CONTEXT, T_RETURN>(T_CONTEXT context, Func<T_CONTEXT, T_RETURN> func)
        : AndroidTaskState<T_CONTEXT>(context)
        where T_CONTEXT : class
    {
        public Func<T_CONTEXT, T_RETURN> Func { get; } = func;



        public T_RETURN Execute()
        {
            return Func.Invoke(Context);

        }


    }

}
