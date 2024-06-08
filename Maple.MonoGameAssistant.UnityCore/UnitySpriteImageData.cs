using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.UnityCore
{
    public class UnitySpriteImageData
    {
        public required string Category { set; get; }
        public required string? Name { set; get; }
        public PMonoArray<byte> ImageData { set; get; }
    }


  
}
