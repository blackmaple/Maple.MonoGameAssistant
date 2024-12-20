using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public static class MetadataCollectorExtensions
    {
        public static bool IsNotNull<T_PTR>(this T_PTR @this) where T_PTR : unmanaged, IPtrMetadata
            => @this.Ptr != nint.Zero;

        public static bool IsNull<T_PTR>(this T_PTR @this) where T_PTR : unmanaged, IPtrMetadata
            => @this.Ptr == nint.Zero;



    }
}
