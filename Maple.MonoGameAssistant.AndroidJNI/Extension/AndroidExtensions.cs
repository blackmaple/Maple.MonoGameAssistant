using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidJNI.Extension
{
    internal static class AndroidExtensions
    {
      

        internal unsafe static ref T_STRUCT RefStruct<T_STRUCT>(this nint @this)
              where T_STRUCT : unmanaged
              => ref Unsafe.AsRef<T_STRUCT>(@this.ToPointer());

        internal static bool IsNotNullPtr<T>(this T obj) where T : unmanaged, IJNIReferenceInterface
            => obj.Ptr != nint.Zero;

        internal static string ToString<T>(this T obj) where T : unmanaged, IJNIReferenceInterface
            => obj.Ptr.ToString("X8");
    }





}
