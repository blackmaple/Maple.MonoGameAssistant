using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public sealed class ClassMetadataCollection(MonoClassInfoDTO classInfo)
    {
        public MonoClassInfoDTO ClassInfo { get; } = classInfo;
        public List<MonoClassInfoDTO> ParentClasses { get; } = [];
        public List<MonoMethodInfoDTO> MethodInfos { get; } = [];
        public List<MonoFieldInfoDTO> FieldInfos { get; } = [];
    }
}
