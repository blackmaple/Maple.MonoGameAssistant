namespace Maple.MonoGameAssistant.Core
{
    public interface IPtrMonoHashSet<T_REF, T_VALUE, TRef_MonoSlot> : IMonoPointer<T_REF>
            where T_REF : unmanaged, IRefMonoHashSet
            where T_VALUE : unmanaged
            where TRef_MonoSlot : unmanaged, IRefMonoSlot<T_VALUE>

    {
        PMonoSlot<TRef_MonoSlot, T_VALUE>[] AsRefArray();
    }
}
