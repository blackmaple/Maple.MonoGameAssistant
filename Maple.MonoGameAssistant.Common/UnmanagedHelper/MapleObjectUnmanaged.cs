using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Common
{
    public unsafe struct MapleObjectUnmanaged(object obj) : IDisposable
    {
        GCHandle _handle = GCHandle.Alloc(obj);

        public readonly nint ToIntPtr() => GCHandle.ToIntPtr(_handle);
        public static bool TryGet<T>(nint ptr, [MaybeNullWhen(false)] out T obj)
            where T : class
        {
            Unsafe.SkipInit(out obj);
            if (ptr != nint.Zero)
            {
                var handle = GCHandle.FromIntPtr(ptr);
                if (handle.Target is T b)
                {
                    obj = b;
                    return true;
                }
            }
            return false;
        }

        public void Dispose()
        {
            _handle.Free();
        }

        public static implicit operator nint(MapleObjectUnmanaged @ref) => @ref.ToIntPtr();
    }

}
