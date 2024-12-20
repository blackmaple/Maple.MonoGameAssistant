using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Model
{
    public class MonoSearchClassDTO : MonoSearchMemberDTO
    {
        public byte[]? Utf8ImageName { get; }
        public byte[]? Utf8Namespace { get; }
        public byte[]? Utf8ClassName { get; }
    }

}
