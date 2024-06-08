
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_METHOD_GET_OBJECT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_METHOD_GET_OBJECT(nint ptr)
    {
        public const string il2cpp = "il2cpp_method_get_object";
        //nint IL2CPP_METHOD_GET_OBJECT (void* method, void* klass)
        //typedef void* (__cdecl *IL2CPP_METHOD_GET_OBJECT)(void* method, void* klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();

    }


    #endregion



}