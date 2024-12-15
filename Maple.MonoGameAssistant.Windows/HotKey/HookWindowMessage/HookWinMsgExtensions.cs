using Microsoft.Extensions.DependencyInjection;

namespace Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage
{
    public static class HookWinMsgExtensions
    {

        //[Obsolete("remove...")]
        //public static IHookWinMsgService CreateHookWinMsgService()
        //{
        //    using var currentProcess = System.Diagnostics.Process.GetCurrentProcess();
        //    var hWnd = currentProcess.MainWindowHandle;
        //    return new HookWinMsgService(hWnd);
        //}

        public static IServiceCollection AddHookWinMsgFactory(this IServiceCollection serviceDescriptors)
        {
            return serviceDescriptors.AddSingleton<HookWinMsgFactory>();
        }

    }

}
