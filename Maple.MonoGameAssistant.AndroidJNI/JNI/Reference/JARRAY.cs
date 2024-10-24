using Maple.MonoGameAssistant.AndroidJNI.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JARRAY(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator JARRAY(nint val) => new(val);
        public static implicit operator nint(JARRAY val) => val._ptr;
        public static implicit operator bool(JARRAY val) => val.IsNotNullPtr();
        public static implicit operator JOBJECT(JARRAY val) => new(val._ptr);
        public static implicit operator JVALUE(JARRAY val) => new(val._ptr);

    }


}
