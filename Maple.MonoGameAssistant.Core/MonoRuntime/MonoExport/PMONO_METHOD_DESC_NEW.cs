
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METHOD_DESC_NEW


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METHOD_DESC_NEW(nint ptr)
    {
        //nint MONO_METHOD_DESC_NEW (const char *name, int include_namespace)
        //typedef void* (__cdecl *MONO_METHOD_DESC_NEW)(const char *name, int include_namespace);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_METHOD_DESC_NEW func)
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


    internal readonly unsafe partial struct PMONO_METHOD_DESC_NEW
    {
        public const string il2cpp = "il2cpp_method_desc_new";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_METHOD_DESC_NEW func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_METHOD_DESC_NEW
    {
        public const string mono = "mono_method_desc_new";
        public static bool TryCreate_MONO(nint hModule, out PMONO_METHOD_DESC_NEW func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}