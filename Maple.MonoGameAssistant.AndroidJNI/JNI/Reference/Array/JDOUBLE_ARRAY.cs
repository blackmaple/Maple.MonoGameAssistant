using Maple.MonoGameAssistant.AndroidJNI.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.Array
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JDOUBLE_ARRAY(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator JDOUBLE_ARRAY(nint val) => new(val);
        public static implicit operator nint(JDOUBLE_ARRAY val) => val._ptr;
        public static implicit operator bool(JDOUBLE_ARRAY val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JDOUBLE_ARRAY val) => new(val._ptr);
        public static implicit operator JOBJECT_ARRAY(JDOUBLE_ARRAY val) => new(val._ptr);

    }

}
