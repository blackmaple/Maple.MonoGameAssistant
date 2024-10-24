using Maple.MonoGameAssistant.AndroidJNI.Extension;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct JOBJECT(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;


        public static implicit operator JOBJECT(nint val) => new(val);
        public static implicit operator JOBJECT(void* val) => new nint(val);
        public static implicit operator nint(JOBJECT val) => val._ptr;
        public static implicit operator bool(JOBJECT val) => val.IsNotNullPtr();
        public static implicit operator JVALUE(JOBJECT val) => new(val);


    }

}
