using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
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

        public static  bool TryGetClassMetadata<T_ClassMetadata>(ContextMetadataCollector @this, [MaybeNullWhen(false)]out ClassMetadataCollection classMetadata ) where T_ClassMetadata : IClassMetadataCollector
        {
            
        }
        public static bool TryGetClassMetadata(this ContextMetadataCollector @this,string code, [MaybeNullWhen(false)] out ClassMetadataCollection classMetadata) 
        {
            @this.SearchService.TryGetSearchClass(code, out var searchClassDTO);
        }
    }
}
