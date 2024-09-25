using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_MONO_ARRAY_LOWER_BOUND_T
    {
        //[MarshalAs(UnmanagedType.I8)]
        ////[FieldOffset(0)]
        //public readonly long _long_lower_bound;

        //[MarshalAs(UnmanagedType.I4)]
        ////[FieldOffset(0)]
        //public readonly int _lower_bound;
        //[MarshalAs(UnmanagedType.I4)]
        //// [FieldOffset(4)]
        //public readonly int _padding_lower_bound;
        [MarshalAs(UnmanagedType.SysUInt)]
        public readonly nuint _lower_bound;
        public unsafe int LowerBound => new nint(this._lower_bound.ToPointer()).ToInt32();
        public unsafe long LongLowerBound => new nint(this._lower_bound.ToPointer()).ToInt64();

    }

}
