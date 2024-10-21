using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
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

        public JGLOBAL<JSTRING> Action { get; }
        public JGLOBAL<JSTRING> Json { get; }
        public JWEAK<JOBJECT> Instance { get; }
        public JGLOBAL<JCLASS> Class { get; }
        public JMETHODID CallbackMethodId { get; }
    }
}
