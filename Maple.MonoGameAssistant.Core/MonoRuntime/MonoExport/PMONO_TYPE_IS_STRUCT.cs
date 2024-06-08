
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_TYPE_IS_STRUCT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_TYPE_IS_STRUCT(nint ptr)
    {
        //MonoBool MONO_TYPE_IS_STRUCT (void* type)
        //typedef bool(__cdecl* MONO_TYPE_IS_STRUCT)(void* type);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_TYPE_IS_STRUCT func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;
        }

    }
#endregion



}