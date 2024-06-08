
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_IMAGE_GET_TABLE_INFO


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_IMAGE_GET_TABLE_INFO(nint ptr)
    {
        public const string mono = "mono_image_get_table_info";
        public const string il2cpp = "mono_image_get_table_info";

        //nint MONO_IMAGE_GET_TABLE_INFO (void *image, int table_id)
        //typedef void* (__cdecl *MONO_IMAGE_GET_TABLE_INFO)(void *image, int table_id);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, EnumMonoMetaTable, PMonoTableInfo> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, EnumMonoMetaTable, PMonoTableInfo>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoTableInfo Invoke(PMonoImage pMonoImage, EnumMonoMetaTable enumMonoMetaTable) => _func(pMonoImage, enumMonoMetaTable);


    }



    #endregion



}