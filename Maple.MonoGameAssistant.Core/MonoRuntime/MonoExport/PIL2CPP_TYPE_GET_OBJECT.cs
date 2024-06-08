
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_TYPE_GET_OBJECT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_TYPE_GET_OBJECT(nint ptr)
    {
        public const string il2cpp = "il2cpp_type_get_object";
        //nint IL2CPP_TYPE_GET_OBJECT (void *type)
        //typedef void* (__cdecl *IL2CPP_TYPE_GET_OBJECT)(void *type);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();

    }



    #endregion



}