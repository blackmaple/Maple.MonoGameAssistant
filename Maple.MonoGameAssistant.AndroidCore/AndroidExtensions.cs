using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidCore
{
    internal static class AndroidExtensions
    {
        public const int JNI_VERSION_1_6 = 0x00010006;

        internal unsafe static ref T_STRUCT RefStruct<T_STRUCT>(this nint @this)
              where T_STRUCT : unmanaged
              => ref Unsafe.AsRef<T_STRUCT>(@this.ToPointer());

    }
}
