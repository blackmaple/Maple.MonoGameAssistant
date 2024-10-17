using Maple.MonoGameAssistant.AndroidCore.JNI.Primitive;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Reference
{
    [StructLayout(LayoutKind.Explicit)]
    public struct JVALUE
    {
        [FieldOffset(0)] public JBOOLEAN Z;
        [FieldOffset(0)] public JBYTE B;
        [FieldOffset(0)] public JCHAR C;
        [FieldOffset(0)] public JSHORT S;
        [FieldOffset(0)] public JINT I;
        [FieldOffset(0)] public JLONG J;
        [FieldOffset(0)] public JFLOAT F;
        [FieldOffset(0)] public JDOUBLE D;
        [FieldOffset(0)] public JOBJECT L;
    }

}
