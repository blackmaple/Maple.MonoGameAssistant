using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Core
{
    public static unsafe class MonoRawExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_Ref_Struct AsRefStruct<T_Ref_Struct>(this nint ptr)
            where T_Ref_Struct : unmanaged
        {
            return ref Unsafe.AsRef<T_Ref_Struct>(ptr.ToPointer());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_Ref_Struct TryAsRefStruct<T_Ref_Struct>(this nint ptr, out bool valid)
            where T_Ref_Struct : unmanaged
        {
            valid = ptr != nint.Zero;
            return ref Unsafe.AsRef<T_Ref_Struct>(ptr.ToPointer());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint AsPointer<T_Ref_Struct>(this ref T_Ref_Struct ref_Struct)
            where T_Ref_Struct : unmanaged
        {
            void* ptr = Unsafe.AsPointer(ref ref_Struct);
            return (nint)ptr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T_Ptr AsPointer<T_Ref_Struct, T_Ptr>(this ref T_Ref_Struct ref_Struct)
            where T_Ref_Struct : unmanaged
            where T_Ptr : unmanaged
        {
            var p = ref_Struct.AsPointer();
            return Unsafe.As<nint, T_Ptr>(ref p);
        }


    }

}
