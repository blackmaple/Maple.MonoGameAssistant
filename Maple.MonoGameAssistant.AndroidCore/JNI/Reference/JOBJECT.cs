using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly struct JOBJECT(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator JOBJECT(nint val) => new(val);
        public static implicit operator JOBJECT(void* val) => new nint(val);
        public static implicit operator nint(JOBJECT val) => val._ptr;
        public static implicit operator bool(JOBJECT val) => val.IsNullPtr();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNullPtr() => _ptr != nint.Zero;
    }

}
