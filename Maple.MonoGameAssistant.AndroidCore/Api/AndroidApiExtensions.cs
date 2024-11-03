using Maple.MonoGameAssistant.AndroidCore.HostedService;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace Maple.MonoGameAssistant.AndroidCore.Api
{
    public static partial class AndroidApiExtensions
    {
        static AndroidApiContext? ApiContext { get; set; }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad), CallConvs = [typeof(CallConvCdecl)])]
        public static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            ApiContext = AndroidApiContext.CreateContext(javaVM).CreateDefaultAndroidService();
            return JavaVirtualMachineContext.JNI_VERSION_1_6;
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnUnload), CallConvs = [typeof(CallConvCdecl)])]
        public static void JNI_OnUnload(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            // ApiContext?.VirtualMachineContext.DetachThread();
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(ApiAction), CallConvs = [typeof(CallConvCdecl)])]
        public static JBOOLEAN ApiAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
        {
            return ApiContext?.TryWrite(AndroidApiArgs.Create(jniEnv, instance, actionIndex, json)) ?? false;
        }

    }
}
