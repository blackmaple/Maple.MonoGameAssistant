using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct Ref_MonoEntry<TKEY, TVALUE>
        where TKEY : unmanaged
        where TVALUE : unmanaged

    {
        [MarshalAs(UnmanagedType.I4)]
        public readonly System.Int32 _hashCode;

        [MarshalAs(UnmanagedType.I4)]
        public readonly System.Int32 _next;

        public readonly TKEY _key;

        public readonly TVALUE _value;
    }

    readonly unsafe partial struct Ref_MonoEntry<TKEY, TVALUE> : IRefMonoEntry<TKEY, TVALUE>
    {
        public int HashCode => _hashCode;

        public int Next => _next;

        public ref readonly TKEY Key => ref Unsafe.AsRef(in _key);

        public ref readonly TVALUE Value => ref Unsafe.AsRef(in _value);

 

    }
}
