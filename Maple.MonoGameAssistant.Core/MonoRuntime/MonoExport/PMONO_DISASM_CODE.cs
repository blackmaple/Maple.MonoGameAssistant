
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_DISASM_CODE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_DISASM_CODE(nint ptr)
    {
        //PMonoChar MONO_DISASM_CODE (void *dishelper, void *method, void *ip, void *end)
        //typedef char* (__cdecl *MONO_DISASM_CODE)(void *dishelper, void *method, void *ip, void *end);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDisHelper, PMonoMethod, PMonoILCode, PMonoILCode, PMonoUtf8Char> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDisHelper, PMonoMethod, PMonoILCode, PMonoILCode, PMonoUtf8Char>)ptr;
        public readonly PMonoUtf8Char Invoke(PMonoDisHelper pMonoDisHelper, PMonoMethod pMonoMethod, PMonoILCode pIP_Start, PMonoILCode pIP_End)
            => _func(pMonoDisHelper, pMonoMethod, pIP_Start, pIP_End);
        public readonly PMonoUtf8Char Invoke(PMonoMethod pMonoMethod, PMonoILCode pIP_Start, PMonoILCode pIP_End)
        => Invoke(nint.Zero, pMonoMethod, pIP_Start, pIP_End);
        public static bool TryCreate(nint hModule, string name, out PMONO_DISASM_CODE func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;
        }



    }


    internal readonly unsafe partial struct PMONO_DISASM_CODE
    {
        public const string il2cpp = "il2cpp_disasm_code";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_DISASM_CODE func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_DISASM_CODE
    {
        public const string mono = "mono_disasm_code";
        public static bool TryCreate_MONO(nint hModule, out PMONO_DISASM_CODE func)
            => TryCreate(hModule, mono, out func);
    }
    #endregion



}