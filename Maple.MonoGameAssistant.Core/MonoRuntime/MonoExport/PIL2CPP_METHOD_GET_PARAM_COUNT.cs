
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_METHOD_GET_PARAM_COUNT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_METHOD_GET_PARAM_COUNT(nint ptr)
    {
        public const string il2cpp = "il2cpp_method_get_param_count";

        //int IL2CPP_METHOD_GET_PARAM_COUNT (void* method)
        //typedef int(__cdecl *IL2CPP_METHOD_GET_PARAM_COUNT)(void* method);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, int>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Invoke(PMonoMethod pMonoMethod) => _func(pMonoMethod);


    }



    #endregion



}