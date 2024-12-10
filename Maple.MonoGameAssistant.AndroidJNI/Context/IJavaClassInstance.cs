using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidJNI.Context
{
    public interface IJavaClassInstance<T_Reference> : IDisposable
        where T_Reference : struct, IJavaClassReference, allows ref struct
    {
        JOBJECT Instance { get; }
        T_Reference Reference { get; }
    }

    public interface IJavaClassWeakInstance<T_Reference>
        : IJavaClassInstance<T_Reference>
        where T_Reference : struct, IJavaClassReference, allows ref struct
    {
        JWEAK<JOBJECT> JWeak { get; }
        JOBJECT IJavaClassInstance<T_Reference>.Instance => JWeak.Value;
        void IDisposable.Dispose()
        {
            this.Reference.JNI_ENV.DeleteWeakGlobalRef(this.JWeak);
            GC.SuppressFinalize(this);
        }
    }

    public interface IJavaClassLocalInstance<T_Reference>
        : IJavaClassInstance<T_Reference>
        where T_Reference : struct, IJavaClassReference, allows ref struct
    {
        JLOCAL<JOBJECT> JLocal { get; }
        JOBJECT IJavaClassInstance<T_Reference>.Instance => JLocal.Value;

        void IDisposable.Dispose()
        {
            this.Reference.JNI_ENV.DeleteLocalRef(this.JLocal);
            GC.SuppressFinalize(this);
        }
    }

    public interface IJavaClassGlobalInstance<T_Reference>
        : IJavaClassInstance<T_Reference>
        where T_Reference : struct, IJavaClassReference, allows ref struct
    {
        JGLOBAL<JOBJECT> JGlobal { get; }
        JOBJECT IJavaClassInstance<T_Reference>.Instance => JGlobal.Value;

        void IDisposable.Dispose()
        {
            this.Reference.JNI_ENV.DeleteGlobalRef(this.JGlobal);
            GC.SuppressFinalize(this);
        }


    }

}
