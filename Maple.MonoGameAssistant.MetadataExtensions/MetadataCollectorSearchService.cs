using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public class MetadataCollectorSearchService
    {
        public List<MonoSearchClassDTO> SearchClasses { get; } = new List<MonoSearchClassDTO>(256);
        public List<MonoSearchMethodDTO> SearchMethods { get; } = new List<MonoSearchMethodDTO>(256);
        public List<MonoSearchFieldDTO> SearchFields { get; } = new List<MonoSearchFieldDTO>(256);


        public bool TryGetClass(string code, [MaybeNullWhen(false)] out MonoSearchClassDTO searchClassDTO)
        {
            searchClassDTO = this.SearchClasses.Find(p => p.Code == code);
            return searchClassDTO is not null;
        }

        public bool TryGetMethod(string code, [MaybeNullWhen(false)] out MonoSearchMethodDTO searchMethodDTO)
        {
            searchMethodDTO = this.SearchMethods.Find(p => p.Code == code);
            return searchMethodDTO is not null;
        }

        public bool TryGetField(string code, [MaybeNullWhen(false)] out MonoSearchFieldDTO searchFieldDTO)
        {
            searchFieldDTO = this.SearchFields.Find(p => p.Code == code);
            return searchFieldDTO is not null;
        }


        public void Clear()
        {
            this.SearchClasses.Clear();
            this.SearchMethods.Clear();
            this.SearchFields.Clear();
        }

    }
}
