using System.Buffers;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.Common
{
    public unsafe ref struct MapleStringUnmanaged_Ref
    {
        public const int MaxSize = 0x100;
        readonly ref byte _ptr;
        byte[]? _cache;

        public MapleStringUnmanaged_Ref(string str, Encoding encoding, Span<byte> buffer)
        {
            int exactByteCount = encoding.GetByteCount(str) + 1;

            if (exactByteCount > buffer.Length)
            {
                _cache = ArrayPool<byte>.Shared.Rent(exactByteCount);
                _ptr = ref MemoryMarshal.GetArrayDataReference(_cache);
                buffer = _cache;
            }
            else
            {
                _ptr = ref MemoryMarshal.GetReference(buffer);
            }
            int byteCount = encoding.GetBytes(str, buffer);
            buffer[byteCount] = 0; // null-terminate

        }

        public void Dispose()
        {
            if (_cache is not null)
            {
                var tmp = _cache;
                _cache = default;
                ArrayPool<byte>.Shared.Return(tmp, true);
            }
        }

        public readonly ref byte GetPinnableReference() => ref _ptr;
        //public static implicit operator nint(MapleStringUnmanaged_Ref @ref) => new(@ref._ptr);

    }
}
