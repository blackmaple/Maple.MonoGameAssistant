using Maple.MonoGameAssistant.AndroidJNI.Extension;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.Array
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct JVALUE_ARRAY(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;


        public static implicit operator JVALUE_ARRAY(nint val) => new(val);
        public static implicit operator JVALUE_ARRAY(void* val) => new nint(val);
        public static implicit operator nint(JVALUE_ARRAY val) => val._ptr;
        public static implicit operator bool(JVALUE_ARRAY val) => val.IsNotNullPtr();
        public static implicit operator JOBJECT(JVALUE_ARRAY val) => new(val._ptr);
        public static implicit operator JOBJECT_ARRAY(JVALUE_ARRAY val) => new(val._ptr);


    }

}
