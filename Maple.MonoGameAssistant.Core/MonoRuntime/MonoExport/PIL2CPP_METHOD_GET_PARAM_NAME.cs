
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_METHOD_GET_PARAM_NAME


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_METHOD_GET_PARAM_NAME(nint ptr)
    {
        public const string il2cpp = "il2cpp_method_get_param_name";

        //PMonoChar IL2CPP_METHOD_GET_PARAM_NAME (void *method, int index)
        //typedef char*(__cdecl *IL2CPP_METHOD_GET_PARAM_NAME)(void *method, int index);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, int, PMonoUtf8Char> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, int, PMonoUtf8Char>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoUtf8Char Invoke(PMonoMethod pMonoMethod, int index) => _func(pMonoMethod, index);


    }



    #endregion



}