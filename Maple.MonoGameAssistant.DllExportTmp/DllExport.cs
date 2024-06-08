using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.DllHijackData;
using Maple.MonoGameAssistant.Logger;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.DllExportTmp
{
    /*
    <ItemGroup>
		<Compile Include="..\Maple.MonoGameAssistant.DllExportTmp\DllExport.cs" Link="GameDllExport\DllExport.cs" />
		<AdditionalFiles Include="..\Maple.MonoGameAssistant.DllExportTmp\WinHttp.Api" Link="GameDllExport\WinHttp.Api" />
	</ItemGroup>
     */
    [DllHijack("WinHttp.Api", true, "WinHttp.dll")]
    public static partial class DllExport
    {
        private static ILogger Logger { get; } = MonoLoggerExtensions.DefaultProvider.CreateLogger(typeof(DllExport).FullName ?? nameof(DllExport));

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
            WinApi.VirtualProtect(code, (nuint)codeSize, WinApi.EnumVirtualProtectType.PAGE_EXECUTE_READWRITE, out var lpflOldProtect);

            Cpu_Jmp_Addr((nuint)code, codeSize, (nuint)ptr_func);
            WinApi.VirtualProtect(code, (nuint)codeSize, lpflOldProtect, out var _);
        }
        private static unsafe int Cpu_Jmp_Addr(nuint pCode, int length, nuint addr)
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


    }
}
