using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_MonoHashSet_x86
    {


        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;



        /// <summary>
        /// 0x10 System.Int32[] _buckets
        /// </summary>
        [FieldOffset(0x8)]
        public readonly PMonoArray _buckets;


        /// <summary>
        /// 0x18 System.Collections.Generic.HashSet.Slot<System.String>[] _slots
        /// </summary>
        [FieldOffset(0xC)]
        public readonly PMonoArray _slots;


        /// <summary>
        /// 0x10 nint _comparer;
        /// </summary>
        [FieldOffset(0x10)]
        public readonly nint _comparer;



        /// <summary>
        /// 0x14 nint _siInfo;
        /// </summary>
        [FieldOffset(0x14)]
        public readonly nint _siInfo;



        /// <summary>
        /// 0x18 System.Int32 _count;
        /// </summary>
        [FieldOffset(0x18)]
        public readonly System.Int32 _count;


        /// <summary>
        /// 0x1C System.Int32 _lastIndex;
        /// </summary>
        [FieldOffset(0x1C)]
        public readonly System.Int32 _lastIndex;


        /// <summary>
        /// 0x20 System.Int32 _freeList;
        /// </summary>
        [FieldOffset(0x20)]
        public readonly System.Int32 _freeList;


        /// <summary>
        /// 0x24 System.Int32 _version;
        /// </summary>
        [FieldOffset(0x24)]
        public readonly System.Int32 _version;


    }

    readonly unsafe partial struct Ref_MonoHashSet_x86 : IRefMonoHashSet
    {
        public int Count => _count;
        public int LastIndex => _lastIndex;

        public PMonoArray Slots => _slots;



    }

}
