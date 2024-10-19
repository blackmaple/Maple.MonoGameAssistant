using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JMETHODID(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator JMETHODID(nint val) => new(val);
        public static implicit operator nint(JMETHODID val) => val._ptr;
        public static implicit operator bool(JMETHODID val) => val.IsNullPtr();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNullPtr() => _ptr != nint.Zero;
    }

}
