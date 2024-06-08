
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_JIT_INFO_TABLE_FIND


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_JIT_INFO_TABLE_FIND(nint ptr)
    {
        //nint MONO_JIT_INFO_TABLE_FIND (void *domain, void *addr)
        //typedef void* (__cdecl *MONO_JIT_INFO_TABLE_FIND)(void *domain, void *addr);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoAddress, PMonoJITInfo> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoAddress, PMonoJITInfo>)ptr;
        public readonly PMonoJITInfo Invoke(PMonoDomain pMonoDomain, PMonoAddress pMonoAddress) => _func(pMonoDomain, pMonoAddress);
        public static bool TryCreate(nint hModule, string name, out PMONO_JIT_INFO_TABLE_FIND func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;

        }

    }


    internal readonly unsafe partial struct PMONO_JIT_INFO_TABLE_FIND
    {
        public const string il2cpp = "il2cpp_jit_info_table_find";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_JIT_INFO_TABLE_FIND func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_JIT_INFO_TABLE_FIND
    {
        public const string mono = "mono_jit_info_table_find";
        public static bool TryCreate_MONO(nint hModule, out PMONO_JIT_INFO_TABLE_FIND func)
            => TryCreate(hModule, mono, out func);
    }
    #endregion



}