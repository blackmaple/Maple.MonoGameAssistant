
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_FIELD_GET_OFFSET


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_FIELD_GET_OFFSET(nint ptr)
    {
        public const string il2cpp = "il2cpp_field_get_offset";
        public const string mono = "mono_field_get_offset";

        //int MONO_FIELD_GET_OFFSET (void *field)
        //typedef int (__cdecl *MONO_FIELD_GET_OFFSET)(void *field);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, int>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Invoke(PMonoField pMonoField) => _func(pMonoField);



    }



    #endregion



}