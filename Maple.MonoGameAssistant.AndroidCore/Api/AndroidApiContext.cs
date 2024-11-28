using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
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

        public static AndroidApiContext CreateContext(PTR_JAVA_VM javaVM)
        {
            return new AndroidApiContext(new JavaVirtualMachineContext(javaVM));
        }

        public string? GameName { set; get; }

        public string? GameDesc { set; get; }
    }
}
