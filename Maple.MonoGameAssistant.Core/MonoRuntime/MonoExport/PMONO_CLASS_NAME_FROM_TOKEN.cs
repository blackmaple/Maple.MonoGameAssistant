
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_NAME_FROM_TOKEN


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_NAME_FROM_TOKEN(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_name_from_token";
        public const string mono = "mono_class_name_from_token";

        //PMonoChar MONO_CLASS_NAME_FROM_TOKEN (void *image, UINT32 token)
        //typedef char* (__cdecl *MONO_CLASS_NAME_FROM_TOKEN)(void *image, UINT32 token);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke() => _func();


    }



    #endregion



}