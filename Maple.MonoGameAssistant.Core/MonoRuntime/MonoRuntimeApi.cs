using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    internal partial class MonoRuntimeApi(ILogger logger)
    {
        ILogger Logger { get; } = logger;

        #region MonoEnvironment
        public EnumMonoRuntimeType RuntimeType { get; private set; } = EnumMonoRuntimeType.UNKNOWN;

        #endregion



        #region Init RT
        static readonly string[] Static_DLL_Files = ["mono-2.0-bdwgc.dll", "GameAssembly.dll"];
        static IEnumerable<nint> GetCurrentProcessModuleHandles()
        {
            //加载默认的DLL
            foreach (var dll in Static_DLL_Files)
            {
                if (NativeLibrary.TryLoad(dll, out var hModule))
                {
                    yield return hModule;
                }
            }


            //遍历进程内部的所有模块句柄
            using var process = Process.GetCurrentProcess();
            foreach (ProcessModule m in process.Modules)
            {
                yield return m.BaseAddress;
            }

        }

        EnumMonoRuntimeType GetMonoRuntimeModuleHandle(out nint moduleHandle)
        {
            Unsafe.SkipInit(out moduleHandle);
            var runtimeType = EnumMonoRuntimeType.ERROR;
            foreach (var hModule in GetCurrentProcessModuleHandles())
            {
                if (TryCreate(hModule, PMONO_THREAD_ATTACH.mono, out PMONO_THREAD_ATTACH func))
                {
                    this.MONO_THREAD_ATTACH = func;
                    moduleHandle = hModule;
                    runtimeType = EnumMonoRuntimeType.MONO;
                }
                if (TryCreate(hModule, PMONO_THREAD_ATTACH.il2cpp, out func))
                {
                    this.MONO_THREAD_ATTACH = func;
                    moduleHandle = hModule;
                    runtimeType = EnumMonoRuntimeType.IL2CPP;
                }
                if (moduleHandle != nint.Zero)
                {
                    return runtimeType;
                }
            }
            return runtimeType;
        }
        private partial bool LoadMonoRuntime_MONO_Imp(nint hModule);
        private partial bool LoadMonoRuntime_IL2CPP_Imp(nint hModule);

        internal bool TryLoadMonoRuntimeApi()
        {
            if (this.RuntimeType == EnumMonoRuntimeType.UNKNOWN)
            {
                this.RuntimeType = GetMonoRuntimeModuleHandle(out var moduleHandle);
                return this.RuntimeType switch
                {
                    EnumMonoRuntimeType.MONO => LoadMonoRuntime_MONO_Imp(moduleHandle),
                    EnumMonoRuntimeType.IL2CPP => LoadMonoRuntime_IL2CPP_Imp(moduleHandle),
                    _ => false
                };
            }

            return this.RuntimeType != EnumMonoRuntimeType.ERROR;
        }



        private bool TryCreate<T_PTR_FUNC>(nint hModule, string name, out T_PTR_FUNC ptr_func)
            where T_PTR_FUNC : unmanaged
        {
            NativeLibrary.TryGetExport(hModule, name, out var address);
            this.Logger.LogInformation("{funcName}=>0x{address}", name, address.ToString("X8"));
            ptr_func = Unsafe.As<nint, T_PTR_FUNC>(ref address);
            return address != nint.Zero;
        }
        #endregion

    }




}
