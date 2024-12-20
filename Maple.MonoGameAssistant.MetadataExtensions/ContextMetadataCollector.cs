using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public abstract partial class ContextMetadataCollector(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext)
    {
        public ILogger Logger { get; } = logger;
        public MetadataCollectorSearchService SearchService { get; } = searchService;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public MonoObjectNameDTO[] ImageNames { get; } = [.. runtimeContext.EnumMonoImageNames()];

        public bool TryGetImageMetadata(MonoSearchClassDTO searchClassDTO, [MaybeNullWhen(false)] out MonoObjectNameDTO imageNameDTO)
        {
            Unsafe.SkipInit(out imageNameDTO);
            foreach (var data in this.ImageNames)
            {
                if (SequenceEqual(data.Utf8Name, searchClassDTO.Utf8ImageName))
                {
                    imageNameDTO = data;
                    return true;
                }
            }
            return false;

            static bool SequenceEqual(ReadOnlySpan<byte> dest, ReadOnlySpan<byte> findSearch)
            {
                if (MemoryExtensions.SequenceEqual(dest, findSearch))
                {
                    return true;
                }
                return findSearch.EndsWith(".dll"u8) && MemoryExtensions.SequenceEqual(dest, findSearch[..^4]);
            }
        }

        public bool TryGetClassMetadata(string code, [MaybeNullWhen(false)] out MonoMetadataCollection classMetadata)
        {
            Unsafe.SkipInit(out classMetadata);
            if (!this.SearchService.TryGetClass(code, out var searchClassDTO))
            {
                return false;
            }
            this.RuntimeContext.TryGetFirstClassInfo(searchClassDTO.ImageName, searchClassDTO.Namespace, searchClassDTO.ClassName, out var classInfo);
        }
    }
}
