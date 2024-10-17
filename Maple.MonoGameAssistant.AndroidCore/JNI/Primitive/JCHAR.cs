using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Primitive
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JCHAR(char val)
    {


        [MarshalAs(UnmanagedType.U2)]
        readonly char _value = val;
        public static implicit operator JCHAR(char val) => new(val);
        public static implicit operator char(JCHAR val) => val._value;

    }

}
