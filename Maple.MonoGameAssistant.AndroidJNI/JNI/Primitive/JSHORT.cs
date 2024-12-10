using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JSHORT(short val)
    {


        [MarshalAs(UnmanagedType.I2)]
        readonly short _value = val;
        public static implicit operator JSHORT(short val) => new(val);
        public static implicit operator short(JSHORT val) => val._value;
        public static implicit operator JVALUE(JSHORT val) => new(val);

    }

}
