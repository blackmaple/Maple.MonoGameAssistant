
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET_IMAGE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_IMAGE(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_image";
        public const string mono = "mono_class_get_image";
        //nint MONO_CLASS_GET_IMAGE (void *klass)
        //typedef void* (__cdecl *MONO_CLASS_GET_IMAGE)(void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoImage> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoImage>)ptr;
        public readonly PMonoImage Invoke(PMonoClass pMonoClass) => _func(pMonoClass);


    }



    #endregion



}