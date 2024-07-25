using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Core
{
    public interface IRefMonoString
    {
        int Length { get; }
        ref readonly char FirstChar { get; }

    }
}
