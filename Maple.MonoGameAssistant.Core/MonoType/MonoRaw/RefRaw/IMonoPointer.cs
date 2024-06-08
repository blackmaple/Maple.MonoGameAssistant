namespace Maple.MonoGameAssistant.Core
{
    public interface IMonoPointer<TRefMonoObject>
        where TRefMonoObject : unmanaged
    {
        ref TRefMonoObject AsRef();
    }
}
