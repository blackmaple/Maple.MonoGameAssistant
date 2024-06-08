using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly struct Ptr_MonoItem<T_REF_VALUE>(nint ptr)
        where T_REF_VALUE : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(Ptr_MonoItem<T_REF_VALUE> obj) => obj._ptr;
        public static implicit operator Ptr_MonoItem<T_REF_VALUE>(nint ptr) => new(ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        public ref T_REF_VALUE Value => ref _ptr.AsRefStruct<T_REF_VALUE>();
        public ref T_REF_VALUE RefValue => ref _ptr.AsRefStruct<nint>().AsRefStruct<T_REF_VALUE>();

    }
 
}
