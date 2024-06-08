
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_IMAGE_LOADED


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_IMAGE_LOADED(nint ptr)
    {
        //nint MONO_IMAGE_LOADED (void *aname)
        //typedef void* (__cdecl *MONO_IMAGE_LOADED)(void *aname);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_IMAGE_LOADED func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;

        }

    }
#endregion



}