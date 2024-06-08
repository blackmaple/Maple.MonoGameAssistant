
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_SIGNATURE_GET_PARAM_COUNT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_SIGNATURE_GET_PARAM_COUNT(nint ptr)
    {
        public const string il2cpp = "il2cpp_signature_get_param_count";
        public const string mono = "mono_signature_get_param_count";

        //int MONO_SIGNATURE_GET_PARAM_COUNT (void *signature)
        //typedef int (__cdecl *MONO_SIGNATURE_GET_PARAM_COUNT)(void *signature);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMethodSignature, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMethodSignature, int>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Invoke(PMethodSignature pMethodSignature) => _func(pMethodSignature);

    }



    #endregion



}