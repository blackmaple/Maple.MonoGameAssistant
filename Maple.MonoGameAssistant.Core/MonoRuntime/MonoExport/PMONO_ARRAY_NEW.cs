
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_ARRAY_NEW


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_ARRAY_NEW(nint ptr)
    {
        public const string mono = "mono_array_new";

        //nint MONO_ARRAY_NEW (void *domain, void *eclass, uintptr_t n)
        //typedef void* (__cdecl *MONO_ARRAY_NEW)(void *domain, void *eclass, uintptr_t n);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoClass, nuint, PMonoArray> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoClass, nuint, PMonoArray>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoArray Invoke(PMonoDomain pMonoDomain, PMonoClass pMonoClass, nuint size) => _func(pMonoDomain, pMonoClass, size);



    }



    #endregion



}