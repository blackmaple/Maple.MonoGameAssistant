using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public abstract partial class ContextMetadataCollector(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext)
    {
        public ILogger Logger { get; } = logger;
        public MetadataCollectorSearchService SearchService { get; } = searchService;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
    }
}
