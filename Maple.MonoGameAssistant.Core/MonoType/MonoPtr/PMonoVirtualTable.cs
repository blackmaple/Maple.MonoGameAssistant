using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PMonoVirtualTable(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoVirtualTable ptr) => ptr._ptr;
        public static implicit operator PMonoVirtualTable(nint ptr) => new(ptr);
        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        public bool Valid() => _ptr != IntPtr.Zero;


        public T_REF AsRef<T_REF>() where T_REF : unmanaged
            => _ptr.AsRefStruct<T_REF>();

    }


}
