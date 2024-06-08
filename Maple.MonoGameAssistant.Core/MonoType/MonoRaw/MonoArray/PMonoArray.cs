using Maple.MonoGameAssistant.RawDotNet;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Maple.MonoGameAssistant.Core
{

    readonly unsafe partial struct PMonoArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref Ref_MonoArray AsRef()
            => ref _ptr.AsRefStruct<Ref_MonoArray>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan<T_DATA>() where T_DATA : unmanaged
            => new PMonoArray<Ref_MonoArray, T_DATA>(_ptr).AsReadOnlySpan();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan<T_DATA>(int count) where T_DATA : unmanaged
            => new PMonoArray<Ref_MonoArray, T_DATA>(_ptr).AsReadOnlySpan(count);



        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<T_DATA> AsSpan<T_DATA>() where T_DATA : unmanaged
            => new PMonoArray<Ref_MonoArray, T_DATA>(_ptr).AsSpan();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<T_DATA> AsSpan<T_DATA>(int count) where T_DATA : unmanaged
            => new PMonoArray<Ref_MonoArray, T_DATA>(_ptr).AsSpan(count);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt<T_DATA>(int index) where T_DATA : unmanaged
            => ref new PMonoArray<Ref_MonoArray, T_DATA>(_ptr).RefElementAt(index);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt<T_DATA>(int col, int row) where T_DATA : unmanaged
            => ref new PMonoArray<Ref_MonoArray, T_DATA>(_ptr).RefElementAt(col, row);

    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoArray<T_REF, T_DATA>(nint ptr) : IPtrMonoArray<T_REF, T_DATA>
        where T_REF : unmanaged, IRefMonoArray
        where T_DATA : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;

        public static implicit operator nint(PMonoArray<T_REF, T_DATA> obj) => obj._ptr;
        public static implicit operator PMonoArray<T_REF, T_DATA>(nint ptr) => new(ptr);

        public static implicit operator PMonoArray(PMonoArray<T_REF, T_DATA> obj) => new(obj._ptr);
        public static implicit operator PMonoArray<T_REF, T_DATA>(PMonoArray obj) => new(obj);

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
            => this.AsReadOnlySpan<PMonoArray<T_REF, T_DATA>, T_REF, T_DATA>();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan(int count)
            => this.AsReadOnlySpan<PMonoArray<T_REF, T_DATA>, T_REF, T_DATA>(count);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<T_DATA> AsSpan()
            => this.AsSpan<PMonoArray<T_REF, T_DATA>, T_REF, T_DATA>();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<T_DATA> AsSpan(int count)
            => this.AsSpan<PMonoArray<T_REF, T_DATA>, T_REF, T_DATA>(count);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int index)
            => ref this.RefElementAt<PMonoArray<T_REF, T_DATA>, T_REF, T_DATA>(index);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int col, int row)
            => throw new IndexOutOfRangeException();

        public ref T_DATA this[int index] => ref this.RefElementAt(index);

        public ref T_DATA this[int col, int row] => ref this.RefElementAt(col, row);

    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoArray<T_DATA>(nint ptr) : IPtrMonoArray<Ref_MonoArray, T_DATA>
        where T_DATA : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoArray<T_DATA> obj) => obj._ptr;
        public static implicit operator PMonoArray<T_DATA>(nint ptr) => new(ptr);
        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref Ref_MonoArray AsRef() => ref _ptr.AsRefStruct<Ref_MonoArray>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan()
            => this.AsReadOnlySpan<PMonoArray<T_DATA>, Ref_MonoArray, T_DATA>();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan(int count)
            => this.AsReadOnlySpan<PMonoArray<T_DATA>, Ref_MonoArray, T_DATA>(count);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<T_DATA> AsSpan()
            => this.AsSpan<PMonoArray<T_DATA>, Ref_MonoArray, T_DATA>();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<T_DATA> AsSpan(int count)
            => this.AsSpan<PMonoArray<T_DATA>, Ref_MonoArray, T_DATA>(count);

        public int Size => this.AsRef().Size;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int index)
          => ref this.RefElementAt<PMonoArray<T_DATA>, Ref_MonoArray, T_DATA>(index);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int col, int row)
            => throw new IndexOutOfRangeException();

        public ref T_DATA this[int index] => ref this.RefElementAt(index);

        public ref T_DATA this[int col, int row] => ref this.RefElementAt(col, row);

        public IEnumerable<T_DATA> AsEnumerable()
        {
            var size = this.Size;
            for (int i = 0; i < size; ++i)
            {
                yield return this[i % size];
            }
        }


    }

}
