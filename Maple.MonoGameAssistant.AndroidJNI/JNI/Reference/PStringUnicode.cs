using Maple.MonoGameAssistant.AndroidJNI.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct PStringUnicode(nint ptr) : IJNIReferenceInterface
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator nint(PStringUnicode ptr) => ptr._ptr;
        public static implicit operator PStringUnicode(nint ptr) => new(ptr);
        public unsafe static implicit operator PStringUnicode(char* ptr) => new nint(ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string? ToString() => GetRawString();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string? GetRawString()
        {
            if (false == this.IsNullPtr())
            {
                return default;
            }

            return new string((char*)_ptr);
        }

        public ReadOnlySpan<char> AsReadOnlySpan()
        {
            if (false == this.IsNullPtr())
            {
                return default;
            }
            return MemoryMarshal.CreateReadOnlySpanFromNullTerminated((char*)_ptr);
        }

    }

}
