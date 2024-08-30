
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_FREE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_FREE(nint ptr)
    {
        //void MONO_FREE (void*)
        //typedef void  (__cdecl *MONO_FREE)(void*);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<nint, void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<nint, void>)ptr;
        public readonly void Invoke(nint pMonoObject) => _func(pMonoObject);

        public static bool TryCreate(nint hModule, string name, out PMONO_FREE func)
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


    internal readonly unsafe partial struct PMONO_FREE
    {
        public const string il2cpp = "il2cpp_free";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_FREE func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_FREE
    {
        public const string mono = "mono_free";
        public static bool TryCreate_MONO(nint hModule, out PMONO_FREE func)
            => TryCreate(hModule, mono, out func);
    }
    #endregion



}