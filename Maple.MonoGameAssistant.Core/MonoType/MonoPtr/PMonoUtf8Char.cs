using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Maple.MonoGameAssistant.Core
{

    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly struct PMonoUtf8Char(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoUtf8Char ptr) => ptr._ptr;
        public static implicit operator PMonoUtf8Char(nint ptr) => new(ptr);
        public unsafe static implicit operator PMonoUtf8Char(byte* ptr) => new nint(ptr);
        public unsafe static implicit operator PMonoUtf8Char(void* ptr) => new nint(ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string? ToString() => GetRawString();

        public ReadOnlySpan<byte> AsReadOnlySpan()
        {
            if (false == Valid())
            {
                return default;
            }
            var span = MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)_ptr);
            return span;
        }

        public string? GetRawString()
        {
            if (false == Valid())
            {
                return default;
            }
            return Encoding.UTF8.GetString(this.AsReadOnlySpan());
        }

        public byte[] ToArray()
             => AsReadOnlySpan().ToArray();

    }





}
