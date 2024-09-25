using Maple.MonoGameAssistant.Logger;
using Maple.MonoGameAssistant.WinApi;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.DllExportTmp
{
    /*
    <ItemGroup>
		<Compile Include="..\Maple.MonoGameAssistant.DllExportTmp\DllExport.cs" Link="GameDllExport\DllExport.cs" />
		<AdditionalFiles Include="..\Maple.MonoGameAssistant.DllExportTmp\WinHttp.Api" Link="GameDllExport\WinHttp.Api" />
	</ItemGroup>
     */

    //    [DllHijack("WinHttp.Api", true, "WinHttp.dll")] 
    public static partial class DllExport
    {
        private static ILogger Logger { get; } = MonoGameLoggerExtensions.DefaultProvider.CreateLogger(typeof(DllExport).FullName ?? nameof(DllExport));

        private static nint GetModuleHandle(bool system, string dll)
        {
            var dllPath = system ? Environment.SystemDirectory : AppContext.BaseDirectory;
            var dllFileName = Path.Combine(dllPath, dll);
            if (NativeLibrary.TryLoad(dllFileName, out var hModule) == false)
            {
                Logger.LogInformation("NOT FOUND {dllFileName}", dllFileName);
            }
            return hModule;
        }
        private static nint GetProcAddress(nint hModule, string lpProcName)
        {
            if (NativeLibrary.TryGetExport(hModule, lpProcName, out var addr) == false)
            {
                Logger.LogInformation("NOT FOUND {lpProcName}", lpProcName);
            }
            return addr;
        }
        private static unsafe void Jump(delegate* unmanaged[Stdcall]<nint> _func, nint ptr_func)
        {
            if (ptr_func == nint.Zero)
            {
                return;
            }
            var code = (nint)_func;
            var codeSize = 32;
            WindowsRuntime.VirtualProtect(code, (nuint)codeSize, WindowsRuntime.EnumVirtualProtectType.PAGE_EXECUTE_READWRITE, out var lpflOldProtect);

            Cpu_Jmp_Addr((nuint)code, codeSize, (nuint)ptr_func);
            WindowsRuntime.VirtualProtect(code, (nuint)codeSize, lpflOldProtect, out var _);
        }
        private static unsafe int Cpu_Jmp_Addr(nuint pCode, int length, nuint addr)
        {
            return Environment.Is64BitProcess ? Cpu_Jmp_Addr_x64(pCode, length, addr) : Cpu_Jmp_Addr_x86(pCode, length, addr);
        }
        private static unsafe int Cpu_Jmp_Addr_x64(nuint pCode, int length, nuint addr)
        {
            var cpuCode = new Span<byte>(pCode.ToPointer(), length);
            const int Const_CpuCode_JmpNearSize = 2;
            var tmp_offset = (addr - pCode);
            var long_offset = (tmp_offset - Const_CpuCode_JmpNearSize).ToUInt64();
            if (long_offset <= byte.MaxValue)
            {
                const byte Const_CpuCode_Jmp = 0xEB;
                const byte Const_CpuCode_JmpIndex = 0;
                cpuCode[Const_CpuCode_JmpIndex] = Const_CpuCode_Jmp;

                const int Const_CpuCode_AddresIndex = 1;
                byte offset = (byte)(long_offset & byte.MaxValue);
                cpuCode[Const_CpuCode_AddresIndex] = offset;
                return Const_CpuCode_JmpNearSize;
            }

            const int Const_CpuCode_JmpCommonSize = 5;
            long_offset = (tmp_offset - Const_CpuCode_JmpCommonSize).ToUInt64();
            if (long_offset <= int.MaxValue)
            {
                const byte Const_CpuCode_Jmp = 0xE9;
                const byte Const_CpuCode_JmpIndex = 0;
                cpuCode[Const_CpuCode_JmpIndex] = Const_CpuCode_Jmp;

                uint offset = (uint)(long_offset & uint.MaxValue);
                const int Const_CpuCode_AddresIndex = 1;
                const int Const_CpuCode_AddresSize = 4;
                MemoryMarshal.Write(cpuCode.Slice(Const_CpuCode_AddresIndex, Const_CpuCode_AddresSize), offset);

                return Const_CpuCode_JmpCommonSize;
            }
            else
            {
                const ulong Const_CpuCode_Jmp = 0x25FFUL;
                //const byte Const_CpuCode_CallIndex = 0;
                //const byte Const_CpuCode_CallSize = 6;
                MemoryMarshal.Write(cpuCode, Const_CpuCode_Jmp);

                const int Const_CpuCode_AddresIndex = 6;
                const int Const_CpuCode_AddresSize = 8;
                MemoryMarshal.Write(cpuCode.Slice(Const_CpuCode_AddresIndex, Const_CpuCode_AddresSize), addr);
                const int Const_CpuCode_JmpFarSize = 14;
                return Const_CpuCode_JmpFarSize;


            }




        }
        private static unsafe int Cpu_Jmp_Addr_x86(nuint pCode, int length, nuint addr)
        {
            var cpuCode = new Span<byte>(pCode.ToPointer(), length);
            const int Const_CpuCode_JmpNearSize = 2;
            var tmp_offset = (addr - pCode);
            var long_offset = (tmp_offset - Const_CpuCode_JmpNearSize).ToUInt32();
            if (long_offset <= byte.MaxValue)
            {
                const byte Const_CpuCode_Jmp = 0xEB;
                const byte Const_CpuCode_JmpIndex = 0;
                cpuCode[Const_CpuCode_JmpIndex] = Const_CpuCode_Jmp;

                const int Const_CpuCode_AddresIndex = 1;
                byte offset = (byte)(long_offset & byte.MaxValue);
                cpuCode[Const_CpuCode_AddresIndex] = offset;
                return Const_CpuCode_JmpNearSize;
            }

            const int Const_CpuCode_JmpCommonSize = 5;
            long_offset = (tmp_offset - Const_CpuCode_JmpCommonSize).ToUInt32();
            if (long_offset <= uint.MaxValue)
            {
                const byte Const_CpuCode_Jmp = 0xE9;
                const byte Const_CpuCode_JmpIndex = 0;
                cpuCode[Const_CpuCode_JmpIndex] = Const_CpuCode_Jmp;

                uint offset = (uint)(long_offset & uint.MaxValue);
                const int Const_CpuCode_AddresIndex = 1;
                const int Const_CpuCode_AddresSize = 4;
                MemoryMarshal.Write(cpuCode.Slice(Const_CpuCode_AddresIndex, Const_CpuCode_AddresSize), offset);

                return Const_CpuCode_JmpCommonSize;
            }

            throw new InvalidOperationException("API ADDRESS ERROR");
            //else
            //{
            //    const ulong Const_CpuCode_Jmp = 0x25FFUL;
            //    //const byte Const_CpuCode_CallIndex = 0;
            //    //const byte Const_CpuCode_CallSize = 6;
            //    MemoryMarshal.Write(cpuCode, Const_CpuCode_Jmp);

            //    const int Const_CpuCode_AddresIndex = 6;
            //    const int Const_CpuCode_AddresSize = 8;
            //    MemoryMarshal.Write(cpuCode.Slice(Const_CpuCode_AddresIndex, Const_CpuCode_AddresSize), addr);
            //    const int Const_CpuCode_JmpFarSize = 14;
            //    return Const_CpuCode_JmpFarSize;


            //}




        }


    }

    public static partial class DllExport
    {



        [MethodImpl(MethodImplOptions.NoInlining)]
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = nameof(Test))]
        public static nint Test() => nint.Zero;

        /// <summary>
        /// Private1
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "Private1")]
        public static nint Private1() => nint.Zero;

        /// <summary>
        /// SvchostPushServiceGlobals
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = nameof(SvchostPushServiceGlobals2))]
        public static nint SvchostPushServiceGlobals2() => nint.Zero;

        /// <summary>
        /// WinHttpAddRequestHeaders
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpAddRequestHeaders")]
        public static nint WinHttpAddRequestHeaders() => nint.Zero;

        /// <summary>
        /// WinHttpAddRequestHeadersEx
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpAddRequestHeadersEx")]
        public static nint WinHttpAddRequestHeadersEx() => nint.Zero;

        /// <summary>
        /// WinHttpAutoProxySvcMain
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpAutoProxySvcMain")]
        public static nint WinHttpAutoProxySvcMain() => nint.Zero;

        /// <summary>
        /// WinHttpCheckPlatform
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpCheckPlatform")]
        public static nint WinHttpCheckPlatform() => nint.Zero;

        /// <summary>
        /// WinHttpCloseHandle
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpCloseHandle")]
        public static nint WinHttpCloseHandle() => nint.Zero;

        /// <summary>
        /// WinHttpConnect
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnect")]
        public static nint WinHttpConnect() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionDeletePolicyEntries
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionDeletePolicyEntries")]
        public static nint WinHttpConnectionDeletePolicyEntries() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionDeleteProxyInfo
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionDeleteProxyInfo")]
        public static nint WinHttpConnectionDeleteProxyInfo() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionFreeNameList
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionFreeNameList")]
        public static nint WinHttpConnectionFreeNameList() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionFreeProxyInfo
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionFreeProxyInfo")]
        public static nint WinHttpConnectionFreeProxyInfo() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionFreeProxyList
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionFreeProxyList")]
        public static nint WinHttpConnectionFreeProxyList() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionGetNameList
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionGetNameList")]
        public static nint WinHttpConnectionGetNameList() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionGetProxyInfo
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionGetProxyInfo")]
        public static nint WinHttpConnectionGetProxyInfo() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionGetProxyList
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionGetProxyList")]
        public static nint WinHttpConnectionGetProxyList() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionOnlyConvert
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionOnlyConvert")]
        public static nint WinHttpConnectionOnlyConvert() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionOnlyReceive
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionOnlyReceive")]
        public static nint WinHttpConnectionOnlyReceive() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionOnlySend
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionOnlySend")]
        public static nint WinHttpConnectionOnlySend() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionSetPolicyEntries
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionSetPolicyEntries")]
        public static nint WinHttpConnectionSetPolicyEntries() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionSetProxyInfo
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionSetProxyInfo")]
        public static nint WinHttpConnectionSetProxyInfo() => nint.Zero;

        /// <summary>
        /// WinHttpConnectionUpdateIfIndexTable
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpConnectionUpdateIfIndexTable")]
        public static nint WinHttpConnectionUpdateIfIndexTable() => nint.Zero;

        /// <summary>
        /// WinHttpCrackUrl
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpCrackUrl")]
        public static nint WinHttpCrackUrl() => nint.Zero;

        /// <summary>
        /// WinHttpCreateProxyResolver
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpCreateProxyResolver")]
        public static nint WinHttpCreateProxyResolver() => nint.Zero;

        /// <summary>
        /// WinHttpCreateUrl
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpCreateUrl")]
        public static nint WinHttpCreateUrl() => nint.Zero;

        /// <summary>
        /// WinHttpDetectAutoProxyConfigUrl
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpDetectAutoProxyConfigUrl")]
        public static nint WinHttpDetectAutoProxyConfigUrl() => nint.Zero;

        /// <summary>
        /// WinHttpFreeProxyResult
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpFreeProxyResult")]
        public static nint WinHttpFreeProxyResult() => nint.Zero;

        /// <summary>
        /// WinHttpFreeProxyResultEx
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpFreeProxyResultEx")]
        public static nint WinHttpFreeProxyResultEx() => nint.Zero;

        /// <summary>
        /// WinHttpFreeProxySettings
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpFreeProxySettings")]
        public static nint WinHttpFreeProxySettings() => nint.Zero;

        /// <summary>
        /// WinHttpFreeProxySettingsEx
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpFreeProxySettingsEx")]
        public static nint WinHttpFreeProxySettingsEx() => nint.Zero;

        /// <summary>
        /// WinHttpFreeQueryConnectionGroupResult
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpFreeQueryConnectionGroupResult")]
        public static nint WinHttpFreeQueryConnectionGroupResult() => nint.Zero;

        /// <summary>
        /// WinHttpGetDefaultProxyConfiguration
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetDefaultProxyConfiguration")]
        public static nint WinHttpGetDefaultProxyConfiguration() => nint.Zero;

        /// <summary>
        /// WinHttpGetIEProxyConfigForCurrentUser
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetIEProxyConfigForCurrentUser")]
        public static nint WinHttpGetIEProxyConfigForCurrentUser() => nint.Zero;

        /// <summary>
        /// WinHttpGetProxyForUrl
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetProxyForUrl")]
        public static nint WinHttpGetProxyForUrl() => nint.Zero;

        /// <summary>
        /// WinHttpGetProxyForUrlEx
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetProxyForUrlEx")]
        public static nint WinHttpGetProxyForUrlEx() => nint.Zero;

        /// <summary>
        /// WinHttpGetProxyForUrlEx2
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetProxyForUrlEx2")]
        public static nint WinHttpGetProxyForUrlEx2() => nint.Zero;

        /// <summary>
        /// WinHttpGetProxyForUrlHvsi
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetProxyForUrlHvsi")]
        public static nint WinHttpGetProxyForUrlHvsi() => nint.Zero;

        /// <summary>
        /// WinHttpGetProxyResult
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetProxyResult")]
        public static nint WinHttpGetProxyResult() => nint.Zero;

        /// <summary>
        /// WinHttpGetProxyResultEx
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetProxyResultEx")]
        public static nint WinHttpGetProxyResultEx() => nint.Zero;

        /// <summary>
        /// WinHttpGetProxySettingsEx
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetProxySettingsEx")]
        public static nint WinHttpGetProxySettingsEx() => nint.Zero;

        /// <summary>
        /// WinHttpGetProxySettingsResultEx
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetProxySettingsResultEx")]
        public static nint WinHttpGetProxySettingsResultEx() => nint.Zero;

        /// <summary>
        /// WinHttpGetProxySettingsVersion
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetProxySettingsVersion")]
        public static nint WinHttpGetProxySettingsVersion() => nint.Zero;

        /// <summary>
        /// WinHttpGetTunnelSocket
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpGetTunnelSocket")]
        public static nint WinHttpGetTunnelSocket() => nint.Zero;

        /// <summary>
        /// WinHttpOpen
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpOpen")]
        public static nint WinHttpOpen() => nint.Zero;

        /// <summary>
        /// WinHttpOpenRequest
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpOpenRequest")]
        public static nint WinHttpOpenRequest() => nint.Zero;

        /// <summary>
        /// WinHttpPacJsWorkerMain
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpPacJsWorkerMain")]
        public static nint WinHttpPacJsWorkerMain() => nint.Zero;

        /// <summary>
        /// WinHttpProbeConnectivity
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpProbeConnectivity")]
        public static nint WinHttpProbeConnectivity() => nint.Zero;

        /// <summary>
        /// WinHttpQueryAuthSchemes
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpQueryAuthSchemes")]
        public static nint WinHttpQueryAuthSchemes() => nint.Zero;

        /// <summary>
        /// WinHttpQueryConnectionGroup
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpQueryConnectionGroup")]
        public static nint WinHttpQueryConnectionGroup() => nint.Zero;

        /// <summary>
        /// WinHttpQueryDataAvailable
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpQueryDataAvailable")]
        public static nint WinHttpQueryDataAvailable() => nint.Zero;

        /// <summary>
        /// WinHttpQueryHeaders
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpQueryHeaders")]
        public static nint WinHttpQueryHeaders() => nint.Zero;

        /// <summary>
        /// WinHttpQueryHeadersEx
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpQueryHeadersEx")]
        public static nint WinHttpQueryHeadersEx() => nint.Zero;

        /// <summary>
        /// WinHttpQueryOption
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpQueryOption")]
        public static nint WinHttpQueryOption() => nint.Zero;

        /// <summary>
        /// WinHttpReadData
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpReadData")]
        public static nint WinHttpReadData() => nint.Zero;

        /// <summary>
        /// WinHttpReadDataEx
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpReadDataEx")]
        public static nint WinHttpReadDataEx() => nint.Zero;

        /// <summary>
        /// WinHttpReadProxySettings
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpReadProxySettings")]
        public static nint WinHttpReadProxySettings() => nint.Zero;

        /// <summary>
        /// WinHttpReadProxySettingsHvsi
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpReadProxySettingsHvsi")]
        public static nint WinHttpReadProxySettingsHvsi() => nint.Zero;

        /// <summary>
        /// WinHttpReceiveResponse
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpReceiveResponse")]
        public static nint WinHttpReceiveResponse() => nint.Zero;

        /// <summary>
        /// WinHttpRegisterProxyChangeNotification
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpRegisterProxyChangeNotification")]
        public static nint WinHttpRegisterProxyChangeNotification() => nint.Zero;

        /// <summary>
        /// WinHttpResetAutoProxy
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpResetAutoProxy")]
        public static nint WinHttpResetAutoProxy() => nint.Zero;

        /// <summary>
        /// WinHttpSaveProxyCredentials
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpSaveProxyCredentials")]
        public static nint WinHttpSaveProxyCredentials() => nint.Zero;

        /// <summary>
        /// WinHttpSendRequest
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpSendRequest")]
        public static nint WinHttpSendRequest() => nint.Zero;

        /// <summary>
        /// WinHttpSetCredentials
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpSetCredentials")]
        public static nint WinHttpSetCredentials() => nint.Zero;

        /// <summary>
        /// WinHttpSetDefaultProxyConfiguration
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpSetDefaultProxyConfiguration")]
        public static nint WinHttpSetDefaultProxyConfiguration() => nint.Zero;

        /// <summary>
        /// WinHttpSetOption
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpSetOption")]
        public static nint WinHttpSetOption() => nint.Zero;

        /// <summary>
        /// WinHttpSetProxySettingsPerUser
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpSetProxySettingsPerUser")]
        public static nint WinHttpSetProxySettingsPerUser() => nint.Zero;

        /// <summary>
        /// WinHttpSetSecureLegacyServersAppCompat
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpSetSecureLegacyServersAppCompat")]
        public static nint WinHttpSetSecureLegacyServersAppCompat() => nint.Zero;

        /// <summary>
        /// WinHttpSetStatusCallback
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpSetStatusCallback")]
        public static nint WinHttpSetStatusCallback() => nint.Zero;

        /// <summary>
        /// WinHttpSetTimeouts
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpSetTimeouts")]
        public static nint WinHttpSetTimeouts() => nint.Zero;

        /// <summary>
        /// WinHttpTimeFromSystemTime
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpTimeFromSystemTime")]
        public static nint WinHttpTimeFromSystemTime() => nint.Zero;

        /// <summary>
        /// WinHttpTimeToSystemTime
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpTimeToSystemTime")]
        public static nint WinHttpTimeToSystemTime() => nint.Zero;

        /// <summary>
        /// WinHttpUnregisterProxyChangeNotification
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpUnregisterProxyChangeNotification")]
        public static nint WinHttpUnregisterProxyChangeNotification() => nint.Zero;

        /// <summary>
        /// WinHttpWebSocketClose
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpWebSocketClose")]
        public static nint WinHttpWebSocketClose() => nint.Zero;

        /// <summary>
        /// WinHttpWebSocketCompleteUpgrade
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpWebSocketCompleteUpgrade")]
        public static nint WinHttpWebSocketCompleteUpgrade() => nint.Zero;

        /// <summary>
        /// WinHttpWebSocketQueryCloseStatus
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpWebSocketQueryCloseStatus")]
        public static nint WinHttpWebSocketQueryCloseStatus() => nint.Zero;

        /// <summary>
        /// WinHttpWebSocketReceive
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpWebSocketReceive")]
        public static nint WinHttpWebSocketReceive() => nint.Zero;

        /// <summary>
        /// WinHttpWebSocketSend
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpWebSocketSend")]
        public static nint WinHttpWebSocketSend() => nint.Zero;

        /// <summary>
        /// WinHttpWebSocketShutdown
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpWebSocketShutdown")]
        public static nint WinHttpWebSocketShutdown() => nint.Zero;

        /// <summary>
        /// WinHttpWriteData
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpWriteData")]
        public static nint WinHttpWriteData() => nint.Zero;

        /// <summary>
        /// WinHttpWriteProxySettings
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = "WinHttpWriteProxySettings")]
        public static nint WinHttpWriteProxySettings() => nint.Zero;


        public static unsafe void LoadApis()
        {
            var hModule = GetModuleHandle(true, "WinHttp.dll");


            var ptr_Private1 = GetProcAddress(hModule, "Private1");
            Jump(&Private1, ptr_Private1);


            var ptr_SvchostPushServiceGlobals = GetProcAddress(hModule, "SvchostPushServiceGlobals2");
            Jump(&SvchostPushServiceGlobals2, ptr_SvchostPushServiceGlobals);


            var ptr_WinHttpAddRequestHeaders = GetProcAddress(hModule, "WinHttpAddRequestHeaders");
            Jump(&WinHttpAddRequestHeaders, ptr_WinHttpAddRequestHeaders);


            var ptr_WinHttpAddRequestHeadersEx = GetProcAddress(hModule, "WinHttpAddRequestHeadersEx");
            Jump(&WinHttpAddRequestHeadersEx, ptr_WinHttpAddRequestHeadersEx);


            var ptr_WinHttpAutoProxySvcMain = GetProcAddress(hModule, "WinHttpAutoProxySvcMain");
            Jump(&WinHttpAutoProxySvcMain, ptr_WinHttpAutoProxySvcMain);


            var ptr_WinHttpCheckPlatform = GetProcAddress(hModule, "WinHttpCheckPlatform");
            Jump(&WinHttpCheckPlatform, ptr_WinHttpCheckPlatform);


            var ptr_WinHttpCloseHandle = GetProcAddress(hModule, "WinHttpCloseHandle");
            Jump(&WinHttpCloseHandle, ptr_WinHttpCloseHandle);


            var ptr_WinHttpConnect = GetProcAddress(hModule, "WinHttpConnect");
            Jump(&WinHttpConnect, ptr_WinHttpConnect);


            var ptr_WinHttpConnectionDeletePolicyEntries = GetProcAddress(hModule, "WinHttpConnectionDeletePolicyEntries");
            Jump(&WinHttpConnectionDeletePolicyEntries, ptr_WinHttpConnectionDeletePolicyEntries);


            var ptr_WinHttpConnectionDeleteProxyInfo = GetProcAddress(hModule, "WinHttpConnectionDeleteProxyInfo");
            Jump(&WinHttpConnectionDeleteProxyInfo, ptr_WinHttpConnectionDeleteProxyInfo);


            var ptr_WinHttpConnectionFreeNameList = GetProcAddress(hModule, "WinHttpConnectionFreeNameList");
            Jump(&WinHttpConnectionFreeNameList, ptr_WinHttpConnectionFreeNameList);


            var ptr_WinHttpConnectionFreeProxyInfo = GetProcAddress(hModule, "WinHttpConnectionFreeProxyInfo");
            Jump(&WinHttpConnectionFreeProxyInfo, ptr_WinHttpConnectionFreeProxyInfo);


            var ptr_WinHttpConnectionFreeProxyList = GetProcAddress(hModule, "WinHttpConnectionFreeProxyList");
            Jump(&WinHttpConnectionFreeProxyList, ptr_WinHttpConnectionFreeProxyList);


            var ptr_WinHttpConnectionGetNameList = GetProcAddress(hModule, "WinHttpConnectionGetNameList");
            Jump(&WinHttpConnectionGetNameList, ptr_WinHttpConnectionGetNameList);


            var ptr_WinHttpConnectionGetProxyInfo = GetProcAddress(hModule, "WinHttpConnectionGetProxyInfo");
            Jump(&WinHttpConnectionGetProxyInfo, ptr_WinHttpConnectionGetProxyInfo);


            var ptr_WinHttpConnectionGetProxyList = GetProcAddress(hModule, "WinHttpConnectionGetProxyList");
            Jump(&WinHttpConnectionGetProxyList, ptr_WinHttpConnectionGetProxyList);


            var ptr_WinHttpConnectionOnlyConvert = GetProcAddress(hModule, "WinHttpConnectionOnlyConvert");
            Jump(&WinHttpConnectionOnlyConvert, ptr_WinHttpConnectionOnlyConvert);


            var ptr_WinHttpConnectionOnlyReceive = GetProcAddress(hModule, "WinHttpConnectionOnlyReceive");
            Jump(&WinHttpConnectionOnlyReceive, ptr_WinHttpConnectionOnlyReceive);


            var ptr_WinHttpConnectionOnlySend = GetProcAddress(hModule, "WinHttpConnectionOnlySend");
            Jump(&WinHttpConnectionOnlySend, ptr_WinHttpConnectionOnlySend);


            var ptr_WinHttpConnectionSetPolicyEntries = GetProcAddress(hModule, "WinHttpConnectionSetPolicyEntries");
            Jump(&WinHttpConnectionSetPolicyEntries, ptr_WinHttpConnectionSetPolicyEntries);


            var ptr_WinHttpConnectionSetProxyInfo = GetProcAddress(hModule, "WinHttpConnectionSetProxyInfo");
            Jump(&WinHttpConnectionSetProxyInfo, ptr_WinHttpConnectionSetProxyInfo);


            var ptr_WinHttpConnectionUpdateIfIndexTable = GetProcAddress(hModule, "WinHttpConnectionUpdateIfIndexTable");
            Jump(&WinHttpConnectionUpdateIfIndexTable, ptr_WinHttpConnectionUpdateIfIndexTable);


            var ptr_WinHttpCrackUrl = GetProcAddress(hModule, "WinHttpCrackUrl");
            Jump(&WinHttpCrackUrl, ptr_WinHttpCrackUrl);


            var ptr_WinHttpCreateProxyResolver = GetProcAddress(hModule, "WinHttpCreateProxyResolver");
            Jump(&WinHttpCreateProxyResolver, ptr_WinHttpCreateProxyResolver);


            var ptr_WinHttpCreateUrl = GetProcAddress(hModule, "WinHttpCreateUrl");
            Jump(&WinHttpCreateUrl, ptr_WinHttpCreateUrl);


            var ptr_WinHttpDetectAutoProxyConfigUrl = GetProcAddress(hModule, "WinHttpDetectAutoProxyConfigUrl");
            Jump(&WinHttpDetectAutoProxyConfigUrl, ptr_WinHttpDetectAutoProxyConfigUrl);


            var ptr_WinHttpFreeProxyResult = GetProcAddress(hModule, "WinHttpFreeProxyResult");
            Jump(&WinHttpFreeProxyResult, ptr_WinHttpFreeProxyResult);


            var ptr_WinHttpFreeProxyResultEx = GetProcAddress(hModule, "WinHttpFreeProxyResultEx");
            Jump(&WinHttpFreeProxyResultEx, ptr_WinHttpFreeProxyResultEx);


            var ptr_WinHttpFreeProxySettings = GetProcAddress(hModule, "WinHttpFreeProxySettings");
            Jump(&WinHttpFreeProxySettings, ptr_WinHttpFreeProxySettings);


            var ptr_WinHttpFreeProxySettingsEx = GetProcAddress(hModule, "WinHttpFreeProxySettingsEx");
            Jump(&WinHttpFreeProxySettingsEx, ptr_WinHttpFreeProxySettingsEx);


            var ptr_WinHttpFreeQueryConnectionGroupResult = GetProcAddress(hModule, "WinHttpFreeQueryConnectionGroupResult");
            Jump(&WinHttpFreeQueryConnectionGroupResult, ptr_WinHttpFreeQueryConnectionGroupResult);


            var ptr_WinHttpGetDefaultProxyConfiguration = GetProcAddress(hModule, "WinHttpGetDefaultProxyConfiguration");
            Jump(&WinHttpGetDefaultProxyConfiguration, ptr_WinHttpGetDefaultProxyConfiguration);


            var ptr_WinHttpGetIEProxyConfigForCurrentUser = GetProcAddress(hModule, "WinHttpGetIEProxyConfigForCurrentUser");
            Jump(&WinHttpGetIEProxyConfigForCurrentUser, ptr_WinHttpGetIEProxyConfigForCurrentUser);


            var ptr_WinHttpGetProxyForUrl = GetProcAddress(hModule, "WinHttpGetProxyForUrl");
            Jump(&WinHttpGetProxyForUrl, ptr_WinHttpGetProxyForUrl);


            var ptr_WinHttpGetProxyForUrlEx = GetProcAddress(hModule, "WinHttpGetProxyForUrlEx");
            Jump(&WinHttpGetProxyForUrlEx, ptr_WinHttpGetProxyForUrlEx);


            var ptr_WinHttpGetProxyForUrlEx2 = GetProcAddress(hModule, "WinHttpGetProxyForUrlEx2");
            Jump(&WinHttpGetProxyForUrlEx2, ptr_WinHttpGetProxyForUrlEx2);


            var ptr_WinHttpGetProxyForUrlHvsi = GetProcAddress(hModule, "WinHttpGetProxyForUrlHvsi");
            Jump(&WinHttpGetProxyForUrlHvsi, ptr_WinHttpGetProxyForUrlHvsi);


            var ptr_WinHttpGetProxyResult = GetProcAddress(hModule, "WinHttpGetProxyResult");
            Jump(&WinHttpGetProxyResult, ptr_WinHttpGetProxyResult);


            var ptr_WinHttpGetProxyResultEx = GetProcAddress(hModule, "WinHttpGetProxyResultEx");
            Jump(&WinHttpGetProxyResultEx, ptr_WinHttpGetProxyResultEx);


            var ptr_WinHttpGetProxySettingsEx = GetProcAddress(hModule, "WinHttpGetProxySettingsEx");
            Jump(&WinHttpGetProxySettingsEx, ptr_WinHttpGetProxySettingsEx);


            var ptr_WinHttpGetProxySettingsResultEx = GetProcAddress(hModule, "WinHttpGetProxySettingsResultEx");
            Jump(&WinHttpGetProxySettingsResultEx, ptr_WinHttpGetProxySettingsResultEx);


            var ptr_WinHttpGetProxySettingsVersion = GetProcAddress(hModule, "WinHttpGetProxySettingsVersion");
            Jump(&WinHttpGetProxySettingsVersion, ptr_WinHttpGetProxySettingsVersion);


            var ptr_WinHttpGetTunnelSocket = GetProcAddress(hModule, "WinHttpGetTunnelSocket");
            Jump(&WinHttpGetTunnelSocket, ptr_WinHttpGetTunnelSocket);


            var ptr_WinHttpOpen = GetProcAddress(hModule, "WinHttpOpen");
            Jump(&WinHttpOpen, ptr_WinHttpOpen);


            var ptr_WinHttpOpenRequest = GetProcAddress(hModule, "WinHttpOpenRequest");
            Jump(&WinHttpOpenRequest, ptr_WinHttpOpenRequest);


            var ptr_WinHttpPacJsWorkerMain = GetProcAddress(hModule, "WinHttpPacJsWorkerMain");
            Jump(&WinHttpPacJsWorkerMain, ptr_WinHttpPacJsWorkerMain);


            var ptr_WinHttpProbeConnectivity = GetProcAddress(hModule, "WinHttpProbeConnectivity");
            Jump(&WinHttpProbeConnectivity, ptr_WinHttpProbeConnectivity);


            var ptr_WinHttpQueryAuthSchemes = GetProcAddress(hModule, "WinHttpQueryAuthSchemes");
            Jump(&WinHttpQueryAuthSchemes, ptr_WinHttpQueryAuthSchemes);


            var ptr_WinHttpQueryConnectionGroup = GetProcAddress(hModule, "WinHttpQueryConnectionGroup");
            Jump(&WinHttpQueryConnectionGroup, ptr_WinHttpQueryConnectionGroup);


            var ptr_WinHttpQueryDataAvailable = GetProcAddress(hModule, "WinHttpQueryDataAvailable");
            Jump(&WinHttpQueryDataAvailable, ptr_WinHttpQueryDataAvailable);


            var ptr_WinHttpQueryHeaders = GetProcAddress(hModule, "WinHttpQueryHeaders");
            Jump(&WinHttpQueryHeaders, ptr_WinHttpQueryHeaders);


            var ptr_WinHttpQueryHeadersEx = GetProcAddress(hModule, "WinHttpQueryHeadersEx");
            Jump(&WinHttpQueryHeadersEx, ptr_WinHttpQueryHeadersEx);


            var ptr_WinHttpQueryOption = GetProcAddress(hModule, "WinHttpQueryOption");
            Jump(&WinHttpQueryOption, ptr_WinHttpQueryOption);


            var ptr_WinHttpReadData = GetProcAddress(hModule, "WinHttpReadData");
            Jump(&WinHttpReadData, ptr_WinHttpReadData);


            var ptr_WinHttpReadDataEx = GetProcAddress(hModule, "WinHttpReadDataEx");
            Jump(&WinHttpReadDataEx, ptr_WinHttpReadDataEx);


            var ptr_WinHttpReadProxySettings = GetProcAddress(hModule, "WinHttpReadProxySettings");
            Jump(&WinHttpReadProxySettings, ptr_WinHttpReadProxySettings);


            var ptr_WinHttpReadProxySettingsHvsi = GetProcAddress(hModule, "WinHttpReadProxySettingsHvsi");
            Jump(&WinHttpReadProxySettingsHvsi, ptr_WinHttpReadProxySettingsHvsi);


            var ptr_WinHttpReceiveResponse = GetProcAddress(hModule, "WinHttpReceiveResponse");
            Jump(&WinHttpReceiveResponse, ptr_WinHttpReceiveResponse);


            var ptr_WinHttpRegisterProxyChangeNotification = GetProcAddress(hModule, "WinHttpRegisterProxyChangeNotification");
            Jump(&WinHttpRegisterProxyChangeNotification, ptr_WinHttpRegisterProxyChangeNotification);


            var ptr_WinHttpResetAutoProxy = GetProcAddress(hModule, "WinHttpResetAutoProxy");
            Jump(&WinHttpResetAutoProxy, ptr_WinHttpResetAutoProxy);


            var ptr_WinHttpSaveProxyCredentials = GetProcAddress(hModule, "WinHttpSaveProxyCredentials");
            Jump(&WinHttpSaveProxyCredentials, ptr_WinHttpSaveProxyCredentials);


            var ptr_WinHttpSendRequest = GetProcAddress(hModule, "WinHttpSendRequest");
            Jump(&WinHttpSendRequest, ptr_WinHttpSendRequest);


            var ptr_WinHttpSetCredentials = GetProcAddress(hModule, "WinHttpSetCredentials");
            Jump(&WinHttpSetCredentials, ptr_WinHttpSetCredentials);


            var ptr_WinHttpSetDefaultProxyConfiguration = GetProcAddress(hModule, "WinHttpSetDefaultProxyConfiguration");
            Jump(&WinHttpSetDefaultProxyConfiguration, ptr_WinHttpSetDefaultProxyConfiguration);


            var ptr_WinHttpSetOption = GetProcAddress(hModule, "WinHttpSetOption");
            Jump(&WinHttpSetOption, ptr_WinHttpSetOption);


            var ptr_WinHttpSetProxySettingsPerUser = GetProcAddress(hModule, "WinHttpSetProxySettingsPerUser");
            Jump(&WinHttpSetProxySettingsPerUser, ptr_WinHttpSetProxySettingsPerUser);


            var ptr_WinHttpSetSecureLegacyServersAppCompat = GetProcAddress(hModule, "WinHttpSetSecureLegacyServersAppCompat");
            Jump(&WinHttpSetSecureLegacyServersAppCompat, ptr_WinHttpSetSecureLegacyServersAppCompat);


            var ptr_WinHttpSetStatusCallback = GetProcAddress(hModule, "WinHttpSetStatusCallback");
            Jump(&WinHttpSetStatusCallback, ptr_WinHttpSetStatusCallback);


            var ptr_WinHttpSetTimeouts = GetProcAddress(hModule, "WinHttpSetTimeouts");
            Jump(&WinHttpSetTimeouts, ptr_WinHttpSetTimeouts);


            var ptr_WinHttpTimeFromSystemTime = GetProcAddress(hModule, "WinHttpTimeFromSystemTime");
            Jump(&WinHttpTimeFromSystemTime, ptr_WinHttpTimeFromSystemTime);


            var ptr_WinHttpTimeToSystemTime = GetProcAddress(hModule, "WinHttpTimeToSystemTime");
            Jump(&WinHttpTimeToSystemTime, ptr_WinHttpTimeToSystemTime);


            var ptr_WinHttpUnregisterProxyChangeNotification = GetProcAddress(hModule, "WinHttpUnregisterProxyChangeNotification");
            Jump(&WinHttpUnregisterProxyChangeNotification, ptr_WinHttpUnregisterProxyChangeNotification);


            var ptr_WinHttpWebSocketClose = GetProcAddress(hModule, "WinHttpWebSocketClose");
            Jump(&WinHttpWebSocketClose, ptr_WinHttpWebSocketClose);


            var ptr_WinHttpWebSocketCompleteUpgrade = GetProcAddress(hModule, "WinHttpWebSocketCompleteUpgrade");
            Jump(&WinHttpWebSocketCompleteUpgrade, ptr_WinHttpWebSocketCompleteUpgrade);


            var ptr_WinHttpWebSocketQueryCloseStatus = GetProcAddress(hModule, "WinHttpWebSocketQueryCloseStatus");
            Jump(&WinHttpWebSocketQueryCloseStatus, ptr_WinHttpWebSocketQueryCloseStatus);


            var ptr_WinHttpWebSocketReceive = GetProcAddress(hModule, "WinHttpWebSocketReceive");
            Jump(&WinHttpWebSocketReceive, ptr_WinHttpWebSocketReceive);


            var ptr_WinHttpWebSocketSend = GetProcAddress(hModule, "WinHttpWebSocketSend");
            Jump(&WinHttpWebSocketSend, ptr_WinHttpWebSocketSend);


            var ptr_WinHttpWebSocketShutdown = GetProcAddress(hModule, "WinHttpWebSocketShutdown");
            Jump(&WinHttpWebSocketShutdown, ptr_WinHttpWebSocketShutdown);


            var ptr_WinHttpWriteData = GetProcAddress(hModule, "WinHttpWriteData");
            Jump(&WinHttpWriteData, ptr_WinHttpWriteData);


            var ptr_WinHttpWriteProxySettings = GetProcAddress(hModule, "WinHttpWriteProxySettings");
            Jump(&WinHttpWriteProxySettings, ptr_WinHttpWriteProxySettings);

        }


    }

}
