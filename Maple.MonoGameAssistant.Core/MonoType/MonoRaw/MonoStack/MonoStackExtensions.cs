using Maple.MonoGameAssistant.RawDotNet;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Core
{
    public static class MonoStackExtensions
    {
        public static Ptr_MonoItem<T_DATA>[] ToArray<T_REF, T_DATA>(this ref T_REF ref_this)
            where T_REF : unmanaged, IRefMonoStack
            where T_DATA : unmanaged
        {

            var realSize = ref_this.Size;
            if (realSize == 0)
            {
                return [];
            }
            var ret_value = new Ptr_MonoItem<T_DATA>[realSize];
            ref var ref_array = ref ref_this.Array.AsRef();
            for (int i = 0; i < realSize; i++)
            {
                ref var val = ref ref_array.RefElementAt<Ref_MonoArray, T_DATA>(realSize - i - 1);
                var ptr_val = val.AsPointer();
                ret_value[i % ret_value.Length] = ptr_val;
            }
            return ret_value;

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Ptr_MonoItem<T_DATA>[] ToArray<T_PTR, T_REF, T_DATA>(this T_PTR @this)
            where T_PTR : IPtrMonoStack<T_REF, T_DATA>
            where T_REF : unmanaged, IRefMonoStack
            where T_DATA : unmanaged
         => @this.AsRef().ToArray<T_REF, T_DATA>();
    }
}
