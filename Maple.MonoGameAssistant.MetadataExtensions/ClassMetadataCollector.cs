using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public abstract partial class ClassMetadataCollector(ContextMetadataCollector metadataCollector, ClassMetadataCollection collection) : IClassMetadataCollectorCode
    {
        public ContextMetadataCollector MetadataCollector { get; } = metadataCollector;
        public ILogger Logger => MetadataCollector.Logger;
        public MetadataCollectorSearchService SearchService => MetadataCollector.SearchService;
        public MonoRuntimeContext RuntimeContext => MetadataCollector.RuntimeContext;
        public ClassMetadataCollection Collection { get; } = collection;

    }
}
