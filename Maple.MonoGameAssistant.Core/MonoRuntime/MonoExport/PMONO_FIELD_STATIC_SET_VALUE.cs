
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_FIELD_STATIC_SET_VALUE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_FIELD_STATIC_SET_VALUE(nint ptr)
    {
        public const string mono = "mono_field_static_set_value";

        //nint MONO_FIELD_STATIC_SET_VALUE (void *vtable, void* field, void* input)
        //typedef void* (__cdecl *MONO_FIELD_STATIC_SET_VALUE)(void *vtable, void* field, void* input);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke() => _func();


    }



    #endregion



}