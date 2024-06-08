
using Maple.MonoGameAssistant.Common;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET_FIELDS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_FIELDS(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_fields";
        public const string mono = "mono_class_get_fields";

        //nint MONO_CLASS_GET_FIELDS (void *klass, void *iter)
        //typedef void* (__cdecl *MONO_CLASS_GET_FIELDS)(void *klass, void *iter);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, ref PMonoIterator, PMonoField> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, ref PMonoIterator, PMonoField>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoField Invoke(PMonoClass pMonoClass, ref PMonoIterator iter) => _func(pMonoClass, ref iter);


    }



    #endregion



}