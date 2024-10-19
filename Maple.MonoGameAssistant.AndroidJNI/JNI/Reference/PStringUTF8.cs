using Maple.MonoGameAssistant.AndroidJNI.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct PStringUTF8(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator nint(PStringUTF8 ptr) => ptr._ptr;
        public static implicit operator PStringUTF8(nint ptr) => new(ptr);
        public unsafe static implicit operator PStringUTF8(byte* ptr) => new nint(ptr);
        public unsafe static implicit operator PStringUTF8(void* ptr) => new nint(ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string? ToString() => GetRawString();

        public ReadOnlySpan<byte> AsReadOnlySpan()
        {
            if (false == this.IsNullPtr())
            {
                return default;
            }
            var span = MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)_ptr);
            return span;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string? GetRawString()
        {
            if (false == this.IsNullPtr())
            {
                return default;
            }
            return Marshal.PtrToStringUTF8(_ptr);
        }

        public byte[] ToArray()
             => AsReadOnlySpan().ToArray();

    }

}
