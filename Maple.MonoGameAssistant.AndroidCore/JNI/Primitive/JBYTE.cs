using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Primitive
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JBYTE(byte val)
    {


        [MarshalAs(UnmanagedType.U1)]
        readonly byte _value = val;
        public static implicit operator JBYTE(byte val) => new(val);
        public static implicit operator byte(JBYTE val) => val._value;

    }

}
