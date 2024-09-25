using System.Xml.Linq;

namespace Maple.MonoGameAssistant.Core
{
    public interface IRefMonoQueue
    {
        int Size { get; }
        PMonoArray Array { get; }
        int Head { get; }

    }
}
