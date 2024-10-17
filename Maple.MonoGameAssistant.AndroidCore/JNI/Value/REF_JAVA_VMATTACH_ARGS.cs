using Maple.MonoGameAssistant.AndroidCore.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidCore.JNI.Reference;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Value
{
    [StructLayout(LayoutKind.Sequential)]
    public struct REF_JAVA_VM_ATTACH_ARGS
    {
        /// <summary>
        /// must be >= JNI_VERSION_1_2
        /// </summary>
        public JINT Version;

        /// <summary>
        /// NULL or name of thread as modified UTF-8 str
        /// </summary>
        public PStringUTF8 Name;

        /// <summary>
        /// global ref of a ThreadGroup object, or NULL
        /// </summary>
        public JOBJECT Group;
    }
}
