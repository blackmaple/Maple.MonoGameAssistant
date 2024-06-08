namespace Maple.MonoGameAssistant.Core
{
    public interface IRefMonoHashSet
    {
        int Count { get; }
        int LastIndex { get; }
        PMonoArray Slots { get; }
    }
}
