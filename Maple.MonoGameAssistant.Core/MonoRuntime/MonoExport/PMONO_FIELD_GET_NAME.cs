
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_FIELD_GET_NAME


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_FIELD_GET_NAME(nint ptr)
    {
        public const string il2cpp = "il2cpp_field_get_name";
        public const string mono = "mono_field_get_name";

        //PMonoChar MONO_FIELD_GET_NAME (void *field)
        //typedef char* (__cdecl *MONO_FIELD_GET_NAME)(void *field);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, PMonoUtf8Char> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, PMonoUtf8Char>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoUtf8Char Invoke(PMonoField pMonoField) => _func(pMonoField);


    }



    #endregion



}