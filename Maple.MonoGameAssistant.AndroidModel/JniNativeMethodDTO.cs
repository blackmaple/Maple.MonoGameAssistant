using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.AndroidNdk.Helper
{
    public class JniNativeMethodDTO
    {
        [NotNull]
        public string? Name { set; get; }

        [NotNull]
        public string? Signature { set; get; }

        public nint Pointer { set; get; }
    }
}
