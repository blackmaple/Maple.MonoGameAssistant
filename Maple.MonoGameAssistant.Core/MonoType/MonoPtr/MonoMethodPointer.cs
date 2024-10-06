using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [DebuggerDisplay("{_ptr}")]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct MonoMethodPointer(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(MonoMethodPointer ptr) => ptr._ptr;
        public static implicit operator MonoMethodPointer(nint ptr) => new(ptr);
        public static implicit operator bool(MonoMethodPointer ptr) => ptr.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        public bool Valid() => _ptr != IntPtr.Zero;

        public bool Aligned() => (_ptr & 2) == 0;
    }


}
