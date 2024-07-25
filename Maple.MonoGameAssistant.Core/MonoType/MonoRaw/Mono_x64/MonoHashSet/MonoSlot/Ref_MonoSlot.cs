using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct Ref_MonoSlot<T_VALUE>
        where T_VALUE : unmanaged

    {
        [MarshalAs(UnmanagedType.I4)]
        public readonly System.Int32 _hashCode;

        [MarshalAs(UnmanagedType.I4)]
        public readonly System.Int32 _next;

        public readonly T_VALUE _value;
    }

    readonly unsafe partial struct Ref_MonoSlot<T_VALUE> : IRefMonoSlot<T_VALUE>
    {
        public int HashCode => _hashCode;

        public int Next => _next;

        public ref readonly T_VALUE Value => ref Unsafe.AsRef(in _value);



    }
}
