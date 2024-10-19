using Maple.MonoGameAssistant.AndroidJNI.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JSTRING(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator JSTRING(nint val) => new(val);
        public static implicit operator nint(JSTRING val) => val._ptr;
        public static implicit operator bool(JSTRING val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JSTRING val) => new(val._ptr);

    }

}
