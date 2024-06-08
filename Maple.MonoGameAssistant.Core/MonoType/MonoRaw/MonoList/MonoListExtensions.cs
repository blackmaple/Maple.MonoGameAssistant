using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Core
{
    public static class MonoListExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<T_DATA> AsReadOnlySpan<T_REF, T_DATA>(this ref T_REF ref_this)
            where T_REF : unmanaged, IRefMonoList
            where T_DATA : unmanaged
        {

            return ref_this.Items.AsReadOnlySpan<T_DATA>(ref_this.Size);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<T_DATA> AsReadOnlySpan<T_PTR, T_REF, T_DATA>(this T_PTR @this)
            where T_PTR : IPtrMonoList<T_REF, T_DATA>
            where T_REF : unmanaged, IRefMonoList
            where T_DATA : unmanaged
        {
            ref var ref_this = ref @this.AsRef();
            return ref_this.AsReadOnlySpan<T_REF, T_DATA>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_DATA RefElementAt<T_REF, T_DATA>(this ref T_REF ref_this, int index)
            where T_REF : unmanaged, IRefMonoList
            where T_DATA : unmanaged
        {
            return ref ref_this.Items.RefElementAt<T_DATA>(index);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_DATA RefElementAt<T_PTR, T_REF, T_DATA>(this T_PTR @this, int index)
            where T_PTR : unmanaged, IPtrMonoList<T_REF, T_DATA>
            where T_REF : unmanaged, IRefMonoList
            where T_DATA : unmanaged
        {
            ref var ref_this = ref @this.AsRef();
            return ref ref_this.RefElementAt<T_REF, T_DATA>(index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Size<T_PTR, T_REF, T_DATA>(this T_PTR @this)
             where T_PTR : IPtrMonoList<T_REF, T_DATA>
             where T_REF : unmanaged, IRefMonoList
             where T_DATA : unmanaged
        {
            return @this.AsRef().Size;
        }

    }
}
