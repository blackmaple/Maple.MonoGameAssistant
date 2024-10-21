using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System;

namespace Maple.MonoGameAssistant.AndroidJNI
{

    //public unsafe readonly struct Ptr_Func_Callback(nint ptr)
    //{
    //    readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<JSTRING, JSTRING, JBOOLEAN> _ptr
    //        = (delegate* unmanaged[Cdecl, SuppressGCTransition]<JSTRING, JSTRING, JBOOLEAN>)ptr;

    //    public JBOOLEAN Invoke()
    //}

    public class AndroidJniArgs
    {

        public JGLOBAL<JSTRING> Action { get; init; }
        public JGLOBAL<JSTRING> Json { get; init; }
        public JWEAK<JOBJECT> Instance { get; init; }
        public JGLOBAL<JCLASS> Class { get; init; }
        public JMETHODID MethodId { get; init; }

        public static AndroidJniArgs Create(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING actionName, JSTRING json)
        {
            return new AndroidJniArgs()
            {
                Instance = jniEnv.NewWeakGlobalRef(instance),
                Action = jniEnv.NewGlobalRef(actionName),
                Json = jniEnv.NewGlobalRef(json)
            };



        }

    }
}
