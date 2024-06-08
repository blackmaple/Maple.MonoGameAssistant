using System.Text;

namespace Maple.MonoGameAssistant.Common
{
    public static class MapleStringUnmanagedExtensions
    {
        public static MapleStringUnmanaged_Ref AsUnmanaged(this string str, Encoding encoding, Span<byte> buffer)
        {
            return new MapleStringUnmanaged_Ref(str, encoding, buffer);
        }

        public static MapleStringUnmanagedLimite_Ref AsUnmanagedLimite(this string str, Encoding encoding, Span<byte> buffer)
        {
            return new MapleStringUnmanagedLimite_Ref(str, encoding, buffer);
        }
    }
}
