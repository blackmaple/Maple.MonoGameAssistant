
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_TYPE_GET_NAME

    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_TYPE_GET_NAME(nint ptr)
    {
        public const string il2cpp = "il2cpp_type_get_name";
        //PMonoChar IL2CPP_TYPE_GET_NAME (void* ptype)
        //typedef char*(__cdecl *IL2CPP_TYPE_GET_NAME)(void* ptype);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoType, PMonoUtf8Char> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoType, PMonoUtf8Char>)ptr;
        public readonly PMonoUtf8Char Invoke(PMonoType pMonoType) => _func(pMonoType);


    }



    #endregion



}