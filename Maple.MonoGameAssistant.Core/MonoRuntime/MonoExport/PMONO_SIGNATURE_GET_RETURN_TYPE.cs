
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_SIGNATURE_GET_RETURN_TYPE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_SIGNATURE_GET_RETURN_TYPE(nint ptr)
    {
        public const string il2cpp = "il2cpp_signature_get_return_type";
        public const string mono = "mono_signature_get_return_type";

        //PMonoType MONO_SIGNATURE_GET_RETURN_TYPE (void *signature)
        //typedef MonoType* (__cdecl *MONO_SIGNATURE_GET_RETURN_TYPE)(void *signature);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMethodSignature, PMonoType> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMethodSignature, PMonoType>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoType Invoke(PMethodSignature pMethodSignature) => _func(pMethodSignature);

    }



    #endregion



}