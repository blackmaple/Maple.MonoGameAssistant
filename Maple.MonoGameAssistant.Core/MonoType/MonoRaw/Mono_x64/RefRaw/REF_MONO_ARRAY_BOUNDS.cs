using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct REF_MONO_ARRAY_BOUNDS
    {
        //[FieldOffset(0)]
        public readonly REF_MONO_ARRAY_SIZE_T _length;

        //[FieldOffset(8)]
        public readonly REF_MONO_ARRAY_LOWER_BOUND_T _lower_bound;


        public int Length => _length.Length;
        public long LongLength => _length.LongLength;

        public int LowerBound => _lower_bound.LowerBound;
        public long LongLowerBound => _lower_bound.LongLowerBound;

    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct PTR_MONO_ARRAY_BOUNDS(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PTR_MONO_ARRAY_BOUNDS(nint ptr) => new(ptr);
        public static implicit operator nint(PTR_MONO_ARRAY_BOUNDS obj) => obj._ptr;
        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref REF_MONO_ARRAY_BOUNDS AsRef()
        {
            return ref Unsafe.AsRef<REF_MONO_ARRAY_BOUNDS>(_ptr.ToPointer());
        }
    }

}
