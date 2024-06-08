using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.Core
{

    public struct MonoRuntimeAttachContext(MonoRuntimeContext runtimeContext) : IDisposable
    {
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        PMonoThread MonoThread { get; set; } = runtimeContext.AttachThread();
        public void Dispose()
        {
            var tmp = this.MonoThread;
            if (tmp.Valid())
            {
                this.MonoThread = nint.Zero;
                this.RuntimeContext.DetachThread(tmp);
            }
        }
    }
}
