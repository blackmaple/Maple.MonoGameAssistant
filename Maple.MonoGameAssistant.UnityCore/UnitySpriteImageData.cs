using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;

namespace Maple.MonoGameAssistant.UnityCore
{
    public class UnitySpriteImageData
    {
        public required string Category { set; get; }
        public required string? Name { set; get; }
        public PMonoArray<byte> ImageData { set; get; }
    }

    public class UnitySpriteData
    {
        public required string Category { set; get; }
        public required string? Name { set; get; }
        public Sprite.Ptr_Sprite Ptr_Sprite { set; get; }
    }

}
