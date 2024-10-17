using Maple.MonoGameAssistant.AndroidCore.JNI.Value;
using Maple.MonoGameAssistant.AndroidNdk.Helper;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidCore.Context
{
    public readonly struct JniEnvironmentContext(JavaVirtualMachineContext javaVirtualMachineContext, PTR_JNI_ENV jniEnv) : IDisposable
    {
        public JavaVirtualMachineContext JavaVMContext { get; } = javaVirtualMachineContext;
        public PTR_JNI_ENV JNI_ENV { get; } = jniEnv;

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

        public bool ExceptionCheck()
        {
            if (JNI_ENV.ExceptionCheck())
            {
                JNI_ENV.ExceptionDescribe();
                JNI_ENV.ExceptionClear();
                return true;
            }
            return false;
        }

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


        public JniGlobalObjectColltion CreateGlobalObject()
        {
            JniGlobalObjectColltion objectColltion = new();
            if (JNI_ENV.TryFindClass(JniGlobalObjectColltion.LooperClassName, out var looperObj))
            {
                objectColltion.LooperObject = JNI_ENV.NewGlobal(looperObj);
                JNI_ENV.DeleteLocal(looperObj);
            }
            if (JNI_ENV.TryFindClass(JniGlobalObjectColltion.ToastClassName, out var toastObj))
            {
                objectColltion.ToastObject = JNI_ENV.NewGlobal(toastObj);
                JNI_ENV.DeleteLocal(toastObj);
            }


            return objectColltion;
        }
    }

}
