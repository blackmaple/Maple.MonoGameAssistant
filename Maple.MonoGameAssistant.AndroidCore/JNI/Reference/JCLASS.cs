using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JCLASS(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator JCLASS(nint val) => new(val);
        public static implicit operator nint(JCLASS val) => val._ptr;
        public static implicit operator bool(JCLASS val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JCLASS val) => new(val._ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNullPtr() => _ptr != nint.Zero;


        public override string ToString()
        {
            return _ptr.ToString("X8");
        }
    }

}
