using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PMonoUtf16Char(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoUtf16Char ptr) => ptr._ptr;
        public static implicit operator PMonoUtf16Char(nint ptr) => new(ptr);
        public unsafe static implicit operator PMonoUtf16Char(byte* ptr) => new nint(ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string? ToString()
        {
            return Marshal.PtrToStringUni(_ptr);
        }
    }





}
