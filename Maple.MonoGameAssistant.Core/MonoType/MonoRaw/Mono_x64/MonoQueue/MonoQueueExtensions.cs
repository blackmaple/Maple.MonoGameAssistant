using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Core
{
    public static class MonoQueueExtensions
    {
        public static Ptr_MonoItem<T_DATA>[] ToArray<T_REF, T_DATA>(this ref T_REF ref_this)
            where T_REF : unmanaged, IRefMonoQueue
            where T_DATA : unmanaged
        {
            var realSize = ref_this.Size;
            if (realSize == 0)
            {
                return [];
            }
            var ret_value = new Ptr_MonoItem<T_DATA>[realSize];

            ref var ref_array = ref ref_this.Array.AsRef();
            var capacity = ref_array.Size;
            var head = ref_this.Head;

            for (int i = 0; i < realSize; ++i)
            {
                var arrayIndex = (head + i);
                if (arrayIndex >= capacity)
                {
                    arrayIndex -= capacity;
                }
                ref var val = ref ref_array.RefElementAt<Ref_MonoArray, T_DATA>(arrayIndex);
                var ptr_val = val.AsPointer();
                ret_value[i % ret_value.Length] = ptr_val;
            }
            return ret_value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Ptr_MonoItem<T_DATA>[] ToArray<T_PTR, T_REF, T_DATA>(this T_PTR @this)
            where T_PTR : IPtrMonoQueue<T_REF, T_DATA>
            where T_REF : unmanaged, IRefMonoQueue
            where T_DATA : unmanaged
            => @this.AsRef().ToArray<T_REF, T_DATA>();
    }
}
