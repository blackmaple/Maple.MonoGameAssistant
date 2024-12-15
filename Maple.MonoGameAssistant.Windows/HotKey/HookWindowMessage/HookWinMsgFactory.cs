using System.Collections.Concurrent;

namespace Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage
{
    public class HookWinMsgFactory
    {
        ConcurrentDictionary<nint, HookWinMsgService> Cache { get; } = new ConcurrentDictionary<nint, HookWinMsgService>();

        public HookWinMsgService Create(nint hWnd) => Cache.GetOrAdd(hWnd, (key) => new HookWinMsgService(key));
        public HookWinMsgService Create()
        {
            using var currentProcess = System.Diagnostics.Process.GetCurrentProcess();
            var hWnd = currentProcess.MainWindowHandle;
            return Create(hWnd);
        }




    }

}
