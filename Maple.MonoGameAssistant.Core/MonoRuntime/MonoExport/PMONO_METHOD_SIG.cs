
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METHOD_SIG


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METHOD_SIG(nint ptr)
    {
        public const string il2cpp = "il2cpp_method_signature";
        public const string mono = "mono_method_signature";

        //nint MONO_METHOD_SIG (void *method)
        //typedef void* (__cdecl *MONO_METHOD_SIG)(void *method);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMethodSignature> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMethodSignature>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMethodSignature Invoke(PMonoMethod pMonoMethod) => _func(pMonoMethod);



    }



    #endregion



}