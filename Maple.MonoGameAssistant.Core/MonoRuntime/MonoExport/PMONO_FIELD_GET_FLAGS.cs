
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_FIELD_GET_FLAGS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_FIELD_GET_FLAGS(nint ptr)
    {
        public const string il2cpp = "il2cpp_field_get_flags";
        public const string mono = "mono_field_get_flags";

        //int MONO_FIELD_GET_FLAGS (void *type)
        //typedef int (__cdecl *MONO_FIELD_GET_FLAGS)(void *type);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, uint> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, uint>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Invoke(PMonoField pMonoField) => _func(pMonoField);


    }
    #endregion



}