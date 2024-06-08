using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoQueue(nint ptr)
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoQueue(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoQueue obj) => obj._ptr;

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;


    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoQueue<T_REF, T_DATA>(nint ptr) : IPtrMonoQueue<T_REF, T_DATA>
        where T_REF : unmanaged, IRefMonoQueue
        where T_DATA : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoQueue<T_REF, T_DATA> obj) => obj._ptr;
        public static implicit operator PMonoQueue<T_REF, T_DATA>(nint ptr) => new(ptr);

        public static implicit operator PMonoQueue(PMonoQueue<T_REF, T_DATA> obj) => new(obj._ptr);
        public static implicit operator PMonoQueue<T_REF, T_DATA>(PMonoQueue obj) => new(obj);

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
            => this.ToArray<PMonoQueue<T_REF, T_DATA>, T_REF, T_DATA>();
    }
}
