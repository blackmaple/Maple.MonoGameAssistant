
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METHOD_DESC_FROM_METHOD


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METHOD_DESC_FROM_METHOD(nint ptr)
    {
        //nint MONO_METHOD_DESC_FROM_METHOD (void *method)
        //typedef void* (__cdecl *MONO_METHOD_DESC_FROM_METHOD)(void *method);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_METHOD_DESC_FROM_METHOD func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;

        }

    }


    internal readonly unsafe partial struct PMONO_METHOD_DESC_FROM_METHOD
    {
        public const string il2cpp = "il2cpp_method_desc_from_method";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_METHOD_DESC_FROM_METHOD func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_METHOD_DESC_FROM_METHOD
    {
        public const string mono = "mono_method_desc_from_method";
        public static bool TryCreate_MONO(nint hModule, out PMONO_METHOD_DESC_FROM_METHOD func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}