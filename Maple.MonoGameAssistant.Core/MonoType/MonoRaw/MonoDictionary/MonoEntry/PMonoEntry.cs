using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoEntry(nint ptr)
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoEntry obj) => obj._ptr;
        public static implicit operator PMonoEntry(nint ptr) => new(ptr);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;
    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoEntry<TREF, TKEY, TVALUE>(nint ptr)
        where TREF : unmanaged, IRefMonoEntry<TKEY, TVALUE>
        where TKEY : unmanaged
        where TVALUE : unmanaged
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoEntry<TREF, TKEY, TVALUE> obj) => obj._ptr;
        public static implicit operator PMonoEntry<TREF, TKEY, TVALUE>(nint ptr) => new(ptr);

        public static implicit operator PMonoEntry(PMonoEntry<TREF, TKEY, TVALUE> obj) => new(obj._ptr);
        public static implicit operator PMonoEntry<TREF, TKEY, TVALUE>(PMonoEntry ptr) => new(ptr);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref TREF AsRef()
            => ref _ptr.AsRefStruct<TREF>();

        public ref readonly TKEY Key
            => ref AsRef().Key;

        public ref readonly TVALUE Value
            => ref AsRef().Value;

    }
}
