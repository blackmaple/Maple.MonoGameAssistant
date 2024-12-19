using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public static class ClassMetadataExtensions
    {
        public static bool IsNotNull<T_PTR>(this T_PTR @this) where T_PTR : unmanaged, IPtrMetadata
            => @this.Ptr != nint.Zero;

        public static bool IsNull<T_PTR>(this T_PTR @this) where T_PTR : unmanaged, IPtrMetadata
            => @this.Ptr == nint.Zero;

    }

    public interface IClassMetadataCollector
    {
        abstract static string CODE { get; }
    }

    public abstract partial class ClassMetadataCollector
    {

    }

    public abstract partial class ContextMetadataCollector
    {

    }



    public static class MetadataJsonContext
    {

    }



    public sealed class ClassMetadataInfo(MonoClassInfoDTO classInfo)
    {
        public MonoClassInfoDTO ClassInfo { get; } = classInfo;
        public List<MonoClassInfoDTO> ParentClasses { get; } = [];
        public List<MonoMethodInfoDTO> MethodInfos { get; } = [];
        public List<MonoFieldInfoDTO> FieldInfos { get; } = [];
    }
}
