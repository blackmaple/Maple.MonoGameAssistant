﻿using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_MonoList_x86
    {
        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;

        /// <summary>
        /// 0x10 AchievementData[] _items
        /// </summary>
        [FieldOffset(0x8)]
        public readonly PMonoArray _items;


        /// <summary>
        /// 0x18 System.Int32 _size
        /// </summary>
        [FieldOffset(0xC)]
        public readonly System.Int32 _size;


        /// <summary>
        /// 0x1C System.Int32 _version
        /// </summary>
        [FieldOffset(0x10)]
        public readonly System.Int32 _version;


        /// <summary>
        /// 0x20 System.Object _syncRoot
        /// </summary>
        [FieldOffset(0x14)]
        public readonly nint _syncRoot;

    }

    readonly unsafe partial struct Ref_MonoList_x86 : IRefMonoList
    {
        public readonly PMonoArray Items => _items;

        public readonly int Size => _size;


    }

}
