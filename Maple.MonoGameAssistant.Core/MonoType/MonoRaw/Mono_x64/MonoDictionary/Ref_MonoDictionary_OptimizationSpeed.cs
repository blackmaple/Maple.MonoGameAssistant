using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_MonoDictionary_OptimizationSpeed
    {

        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;

        /// <summary>
        /// 0x10 System.Int32[] buckets
        /// </summary>
        [FieldOffset(0x10)]
        public readonly nint buckets;


        /// <summary>
        /// 0x18 System.Collections.Generic.Dictionary.Entry<TKey,TValue>[] entries
        /// </summary>
        [FieldOffset(0x18)]
        public readonly nint entries;


        /// <summary>
        /// 0x20 System.Collections.Generic.IEqualityComparer<TKey> comparer
        /// </summary>
        [FieldOffset(0x20)]
        public readonly nint comparer;


        /// <summary>
        /// 0x28 System.Collections.Generic.Dictionary.KeyCollection<TKey,TValue> keys
        /// </summary>
        [FieldOffset(0x28)]
        public readonly nint keys;


        /// <summary>
        /// 0x30 System.Collections.Generic.Dictionary.ValueCollection<TKey,TValue> values
        /// </summary>
        [FieldOffset(0x30)]
        public readonly nint values;


        /// <summary>
        /// 0x38 System.Object _syncRoot
        /// </summary>
        [FieldOffset(0x38)]
        public readonly nint _syncRoot;


        /// <summary>
        /// 0x40 System.Int32 count
        /// </summary>
        [FieldOffset(0x40)]
        public readonly System.Int32 count;


        /// <summary>
        /// 0x44 System.Int32 version
        /// </summary>
        [FieldOffset(0x44)]
        public readonly System.Int32 version;


        /// <summary>
        /// 0x48 System.Int32 freeList
        /// </summary>
        [FieldOffset(0x48)]
        public readonly System.Int32 freeList;


        /// <summary>
        /// 0x4C System.Int32 freeCount
        /// </summary>
        [FieldOffset(0x4C)]
        public readonly System.Int32 freeCount;
    }

    readonly unsafe partial struct Ref_MonoDictionary_OptimizationSpeed : IRefMonoDictionary
    {
        public int Count => count;

        public int FreeCount => freeCount;

        public PMonoArray Entries => entries;


    }
}
