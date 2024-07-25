using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMono2DArray<T_REF, T_DATA>(nint ptr) : IPtrMonoArray<T_REF, T_DATA>
    where T_REF : unmanaged, IRefMonoArray
    where T_DATA : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;

        public static implicit operator nint(PMono2DArray<T_REF, T_DATA> obj) => obj._ptr;
        public static implicit operator PMono2DArray<T_REF, T_DATA>(nint ptr) => new(ptr);

        public static implicit operator PMonoArray(PMono2DArray<T_REF, T_DATA> obj) => new(obj._ptr);
        public static implicit operator PMono2DArray<T_REF, T_DATA>(PMonoArray obj) => new(obj);

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
        public ReadOnlySpan<T_DATA> AsReadOnlySpan()
            => this.AsReadOnlySpan<PMono2DArray<T_REF, T_DATA>, T_REF, T_DATA>();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan(int count)
            => this.AsReadOnlySpan<PMono2DArray<T_REF, T_DATA>, T_REF, T_DATA>(count);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<T_DATA> AsSpan()
            => this.AsSpan<PMono2DArray<T_REF, T_DATA>, T_REF, T_DATA>();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<T_DATA> AsSpan(int count)
            => this.AsSpan<PMono2DArray<T_REF, T_DATA>, T_REF, T_DATA>(count);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int index)
            => ref this.RefElementAt<PMono2DArray<T_REF, T_DATA>, T_REF, T_DATA>(index);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int col, int row)
            => ref this.RefElementAt<PMono2DArray<T_REF, T_DATA>, T_REF, T_DATA>(col, row);

        public ref T_DATA this[int index] => ref this.RefElementAt(index);

        public ref T_DATA this[int col, int row] => ref this.RefElementAt(col, row);


        public (int Length, int LowerBound) GetArrayBounds() => this.AsRef().GetArrayBounds();
       
    }


    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMono2DArray<T_DATA>(nint ptr) : IPtrMonoArray<Ref_MonoArray, T_DATA>
        where T_DATA : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;

        public static implicit operator nint(PMono2DArray<T_DATA> obj) => obj._ptr;
        public static implicit operator PMono2DArray<T_DATA>(nint ptr) => new(ptr);

        public static implicit operator PMonoArray(PMono2DArray<T_DATA> obj) => new(obj._ptr);
        public static implicit operator PMono2DArray<T_DATA>(PMonoArray obj) => new(obj);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref Ref_MonoArray AsRef()
            => ref _ptr.AsRefStruct<Ref_MonoArray>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan()
            => this.AsReadOnlySpan<PMono2DArray<T_DATA>, Ref_MonoArray, T_DATA>();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan(int count)
            => this.AsReadOnlySpan<PMono2DArray<T_DATA>, Ref_MonoArray, T_DATA>(count);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<T_DATA> AsSpan()
            => this.AsSpan<PMono2DArray<T_DATA>, Ref_MonoArray, T_DATA>();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<T_DATA> AsSpan(int count)
            => this.AsSpan<PMono2DArray<T_DATA>, Ref_MonoArray, T_DATA>(count);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int index)
            => ref this.RefElementAt<PMono2DArray<T_DATA>, Ref_MonoArray, T_DATA>(index);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int col, int row)
            => ref this.RefElementAt<PMono2DArray<T_DATA>, Ref_MonoArray, T_DATA>(col, row);

        public ref T_DATA this[int index] => ref this.RefElementAt(index);

        public ref T_DATA this[int col, int row] => ref this.RefElementAt(col, row);

    }

}
