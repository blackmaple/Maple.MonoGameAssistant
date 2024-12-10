using Maple.MonoGameAssistant.AndroidJNI.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.Array
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly struct JCHAR_ARRAY(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;


        public static implicit operator JCHAR_ARRAY(nint val) => new(val);
        public static implicit operator nint(JCHAR_ARRAY val) => val._ptr;
        public static implicit operator bool(JCHAR_ARRAY val) => val.IsNotNullPtr();
        public static implicit operator JOBJECT(JCHAR_ARRAY val) => new(val._ptr);
        public static implicit operator JOBJECT_ARRAY(JCHAR_ARRAY val) => new(val._ptr);
        public static implicit operator JCHAR_ARRAY(char* val) =>  new nint(val);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string? ToString(int len) => GetRawString(len);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string? GetRawString(int len)
        {
            if (false == this.IsNotNullPtr())
            {
                return default;
            }

            return new string(((char*)_ptr), 0, len);
        }

        public ReadOnlySpan<char> AsReadOnlySpan(int len)
        {
            if (false == this.IsNotNullPtr())
            {
                return default;
            }
            return new ReadOnlySpan<char>((char*)_ptr, len);

        }

    }

}
