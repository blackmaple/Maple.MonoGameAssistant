using System.IO;

namespace Maple.MonoGameAssistant.MetadataModel.ClassMetadata
{
    public interface IClassMetadataCollectorBase<T_RefMetadata, T_PtrMetadata>
        where T_RefMetadata : unmanaged, IRefMetadata
        where T_PtrMetadata : unmanaged, IPtrMetadata
    {

    }

    public interface IClassMetadataCollectorCode
    { 
    
    }
}
