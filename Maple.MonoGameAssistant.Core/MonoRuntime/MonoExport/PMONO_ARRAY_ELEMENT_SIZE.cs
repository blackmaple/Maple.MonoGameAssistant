
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_ARRAY_ELEMENT_SIZE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_ARRAY_ELEMENT_SIZE(nint ptr)
    {
        public const string il2cpp = "il2cpp_array_element_size";
        public const string mono = "mono_array_element_size";
        //int MONO_ARRAY_ELEMENT_SIZE (void * klass)
        //typedef int (__cdecl *MONO_ARRAY_ELEMENT_SIZE)(void * klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, int>)ptr;
        public readonly int Invoke(PMonoClass pMonoClass) => _func(pMonoClass);


    }



    #endregion



}