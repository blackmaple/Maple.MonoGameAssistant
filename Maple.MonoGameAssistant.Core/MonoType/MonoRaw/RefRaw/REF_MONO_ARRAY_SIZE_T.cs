using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct REF_MONO_ARRAY_SIZE_T
    {
        [MarshalAs(UnmanagedType.I8)]
        [FieldOffset(0)]
        public readonly long _long_length;

        [MarshalAs(UnmanagedType.U4)]
        [FieldOffset(0)]
        public readonly int _length;
        [MarshalAs(UnmanagedType.U4)]
        [FieldOffset(4)]
        public readonly int _padding_length;

    }
}
