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
        public static implicit operator bool(JGLOBAL val) => val.IsNotNullPtr();
        public static implicit operator JOBJECT(JGLOBAL val) => new(val._ptr);
        public static implicit operator JVALUE(JGLOBAL val) => new(val._ptr);

    }



    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JGLOBAL<T>(nint ptr) : IJNIReferenceInterface
        where T : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;

        public static implicit operator JGLOBAL<T>(nint val) => new(val);
        public static implicit operator JGLOBAL<T>(JGLOBAL val) => new(val.Ptr);

        public static implicit operator nint(JGLOBAL<T> val) => val._ptr;
        public static implicit operator bool(JGLOBAL<T> val) => val.IsNotNullPtr();
        public static implicit operator JOBJECT(JGLOBAL<T> val) => new(val._ptr);
        public static implicit operator JGLOBAL(JGLOBAL<T> val) => new(val._ptr);
        public static implicit operator T(JGLOBAL<T> val) => val.Value;


        public T Value => Unsafe.As<nint, T>(ref Unsafe.AsRef(in _ptr));
    }

}
