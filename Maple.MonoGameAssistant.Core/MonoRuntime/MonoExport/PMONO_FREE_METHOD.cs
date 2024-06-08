
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_FREE_METHOD


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_FREE_METHOD(nint ptr)
    {
        //void MONO_FREE_METHOD (void *method)
        //typedef void (__cdecl *MONO_FREE_METHOD)(void *method);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod,void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, void>)ptr;
        public readonly void Invoke(PMonoMethod pMonoMethod) => _func(pMonoMethod);
        public static bool TryCreate(nint hModule, string name, out PMONO_FREE_METHOD func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;

        }

    }


    internal readonly unsafe partial struct PMONO_FREE_METHOD
    {
        public const string il2cpp = "il2cpp_free_method";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_FREE_METHOD func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_FREE_METHOD
    {
        public const string mono = "mono_free_method";
        public static bool TryCreate_MONO(nint hModule, out PMONO_FREE_METHOD func)
            => TryCreate(hModule, mono, out func);
    }
    #endregion



}