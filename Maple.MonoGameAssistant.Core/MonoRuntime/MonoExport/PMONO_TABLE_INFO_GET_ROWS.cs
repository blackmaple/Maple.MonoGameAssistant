
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_TABLE_INFO_GET_ROWS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_TABLE_INFO_GET_ROWS(nint ptr)
    {
        public const string il2cpp = "il2cpp_table_info_get_rows";
        public const string mono = "mono_table_info_get_rows";

        //int MONO_TABLE_INFO_GET_ROWS (void *tableinfo)
        //typedef int (__cdecl *MONO_TABLE_INFO_GET_ROWS)(void *tableinfo);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoTableInfo, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoTableInfo, int>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Invoke(PMonoTableInfo pMonoTableInfo) => _func(pMonoTableInfo);


    }



    #endregion



}