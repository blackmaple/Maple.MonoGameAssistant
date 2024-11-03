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
            //ApiContext = AndroidApiContext.CreateContext(javaVM).CreateDefaultAndroidService();
            //if (ApiContext.VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            //{
            //    jniEnvironmentContext.RegisterNativeMethod("com.android.maple.MainActivity", nameof(TestAction), "(Ljava/lang/String;)Z", new Ptr_Func_TestAction(&TestAction));
            //}
            Logger.MonoGameLoggerExtensions.SetAndroidEnvironment();
            Logger.MonoGameLogger.Default.Info("1234");
           
            if (new JavaVirtualMachineContext(javaVM).TryGetEnv(out var jniEnvironmentContext))
            {
                var b = jniEnvironmentContext.RegisterNativeMethod("com/android/maple/MainActivity", nameof(TestAction), "(Ljava/lang/String;)Z", new Ptr_Func_TestAction(&TestAction));
                Logger.MonoGameLogger.Default.Info(b.ToString());
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
            return ApiContext?.TryWrite(AndroidApiArgs.Create(jniEnv, instance, actionIndex, json)) ?? false;
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(TestAction))]
        public static JBOOLEAN TestAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
        {
            Logger.MonoGameLogger.Default.Info("1");
            if (JniEnvironmentContext.TryCreateJniEnvironmentContext(jniEnv, out var jniEnvironmentContext))
            {
                try
                {
                    Logger.MonoGameLogger.Default.Info("2");
                    var metadata = AndroidToastMetadata.CreateMetadata(in jniEnvironmentContext);
                    Logger.MonoGameLogger.Default.Info("3");

                    var androidToast = new AndroidToastReference() { Jni = jniEnvironmentContext, Metadata = metadata };

                    androidToast.Show(instance, jniEnvironmentContext.JNI_ENV.ConvertStringUnicode(text), false);
                    Logger.MonoGameLogger.Default.Info("4");

                }
                catch (Exception ex)
                {
                    Logger.MonoGameLogger.Default.Error(ex);
                }
                return true;
                 
            }
            Logger.MonoGameLogger.Default.Info("11");
            return false;
        }

        readonly unsafe struct Ptr_Func_TestAction(TestActionDelegate ptr)
        {
            readonly TestActionDelegate _ptr = ptr;
            public static implicit operator nint(Ptr_Func_TestAction func) => (nint)func._ptr;
        }

 
    }
}
