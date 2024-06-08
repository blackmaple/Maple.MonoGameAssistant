
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_JIT_INFO_GET_CODE_START


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_JIT_INFO_GET_CODE_START(nint ptr)
    {
        //nint MONO_JIT_INFO_GET_CODE_START (void *jitinfo)
        //typedef void* (__cdecl *MONO_JIT_INFO_GET_CODE_START)(void *jitinfo);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoJITInfo, PMonoAddress> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoJITInfo, PMonoAddress>)ptr;
        public readonly PMonoAddress Invoke(PMonoJITInfo pMonoJITInfo) => _func(pMonoJITInfo);
        public static bool TryCreate(nint hModule, string name, out PMONO_JIT_INFO_GET_CODE_START func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;

        }

    }


    internal readonly unsafe partial struct PMONO_JIT_INFO_GET_CODE_START
    {
        public const string il2cpp = "il2cpp_jit_info_get_code_start";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_JIT_INFO_GET_CODE_START func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_JIT_INFO_GET_CODE_START
    {
        public const string mono = "mono_jit_info_get_code_start";
        public static bool TryCreate_MONO(nint hModule, out PMONO_JIT_INFO_GET_CODE_START func)
            => TryCreate(hModule, mono, out func);
    }
    #endregion



}