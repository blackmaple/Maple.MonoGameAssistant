using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly struct PStringUTF8(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PStringUTF8 ptr) => ptr._ptr;
        public static implicit operator PStringUTF8(nint ptr) => new(ptr);
        public unsafe static implicit operator PStringUTF8(byte* ptr) => new nint(ptr);
        public unsafe static implicit operator PStringUTF8(void* ptr) => new nint(ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNullPtr() => _ptr != nint.Zero;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string? ToString() => GetRawString();

        public ReadOnlySpan<byte> AsReadOnlySpan()
        {
            if (false == IsNullPtr())
            {
                return default;
            }
            var span = MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)_ptr);
            return span;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string? GetRawString()
        {
            if (false == IsNullPtr())
            {
                return default;
            }
            var span = MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)_ptr);
            return Encoding.UTF8.GetString(span);
        }

        public byte[] ToArray()
             => AsReadOnlySpan().ToArray();

    }
}
