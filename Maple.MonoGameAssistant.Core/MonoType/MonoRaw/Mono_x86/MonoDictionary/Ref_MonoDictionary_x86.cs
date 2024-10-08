﻿using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_MonoDictionary_x86
    {
        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;

        /// <summary>
        /// 0x10 System.Int32[] _buckets
        /// </summary>
        [FieldOffset(0x8)]
        public readonly PMonoArray<Ref_MonoArray, int> _buckets;


        /// <summary>
        /// 0x18 System.Collections.Generic.Dictionary.Entry<TKEY,TVALUE>[] _entries
        /// </summary>
        [FieldOffset(0xC)]
        public readonly PMonoArray _entries;


        /// <summary>
        /// 0x20 System.Int32 _comparer
        /// </summary>
        [FieldOffset(0x10)]
        public readonly nint _comparer;



        /// <summary>
        /// 0x24 System.Int32 _keys
        /// </summary>
        [FieldOffset(0x14)]
        public readonly nint _keys;




        /// <summary>
        /// 0x28 System.Int32 _values
        /// </summary>
        [FieldOffset(0x18)]
        public readonly nint _values;



        /// <summary>
        /// 0x2C System.Int32 _syncRoot
        /// </summary>
        [FieldOffset(0x1C)]
        public readonly nint _syncRoot;



        /// <summary>
        /// 0x30 System.Int32 _count;
        /// </summary>
        [FieldOffset(0x20)]
        public readonly System.Int32 _count;


        /// <summary>
        /// 0x38 System.Int32 _freeList;
        /// </summary>
        [FieldOffset(0x24)]
        public readonly System.Int32 _freeList;


        /// <summary>
        /// 0x40 System.Int32 _freeCount;
        /// </summary>
        [FieldOffset(0x28)]
        public readonly System.Int32 _freeCount;


        /// <summary>
        /// 0x48 System.Int32 _version;
        /// </summary>
        [FieldOffset(0x2C)]
        public readonly System.Int32 _version;

    }

    partial struct Ref_MonoDictionary_x86 : IRefMonoDictionary
    {
        public int Count => _count;

        public int FreeCount => _freeCount;

        public PMonoArray Entries => _entries;


        public int Size => Count - FreeCount;

    }
}
