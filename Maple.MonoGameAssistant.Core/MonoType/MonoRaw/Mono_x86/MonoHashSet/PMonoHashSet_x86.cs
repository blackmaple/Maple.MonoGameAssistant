using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PMonoSlot<Ref_MonoSlot<T_VALUE>, T_VALUE>[] AsRefArray()
            => this.AsRefArray<PMonoHashSet_x86<T_VALUE>, Ref_MonoHashSet_x86, T_VALUE, Ref_MonoSlot<T_VALUE>>();

        public int Size => AsRef().Count;


    }

}
