
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_FROM_NAME_CASE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_FROM_NAME_CASE(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_from_name_case";
        public const string mono = "mono_class_from_name_case";
        //nint MONO_CLASS_FROM_NAME_CASE (void *image, char *name_space, char *name)
        //typedef void* (__cdecl *MONO_CLASS_FROM_NAME_CASE)(void *image, char *name_space, char *name);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, PMonoUtf8Char, PMonoUtf8Char, PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, PMonoUtf8Char, PMonoUtf8Char, PMonoClass>)ptr;
        public readonly unsafe PMonoClass Invoke(PMonoImage pMonoImage, PMonoUtf8Char pNameSpace, PMonoUtf8Char pClassName) => _func(pMonoImage, pNameSpace, pClassName);


    }



    #endregion



}