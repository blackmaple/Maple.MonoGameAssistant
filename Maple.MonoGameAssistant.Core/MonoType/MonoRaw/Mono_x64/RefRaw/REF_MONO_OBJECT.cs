using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_MONO_OBJECT
    {
       // [MarshalAs(UnmanagedType.SysInt)]
       // [FieldOffset(0)]
        public readonly PMonoVirtualTable _vtable;

        [MarshalAs(UnmanagedType.SysInt)]
      //  [FieldOffset(8)]
        public readonly nint _synchronisation;


        public PMonoClass  MonoClass=> _vtable.AsRef().MonoClass;
    }


 
}
