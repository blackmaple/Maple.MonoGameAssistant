using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{


    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoStack(nint ptr)
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoStack(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoStack obj) => obj._ptr;

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;


    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoStack<T_REF, T_DATA>(nint ptr): IPtrMonoStack<T_REF, T_DATA>
            where T_REF : unmanaged, IRefMonoStack
            where T_DATA : unmanaged
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoStack<T_REF, T_DATA>(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoStack<T_REF, T_DATA> obj) => obj._ptr;

        public static implicit operator PMonoStack<T_REF, T_DATA>(PMonoStack obj) => new(obj);
        public static implicit operator PMonoStack(PMonoStack<T_REF, T_DATA> obj) => new(obj._ptr);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_REF AsRef()
            => ref _ptr.AsRefStruct<T_REF>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Ptr_MonoItem<T_DATA>[] ToArray()
            => this.ToArray<PMonoStack<T_REF, T_DATA>, T_REF, T_DATA>();
    }

}
