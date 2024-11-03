using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.AndroidJNI.Context
{
    public abstract class JavaClassReference
    {
        public JniEnvironmentContext Jni { get; init; }
        public PTR_JNI_ENV JNI_ENV => Jni.JNI_ENV;

    }

    public abstract class JavaClassReference<T_Reference, T_Metadata>: JavaClassReference
        where T_Reference : JavaClassReference<T_Reference, T_Metadata>, new()
        where T_Metadata : JavaClassMetadata<T_Metadata>, new()
    {
        [NotNull]
        public T_Metadata? Metadata { get; init; }

        public static T_Reference CreateReference(in JniEnvironmentContext context, ReadOnlySpan<char> className)
            => context.GetOrAddReference<T_Reference, T_Metadata>(className);

        public static T_Reference CreateReference(in JniEnvironmentContext context, ReadOnlySpan<byte> className)
            => context.GetOrAddReference<T_Reference, T_Metadata>(className);

        public static T_Reference CreateReference(in JniEnvironmentContext context, JCLASS classObj)
            => context.GetOrAddReference<T_Reference, T_Metadata>(classObj);

    }

}
