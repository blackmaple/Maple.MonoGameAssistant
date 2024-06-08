
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_IMAGE_GET_FILENAME


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_IMAGE_GET_FILENAME(nint ptr)
    {
        public const string il2cpp = "il2cpp_image_get_filename";
        public const string mono = "mono_image_get_filename";

        //PMonoChar MONO_IMAGE_GET_FILENAME (void *image)
        //typedef char* (__cdecl *MONO_IMAGE_GET_FILENAME)(void *image);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, PMonoUtf8Char> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, PMonoUtf8Char>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoUtf8Char Invoke(PMonoImage pMonoImage) => _func(pMonoImage);


    }


    #endregion



}