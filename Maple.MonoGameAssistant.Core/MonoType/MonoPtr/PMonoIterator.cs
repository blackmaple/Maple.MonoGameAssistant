using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [DebuggerDisplay("{_ptr}")]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PMonoIterator(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoIterator ptr) => ptr._ptr;
        public static implicit operator PMonoIterator(nint ptr) => new(ptr);
        public override string ToString()
        {
            return _ptr.ToString();
        }

        public bool Valid() => _ptr != IntPtr.Zero;
    }
}
