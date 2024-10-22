
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_SIGNATURE_GET_PARAMS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_SIGNATURE_GET_PARAMS(nint ptr)
    {
        public const string il2cpp = "il2cpp_signature_get_params";
        public const string mono = "mono_signature_get_params";

        //PMonoType MONO_SIGNATURE_GET_PARAMS (MonoMethodSignature *sig, gpointer *iter)
        //typedef MonoType* (__cdecl *MONO_SIGNATURE_GET_PARAMS)(MonoMethodSignature *sig, gpointer *iter);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMethodSignature, RefValue<PMonoIterator>, PMonoType> _func 
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMethodSignature, RefValue<PMonoIterator>, PMonoType>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoType Invoke(PMethodSignature pMethodSignature, ref PMonoIterator iter) => _func(pMethodSignature, RefValue<PMonoIterator>.CreateRefValue(ref iter));

    }



    #endregion



}