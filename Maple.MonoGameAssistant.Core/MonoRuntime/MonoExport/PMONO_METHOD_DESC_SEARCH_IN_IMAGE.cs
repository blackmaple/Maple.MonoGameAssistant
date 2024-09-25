
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METHOD_DESC_SEARCH_IN_IMAGE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METHOD_DESC_SEARCH_IN_IMAGE(nint ptr)
    {
        //nint MONO_METHOD_DESC_SEARCH_IN_IMAGE (void *desc, void *image)
        //typedef void* (__cdecl *MONO_METHOD_DESC_SEARCH_IN_IMAGE)(void *desc, void *image);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoUtf8Char, PMonoImage, PMonoMethod> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoUtf8Char, PMonoImage, PMonoMethod>)ptr;
        public readonly PMonoMethod Invoke(PMonoImage pMonoImage, PMonoUtf8Char  pMonoUtf8Char) => _func(pMonoUtf8Char, pMonoImage);
        public static bool TryCreate(nint hModule, string name, out PMONO_METHOD_DESC_SEARCH_IN_IMAGE func)
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


    internal readonly unsafe partial struct PMONO_METHOD_DESC_SEARCH_IN_IMAGE
    {
        public const string il2cpp = "il2cpp_method_desc_search_in_image";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_METHOD_DESC_SEARCH_IN_IMAGE func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_METHOD_DESC_SEARCH_IN_IMAGE
    {
        public const string mono = "mono_method_desc_search_in_image";
        public static bool TryCreate_MONO(nint hModule, out PMONO_METHOD_DESC_SEARCH_IN_IMAGE func)
            => TryCreate(hModule, mono, out func);
    }
    #endregion



}