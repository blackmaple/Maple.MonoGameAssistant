using System.Drawing;

namespace Maple.MonoGameAssistant.Core
{
    public interface IRefMonoArray
    {
        int Size { get; }
        ref  byte FirstByte { get; }

        (int Length, int LowerBound) GetArrayBounds();
    }
}
