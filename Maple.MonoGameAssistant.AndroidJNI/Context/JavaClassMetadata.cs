using Maple.MonoGameAssistant.AndroidJNI.Classes;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;

namespace Maple.MonoGameAssistant.AndroidJNI.Context
{

    public abstract class JavaClassMetadata
    {

        public JGLOBAL<JCLASS> GlobalClass { get; init; }

        protected virtual void FindMethods(in JniEnvironmentContext context) { }
        protected virtual void FindFields(in JniEnvironmentContext context) { }


        public static TMetadata CreateMetadataImp<TMetadata>(in JniEnvironmentContext jniEnvironmentContext, ReadOnlySpan<char> className)
          where TMetadata : JavaClassMetadata, new()
        {
            var classObj = jniEnvironmentContext.JNI_ENV.FindClass(className);
            try
            {
                return CreateMetadataImp<TMetadata>(jniEnvironmentContext, classObj);
            }
            finally
            {
                jniEnvironmentContext.JNI_ENV.DeleteLocalRef(classObj);
            }
        }
        public static TMetadata CreateMetadataImp<TMetadata>(in JniEnvironmentContext jniEnvironmentContext, ReadOnlySpan<byte> className)
          where TMetadata : JavaClassMetadata, new()
        {
            var classObj = jniEnvironmentContext.JNI_ENV.FindClass(className);
            try
            {
                return CreateMetadataImp<TMetadata>(jniEnvironmentContext, classObj);
            }
            finally
            {
                jniEnvironmentContext.JNI_ENV.DeleteLocalRef(classObj);
            }
        }
        public static TMetadata CreateMetadataImp<TMetadata>(in JniEnvironmentContext jniEnvironmentContext, JCLASS classObj)
            where TMetadata : JavaClassMetadata, new()
        {
            var globalClass = jniEnvironmentContext.JNI_ENV.NewGlobalRef(classObj);
            var javaClass = new TMetadata() { GlobalClass = globalClass };
            javaClass.FindMethods(jniEnvironmentContext);
            javaClass.FindFields(jniEnvironmentContext);
            return javaClass;
        }
        public static TMetadata CreateMetadataImp<TMetadata>(in JniEnvironmentContext jniEnvironmentContext, JOBJECT instance)
            where TMetadata : JavaClassMetadata, new()
        {
            var classObj = jniEnvironmentContext.JNI_ENV.GetObjectClass(instance);
            try
            {
                return CreateMetadataImp<TMetadata>(jniEnvironmentContext, classObj);
            }
            finally
            {
                jniEnvironmentContext.JNI_ENV.DeleteLocalRef(classObj);
            }
        }

        public void Release(in JniEnvironmentContext jniEnvironmentContext)
        {
            jniEnvironmentContext.JNI_ENV.DeleteGlobalRef(GlobalClass);
        }
    }

    public abstract class JavaClassMetadata<TMetadata> : JavaClassMetadata
        where TMetadata : JavaClassMetadata<TMetadata>, new()
    {
        public static TMetadata CreateMetadata(in JniEnvironmentContext context,ReadOnlySpan<char> className)
        {
            return context.GetOrAddMetadata<TMetadata>(className);
        }
        public static TMetadata CreateMetadata(in JniEnvironmentContext context, ReadOnlySpan<byte> className)
        {
            return context.GetOrAddMetadata<TMetadata>(className);
        }

        public static TMetadata CreateMetadata(in JniEnvironmentContext context, JCLASS classObj)
        {
            return context.GetOrAddMetadata<TMetadata>(classObj);
        }

        public static TMetadata CreateMetadata(in JniEnvironmentContext context, JOBJECT instance)
        {
            return context.GetOrAddMetadata<TMetadata>(instance);
        }
    }
}
