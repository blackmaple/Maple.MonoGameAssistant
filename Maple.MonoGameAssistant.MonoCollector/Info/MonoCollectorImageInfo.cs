using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.MonoCollector
{
    public class MonoCollectorImageInfo(MonoImageInfoDTO imageInfoDTO)
    {
        public MonoImageInfoDTO ImageInfoDTO { get; } = imageInfoDTO;
        public List<MonoCollectorClassInfo> ListClassInfo { get; } = [];
    }
}
