using Maple.MonoGameAssistant.Core;
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
    public readonly unsafe partial struct PMonoList(nint ptr)
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoList(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoList obj) => obj._ptr;

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;


    }


    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoList<T_REF, T_DATA>(nint ptr) : IPtrMonoList<T_REF, T_DATA>
        where T_REF : unmanaged, IRefMonoList
        where T_DATA : unmanaged
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoList<T_REF, T_DATA>(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoList<T_REF, T_DATA> obj) => obj._ptr;

        public static implicit operator PMonoList(PMonoList<T_REF, T_DATA> obj) => new(obj._ptr);
        public static implicit operator PMonoList<T_REF, T_DATA>(PMonoList obj) => new(obj);

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
            => this.AsReadOnlySpan<PMonoList<T_REF, T_DATA>, T_REF, T_DATA>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int index)
            => ref this.RefElementAt<PMonoList<T_REF, T_DATA>, T_REF, T_DATA>(index);

        public ref T_DATA this[int index] => ref this.RefElementAt(index);
    }



    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoList_S<T_DATA>(nint ptr) : IPtrMonoList<Ref_MonoList_OptimizationSpeed, T_DATA>
    where T_DATA : unmanaged
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoList_S<T_DATA>(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoList_S<T_DATA> obj) => obj._ptr;

        public static implicit operator PMonoList(PMonoList_S<T_DATA> obj) => new(obj._ptr);
        public static implicit operator PMonoList_S<T_DATA>(PMonoList obj) => new(obj);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref Ref_MonoList_OptimizationSpeed AsRef()
            => ref _ptr.AsRefStruct<Ref_MonoList_OptimizationSpeed>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan()
            => this.AsReadOnlySpan<PMonoList_S<T_DATA>, Ref_MonoList_OptimizationSpeed, T_DATA>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int index)
            => ref this.RefElementAt<PMonoList_S<T_DATA>, Ref_MonoList_OptimizationSpeed, T_DATA>(index);

        public ref T_DATA this[int index] => ref this.RefElementAt(index);

        public int Size => AsRef().Size;

        public IEnumerable<T_DATA> AsEnumerable()
        {
            var size = this.Size;
            for (int i = 0; i < size; ++i)
            {
                yield return this[i % size];
            }
        }
    }


    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoList_D<T_DATA>(nint ptr) : IPtrMonoList<Ref_MonoList_OptimizationDefault, T_DATA>
        where T_DATA : unmanaged
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoList_D<T_DATA>(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoList_D<T_DATA> obj) => obj._ptr;

        public static implicit operator PMonoList(PMonoList_D<T_DATA> obj) => new(obj._ptr);
        public static implicit operator PMonoList_D<T_DATA>(PMonoList obj) => new(obj);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref Ref_MonoList_OptimizationDefault AsRef()
            => ref _ptr.AsRefStruct<Ref_MonoList_OptimizationDefault>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan()
            => this.AsReadOnlySpan<PMonoList_D<T_DATA>, Ref_MonoList_OptimizationDefault, T_DATA>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int index)
            => ref this.RefElementAt<PMonoList_D<T_DATA>, Ref_MonoList_OptimizationDefault, T_DATA>(index);

        public ref T_DATA this[int index] => ref this.RefElementAt(index);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public IEnumerable<T_DATA> AsEnumerable()
        {
            int size = this.Size<PMonoList_D<T_DATA>, Ref_MonoList_OptimizationDefault, T_DATA>();
            for (int i = 0; i < size; ++i)
            { 
                yield return this[i];
            }
        }

    }

}
