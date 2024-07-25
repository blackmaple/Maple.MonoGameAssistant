using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Core
{
    readonly unsafe partial struct PMonoString
    {
        public ref Ref_MonoString AsRef() => ref _ptr.AsRefStruct<Ref_MonoString>();

        public string? GetString() => this.GetString<Ref_MonoString>();

        public string? GetString(int readSize) => this.GetString<Ref_MonoString>(readSize);

        public ReadOnlySpan<char> AsReadOnlySpan() => this.AsRef().AsReadOnlySpan();

    }


}
