namespace Maple.MonoGameAssistant.Core
{
    public interface IPtrMonoStack<T_REF, T_DATA> : IMonoPointer<T_REF>
        where T_REF : unmanaged, IRefMonoStack
        where T_DATA : unmanaged
    {
        Ptr_MonoItem<T_DATA>[] ToArray();
    }
}
