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

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JWEAK<T>(nint ptr) : IJNIReferenceInterface
    where T : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator JWEAK<T>(nint val) => new(val);
        public static implicit operator JWEAK<T>(JWEAK val) => new(val.Ptr);
        public static implicit operator nint(JWEAK<T> val) => val._ptr;
        public static implicit operator bool(JWEAK<T> val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JWEAK<T> val) => new(val._ptr);
        public static implicit operator JWEAK(JWEAK<T> val) => new(val._ptr);
        public static implicit operator T(JWEAK<T> val) => val.Value;


        public T Value => Unsafe.As<nint, T>(ref Unsafe.AsRef(in _ptr));
    }


}
