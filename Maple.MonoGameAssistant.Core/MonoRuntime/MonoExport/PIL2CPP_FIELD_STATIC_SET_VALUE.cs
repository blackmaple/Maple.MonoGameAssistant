
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_FIELD_STATIC_SET_VALUE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_FIELD_STATIC_SET_VALUE(nint ptr)
    {
        public const string il2cpp = "il2cpp_field_static_set_value";

        //nint IL2CPP_FIELD_STATIC_SET_VALUE (void* field, void* input)
        //typedef void* (__cdecl *IL2CPP_FIELD_STATIC_SET_VALUE)(void* field, void* input);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke() => _func();


    }



    #endregion



}