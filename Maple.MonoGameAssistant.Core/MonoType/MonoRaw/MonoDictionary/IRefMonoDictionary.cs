using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Core
{
    public interface IRefMonoDictionary
    {
        int Count { get; }
        int FreeCount { get; }
        PMonoArray Entries { get; }
    }
}
