
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_TYPE_GET_NAME_FULL


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_TYPE_GET_NAME_FULL(nint ptr)
    {
        //PMonoChar MONO_TYPE_GET_NAME_FULL (void *type, int format)
        //typedef char* (__cdecl *MONO_TYPE_GET_NAME_FULL)(void *type, int format);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_TYPE_GET_NAME_FULL func)
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


    internal readonly unsafe partial struct PMONO_TYPE_GET_NAME_FULL
    {
        public const string il2cpp = "il2cpp_type_get_name_full";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_TYPE_GET_NAME_FULL func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_TYPE_GET_NAME_FULL
    {
        public const string mono = "mono_type_get_name_full";
        public static bool TryCreate_MONO(nint hModule, out PMONO_TYPE_GET_NAME_FULL func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}