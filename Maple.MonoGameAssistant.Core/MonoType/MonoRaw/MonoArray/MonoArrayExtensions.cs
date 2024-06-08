using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    /// <summary>
    /// 接口默认实现无法内联
    /// </summary>
    public static class MonoArrayExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<T_DATA> AsSpan<T_REF, T_DATA>(this ref T_REF ref_this, int count)
            where T_REF : unmanaged, IRefMonoArray
            where T_DATA : unmanaged
        {
            ref var data = ref Unsafe.As<byte, T_DATA>(ref ref_this.FirstByte);
            return MemoryMarshal.CreateSpan(ref data, count);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<T_DATA> AsSpan<T_PTR, T_REF, T_DATA>(this T_PTR @this, int count)
            where T_PTR : IPtrMonoArray<T_REF, T_DATA>
            where T_REF : unmanaged, IRefMonoArray
            where T_DATA : unmanaged
        {
            ref var ref_this = ref @this.AsRef();
            return ref_this.AsSpan<T_REF, T_DATA>(count);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<T_DATA> AsSpan<T_PTR, T_REF, T_DATA>(this T_PTR @this)
            where T_PTR : IPtrMonoArray<T_REF, T_DATA>
            where T_REF : unmanaged, IRefMonoArray
            where T_DATA : unmanaged
            => @this.AsSpan<T_PTR, T_REF, T_DATA>(@this.AsRef().Size);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<T_DATA> AsReadOnlySpan<T_REF, T_DATA>(this ref T_REF ref_this, int count)
            where T_REF : unmanaged, IRefMonoArray
            where T_DATA : unmanaged
            => ref_this.AsSpan<T_REF, T_DATA>(count);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<T_DATA> AsReadOnlySpan<T_PTR, T_REF, T_DATA>(this T_PTR @this, int count)
            where T_PTR : IPtrMonoArray<T_REF, T_DATA>
            where T_REF : unmanaged, IRefMonoArray
            where T_DATA : unmanaged
        {
            ref var ref_this = ref @this.AsRef();
            return ref_this.AsReadOnlySpan<T_REF, T_DATA>(count);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<T_DATA> AsReadOnlySpan<T_PTR, T_REF, T_DATA>(this T_PTR @this)
            where T_PTR : IPtrMonoArray<T_REF, T_DATA>
            where T_REF : unmanaged, IRefMonoArray
            where T_DATA : unmanaged
            => @this.AsReadOnlySpan<T_PTR, T_REF, T_DATA>(@this.AsRef().Size);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_DATA RefElementAt<T_REF, T_DATA>(this ref T_REF ref_this, int index)
            where T_REF : unmanaged, IRefMonoArray
            where T_DATA : unmanaged
        {
            ref var data = ref Unsafe.As<byte, T_DATA>(ref ref_this.FirstByte);
            return ref Unsafe.Add(ref data, index);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_DATA RefElementAt<T_PTR, T_REF, T_DATA>(this T_PTR @this, int index)
            where T_PTR : IPtrMonoArray<T_REF, T_DATA>
            where T_REF : unmanaged, IRefMonoArray
            where T_DATA : unmanaged
        {
            ref var ref_this = ref @this.AsRef();
            return ref ref_this.RefElementAt<T_REF, T_DATA>(index);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_DATA RefElementAt<T_REF, T_DATA>(this ref T_REF ref_this, int col, int row)
            where T_REF : unmanaged, IRefMonoArray
            where T_DATA : unmanaged
        {
            var index = col * ref_this.GetArrayBounds().LowerBound + row;

            return ref ref_this.RefElementAt<T_REF, T_DATA>(index);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_DATA RefElementAt<T_PTR, T_REF, T_DATA>(this T_PTR @this, int col, int row)
            where T_PTR : IPtrMonoArray<T_REF, T_DATA>
            where T_REF : unmanaged, IRefMonoArray
            where T_DATA : unmanaged
        {
            ref var ref_this = ref @this.AsRef();
            return ref ref_this.RefElementAt<T_REF, T_DATA>(col, row);
        }






    }
}
