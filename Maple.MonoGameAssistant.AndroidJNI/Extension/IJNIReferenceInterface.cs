using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.Extension
{
    internal interface IJNIReferenceInterface
    {
        public nint Ptr { get; }

    }



    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct JREF<T>(nint ptr) where T : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;

        public JREF(scoped ref T data) : this(new(Unsafe.AsPointer(ref data)))
        {

        }

        public ref T Raw => ref Unsafe.AsRef<T>(_ptr.ToPointer());

        public static JREF<T> CreateOutValue(out T data)
        {
            Unsafe.SkipInit(out data);
            return new JREF<T>(ref data);
        }
        public static JREF<T> CreateRefValue(ref T data)
        {
            return new JREF<T>(ref data);
        }
        public static JREF<T> CreatePointer(nint ptr)
        {
            return new JREF<T>(ptr);
        }
        public static JREF<T> NullRef() => JREF<T>.CreatePointer(nint.Zero);

    }


}
