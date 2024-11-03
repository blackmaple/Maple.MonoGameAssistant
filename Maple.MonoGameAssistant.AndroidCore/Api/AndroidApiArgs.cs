using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System;

namespace Maple.MonoGameAssistant.AndroidCore
{
    public class AndroidApiArgs
    {

        public JINT Action { get; init; }
        public JGLOBAL<JSTRING> Json { get; init; }
        public JWEAK<JOBJECT> Instance { get; init; }
       // public JMETHODID MethodId { get; init; }

        public static AndroidApiArgs Create(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
        {
            return new AndroidApiArgs()
            {
                Action = actionIndex,
                Instance = jniEnv.NewWeakGlobalRef(instance),
                Json = jniEnv.NewGlobalRef(json)
            };



        }
   
    }
}
