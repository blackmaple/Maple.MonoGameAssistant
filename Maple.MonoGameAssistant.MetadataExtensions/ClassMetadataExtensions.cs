using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public static class ClassMetadataExtensions
    {
        public static bool IsNotNull<T_PTR>(this T_PTR @this) where T_PTR : unmanaged, IPtrObject
            => @this.Ptr != nint.Zero;

        public static bool IsNull<T_PTR>(this T_PTR @this) where T_PTR : unmanaged, IPtrObject
            => @this.Ptr == nint.Zero;

        

    }
}
