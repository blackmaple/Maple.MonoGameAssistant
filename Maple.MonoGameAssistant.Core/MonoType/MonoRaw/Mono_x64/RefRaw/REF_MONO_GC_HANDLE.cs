using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_MONO_GC_HANDLE(UInt32 handle)
    {
        [MarshalAs(UnmanagedType.U4)]
        readonly UInt32 _handle = handle;
        public static implicit operator UInt32(REF_MONO_GC_HANDLE ptr) => ptr._handle;
        public static implicit operator REF_MONO_GC_HANDLE(UInt32 ptr) => new(ptr);

        public override string ToString()
        {
            return _handle.ToString("X8");
        }
    }

}
