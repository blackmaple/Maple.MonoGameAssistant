using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Model
{
    public class MonoSearchClassDTO : MonoSearchMemberDTO
    {
        public byte[]? Utf8ImageName { get; }
        public byte[]? Utf8Namespace { get; }
        public byte[]? Utf8ClassName { get; }

        public MonoSearchMemberDTO[]? Members { set; get; }

        public bool TryGetSearchMember(string code, [MaybeNullWhen(false)] out MonoSearchMemberDTO searchMemberDTO)
        {
            searchMemberDTO = this.Members?.FirstOrDefault(p => p.Code == code);
            return searchMemberDTO is not null;
        }
    }


}
