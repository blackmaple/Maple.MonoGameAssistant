
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_STRING_TO_UTF8


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_STRING_TO_UTF8(nint ptr)
    {
        //PMonoChar MONO_STRING_TO_UTF8 (void*)
        //typedef char* (__cdecl *MONO_STRING_TO_UTF8)(void*);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_STRING_TO_UTF8 func)
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


    internal readonly unsafe partial struct PMONO_STRING_TO_UTF8
    {
        public const string il2cpp = "il2cpp_string_to_utf8";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_STRING_TO_UTF8 func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_STRING_TO_UTF8
    {
        public const string mono = "mono_string_to_utf8";
        public static bool TryCreate_MONO(nint hModule, out PMONO_STRING_TO_UTF8 func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}