using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_MonoDictionary_WuLin
    {
        /// <summary>
        /// REF_MONO_OBJECT._vtable
        /// </summary>
        [MarshalAs(UnmanagedType.SysInt)]
        [FieldOffset(0)]
        public readonly nint _vtable;

        /// <summary>
        /// REF_MONO_OBJECT._synchronisation
        /// </summary>
        [MarshalAs(UnmanagedType.SysInt)]
        [FieldOffset(8)]
        public readonly nint _synchronisation;



        /// <summary>
        /// class 0x10 System.Int32[] buckets
        /// </summary>
        [FieldOffset(0x10)]
        public readonly nint buckets;


        /// <summary>
        /// class 0x18 System.Collections.Generic.Dictionary.Entry<System.String,UnityEngine.Sprite>[] entries
        /// </summary>
        [FieldOffset(0x18)]
        public readonly nint entries;


        /// <summary>
        /// struct 0x20 System.Int32 count
        /// </summary>
        [FieldOffset(0x20)]
        public readonly System.Int32 count;


        /// <summary>
        /// struct 0x24 System.Int32 version
        /// </summary>
        [FieldOffset(0x24)]
        public readonly System.Int32 version;


        /// <summary>
        /// struct 0x28 System.Int32 freeList
        /// </summary>
        [FieldOffset(0x28)]
        public readonly System.Int32 freeList;


        /// <summary>
        /// struct 0x2C System.Int32 freeCount
        /// </summary>
        [FieldOffset(0x2C)]
        public readonly System.Int32 freeCount;


        /// <summary>
        /// interface 0x30 System.Collections.Generic.IEqualityComparer<System.String> comparer
        /// </summary>
        [FieldOffset(0x30)]
        public readonly nint comparer;


        /// <summary>
        /// class 0x38 System.Collections.Generic.Dictionary.KeyCollection<System.String,UnityEngine.Sprite> keys
        /// </summary>
        [FieldOffset(0x38)]
        public readonly nint keys;


        /// <summary>
        /// class 0x40 System.Collections.Generic.Dictionary.ValueCollection<System.String,UnityEngine.Sprite> values
        /// </summary>
        [FieldOffset(0x40)]
        public readonly nint values;


        /// <summary>
        /// class 0x48 System.Object _syncRoot
        /// </summary>
        [FieldOffset(0x48)]
        public readonly nint _syncRoot;

    }

    partial struct Ref_MonoDictionary_WuLin : IRefMonoDictionary
    {
        public int Count => count;

        public int FreeCount => freeCount;

        public PMonoArray Entries => entries;
    }
}
