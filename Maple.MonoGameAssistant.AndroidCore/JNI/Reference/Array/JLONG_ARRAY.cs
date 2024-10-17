using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Reference.Array
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JLONG_ARRAY(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator JLONG_ARRAY(nint val) => new(val);
        public static implicit operator nint(JLONG_ARRAY val) => val._ptr;
        public static implicit operator bool(JLONG_ARRAY val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JLONG_ARRAY val) => new(val._ptr);
        public static implicit operator JOBJECT_ARRAY(JLONG_ARRAY val) => new(val._ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNullPtr() => _ptr != nint.Zero;
    }

}
