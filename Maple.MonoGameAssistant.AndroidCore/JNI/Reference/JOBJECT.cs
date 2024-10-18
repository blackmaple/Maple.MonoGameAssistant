using Maple.MonoGameAssistant.AndroidCore.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JOBJECT(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        nint _ptr = ptr;

        public nint Ptr { readonly get => _ptr; set => _ptr = value; }

        public static implicit operator JOBJECT(nint val) => new(val);
        public static implicit operator JOBJECT(void* val) => new nint(val);
        public static implicit operator nint(JOBJECT val) => val._ptr;
        public static implicit operator bool(JOBJECT val) => val.IsNullPtr();


    }

}
