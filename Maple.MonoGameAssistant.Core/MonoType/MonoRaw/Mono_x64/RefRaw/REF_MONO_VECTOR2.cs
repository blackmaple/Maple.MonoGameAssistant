using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct REF_MONO_VECTOR2
    {
        [MarshalAs(UnmanagedType.R4)]
        //[FieldOffset(0)]
        public float x;

        [MarshalAs(UnmanagedType.R4)]
        //[FieldOffset(4)]
        public float y;

    }
}
