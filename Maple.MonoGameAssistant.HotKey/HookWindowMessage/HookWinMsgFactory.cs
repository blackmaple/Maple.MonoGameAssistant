using Maple.MonoGameAssistant.HotKey.Abstractions;
using System.Collections.Concurrent;

namespace Maple.MonoGameAssistant.HotKey
{
    public class HookWinMsgFactory
    {
        ConcurrentDictionary<nint, HookWinMsgService> Cache { get; } = new ConcurrentDictionary<nint, HookWinMsgService>();

        public IHookWinMsgService Create(nint hWnd) => this.Cache.GetOrAdd(hWnd, (key) => new HookWinMsgService(key));
        public IHookWinMsgService Create()
        {
            using var currentProcess = System.Diagnostics.Process.GetCurrentProcess();
            var hWnd = currentProcess.MainWindowHandle;
            return Create(hWnd);
        }




    }

}
