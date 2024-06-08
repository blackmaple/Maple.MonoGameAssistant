
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_TYPE_GET_ASSEMBLY_QUALIFIED_NAME


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_TYPE_GET_ASSEMBLY_QUALIFIED_NAME(nint ptr)
    {
        public const string il2cpp = "il2cpp_type_get_assembly_qualified_name";
        //PMonoChar IL2CPP_TYPE_GET_ASSEMBLY_QUALIFIED_NAME (void* ptype)
        //typedef char*(__cdecl *IL2CPP_TYPE_GET_ASSEMBLY_QUALIFIED_NAME)(void* ptype);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();


    }


    #endregion



}