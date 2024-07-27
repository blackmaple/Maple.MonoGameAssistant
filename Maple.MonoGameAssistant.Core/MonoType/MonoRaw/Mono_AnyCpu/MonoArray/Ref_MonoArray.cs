using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Maple.MonoGameAssistant.Core
{
    /*
    Mono的Array默认实现;但是编译参数差异可能存在字段偏移的不同
    实现IRef_MonoArray接口上需要的属性
    调用泛型
    AsRef<T_REF>();
    AsReadOnlySpan<T_REF>();
    AsReadOnlySpan<T_REF>(int size);
    AsSpan<T_REF>();
    AsSpan<T_REF>(int size);
    */

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct Ref_MonoArray
    {
     //   [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;

     //   [FieldOffset(0x10)]
        public readonly PTR_MONO_ARRAY_BOUNDS _bounds;

      //  [FieldOffset(0x18)]
        public readonly REF_MONO_ARRAY_SIZE_T _length;

        [MarshalAs(UnmanagedType.U1)]
    //    [FieldOffset(0x20)]
        public readonly byte _first_byte;
        //public byte Byte_2;
        //public ...
        //public byte Byte_Size;


    }

    readonly unsafe partial struct Ref_MonoArray : IRefMonoArray
    {
        public int Size => new nint(_length._length.ToPointer()).ToInt32();

        public ref byte FirstByte => ref Unsafe.AsRef(in _first_byte);

        public (int Length, int LowerBound) GetArrayBounds()
        {
            ref var ref_bounds = ref this._bounds.AsRef();
            return (ref_bounds.Length, ref_bounds.LowerBound);
        }


    }



}
