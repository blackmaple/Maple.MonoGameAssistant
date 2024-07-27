using Maple.GameContext;
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.MonoDataCollector
{
    internal class MonoDataCollectorWebApiService()
     : GameWebApi<MonoDataCollectorWebApiService, MonoDataCollectorService, MonoDataCollectorContext>("MonoDataCollector")
    {

        [ModuleInitializer]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2255:不应在库中使用 “ModuleInitializer” 属性", Justification = "<挂起>")]
        public static void Initializer()
        {
            //DllHijackExport.LoadApis();
            Initializer(8000);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hModule"></param>
        /// <param name="ul_reason_for_call"></param>
        /// <param name="lpReserved"></param>
        /// <returns></returns>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = nameof(DllMain))]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static bool DllMain(nint hModule, [MarshalAs(UnmanagedType.U4)] EnumReasonForCall ul_reason_for_call, nint lpReserved)
        {
            switch (ul_reason_for_call)
            {
                case EnumReasonForCall.DLL_PROCESS_ATTACH:
                    {
                        break;
                    }
                case EnumReasonForCall.DLL_THREAD_ATTACH:
                case EnumReasonForCall.DLL_THREAD_DETACH:
                case EnumReasonForCall.DLL_PROCESS_DETACH:
                    {
                        break;
                    }

            }
            return true;
        }

    }

}
