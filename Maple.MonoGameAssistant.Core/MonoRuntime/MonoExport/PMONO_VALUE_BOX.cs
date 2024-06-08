
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_VALUE_BOX


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_VALUE_BOX(nint ptr)
    {
        //nint MONO_VALUE_BOX (void *domain, void *klass, void* val)
        //typedef void* (__cdecl *MONO_VALUE_BOX)(void *domain, void *klass, void* val);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_VALUE_BOX func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;
        }

    }


    internal readonly unsafe partial struct PMONO_VALUE_BOX
    {
        public const string il2cpp = "il2cpp_value_box";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_VALUE_BOX func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_VALUE_BOX
    {
        public const string mono = "mono_value_box";
        public static bool TryCreate_MONO(nint hModule, out PMONO_VALUE_BOX func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}