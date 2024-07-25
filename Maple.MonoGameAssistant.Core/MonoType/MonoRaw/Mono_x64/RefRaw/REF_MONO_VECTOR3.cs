using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.RawDotNet
{
    [StructLayout(LayoutKind.Sequential)]
    public struct REF_MONO_VECTOR3
    {
        [MarshalAs(UnmanagedType.R4)]
      //  [FieldOffset(0)]
        public float x;

        [MarshalAs(UnmanagedType.R4)]
     //   [FieldOffset(4)]
        public float y;

        [MarshalAs(UnmanagedType.R4)]
  //      [FieldOffset(8)]
        public float z;

    }
}
