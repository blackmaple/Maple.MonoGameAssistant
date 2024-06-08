
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_METHOD_GET_RETURN_TYPE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_METHOD_GET_RETURN_TYPE(nint ptr)
    {
        public const string il2cpp = "il2cpp_method_get_return_type";

        //nint IL2CPP_METHOD_GET_RETURN_TYPE (void *method)
        //typedef void*(__cdecl *IL2CPP_METHOD_GET_RETURN_TYPE)(void *method);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMonoType> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMonoType>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoType Invoke(PMonoMethod pMonoMethod) => _func(pMonoMethod);


    }



    #endregion



}