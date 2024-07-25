using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_MONO_ARRAY_LOWER_BOUND_T
    {
        [MarshalAs(UnmanagedType.I8)]
        //[FieldOffset(0)]
        public readonly long _long_lower_bound;

        [MarshalAs(UnmanagedType.I4)]
        //[FieldOffset(0)]
        public readonly int _lower_bound;
        [MarshalAs(UnmanagedType.I4)]
        // [FieldOffset(4)]
        public readonly int _padding_lower_bound;
    }

}
