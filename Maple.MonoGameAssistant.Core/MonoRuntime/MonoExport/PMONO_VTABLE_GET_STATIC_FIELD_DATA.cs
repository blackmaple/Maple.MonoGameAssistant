
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_VTABLE_GET_STATIC_FIELD_DATA


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_VTABLE_GET_STATIC_FIELD_DATA(nint ptr)
    {
        public const string il2cpp = "il2cpp_vtable_get_static_field_data";
        public const string mono = "mono_vtable_get_static_field_data";

        //nint MONO_VTABLE_GET_STATIC_FIELD_DATA (void *vtable)
        //typedef void* (__cdecl *MONO_VTABLE_GET_STATIC_FIELD_DATA)(void *vtable);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoVirtualTable, PMonoStaticFieldData> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoVirtualTable, PMonoStaticFieldData>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoStaticFieldData Invoke(PMonoVirtualTable pMonoVirtualTable) => _func(pMonoVirtualTable);


    }



    #endregion



}