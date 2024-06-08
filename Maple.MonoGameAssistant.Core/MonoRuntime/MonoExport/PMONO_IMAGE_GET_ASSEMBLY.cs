
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_IMAGE_GET_ASSEMBLY


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_IMAGE_GET_ASSEMBLY(nint ptr)
    {
        public const string il2cpp = "il2cpp_image_get_assembly";
        public const string mono = "mono_image_get_assembly";

        //nint MONO_IMAGE_GET_ASSEMBLY (void *image)
        //typedef void* (__cdecl *MONO_IMAGE_GET_ASSEMBLY)(void *image);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke() => _func();


    }



    #endregion



}