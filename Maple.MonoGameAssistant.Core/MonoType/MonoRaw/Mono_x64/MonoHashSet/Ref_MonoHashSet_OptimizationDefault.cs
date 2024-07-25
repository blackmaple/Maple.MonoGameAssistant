using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_MonoHashSet_OptimizationDefault
    {


        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;



        /// <summary>
        /// 0x10 System.Int32[] _buckets
        /// </summary>
        [FieldOffset(0x10)]
        public readonly PMonoArray _buckets;


        /// <summary>
        /// 0x18 System.Collections.Generic.HashSet.Slot<System.String>[] _slots
        /// </summary>
        [FieldOffset(0x18)]
        public readonly PMonoArray _slots;


        /// <summary>
        /// 0x20 System.Int32 _count
        /// </summary>
        [FieldOffset(0x20)]
        public readonly System.Int32 _count;


        /// <summary>
        /// 0x24 System.Int32 _lastIndex
        /// </summary>
        [FieldOffset(0x24)]
        public readonly System.Int32 _lastIndex;


        /// <summary>
        /// 0x28 System.Int32 _freeList
        /// </summary>
        [FieldOffset(0x28)]
        public readonly System.Int32 _freeList;


        /// <summary>
        /// 0x30 System.Collections.Generic.IEqualityComparer<System.String> _comparer
        /// </summary>
        [FieldOffset(0x30)]
        public readonly nint _comparer;


        /// <summary>
        /// 0x38 System.Int32 _version
        /// </summary>
        [FieldOffset(0x38)]
        public readonly System.Int32 _version;


        /// <summary>
        /// 0x40 System.Runtime.Serialization.SerializationInfo _siInfo
        /// </summary>
        [FieldOffset(0x40)]
        public readonly nint _siInfo;

    }

    readonly unsafe partial struct Ref_MonoHashSet_OptimizationDefault : IRefMonoHashSet
    {
        public int Count => _count;
        public int LastIndex => _lastIndex;

        public PMonoArray Slots => _slots;



    }
}
