
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_METHOD_GET_PARAM


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_METHOD_GET_PARAM(nint ptr)
    {
        public const string il2cpp = "il2cpp_method_get_param";

        //nint IL2CPP_METHOD_GET_PARAM (void *method, int index)
        //typedef void*(__cdecl *IL2CPP_METHOD_GET_PARAM)(void *method, int index);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, int, PMonoType> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, int, PMonoType>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoType Invoke(PMonoMethod pMonoMethod, int index) => _func(pMonoMethod, index);


    }



    #endregion



}