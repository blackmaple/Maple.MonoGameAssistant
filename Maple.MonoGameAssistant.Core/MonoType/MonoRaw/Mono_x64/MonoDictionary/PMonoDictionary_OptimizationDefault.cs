using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoDictionary_OptimizationDefault<T_KEY, T_VALUE>(nint ptr) : IPtrMonoDictionary<Ref_MonoDictionary_OptimizationDefault, T_KEY, T_VALUE, Ref_MonoEntry<T_KEY, T_VALUE>>
       where T_KEY : unmanaged
       where T_VALUE : unmanaged
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoDictionary_OptimizationDefault<T_KEY, T_VALUE>(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoDictionary_OptimizationDefault<T_KEY, T_VALUE> obj) => obj._ptr;

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref Ref_MonoDictionary_OptimizationDefault AsRef() => ref _ptr.AsRefStruct<Ref_MonoDictionary_OptimizationDefault>();

        public PMonoEntry<Ref_MonoEntry<T_KEY, T_VALUE>, T_KEY, T_VALUE>[] AsRefArray()
            => this.AsRefArray<PMonoDictionary_OptimizationDefault<T_KEY, T_VALUE>, Ref_MonoDictionary_OptimizationDefault, T_KEY, T_VALUE, Ref_MonoEntry<T_KEY, T_VALUE>>();

    }

}
