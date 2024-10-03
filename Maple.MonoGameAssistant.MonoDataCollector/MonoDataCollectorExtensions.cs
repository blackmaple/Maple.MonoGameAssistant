using Maple.MonoGameAssistant.WebApi;
using Maple.MonoGameAssistant.WinApi;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Maple.MonoGameAssistant.GameContext;
using Maple.MonoGameAssistant.UITask;
using Maple.MonoGameAssistant.HookTask;

namespace Maple.MonoGameAssistant.MonoDataCollector
{
    internal static partial class MonoDataCollectorExtensions
    {
        internal static async Task RunWebApiServiceAsync(int millisecondsDelay = 8000)
        {
            var webapp = WebApiServiceExtensions.AsRunWebApiService(p =>
              {
                  p.GameName = "MonoDataCollector";
                  p.QQ = "0";
              }, services =>
              {
                  services.UseGameContextService<MonoDataCollectorService>();
              });

            //延迟启动
            await Task.Delay(millisecondsDelay).ConfigureAwait(false);
            await webapp.RunAsync().ConfigureAwait(false);

        }


        [ModuleInitializer]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2255:不应在库中使用 “ModuleInitializer” 属性", Justification = "<挂起>")]
        public static void Initializer()
        {
            _ = RunWebApiServiceAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hModule"></param>
        /// <param name="ul_reason_for_call"></param>
        /// <param name="lpReserved"></param>
        /// <returns></returns>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)], EntryPoint = nameof(DllMain))]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static bool DllMain(nint hModule, uint ul_reason_for_call, nint lpReserved)
        {
            return InitDllMain(hModule, ul_reason_for_call, lpReserved);
        }


        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("*")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool InitDllMain(nint hModule, uint ul_reason_for_call, nint lpReserved);

    }

}
