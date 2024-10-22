using Maple.MonoGameAssistant.AndroidJNI.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JCLASS(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator JCLASS(nint val) => new(val);
        public static implicit operator nint(JCLASS val) => val._ptr;
        public static implicit operator bool(JCLASS val) => val.IsNotNullPtr();
        public static implicit operator JOBJECT(JCLASS val) => new(val._ptr);

    }

}
