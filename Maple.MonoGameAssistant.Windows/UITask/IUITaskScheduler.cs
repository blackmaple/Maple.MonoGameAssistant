namespace Maple.MonoGameAssistant.Windows.UITask
{
    public interface IUITaskScheduler<T_CONTEXT> where T_CONTEXT : class
    {
        T_CONTEXT Context { get; }
    }
}
