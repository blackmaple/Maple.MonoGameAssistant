using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Common
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct RefValue<T>(nint ptr) where T : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;

        public RefValue(scoped ref T data) : this(new(Unsafe.AsPointer(ref data)))
        {

        }

        public ref T Raw => ref Unsafe.AsRef<T>(_ptr.ToPointer());

        public static RefValue<T> CreateOutValue(out T data)
        {
            Unsafe.SkipInit(out data);
            return new RefValue<T>(ref data);
        }
        public static RefValue<T> CreateRefValue(ref T data)
        {
            return new RefValue<T>(ref data);
        }

        public static RefValue<T> CreatePointer(nint ptr)
        {
            return new RefValue<T>(ptr);
        }

    }

}
