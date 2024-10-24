using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JFLOAT(float val)
    {
        [MarshalAs(UnmanagedType.R4)]
        readonly float _value = val;
        public static implicit operator JFLOAT(float val) => new(val);
        public static implicit operator float(JFLOAT val) => val._value;
        public static implicit operator JVALUE(JFLOAT val) => new(val);

    }

}
