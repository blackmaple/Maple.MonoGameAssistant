using Maple.MonoGameAssistant.AndroidCore.JNI.Reference;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidCore.Extension
{
    internal static class AndroidExtensions
    {
        public const int JNI_VERSION_1_6 = 0x00010006;

        internal unsafe static ref T_STRUCT RefStruct<T_STRUCT>(this nint @this)
              where T_STRUCT : unmanaged
              => ref Unsafe.AsRef<T_STRUCT>(@this.ToPointer());


        internal static bool IsNullPtr<T>(this T obj) where T : unmanaged, IJNIReferenceInterface
            => obj.Ptr == IntPtr.Zero;

        internal static void SetNullPtr<T>(this T obj) where T : unmanaged, IJNIReferenceInterface
            => obj.Ptr = IntPtr.Zero;

        internal static string? ToString<T>(this T obj) where T : unmanaged, IJNIReferenceInterface
            => obj.Ptr.ToString("X8");
    }

    internal interface IJNIReferenceInterface
    {
        public nint Ptr { get; set; }

    }

    internal interface IJNIReferenceInterface<T> where T : unmanaged, IJNIReferenceInterface,INumber
    {
        static implicit operator T(nint val) => new(val);
        static implicit operator nint(T val) => val._ptr;
        static implicit operator bool(JARRAY val) => val.IsNullPtr();
        static implicit operator JOBJECT(JARRAY val) => new(val._ptr);

    }



}
