using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PDelegatePointer(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        nint _ptr = ptr;
        public static implicit operator nint(PDelegatePointer ptr) => ptr._ptr;
        public static implicit operator PDelegatePointer(nint ptr) => new(ptr);
        public static implicit operator bool(PDelegatePointer pointer) => pointer.Valid();

        public readonly bool Valid() => _ptr != IntPtr.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T_Delegate GetDelegate<T_Delegate>()
            where T_Delegate : unmanaged => Unsafe.As<nint, T_Delegate>(ref _ptr);


    }

}