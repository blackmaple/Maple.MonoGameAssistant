using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Maple.MonoGameAssistant.Core
{

    [DebuggerDisplay("{_ptr}")]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PMonoDomain(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoDomain ptr) => ptr._ptr;
        public static implicit operator PMonoDomain(nint ptr) => new(ptr);
        public override string ToString()
        {
            return _ptr.ToString();
        }
    }

    [CustomMarshaller(typeof(PMonoDomain), MarshalMode.Default, typeof(PMonoDomainMarshaller))]
    public static class PMonoDomainMarshaller
    {
        public static nint ConvertToUnmanaged(PMonoDomain managed)
              => managed;

        public static PMonoDomain ConvertToManaged(nint unmanaged)
            => new(unmanaged);

        public static void Free(nint unmanaged)
        { }
    }
}
