using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Core
{
    public static class MonoHashSetExtensions
    {
        public static PMonoSlot<TRef_MonoSlot, T_VALUE>[] AsRefArray<T_REF, T_VALUE, TRef_MonoSlot>(this ref T_REF ref_this)
            where T_REF : unmanaged, IRefMonoHashSet
            where T_VALUE : unmanaged
            where TRef_MonoSlot : unmanaged, IRefMonoSlot<T_VALUE>
        {
            var realCount = ref_this.Count;
            if (realCount == 0)
            {
                return [];
            }
            var arrCount = ref_this.LastIndex;
            var span_Slots = ref_this.Slots.AsReadOnlySpan<TRef_MonoSlot>(arrCount);
            var ret_Values = new PMonoSlot<TRef_MonoSlot, T_VALUE>[realCount];
            int index = 0;
            foreach (ref readonly var ref_Slot in span_Slots)
            {
                if (ref_Slot.HashCode >= 0)
                {
                    var ptr = Unsafe.AsRef(in ref_Slot).AsPointer();
                    ret_Values[index % ret_Values.Length] = new PMonoSlot<TRef_MonoSlot, T_VALUE>(ptr);
                    ++index;
                }
            }
            return ret_Values;

        }

        public static PMonoSlot<TRef_MonoSlot, T_VALUE>[] AsRefArray<T_PTR, T_REF, T_VALUE, TRef_MonoSlot>(this T_PTR @this)
            where T_PTR : IPtrMonoHashSet<T_REF, T_VALUE, TRef_MonoSlot>
            where T_REF : unmanaged, IRefMonoHashSet
            where T_VALUE : unmanaged
            where TRef_MonoSlot : unmanaged, IRefMonoSlot<T_VALUE>
            => @this.AsRef().AsRefArray<T_REF, T_VALUE, TRef_MonoSlot>();
    }

}
