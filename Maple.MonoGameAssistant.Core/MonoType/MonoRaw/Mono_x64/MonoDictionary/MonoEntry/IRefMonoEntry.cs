namespace Maple.MonoGameAssistant.Core
{
    public interface IRefMonoEntry<TKEY, TVALUE>
        where TKEY : unmanaged
        where TVALUE : unmanaged

    {
        int HashCode { get; }
        int Next { get; }

        ref readonly TKEY Key { get; }
        ref readonly TVALUE Value { get; }

 

    }
}
