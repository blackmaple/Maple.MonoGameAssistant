using Maple.MonoGameAssistant.AndroidCore.JNI.Primitive;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Value
{
    [StructLayout(LayoutKind.Sequential)]
    public struct REF_JAVA_VM_INIT_ARGS
    {
        /// <summary>
        /// must be >= JNI_VERSION_1_2
        /// </summary>
        public JINT Version;


        public JINT OptionsLenght;

        [MarshalAs(UnmanagedType.SysInt)]
        public nint Options;

        public JBOOLEAN IgnoreUnrecognized;
    }

}
