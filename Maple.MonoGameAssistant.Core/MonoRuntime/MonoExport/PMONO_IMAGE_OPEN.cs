
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_IMAGE_OPEN


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_IMAGE_OPEN(nint ptr)
    {
        //nint MONO_IMAGE_OPEN (const char *fname, int *status)
        //typedef void* (__cdecl *MONO_IMAGE_OPEN)(const char *fname, int *status);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_IMAGE_OPEN func)
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


    internal readonly unsafe partial struct PMONO_IMAGE_OPEN
    {
        public const string il2cpp = "il2cpp_image_open";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_IMAGE_OPEN func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_IMAGE_OPEN
    {
        public const string mono = "mono_image_open";
        public static bool TryCreate_MONO(nint hModule, out PMONO_IMAGE_OPEN func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}