
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_TYPE_GET_NAME


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_TYPE_GET_NAME(nint ptr)
    {
        public const string il2cpp = "il2cpp_type_get_name";
        public const string mono = "mono_type_get_name";

        //PMonoChar MONO_TYPE_GET_NAME (void *type)
        //typedef char* (__cdecl *MONO_TYPE_GET_NAME)(void *type);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoType, PMonoUtf8Char> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoType, PMonoUtf8Char>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoUtf8Char Invoke(PMonoType pMonoFieldType) => _func(pMonoFieldType);

    }



    #endregion



}