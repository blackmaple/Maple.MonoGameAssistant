using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoDictionary(nint ptr)
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoDictionary obj) => obj._ptr;
        public static implicit operator PMonoDictionary(nint ptr) => new(ptr);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;


    }


    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoDictionary<T_REF, T_KEY, T_VALUE, TRef_MonoEntry>(nint ptr) : IPtrMonoDictionary<T_REF, T_KEY, T_VALUE, TRef_MonoEntry>
        where T_REF : unmanaged, IRefMonoDictionary
        where T_KEY : unmanaged
        where T_VALUE : unmanaged
        where TRef_MonoEntry : unmanaged, IRefMonoEntry<T_KEY, T_VALUE>
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoDictionary<T_REF, T_KEY, T_VALUE, TRef_MonoEntry>(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoDictionary<T_REF, T_KEY, T_VALUE, TRef_MonoEntry> obj) => obj._ptr;

        public static implicit operator PMonoDictionary<T_REF, T_KEY, T_VALUE, TRef_MonoEntry>(PMonoDictionary obj) => new(obj);
        public static implicit operator PMonoDictionary(PMonoDictionary<T_REF, T_KEY, T_VALUE, TRef_MonoEntry> obj) => new(obj._ptr);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_REF AsRef() => ref _ptr.AsRefStruct<T_REF>();

        public PMonoEntry<TRef_MonoEntry, T_KEY, T_VALUE>[] AsRefArray()
            => this.AsRefArray<PMonoDictionary<T_REF, T_KEY, T_VALUE, TRef_MonoEntry>, T_REF, T_KEY, T_VALUE, TRef_MonoEntry>();
    }

}
