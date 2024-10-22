
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET_INTERFACES


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_INTERFACES(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_interfaces";
        public const string mono = "mono_class_get_interfaces";
        //nint MONO_CLASS_GET_INTERFACES (void *klass, void *iter)
        //typedef void* (__cdecl *MONO_CLASS_GET_INTERFACES)(void *klass, void *iter);
         readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, RefValue<PMonoIterator>, PMonoInterface> _func
             = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, RefValue<PMonoIterator>, PMonoInterface>)ptr;


        public readonly unsafe PMonoInterface Invoke(PMonoClass pMonoClass, ref PMonoIterator iter)
        {
            return _func(pMonoClass, RefValue<PMonoIterator>.CreateRefValue(ref iter));
        }


    }



    #endregion



}