
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_FIELD_GET_TYPE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_FIELD_GET_TYPE(nint ptr)
    {
        public const string il2cpp = "il2cpp_field_get_type";
        public const string mono = "mono_field_get_type";

        //nint MONO_FIELD_GET_TYPE (void *field)
        //typedef void* (__cdecl *MONO_FIELD_GET_TYPE)(void *field);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, PMonoType> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, PMonoType>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoType Invoke(PMonoField pMonoField) => _func(pMonoField);


    }



    #endregion



}