using System;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Core
{
    public static class MonoDictionaryExtensions
    {

        public static PMonoEntry<TRef_MonoEntry, T_KEY, T_VALUE>[] AsRefArray<T_REF, T_KEY, T_VALUE, TRef_MonoEntry>(this ref T_REF ref_this)
            where T_REF : unmanaged, IRefMonoDictionary
            where T_KEY : unmanaged
            where T_VALUE : unmanaged
            where TRef_MonoEntry : unmanaged, IRefMonoEntry<T_KEY, T_VALUE>
        {
            var arrCount = ref_this.Count;
            var realCount = arrCount - ref_this.FreeCount;
            if (realCount == 0)
            {
                return [];
            }
            var span_entries = ref_this.Entries.AsReadOnlySpan<TRef_MonoEntry>(arrCount);
            var ret_keyValues = new PMonoEntry<TRef_MonoEntry, T_KEY, T_VALUE>[realCount];
            int index = 0;
            foreach (ref readonly var ref_entry in span_entries)
            {
                if (ref_entry.HashCode >= 0)
                {
                    var ptr = Unsafe.AsRef(in ref_entry).AsPointer();
                    ret_keyValues[index % ret_keyValues.Length] = ptr;
                    ++index;
                }
            }
            return ret_keyValues;
        }


        public static PMonoEntry<TRef_MonoEntry, T_KEY, T_VALUE>[] AsRefArray<T_PTR, T_REF, T_KEY, T_VALUE, TRef_MonoEntry>(this T_PTR @this)
            where T_PTR : IPtrMonoDictionary<T_REF, T_KEY, T_VALUE, TRef_MonoEntry>
            where T_REF : unmanaged, IRefMonoDictionary
            where T_KEY : unmanaged
            where T_VALUE : unmanaged
            where TRef_MonoEntry : unmanaged, IRefMonoEntry<T_KEY, T_VALUE>
            => @this.AsRef().AsRefArray<T_REF, T_KEY, T_VALUE, TRef_MonoEntry>();

    }

}
