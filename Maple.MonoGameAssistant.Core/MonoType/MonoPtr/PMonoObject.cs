using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [DebuggerDisplay("{_ptr}")]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PMonoObject(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoObject ptr) => ptr._ptr;
        public static implicit operator PMonoObject(nint ptr) => new(ptr);
        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        public bool Valid() => _ptr != IntPtr.Zero;
    }
}
