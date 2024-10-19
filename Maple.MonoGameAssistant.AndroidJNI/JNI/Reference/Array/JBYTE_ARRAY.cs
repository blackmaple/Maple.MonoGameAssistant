using Maple.MonoGameAssistant.AndroidJNI.Extension;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.Array
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JBYTE_ARRAY(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;


        public static implicit operator JBYTE_ARRAY(nint val) => new(val);
        public static implicit operator nint(JBYTE_ARRAY val) => val._ptr;
        public static implicit operator bool(JBYTE_ARRAY val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JBYTE_ARRAY val) => new(val._ptr);
        public static implicit operator JOBJECT_ARRAY(JBYTE_ARRAY val) => new(val._ptr);


    }

}
