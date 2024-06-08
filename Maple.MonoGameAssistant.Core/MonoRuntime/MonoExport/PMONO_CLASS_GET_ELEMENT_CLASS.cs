
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET_ELEMENT_CLASS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_ELEMENT_CLASS(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_element_class";
        public const string mono = "mono_class_get_element_class";
        //nint MONO_CLASS_GET_ELEMENT_CLASS (void *klass)
        //typedef void* (__cdecl *MONO_CLASS_GET_ELEMENT_CLASS)(void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoClass>)ptr;
        public readonly PMonoClass Invoke(PMonoClass pMonoClass) => _func(pMonoClass);


    }



    #endregion



}