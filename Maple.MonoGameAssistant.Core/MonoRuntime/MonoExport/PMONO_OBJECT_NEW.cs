
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_OBJECT_NEW


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_OBJECT_NEW(nint ptr)
    {
        public const string mono = "mono_object_new";

        //nint MONO_OBJECT_NEW (void *domain, void *klass)
        //typedef void* (__cdecl *MONO_OBJECT_NEW)(void *domain, void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoClass, PMonoObject> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoClass, PMonoObject>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoObject Invoke(PMonoDomain pMonoDomain, PMonoClass pMonoClass) => _func(pMonoDomain, pMonoClass);


    }

    #endregion


}