using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.WinApi;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.HotKey
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
