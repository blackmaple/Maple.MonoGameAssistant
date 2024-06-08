namespace Maple.MonoGameAssistant.Core
{
    public interface IPtrMonoDictionary<T_REF, T_KEY, T_VALUE, TRef_MonoEntry> : IMonoPointer<T_REF>
            where T_REF : unmanaged, IRefMonoDictionary
            where T_KEY : unmanaged
            where T_VALUE : unmanaged
            where TRef_MonoEntry : unmanaged, IRefMonoEntry<T_KEY, T_VALUE>
    {
        PMonoEntry<TRef_MonoEntry, T_KEY, T_VALUE>[] AsRefArray();
    }
}
