using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public class MetadataCollectorSearchService
    {
        public List<MonoSearchClassDTO> Searches { get; } = new List<MonoSearchClassDTO>(256);

        public void AddRange(List<MonoSearchClassDTO> monoSearches)
            => this.Searches.AddRange(monoSearches);

        public bool TryGetSearchClass(string code, [MaybeNullWhen(false)] out MonoSearchClassDTO searchClassDTO)
        {
            searchClassDTO = this.Searches.Find(p => p.Code == code);
            return searchClassDTO is not null;
        }

        public void Clear()=>this.Searches.Clear();

    }
}
