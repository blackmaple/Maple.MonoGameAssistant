
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_RUNTIME_INVOKE_ARRAY


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_RUNTIME_INVOKE_ARRAY(nint ptr)
    {
        //nint MONO_RUNTIME_INVOKE_ARRAY (void *method, void *obj, void *params, void **exc)
        //typedef void* (__cdecl *MONO_RUNTIME_INVOKE_ARRAY)(void *method, void *obj, void *params, void **exc);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_RUNTIME_INVOKE_ARRAY func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;

        }

    }
#endregion



}