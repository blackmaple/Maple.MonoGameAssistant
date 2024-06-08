
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET_NESTING_TYPE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_NESTING_TYPE(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_nesting_type";
        public const string mono = "mono_class_get_nesting_type";
        //nint MONO_CLASS_GET_NESTING_TYPE (void *klass)
        //typedef void* (__cdecl *MONO_CLASS_GET_NESTING_TYPE)(void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoNestingType> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoNestingType>)ptr;
        public readonly PMonoNestingType Invoke(PMonoClass pMonoClass) => _func(pMonoClass);


    }


    #endregion



}