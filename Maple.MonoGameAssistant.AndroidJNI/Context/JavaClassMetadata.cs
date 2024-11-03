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
            var globalClass = jniEnvironmentContext.JNI_ENV.NewGlobalRef(classObj);
            jniEnvironmentContext.JNI_ENV.DeleteLocalRef(classObj);
            var javaClass = new TMetadata() { GlobalClass = globalClass };
            javaClass.FindMethods(jniEnvironmentContext);
            javaClass.FindFields(jniEnvironmentContext);
            return javaClass;
        }
        public static TMetadata CreateMetadataImp<TMetadata>(in JniEnvironmentContext jniEnvironmentContext, ReadOnlySpan<byte> className)
          where TMetadata : JavaClassMetadata, new()
        {
            var classObj = jniEnvironmentContext.JNI_ENV.FindClass(className);
            var globalClass = jniEnvironmentContext.JNI_ENV.NewGlobalRef(classObj);
            jniEnvironmentContext.JNI_ENV.DeleteLocalRef(classObj);
            var javaClass = new TMetadata() { GlobalClass = globalClass };
            javaClass.FindMethods(jniEnvironmentContext);
            javaClass.FindFields(jniEnvironmentContext);
            return javaClass;
        }
        public static TMetadata CreateMetadataImp<TMetadata>(in JniEnvironmentContext jniEnvironmentContext, JCLASS classObj)
            where TMetadata : JavaClassMetadata, new()
        {
            var globalClass = jniEnvironmentContext.JNI_ENV.NewGlobalRef(classObj);
            jniEnvironmentContext.JNI_ENV.DeleteLocalRef(classObj);
            var javaClass = new TMetadata() { GlobalClass = globalClass };
            javaClass.FindMethods(jniEnvironmentContext);
            javaClass.FindFields(jniEnvironmentContext);
            return javaClass;
        }

        public void Release(in JniEnvironmentContext jniEnvironmentContext)
        {
            jniEnvironmentContext.JNI_ENV.DeleteGlobalRef(GlobalClass);
        }
    }

    public abstract class JavaClassMetadata<TMetadata> : JavaClassMetadata
        where TMetadata : JavaClassMetadata<TMetadata>, new()
    {

        public static TMetadata CreateMetadata(in JniEnvironmentContext jniEnvironmentContext, ReadOnlySpan<char> className)
        {
            return jniEnvironmentContext.GetOrAddMetadata<TMetadata>(className);
        }
        public static TMetadata CreateMetadata(in JniEnvironmentContext jniEnvironmentContext, ReadOnlySpan<byte> className)
        {
            return jniEnvironmentContext.GetOrAddMetadata<TMetadata>(className);
        }
        public static TMetadata CreateMetadata(in JniEnvironmentContext jniEnvironmentContext, JCLASS classObj)
        {
            return jniEnvironmentContext.GetOrAddMetadata<TMetadata>(classObj);
        }
    }
}
