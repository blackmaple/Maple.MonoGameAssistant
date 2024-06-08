namespace Maple.MonoGameAssistant.Core
{
    public interface IRefMonoSlot<T_VALUE>
        where T_VALUE : unmanaged
    {
        int HashCode { get; }

        int Next { get; }

        ref readonly T_VALUE Value { get; }

    }
}
