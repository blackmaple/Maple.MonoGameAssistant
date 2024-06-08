
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METHOD_GET_NAME


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METHOD_GET_NAME(nint ptr)
    {
        public const string il2cpp = "il2cpp_method_get_name";
        public const string mono = "mono_method_get_name";

        //PMonoChar MONO_METHOD_GET_NAME (void *method)
        //typedef char* (__cdecl *MONO_METHOD_GET_NAME)(void *method);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMonoUtf8Char> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMonoUtf8Char>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoUtf8Char Invoke(PMonoMethod pMonoMethod) => _func(pMonoMethod);



    }



    #endregion



}