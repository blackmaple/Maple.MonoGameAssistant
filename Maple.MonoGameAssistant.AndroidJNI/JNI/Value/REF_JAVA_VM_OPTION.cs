using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Value
{
    [StructLayout(LayoutKind.Sequential)]
    public struct REF_JAVA_VM_OPTION
    {
        internal PStringUTF8 Name;

        [MarshalAs(UnmanagedType.SysInt)]
        internal nint ExtraInfo;
    }
}
