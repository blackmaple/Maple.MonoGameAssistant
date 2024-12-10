using Maple.MonoGameAssistant.AndroidJNI.Classes;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.AndroidJNI.Context
{
    public interface IJavaClassReference
    {
        PTR_JNI_ENV JNI_ENV { get; init; }
    }

    public interface IJavaClassReference<T_Reference, T_Metadata> : IJavaClassReference
        where T_Reference : struct, IJavaClassReference<T_Reference, T_Metadata>, allows ref struct
        where T_Metadata : JavaClassMetadata<T_Metadata>, new()
    {
        T_Metadata Metadata { get; init; }

        static T_Reference CreateReference(in JniEnvironmentContext jniEnvironmentContext, T_Metadata metadata)
        {
            return jniEnvironmentContext.GetReference<T_Reference, T_Metadata>(metadata);
        }
    }



}
