using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.Core
{
    public static class MonoStringExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetString<T_REF>(this ref T_REF ref_this)
            where T_REF : unmanaged, IRefMonoString
        {
            if (Unsafe.IsNullRef(ref ref_this))
            {
                return default;
            }
            var span = MemoryMarshal.CreateReadOnlySpan(in ref_this.FirstChar, ref_this.Length);
            return new string(span);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetString<T_REF>(this ref T_REF ref_this, int readSize)
            where T_REF : unmanaged, IRefMonoString
        {
            if (Unsafe.IsNullRef(ref ref_this))
            {
                return default;
            }
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


        public unsafe static string GetMonoStringStructLayout()
        {
            StringBuilder stringBuilder = new();
            Ref_MonoString ex = new();
            byte* addr = (byte*)&ex;
            stringBuilder.AppendFormat("Size:      {0:x};", Unsafe.SizeOf<Ref_MonoArray>());
            stringBuilder.AppendFormat("_obj Offset: {0:x};", (byte*)&ex._obj - addr);
            stringBuilder.AppendFormat("m_stringLength Offset: {0:x};", (byte*)&ex.m_stringLength - addr);
            stringBuilder.AppendFormat("m_firstChar Offset: {0:x};", (byte*)&ex.m_firstChar - addr);
            return stringBuilder.ToString();
        }
    }
}
