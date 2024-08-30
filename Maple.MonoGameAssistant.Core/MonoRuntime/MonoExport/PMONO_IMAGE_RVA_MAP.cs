
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_IMAGE_RVA_MAP


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_IMAGE_RVA_MAP(nint ptr)
    {
        //nint MONO_IMAGE_RVA_MAP (void *image, UINT32 addr)
        //typedef void* (__cdecl *MONO_IMAGE_RVA_MAP)(void *image, UINT32 addr);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, uint, PMonoUtf8Char> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, uint, PMonoUtf8Char>)ptr;
        public readonly PMonoUtf8Char Invoke(PMonoImage pMonoImage, uint addr) => _func(pMonoImage, addr);
        public static bool TryCreate(nint hModule, string name, out PMONO_IMAGE_RVA_MAP func)
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


    internal readonly unsafe partial struct PMONO_IMAGE_RVA_MAP
    {
        public const string il2cpp = "il2cpp_image_rva_map";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_IMAGE_RVA_MAP func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_IMAGE_RVA_MAP
    {
        public const string mono = "mono_image_rva_map";
        public static bool TryCreate_MONO(nint hModule, out PMONO_IMAGE_RVA_MAP func)
            => TryCreate(hModule, mono, out func);
    }
    #endregion



}