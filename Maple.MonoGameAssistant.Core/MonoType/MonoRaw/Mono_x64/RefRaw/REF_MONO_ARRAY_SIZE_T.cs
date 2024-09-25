using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_MONO_ARRAY_SIZE_T
    {
        //[MarshalAs(UnmanagedType.I8)]
        //[FieldOffset(0)]
        //public readonly long _long_length;

        //[MarshalAs(UnmanagedType.I4)]
        //[FieldOffset(0)]
        //public readonly int _length;

        //[MarshalAs(UnmanagedType.I4)]
        //[FieldOffset(4)]
        //public readonly int _padding_length;

        [MarshalAs(UnmanagedType.SysUInt)]
        public readonly nuint _length;

        public unsafe int Length => new nint(this._length.ToPointer()).ToInt32();
        public unsafe long LongLength => new nint(this._length.ToPointer()).ToInt64();

    }
}
