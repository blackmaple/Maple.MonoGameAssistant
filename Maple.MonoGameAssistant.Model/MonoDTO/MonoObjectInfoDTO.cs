using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.Model
{


    public class MonoObjectInfoDTO : MonoObjectPointerDTO
    {
        public string? Name { set; get; }
        public byte[]? Utf8Name { set; get; }


    }




}
