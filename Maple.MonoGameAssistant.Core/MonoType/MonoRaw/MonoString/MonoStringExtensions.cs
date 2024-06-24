using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    public static class MonoStringExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetString<T_REF>(this ref T_REF ref_this)
            where T_REF : unmanaged, IRefMonoString
        {
            var span = MemoryMarshal.CreateReadOnlySpan(in ref_this.FirstChar, ref_this.Length);
            return new string(span);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetString<T_REF>(this ref T_REF ref_this, int readSize)
            where T_REF : unmanaged, IRefMonoString
        {
            readSize = Math.Min(readSize, ref_this.Length);
            if (readSize <= 0)
            {
                return string.Empty;
            }
            var span = MemoryMarshal.CreateReadOnlySpan(in ref_this.FirstChar, readSize);
            return new string(span);

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetString<T_REF>(this PMonoString @this)
            where T_REF : unmanaged, IRefMonoString
            => @this.AsRef().GetString();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetString<T_REF>(this PMonoString @this, int readSize)
            where T_REF : unmanaged, IRefMonoString
            => @this.AsRef().GetString(readSize);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<char> AsReadOnlySpan<T_REF>(this ref T_REF ref_this)
            where T_REF : unmanaged, IRefMonoString
        {
           return MemoryMarshal.CreateReadOnlySpan(in ref_this.FirstChar, ref_this.Length);
           
        }

    }
}
