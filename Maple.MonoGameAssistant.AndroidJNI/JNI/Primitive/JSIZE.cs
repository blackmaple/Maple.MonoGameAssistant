using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive
{

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JSIZE(int val)
    {
        [MarshalAs(UnmanagedType.I4)]
        readonly int _value = val;
        public static implicit operator JSIZE(int val) => new(val);
        public static implicit operator int(JSIZE val) => val._value;

    }

}
