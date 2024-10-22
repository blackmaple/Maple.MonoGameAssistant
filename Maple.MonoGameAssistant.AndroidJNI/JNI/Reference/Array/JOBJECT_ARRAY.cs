using Maple.MonoGameAssistant.AndroidJNI.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.Array
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JOBJECT_ARRAY(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;


        public static implicit operator JOBJECT_ARRAY(nint val) => new(val);
        public static implicit operator nint(JOBJECT_ARRAY val) => val._ptr;
        public static implicit operator bool(JOBJECT_ARRAY val) => val.IsNotNullPtr();
        public static implicit operator JOBJECT(JOBJECT_ARRAY val) => new(val._ptr);

    }

}
