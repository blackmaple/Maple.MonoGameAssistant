
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_RUNTIME_IS_SHUTTING_DOWN


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_RUNTIME_IS_SHUTTING_DOWN(nint ptr)
    {
        //int MONO_RUNTIME_IS_SHUTTING_DOWN ()
        //typedef int (__cdecl *MONO_RUNTIME_IS_SHUTTING_DOWN)(void);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_RUNTIME_IS_SHUTTING_DOWN func)
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


    internal readonly unsafe partial struct PMONO_RUNTIME_IS_SHUTTING_DOWN
    {
        public const string il2cpp = "mono_runtime_is_shutting_down";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_RUNTIME_IS_SHUTTING_DOWN func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_RUNTIME_IS_SHUTTING_DOWN
    {
        public const string mono = "mono_runtime_is_shutting_down";
        public static bool TryCreate_MONO(nint hModule, out PMONO_RUNTIME_IS_SHUTTING_DOWN func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}