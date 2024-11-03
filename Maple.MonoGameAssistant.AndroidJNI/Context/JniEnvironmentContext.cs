using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Maple.MonoGameAssistant.AndroidModel;
using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidJNI.Context
{
    public readonly struct JniEnvironmentContext(JavaVirtualMachineContext javaVirtualMachineContext, PTR_JNI_ENV jniEnv) : IDisposable
    {
        public JavaVirtualMachineContext JavaVMContext { get; } = javaVirtualMachineContext;
        public PTR_JNI_ENV JNI_ENV { get; } = jniEnv;

        #region JNI NATIVE

        public bool RegisterNativeMethod(string className, string methodName, string methodDesc, nint methodPointer)
        {
            if (JNI_ENV.TryFindClass(className, out var findClass))
            {
                return JNI_ENV.RegisterNative(findClass, new JniNativeMethodDTO() { Name = methodName, Signature = methodDesc, Pointer = methodPointer });
            }
            return false;
        }
        public bool RegisterNativeMethods(string className, params ReadOnlySpan<JniNativeMethodDTO> methods)
        {
            if (JNI_ENV.TryFindClass(className, out var findClass))
            {
                return JNI_ENV.RegisterNatives(findClass, methods);
            }
            return false;
        }
        #endregion

        public void Dispose() => JavaVMContext.DetachThread();

        public static bool TryCreateJniEnvironmentContext(PTR_JNI_ENV jniEnv, out JniEnvironmentContext jniEnvironmentContext)
        {
            Unsafe.SkipInit(out jniEnvironmentContext);
            if (jniEnv.TryGetEnv(out var javaVM))
            {
                jniEnvironmentContext = new JniEnvironmentContext(new JavaVirtualMachineContext(javaVM), jniEnv);
                return true;
            }
            return false;
        }


        #region JavaClass
        static ConcurrentDictionary<string, JavaClassMetadata> CacheClasses { get; } = new(Environment.ProcessorCount << 2, 64);


        public TMetadata GetOrAddMetadata<TMetadata>(ReadOnlySpan<char> className)
            where TMetadata : JavaClassMetadata<TMetadata>, new()
        {
            if (!CacheClasses.TryGetValue(typeof(TMetadata).Name, out var metadata))
            {
                var realMetadata = JavaClassMetadata.CreateMetadataImp<TMetadata>(this, className);
                CacheClasses.TryAdd(typeof(TMetadata).Name, realMetadata);
                return realMetadata;
            }
            return metadata as TMetadata ?? AndroidJNIException.Throw<TMetadata>();


        }
        public TMetadata GetOrAddMetadata<TMetadata>(ReadOnlySpan<byte> className)
            where TMetadata : JavaClassMetadata<TMetadata>, new()
        {
            if (!CacheClasses.TryGetValue(typeof(TMetadata).Name, out var metadata))
            {
                var realMetadata = JavaClassMetadata.CreateMetadataImp<TMetadata>(this, className);
                CacheClasses.TryAdd(typeof(TMetadata).Name, realMetadata);
                return realMetadata;
            }
            return metadata as TMetadata ?? AndroidJNIException.Throw<TMetadata>();


        }
        public TMetadata GetOrAddMetadata<TMetadata>(JCLASS classObj)
            where TMetadata : JavaClassMetadata<TMetadata>, new()
        {
            if (!CacheClasses.TryGetValue(typeof(TMetadata).Name, out var metadata))
            {
                var realMetadata = JavaClassMetadata.CreateMetadataImp<TMetadata>(this, classObj);
                CacheClasses.TryAdd(typeof(TMetadata).Name, realMetadata);
                return realMetadata;
            }
            return metadata as TMetadata ?? AndroidJNIException.Throw<TMetadata>();


        }


        public TReference GetOrAddReference<TReference, TMetadata>(ReadOnlySpan<char> className)
            where TReference : JavaClassReference<TReference, TMetadata>, new()
            where TMetadata : JavaClassMetadata<TMetadata>, new()
            => new() { Jni = this, Metadata = this.GetOrAddMetadata<TMetadata>(className) };

        public TReference GetOrAddReference<TReference, TMetadata>(ReadOnlySpan<byte> className)
            where TReference : JavaClassReference<TReference, TMetadata>, new()
            where TMetadata : JavaClassMetadata<TMetadata>, new()
            => new() { Jni = this, Metadata = this.GetOrAddMetadata<TMetadata>(className) };

        public TReference GetOrAddReference<TReference, TMetadata>(JCLASS classObj)
            where TReference : JavaClassReference<TReference, TMetadata>, new()
            where TMetadata : JavaClassMetadata<TMetadata>, new()
            => new() { Jni = this, Metadata = this.GetOrAddMetadata<TMetadata>(classObj) };

        public TReference GetReference<TReference, TMetadata>(TMetadata metadata)
            where TReference : JavaClassReference<TReference, TMetadata>, new()
            where TMetadata : JavaClassMetadata<TMetadata>, new()
            => new() { Jni = this, Metadata = metadata };



        #endregion

    }


}
