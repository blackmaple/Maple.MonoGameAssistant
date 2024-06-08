
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_SIGNATURE_GET_DESC


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_SIGNATURE_GET_DESC(nint ptr)
    {
        public const string il2cpp = "il2cpp_signature_get_desc";
        public const string mono = "mono_signature_get_desc";

        //PMonoChar MONO_SIGNATURE_GET_DESC (void *signature, int include_namespace)
        //typedef char* (__cdecl *MONO_SIGNATURE_GET_DESC)(void *signature, int include_namespace);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMethodSignature, MapleBoolean, PMonoUtf8Char> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMethodSignature, MapleBoolean, PMonoUtf8Char>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoUtf8Char Invoke(PMethodSignature pMethodSignature, MapleBoolean boolean) => _func(pMethodSignature, boolean);

    }


    #endregion



}