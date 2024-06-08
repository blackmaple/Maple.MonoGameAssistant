using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoSlot(nint ptr)
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoSlot obj) => obj._ptr;
        public static implicit operator PMonoSlot(nint ptr) => new(ptr);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;
    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoSlot<T_REF, T_VALUE>(nint ptr) 
        where T_REF : unmanaged, IRefMonoSlot<T_VALUE>
        where T_VALUE : unmanaged
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoSlot<T_REF, T_VALUE> obj) => obj._ptr;
        public static implicit operator PMonoSlot<T_REF, T_VALUE>(nint ptr) => new(ptr);

        public static implicit operator PMonoSlot(PMonoSlot<T_REF, T_VALUE> obj) => new(obj._ptr);
        public static implicit operator PMonoSlot<T_REF, T_VALUE>(PMonoSlot ptr) => new(ptr);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_REF AsRef()
            => ref _ptr.AsRefStruct<T_REF>();

        public ref readonly T_VALUE Value => ref AsRef().Value;

    }
}
