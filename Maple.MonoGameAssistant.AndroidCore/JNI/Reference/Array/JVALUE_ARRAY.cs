using Maple.MonoGameAssistant.AndroidCore.JNI.Reference;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Reference.Array
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly struct JVALUE_ARRAY(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator JVALUE_ARRAY(nint val) => new(val);
        public static implicit operator JVALUE_ARRAY(void* val) => new nint(val);
        public static implicit operator nint(JVALUE_ARRAY val) => val._ptr;
        public static implicit operator bool(JVALUE_ARRAY val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JVALUE_ARRAY val) => new(val._ptr);
        public static implicit operator JOBJECT_ARRAY(JVALUE_ARRAY val) => new(val._ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNullPtr() => _ptr != nint.Zero;
    }

}
