using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_MonoStack_OptimizationDefault
    {


        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;


        /// <summary>
        /// 0x0 T[] _array
        /// </summary>
        [FieldOffset(0x10)]
        public readonly nint _array;


        /// <summary>
        /// 0x0 System.Int32 _size
        /// </summary>
        [FieldOffset(0x18)]
        public readonly System.Int32 _size;


        /// <summary>
        /// 0x0 System.Int32 _version
        /// </summary>
        [FieldOffset(0x1C)]
        public readonly System.Int32 _version;


        /// <summary>
        /// 0x0 System.Object _syncRoot
        /// </summary>
        [FieldOffset(0x20)]
        public readonly nint _syncRoot;

    }

    readonly unsafe partial struct Ref_MonoStack_OptimizationDefault : IRefMonoStack
    {
        public int Size => _size;

        public PMonoArray Array => _array;

    }

}
