namespace Maple.MonoGameAssistant.AndroidCore.AndroidTask
{
    public interface IAndroidTaskScheduler<T_CONTEXT> where T_CONTEXT : class
    {
        T_CONTEXT Context { get; }
        TaskScheduler AndroidScheduler { get; }

    }



}
