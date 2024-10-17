using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JTHROWABLE(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator JTHROWABLE(nint val) => new(val);
        public static implicit operator nint(JTHROWABLE val) => val._ptr;
        public static implicit operator bool(JTHROWABLE val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JTHROWABLE val) => new(val._ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNullPtr() => _ptr != nint.Zero;
    }

}
