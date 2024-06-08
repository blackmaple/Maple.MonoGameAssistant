
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_IS_SUBCLASS_OF


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_IS_SUBCLASS_OF(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_is_subclass_of";
        public const string mono = "mono_class_is_subclass_of";

        //int MONO_CLASS_IS_SUBCLASS_OF (void *klass, void* parentKlass, bool check_interface)
        //typedef int (__cdecl *MONO_CLASS_IS_SUBCLASS_OF)(void *klass, void* parentKlass, bool check_interface);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoClass, MapleBoolean, MapleBoolean> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoClass, MapleBoolean, MapleBoolean>)ptr;
        public readonly MapleBoolean Invoke(PMonoClass pMonoClass, PMonoClass pParentClass, MapleBoolean checkInteface) => _func(pMonoClass, pParentClass, checkInteface);
 

    }


 
    #endregion



}