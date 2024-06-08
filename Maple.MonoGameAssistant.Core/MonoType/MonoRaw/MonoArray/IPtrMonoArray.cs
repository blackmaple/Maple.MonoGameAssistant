namespace Maple.MonoGameAssistant.Core
{
    public interface IPtrMonoArray<TRefMonoArray, T_DATA> : IMonoPointer<TRefMonoArray>
        where TRefMonoArray : unmanaged, IRefMonoArray
        where T_DATA : unmanaged
    {
        ReadOnlySpan<T_DATA> AsReadOnlySpan();
        ReadOnlySpan<T_DATA> AsReadOnlySpan(int count);
        Span<T_DATA> AsSpan();
        Span<T_DATA> AsSpan(int count);
        ref T_DATA RefElementAt(int index);
        ref T_DATA RefElementAt(int col, int row);

    }
}
