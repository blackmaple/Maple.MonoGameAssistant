using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Common
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct MapleRef<T>(nint ptr) where T : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;

        public MapleRef(scoped ref T data) : this(new(Unsafe.AsPointer(ref data)))
        {

        }

        public ref T Raw => ref Unsafe.AsRef<T>(_ptr.ToPointer());

        //public static MapleRef<T> Out(out T data)
        //{
        //    Unsafe.SkipInit(out data);
        //    return new MapleRef<T>(ref data);
        //}

        public static MapleRef<T> FromRef(ref T data)
        {
            return new MapleRef<T>(ref data);
        }

        public static MapleRef<T> FromPtr(nint ptr)
        {
            return new MapleRef<T>(ptr);
        }

        public static MapleRef<T> NullRef() => MapleRef<T>.FromPtr(nint.Zero);

    }

}
