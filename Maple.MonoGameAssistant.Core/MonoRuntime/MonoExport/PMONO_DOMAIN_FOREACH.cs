
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_DOMAIN_FOREACH

    using unsafe PMonoDomainFunc = delegate* unmanaged[Cdecl]<PMonoDomain, PMonoUserData, void>;
    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_DOMAIN_FOREACH(nint ptr)
    {
        public const string il2cpp = "il2cpp_domain_foreach";
        public const string mono = "mono_domain_foreach";

        //void MONO_DOMAIN_FOREACH (MonoDomainFunc func, void *user_data)
        //typedef void (__cdecl *MONO_DOMAIN_FOREACH)(MonoDomainFunc func, void *user_data);
        readonly delegate* unmanaged[Cdecl]<PMonoDomainFunc, PMonoUserData, void> _func = (delegate* unmanaged[Cdecl]<PMonoDomainFunc, PMonoUserData, void>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke(PMonoDomainFunc pMonoDomainFunc, PMonoUserData pMonoUserData) => _func(pMonoDomainFunc, pMonoUserData);


    }



    #endregion



}