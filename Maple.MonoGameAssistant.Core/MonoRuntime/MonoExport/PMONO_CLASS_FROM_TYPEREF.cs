
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_FROM_TYPEREF


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_FROM_TYPEREF(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_from_typeref";
        public const string mono = "mono_class_from_typeref";
        //nint MONO_CLASS_FROM_TYPEREF (void *image, UINT32 type_token)
        //typedef void* (__cdecl *MONO_CLASS_FROM_TYPEREF)(void *image, UINT32 type_token);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();


    }






    #endregion



}