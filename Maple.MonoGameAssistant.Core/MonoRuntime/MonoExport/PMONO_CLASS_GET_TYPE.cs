
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET_TYPE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_TYPE(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_type";
        public const string mono = "mono_class_get_type";
        //nint MONO_CLASS_GET_TYPE (void *klass)
        //typedef void* (__cdecl *MONO_CLASS_GET_TYPE)(void *klass);
        [MarshalAs(UnmanagedType.SysInt)]
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoType> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoType>)ptr;
        public readonly unsafe PMonoType Invoke(PMonoClass pMonoClass) => _func(pMonoClass);


    }


    #endregion



}