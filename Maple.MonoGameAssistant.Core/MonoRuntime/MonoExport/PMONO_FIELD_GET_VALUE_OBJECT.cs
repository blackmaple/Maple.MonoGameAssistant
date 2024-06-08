
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_FIELD_GET_VALUE_OBJECT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_FIELD_GET_VALUE_OBJECT(nint ptr)
    {
        public const string il2cpp = "il2cpp_field_get_value_object";
        public const string mono = "mono_field_get_value_object";

        //nint MONO_FIELD_GET_VALUE_OBJECT (void *domain, void* field, void* object)
        //typedef void* (__cdecl * MONO_FIELD_GET_VALUE_OBJECT)(void *domain, void* field, void* object);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoField, PMonoObject, PMonoObject> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoField, PMonoObject, PMonoObject>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoObject Invoke(PMonoDomain pMonoDomain, PMonoField pMonoField, PMonoObject pMonoObject = default) => _func(pMonoDomain, pMonoField, pMonoObject);


    }



    #endregion



}