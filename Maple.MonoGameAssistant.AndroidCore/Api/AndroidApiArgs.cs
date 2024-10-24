using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System;

namespace Maple.MonoGameAssistant.AndroidCore
{
    public class AndroidApiArgs
    {

        public JGLOBAL<JSTRING> Action { get; init; }
        public JGLOBAL<JSTRING> Json { get; init; }
        public JWEAK<JOBJECT> Instance { get; init; }
  //      public JGLOBAL<JCLASS> Class { get; init; }
        public JMETHODID MethodId { get; init; }

        public static AndroidApiArgs Create(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING actionName, JSTRING json)
        {
            return new AndroidApiArgs()
            {
                Instance = jniEnv.NewWeakGlobalRef(instance),
                Action = jniEnv.NewGlobalRef(actionName),
                Json = jniEnv.NewGlobalRef(json)
            };



        }
        public static AndroidApiArgs Create(PTR_JNI_ENV jniEnv, JOBJECT instance )
        {
            var json = """
                {{
                    "Pointer" : "0x12345678"
                }}
                """;
            var jstring = jniEnv.CreateStringUnicode(json);
            var actionName = jniEnv.CreateStringUnicode("test");
            var args= Create(jniEnv, instance, actionName, jstring);
            jniEnv.DeleteLocalRef(jstring);
            jniEnv.DeleteLocalRef(actionName);
            return args;
        }
    }
}
