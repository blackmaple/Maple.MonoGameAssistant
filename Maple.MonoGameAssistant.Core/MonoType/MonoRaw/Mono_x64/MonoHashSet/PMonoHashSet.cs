using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoHashSet(nint ptr)
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoHashSet(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoHashSet obj) => obj._ptr;

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

    }




    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoHashSet<T_REF, T_VALUE, TRef_MonoSlot>(nint ptr) : IPtrMonoHashSet<T_REF, T_VALUE, TRef_MonoSlot>
            where T_REF : unmanaged, IRefMonoHashSet
            where T_VALUE : unmanaged
            where TRef_MonoSlot : unmanaged, IRefMonoSlot<T_VALUE>
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoHashSet<T_REF, T_VALUE, TRef_MonoSlot>(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoHashSet<T_REF, T_VALUE, TRef_MonoSlot> obj) => obj._ptr;

        public static implicit operator PMonoHashSet<T_REF, T_VALUE, TRef_MonoSlot>(PMonoHashSet obj) => new(obj);
        public static implicit operator PMonoHashSet(PMonoHashSet<T_REF, T_VALUE, TRef_MonoSlot> obj) => new(obj._ptr);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_REF AsRef() => ref _ptr.AsRefStruct<T_REF>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PMonoSlot<TRef_MonoSlot, T_VALUE>[] AsRefArray()
            => this.AsRefArray<PMonoHashSet<T_REF, T_VALUE, TRef_MonoSlot>, T_REF, T_VALUE, TRef_MonoSlot>();
    }


    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoHashSet_x86<T_VALUE>(nint ptr) : IPtrMonoHashSet<Ref_MonoHashSet_x86, T_VALUE, Ref_MonoSlot<T_VALUE>>
        where T_VALUE : unmanaged
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoHashSet_x86<T_VALUE>(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoHashSet_x86<T_VALUE> obj) => obj._ptr;

        public static implicit operator PMonoHashSet_x86<T_VALUE>(PMonoHashSet obj) => new(obj);
        public static implicit operator PMonoHashSet(PMonoHashSet_x86<T_VALUE> obj) => new(obj._ptr);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref Ref_MonoHashSet_x86 AsRef() => ref _ptr.AsRefStruct<Ref_MonoHashSet_x86>();


        //ERROR
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PMonoSlot<Ref_MonoSlot<T_VALUE>, T_VALUE>[] AsRefArray()
            => default!;// this.as(); //this.AsRefArray<PMonoHashSet<Ref_MonoHashSet_x86, T_VALUE, Ref_MonoSlot<T_VALUE>>, Ref_MonoHashSet_x86, T_VALUE, Ref_MonoSlot<T_VALUE>>();
    }

}
