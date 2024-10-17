using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Primitive
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JLONG(long val)
    {
        [MarshalAs(UnmanagedType.I8)]
        readonly long _value = val;
        public static implicit operator JLONG(long val) => new(val);
        public static implicit operator long(JLONG val) => val._value;

    }

}
