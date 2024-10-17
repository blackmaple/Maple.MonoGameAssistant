using Maple.MonoGameAssistant.AndroidCore.JNI.Reference;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Value
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
