namespace Maple.MonoGameAssistant.MetadataModel.ClassMetadata
{
    public interface IClassMetadataCollectorBase<T_RefMetadata, T_PtrMetadata>
        where T_RefMetadata : unmanaged, IRefMetadata
        where T_PtrMetadata : unmanaged, IPtrMetadata
    {

    }

    public class ClassMetadataSettings
    {
        public byte[] Utf8ImageName { get; }
        public byte[] Utf8Namespace { get; }
        public byte[] Utf8ClassName { get; }

    }
}
