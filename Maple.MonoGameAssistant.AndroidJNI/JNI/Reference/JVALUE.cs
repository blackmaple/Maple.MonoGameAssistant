using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Reference
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct JVALUE
    {
        [FieldOffset(0)] readonly JBOOLEAN Z;
        [FieldOffset(0)] readonly JBYTE B;
        [FieldOffset(0)] readonly JCHAR C;
        [FieldOffset(0)] readonly JSHORT S;
        [FieldOffset(0)] readonly JINT I;
        [FieldOffset(0)] readonly JLONG J;
        [FieldOffset(0)] readonly JFLOAT F;
        [FieldOffset(0)] readonly JDOUBLE D;
        [FieldOffset(0)] readonly JOBJECT L;


        public JVALUE(JBOOLEAN val) { Z = val; }
        public JVALUE(JBYTE val) { B = val; }
        public JVALUE(JCHAR val) { C = val; }
        public JVALUE(JSHORT val) { S = val; }
        public JVALUE(JINT val) { I = val; }
        public JVALUE(JLONG val) { J = val; }
        public JVALUE(JFLOAT val) { F = val; }
        public JVALUE(JDOUBLE val) { D = val; }
        public JVALUE(JOBJECT val) { L = val; }
        public JVALUE(nint val) { L = val; }
        public unsafe JVALUE(void* val) { L = val; }


    }

}
