using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.Common
{
    public unsafe ref struct MapleStringUnmanagedLimite_Ref
    {
        public const int MaxSize = 0x100;
        readonly byte* _ptr;


        public MapleStringUnmanagedLimite_Ref(ReadOnlySpan<char> str, Encoding encoding, Span<byte> buffer)
        {
            //栈对象不需要Pin
            int exactByteCount = encoding.GetByteCount(str) + 1;
            Debug.Assert(exactByteCount <= MaxSize);
            int byteCount = encoding.GetBytes(str, buffer);
            buffer[byteCount] = 0; // null-terminate
            _ptr = (byte*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(buffer));

        }



        public static implicit operator nint(MapleStringUnmanagedLimite_Ref @ref) => new(@ref._ptr);
        public static implicit operator byte*(MapleStringUnmanagedLimite_Ref @ref) => @ref._ptr;

    }

}
