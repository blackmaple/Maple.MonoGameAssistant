using Maple.MonoGameAssistant.AndroidJNI.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JLOCAL(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator JLOCAL(nint val) => new(val);
        public static implicit operator nint(JLOCAL val) => val._ptr;
        public static implicit operator bool(JLOCAL val) => val.IsNotNullPtr();
        public static implicit operator JOBJECT(JLOCAL val) => new(val._ptr);
        public static implicit operator JVALUE(JLOCAL val) => new(val._ptr);

    }


    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JLOCAL<T>(nint ptr) : IJNIReferenceInterface
    where T : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator JLOCAL<T>(nint val) => new(val);
        public static implicit operator JLOCAL<T>(JLOCAL val) => new(val.Ptr);

        public static implicit operator nint(JLOCAL<T> val) => val._ptr;
        public static implicit operator bool(JLOCAL<T> val) => val.IsNotNullPtr();
        public static implicit operator JOBJECT(JLOCAL<T> val) => new(val._ptr);
        public static implicit operator JLOCAL(JLOCAL<T> val) => new(val._ptr);
        public static implicit operator T(JLOCAL<T> val) => val.Value;


        public T Value => Unsafe.As<nint, T>(ref Unsafe.AsRef(in _ptr));
    }


}
