
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_OBJECT_TO_STRING


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_OBJECT_TO_STRING(nint ptr)
    {
        //nint MONO_OBJECT_TO_STRING (void *object, void **exc)
        //typedef void* (__cdecl *MONO_OBJECT_TO_STRING)(void *object, void **exc);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_OBJECT_TO_STRING func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;

        }

    }
    #endregion



}