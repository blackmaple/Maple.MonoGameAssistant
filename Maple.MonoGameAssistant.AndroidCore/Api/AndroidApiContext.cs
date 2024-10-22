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
    public class AndroidApiContext (JavaVirtualMachineContext virtualMachineContext)  
    {
        public JavaVirtualMachineContext VirtualMachineContext { get; } = virtualMachineContext;
        public Channel<AndroidApiArgs> TaskChannel { get; } = Channel.CreateBounded<AndroidApiArgs>(new BoundedChannelOptions(128)
        {
            FullMode = BoundedChannelFullMode.Wait
        });

        public bool TryWrite(AndroidApiArgs arg)
        {
            return TaskChannel.Writer.TryWrite(arg);
        }

        public IAsyncEnumerable<AndroidApiArgs> ReadAllAsync( )
        {
            return TaskChannel.Reader.ReadAllAsync();
        }

        public bool TryComplete()
        {
            return TaskChannel.Writer.TryComplete();
        }

    }



    public static partial class AndroidApiExtensions
    {
        static AndroidApiContext? ApiContext { get; set; }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad), CallConvs = [typeof(CallConvCdecl)])]
        public static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            var vmContext = new JavaVirtualMachineContext(javaVM);
            ApiContext = new AndroidApiContext(vmContext);
            //DI
            return JavaVirtualMachineContext.JNI_VERSION_1_6;
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnUnload), CallConvs = [typeof(CallConvCdecl)])]
        public static void JNI_OnUnload(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            // ApiContext?.VirtualMachineContext.DetachThread();
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(ApiAction), CallConvs = [typeof(CallConvCdecl)])]
        public static JBOOLEAN ApiAction(PTR_JNI_ENV jniEnv, JOBJECT classIn )
        {
            //if (ApiContext is not null)
            //{
            //    ApiContext.TryAddRequest
            //}
            return false;
        }

    }
}
