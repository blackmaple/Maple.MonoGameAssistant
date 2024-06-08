
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET_NAME


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_NAME(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_name";
        public const string mono = "mono_class_get_name";

        //PMonoChar MONO_CLASS_GET_NAME (void *klass)
        //typedef char* (__cdecl *MONO_CLASS_GET_NAME)(void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoUtf8Char> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoUtf8Char>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoUtf8Char Invoke(PMonoClass pMonoClass) => _func(pMonoClass);

    }



    #endregion



}