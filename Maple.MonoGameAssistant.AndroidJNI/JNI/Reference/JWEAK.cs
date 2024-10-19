using Maple.MonoGameAssistant.AndroidJNI.Extension;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JWEAK(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator JWEAK(nint val) => new(val);
        public static implicit operator nint(JWEAK val) => val._ptr;
        public static implicit operator bool(JWEAK val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JWEAK val) => new(val._ptr);


    }
}
