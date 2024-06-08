using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.RawDotNet
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct REF_MONO_NULLABLE<T>
        where T : unmanaged
    {

        [FieldOffset(0x0)]
        public readonly System.Boolean hasValue;


        [FieldOffset(0x8)]
        public readonly T value;

    }

}
