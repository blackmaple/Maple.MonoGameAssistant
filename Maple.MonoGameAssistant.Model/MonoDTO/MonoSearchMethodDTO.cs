namespace Maple.MonoGameAssistant.Model
{
    public class MonoSearchMethodDTO : MonoSearchMemberDTO
    {
        public byte[]?[]? Utf8Signature { get; }
        public byte[]? Utf8ReturnType { get; }
    }
}
