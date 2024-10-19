using Maple.MonoGameAssistant.AndroidJNI.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JGLOBAL(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator JGLOBAL(nint val) => new(val);
        public static implicit operator nint(JGLOBAL val) => val._ptr;
        public static implicit operator bool(JGLOBAL val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JGLOBAL val) => new(val._ptr);

    }

}
