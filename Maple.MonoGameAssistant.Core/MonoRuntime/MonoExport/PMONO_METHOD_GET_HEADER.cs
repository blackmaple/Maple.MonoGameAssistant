
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METHOD_GET_HEADER


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METHOD_GET_HEADER(nint ptr)
    {
        //nint MONO_METHOD_GET_HEADER (void *method)
        //typedef void* (__cdecl *MONO_METHOD_GET_HEADER)(void *method);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMonoMethodHeader> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMonoMethodHeader>)ptr;
        public readonly PMonoMethodHeader Invoke(PMonoMethod pMonoMethod) => _func(pMonoMethod);
        public static bool TryCreate(nint hModule, string name, out PMONO_METHOD_GET_HEADER func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;

        }

    }


    internal readonly unsafe partial struct PMONO_METHOD_GET_HEADER
    {
        public const string il2cpp = "il2cpp_method_get_header";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_METHOD_GET_HEADER func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_METHOD_GET_HEADER
    {
        public const string mono = "mono_method_get_header";
        public static bool TryCreate_MONO(nint hModule, out PMONO_METHOD_GET_HEADER func)
            => TryCreate(hModule, mono, out func);
    }
    #endregion



}