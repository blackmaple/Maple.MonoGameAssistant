using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Common
{



    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct MapleOut<T>(scoped ref T data) where T : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = new(Unsafe.AsPointer(ref data));

        //public ref T Raw => ref Unsafe.AsRef<T>(_ptr.ToPointer());

        public static MapleOut<T> FromOut(out T data)
        {
            Unsafe.SkipInit(out data);
            return new MapleOut<T>(ref data);
        }
    }

}
