using Maple.MonoGameAssistant.AndroidCore.JNI.Reference;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Reference.Array
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JFLOAT_ARRAY(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator JFLOAT_ARRAY(nint val) => new(val);
        public static implicit operator nint(JFLOAT_ARRAY val) => val._ptr;
        public static implicit operator bool(JFLOAT_ARRAY val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JFLOAT_ARRAY val) => new(val._ptr);
        public static implicit operator JOBJECT_ARRAY(JFLOAT_ARRAY val) => new(val._ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNullPtr() => _ptr != nint.Zero;
    }

}
