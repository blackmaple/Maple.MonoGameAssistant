
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_JIT_INFO_GET_CODE_SIZE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_JIT_INFO_GET_CODE_SIZE(nint ptr)
    {
        //int MONO_JIT_INFO_GET_CODE_SIZE (void *jitinfo)
        //typedef int (__cdecl *MONO_JIT_INFO_GET_CODE_SIZE)(void *jitinfo);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoJITInfo, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoJITInfo, int>)ptr;
        public readonly int Invoke(PMonoJITInfo pMonoJITInfo) => _func(pMonoJITInfo);
        public static bool TryCreate(nint hModule, string name, out PMONO_JIT_INFO_GET_CODE_SIZE func)
        {
            Unsafe.SkipInit(out func);
            if (NativeLibrary.TryGetExport(hModule, name, out var address))
            {
                func = new(address);
                return true;
            }
            return false;
        }

    }


    internal readonly unsafe partial struct PMONO_JIT_INFO_GET_CODE_SIZE
    {
        public const string il2cpp = "il2cpp_jit_info_get_code_size";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_JIT_INFO_GET_CODE_SIZE func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_JIT_INFO_GET_CODE_SIZE
    {
        public const string mono = "mono_jit_info_get_code_size";
        public static bool TryCreate_MONO(nint hModule, out PMONO_JIT_INFO_GET_CODE_SIZE func)
            => TryCreate(hModule, mono, out func);
    }
    #endregion



}