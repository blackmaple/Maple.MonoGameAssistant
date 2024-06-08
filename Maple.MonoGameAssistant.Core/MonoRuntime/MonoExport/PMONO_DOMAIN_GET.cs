
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_DOMAIN_GET


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_DOMAIN_GET(nint ptr)
    {
        public const string il2cpp = "il2cpp_domain_get";
        public const string mono = "mono_domain_get";

        //nint MONO_DOMAIN_GET ()
        //typedef void* (__cdecl *MONO_DOMAIN_GET)();
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoDomain Invoke() => _func();


    }

    #endregion



}