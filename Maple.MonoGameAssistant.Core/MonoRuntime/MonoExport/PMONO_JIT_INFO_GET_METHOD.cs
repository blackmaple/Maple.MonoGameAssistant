
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_JIT_INFO_GET_METHOD


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_JIT_INFO_GET_METHOD(nint ptr)
    {
        //nint MONO_JIT_INFO_GET_METHOD (void *jitinfo)
        //typedef void* (__cdecl *MONO_JIT_INFO_GET_METHOD)(void *jitinfo);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoJITInfo ,PMonoMethod> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoJITInfo, PMonoMethod>)ptr;
        public readonly PMonoMethod Invoke(PMonoJITInfo pMonoJITInfo) => _func(pMonoJITInfo);
        public static bool TryCreate(nint hModule, string name, out PMONO_JIT_INFO_GET_METHOD func)
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


    internal readonly unsafe partial struct PMONO_JIT_INFO_GET_METHOD
    {
        public const string il2cpp = "il2cpp_jit_info_get_method";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_JIT_INFO_GET_METHOD func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_JIT_INFO_GET_METHOD
    {
        public const string mono = "mono_jit_info_get_method";
        public static bool TryCreate_MONO(nint hModule, out PMONO_JIT_INFO_GET_METHOD func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}