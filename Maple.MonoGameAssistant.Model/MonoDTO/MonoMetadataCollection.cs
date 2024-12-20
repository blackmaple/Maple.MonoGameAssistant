namespace Maple.MonoGameAssistant.Model
{
    public sealed class MonoMetadataCollection
    {
        public required MonoClassInfoDTO ClassInfo { get; init; }
        public required MonoMethodInfoDTO[] MethodInfos { get; init; }
        public required MonoFieldInfoDTO[] FieldInfos { get; init; }
    }
}
