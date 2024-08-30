
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METADATA_STRING_HEAP


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METADATA_STRING_HEAP(nint ptr)
    {
        //PMonoChar MONO_METADATA_STRING_HEAP (void *image, UINT32 index)
        //typedef char* (__cdecl *MONO_METADATA_STRING_HEAP)(void *image, UINT32 index);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_METADATA_STRING_HEAP func)
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


    internal readonly unsafe partial struct PMONO_METADATA_STRING_HEAP
    {
        public const string il2cpp = "il2cpp_metadata_string_heap";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_METADATA_STRING_HEAP func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_METADATA_STRING_HEAP
    {
        public const string mono = "mono_metadata_string_heap";
        public static bool TryCreate_MONO(nint hModule, out PMONO_METADATA_STRING_HEAP func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}