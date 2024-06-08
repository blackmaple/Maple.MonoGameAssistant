namespace Maple.MonoGameAssistant.Core
{
    public interface IPtrMonoQueue<T_REF, T_DATA> : IMonoPointer<T_REF>
        where T_REF : unmanaged, IRefMonoQueue
        where T_DATA : unmanaged
    {
        Ptr_MonoItem<T_DATA>[] ToArray();
    }
}
