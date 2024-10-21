using Maple.MonoGameAssistant.AndroidJNI;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Channels;
namespace Maple.MonoGameAssistant.AndroidCore.Api
{
    public class AndroidApiContext<T_ARG>(JavaVirtualMachineContext virtualMachineContext) where T_ARG : AndroidJniArgs, new()
    {
        public JavaVirtualMachineContext VirtualMachineContext { get; } = virtualMachineContext;
        public Channel<T_ARG> TaskChannel { get; } = Channel.CreateBounded<T_ARG>(new BoundedChannelOptions(128)
        {
            FullMode = BoundedChannelFullMode.Wait
        });

        public bool TryAddRequest(T_ARG arg)
        {
            return TaskChannel.Writer.TryWrite(arg);
        }



        public IAsyncEnumerable<T_ARG> ReadAllAsync()
        {
            return TaskChannel.Reader.ReadAllAsync();
        }



    }



    public static partial class AndroidApiExtensions
    {
        static AndroidApiContext<AndroidJniArgs>? ApiContext { get; set; }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad), CallConvs = [typeof(CallConvCdecl)])]
        public static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            var vmContext = new JavaVirtualMachineContext(javaVM);
            ApiContext = new AndroidApiContext<AndroidJniArgs>(vmContext);
            //DI
            return JavaVirtualMachineContext.JNI_VERSION_1_6;
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnUnload), CallConvs = [typeof(CallConvCdecl)])]
        public static void JNI_OnUnload(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            // ApiContext?.VirtualMachineContext.DetachThread();
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(ApiAction), CallConvs = [typeof(CallConvCdecl)])]
        public static JBOOLEAN ApiAction(PTR_JNI_ENV jniEnv, JOBJECT classIn, JSTRING actionName, JSTRING json)
        {
            if (ApiContext is not null)
            {
                ApiContext.TryAddRequest
            }
            return false;
        }

    }
}
