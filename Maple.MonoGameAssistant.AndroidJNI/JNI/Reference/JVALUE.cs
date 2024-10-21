using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference
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


        public JVALUE(JBOOLEAN val) { Z = val; }
        public JVALUE(JBYTE val) { B = val; }
        public JVALUE(JCHAR val) { C = val; }
        public JVALUE(JSHORT val) { S = val; }
        public JVALUE(JINT val) { I = val; }
        public JVALUE(JLONG val) { J = val; }
        public JVALUE(JFLOAT val) { F = val; }
        public JVALUE(JDOUBLE val) { D = val; }
        public JVALUE(JOBJECT val) { L = val; }


    }

}
