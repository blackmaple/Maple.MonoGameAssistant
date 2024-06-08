
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_VTABLE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_VTABLE(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_vtable";
        public const string mono = "mono_class_vtable";

        //nint MONO_CLASS_VTABLE (void *domain, void *klass)
        //typedef void* (__cdecl *MONO_CLASS_VTABLE)(void *domain, void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoClass, PMonoVirtualTable> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoClass, PMonoVirtualTable>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoVirtualTable Invoke(PMonoDomain pMonoDomain, PMonoClass pMonoClass) => _func(pMonoDomain, pMonoClass);


    }



    #endregion



}