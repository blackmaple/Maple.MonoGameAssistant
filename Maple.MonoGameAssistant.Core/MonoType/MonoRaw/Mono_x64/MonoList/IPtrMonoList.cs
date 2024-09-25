namespace Maple.MonoGameAssistant.Core
{
    public interface IPtrMonoList<T_REF, T_DATA> : IMonoPointer<T_REF>
        where T_REF : unmanaged, IRefMonoList
        where T_DATA : unmanaged
    {
        ReadOnlySpan<T_DATA> AsReadOnlySpan();
        ref T_DATA RefElementAt(int index);

        int Size => 0;
    }
}
