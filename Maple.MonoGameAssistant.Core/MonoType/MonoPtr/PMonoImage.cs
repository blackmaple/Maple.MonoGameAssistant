using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [DebuggerDisplay("{_ptr}")]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PMonoImage(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoImage ptr) => ptr._ptr;
        public static implicit operator PMonoImage(nint ptr) => new(ptr);
        public static implicit operator PMonoImage(string ptr)
        {
            _ = nint.TryParse(ptr, System.Globalization.NumberStyles.HexNumber, default, out nint val);
            return new PMonoImage(val);
        }
        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        public bool Valid() => _ptr != IntPtr.Zero;
    }
}
