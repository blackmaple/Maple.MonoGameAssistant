
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_TYPE_GET_TYPE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_TYPE_GET_TYPE(nint ptr)
    {
        public const string il2cpp = "il2cpp_type_get_type";
        public const string mono = "mono_type_get_type";

        //int MONO_TYPE_GET_TYPE (void *type)
        //typedef int (__cdecl *MONO_TYPE_GET_TYPE)(void *type);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoType, EnumMonoType> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoType, EnumMonoType>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly EnumMonoType Invoke(PMonoType pMonoFieldType) => _func(pMonoFieldType);



    }



    #endregion



}