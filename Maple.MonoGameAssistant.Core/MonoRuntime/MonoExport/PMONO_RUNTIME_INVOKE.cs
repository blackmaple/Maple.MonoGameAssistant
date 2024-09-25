
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_RUNTIME_INVOKE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_RUNTIME_INVOKE(nint ptr)
    {
        //nint MONO_RUNTIME_INVOKE (void *method, void *obj, void **params, MonoObject **exc)
        //typedef void* (__cdecl *MONO_RUNTIME_INVOKE)(void *method, void *obj, void **params, MonoObject **exc);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_RUNTIME_INVOKE func)
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


    internal readonly unsafe partial struct PMONO_RUNTIME_INVOKE
    {
        public const string il2cpp = "il2cpp_runtime_invoke";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_RUNTIME_INVOKE func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_RUNTIME_INVOKE
    {
        public const string mono = "mono_runtime_invoke";
        public static bool TryCreate_MONO(nint hModule, out PMONO_RUNTIME_INVOKE func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}