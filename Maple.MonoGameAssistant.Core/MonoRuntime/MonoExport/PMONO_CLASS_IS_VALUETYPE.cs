
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_IS_VALUETYPE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_IS_VALUETYPE(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_is_valuetype";
        public const string mono = "mono_class_is_valuetype";

        //MapleBoolean MONO_CLASS_IS_VALUETYPE (void *klass)
        //typedef int (__cdecl *MONO_CLASS_IS_VALUETYPE)(void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, MapleBoolean> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, MapleBoolean>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly MapleBoolean Invoke(PMonoClass pMonoClass) => _func(pMonoClass);


    }



    #endregion



}