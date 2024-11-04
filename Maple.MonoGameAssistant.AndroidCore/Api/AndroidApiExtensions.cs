using Maple.MonoGameAssistant.AndroidCore.HostedService;
using Maple.MonoGameAssistant.AndroidJNI.Classes;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Logger;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using unsafe TestActionDelegate = delegate* unmanaged<Maple.MonoGameAssistant.AndroidJNI.JNI.Value.PTR_JNI_ENV, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JOBJECT, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JSTRING, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JBOOLEAN>;
using unsafe ApiActionDelegate = delegate* unmanaged<Maple.MonoGameAssistant.AndroidJNI.JNI.Value.PTR_JNI_ENV, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JOBJECT, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JINT, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JSTRING, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JBOOLEAN>;
using static System.Net.Mime.MediaTypeNames;

namespace Maple.MonoGameAssistant.AndroidCore.Api
{
    public static partial class AndroidApiExtensions
    {
        //private static void DebugLog(object txt)
        //{
        //    var log = Path.Combine($"/sdcard/Download", $"{Environment.ProcessId:X8}.txt");
        //    using var writer = File.AppendText(log);
        //    writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}:{txt}");
        //}
        static AndroidApiContext? ApiContext { get; set; }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
        public unsafe static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            Logger.MonoGameLoggerExtensions.SetAndroidEnvironment();
            ApiContext = AndroidApiContext.CreateContext(javaVM).CreateDefaultAndroidService();
            if (ApiContext.VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            {
                jniEnvironmentContext.RegisterNativeMethod("com/android/maple/MainActivity", nameof(TestAction), "(Ljava/lang/String;)Z", new Ptr_Func_TestAction(&TestAction));
                jniEnvironmentContext.RegisterNativeMethod("com/android/maple/MainActivity", nameof(ApiAction), "(ILjava/lang/String;)Z", new Ptr_Func_ApiAction(&ApiAction));
            }
            return JavaVirtualMachineContext.JNI_VERSION_1_6;
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnUnload))]
        public static void JNI_OnUnload(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            // ApiContext?.VirtualMachineContext.DetachThread();
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(ApiAction))]
        public static JBOOLEAN ApiAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
        {

            //{
            //    var androidToast = AndroidToastReference.Create(in jniEnvironmentContext);
            //    androidToast.Show(instance, $@"{(int)actionIndex}:{jniEnvironmentContext.JNI_ENV.ConvertStringUnicode(json)}", false);
            //    return true;
            //}
            //return false;
            //  return ApiContext?.TryWrite(AndroidApiArgs.Create(jniEnv, instance, actionIndex, json)) ?? false;
            if (JniEnvironmentContext.TryCreateJniEnvironmentContext(jniEnv, out var jniEnvironmentContext))
            {
                try
                {
                    Logger.MonoGameLogger.Default.Info("1");
                    var api = VirtualActionApiCallbackInstance.Create(jniEnvironmentContext, instance);
                    Logger.MonoGameLogger.Default.Info("2");
                    api.None(json);
                    Logger.MonoGameLogger.Default.Info("3");

                }
                catch (Exception ex)
                {
                    Logger.MonoGameLogger.Default.Error(ex);
                }


                var androidToast = AndroidToastReference.Create(in jniEnvironmentContext);
                androidToast.Show(instance, $@"{(int)actionIndex}:{jniEnvironmentContext.JNI_ENV.ConvertStringUnicode(json)}", false);
                return true;
            }
            return true;
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(TestAction))]
        public static JBOOLEAN TestAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
        {
            if (JniEnvironmentContext.TryCreateJniEnvironmentContext(jniEnv, out var jniEnvironmentContext))
            {
                var androidToast = AndroidToastReference.Create(in jniEnvironmentContext);
                androidToast.Show(instance, jniEnvironmentContext.JNI_ENV.ConvertStringUnicode(text), false);
                return true;
            }
            return false;
        }

        readonly unsafe struct Ptr_Func_ApiAction(ApiActionDelegate ptr)
        {
            readonly ApiActionDelegate _ptr = ptr;
            public static implicit operator nint(Ptr_Func_ApiAction func) => (nint)func._ptr;
        }
        readonly unsafe struct Ptr_Func_TestAction(TestActionDelegate ptr)
        {
            readonly TestActionDelegate _ptr = ptr;
            public static implicit operator nint(Ptr_Func_TestAction func) => (nint)func._ptr;
        }


    }
}
