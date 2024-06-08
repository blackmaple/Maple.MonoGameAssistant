
using Maple.MonoGameAssistant.Common;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_GET_ROOT_DOMAIN

    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_GET_ROOT_DOMAIN(nint ptr)
    {
        public const string il2cpp = "il2cpp_get_root_domain";
        public const string mono = "mono_get_root_domain";

        //nint MONO_GET_ROOT_DOMAIN ()
        //typedef void* (__cdecl *MONO_GET_ROOT_DOMAIN)(void);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoDomain Invoke() => _func();


    }
    #endregion



}