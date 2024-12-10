using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Value
{
    [StructLayout(LayoutKind.Sequential)]
    public struct REF_JNI_NATIVE_METHOD
    {
        internal PStringUTF8 Name;
        internal PStringUTF8 Signature;
        [MarshalAs(UnmanagedType.SysInt)]
        internal nint Pointer;
    }
}
