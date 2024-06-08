
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_ASSEMBLY_GET_IMAGE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_ASSEMBLY_GET_IMAGE(nint ptr)
    {
        public const string il2cpp = "il2cpp_assembly_get_image";
        public const string mono = "mono_assembly_get_image";

        //nint MONO_ASSEMBLY_GET_IMAGE (void *assembly)
        //typedef void* (__cdecl *MONO_ASSEMBLY_GET_IMAGE)(void *assembly);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoAssembly, PMonoImage> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoAssembly, PMonoImage>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoImage Invoke(PMonoAssembly pMonoAssembly) => _func(pMonoAssembly);


    }



    #endregion



}