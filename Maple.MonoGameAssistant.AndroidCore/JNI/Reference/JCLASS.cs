using Maple.MonoGameAssistant.AndroidCore.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JCLASS(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        nint _ptr = ptr;

        public nint Ptr { readonly get => _ptr; set => _ptr = value; }

        public static implicit operator JCLASS(nint val) => new(val);
        public static implicit operator nint(JCLASS val) => val._ptr;
        public static implicit operator bool(JCLASS val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JCLASS val) => new(val._ptr);



        public override string ToString()
        {
            return _ptr.ToString("X8");
        }
    }

}
