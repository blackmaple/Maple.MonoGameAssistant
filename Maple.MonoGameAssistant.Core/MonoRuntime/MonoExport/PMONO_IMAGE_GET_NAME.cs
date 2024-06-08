
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_IMAGE_GET_NAME


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_IMAGE_GET_NAME(nint ptr)
    {
        public const string il2cpp = "il2cpp_image_get_name";
        public const string mono = "mono_image_get_name";

        //PMonoChar MONO_IMAGE_GET_NAME (void *image)
        //typedef char* (__cdecl *MONO_IMAGE_GET_NAME)(void *image);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, PMonoUtf8Char> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, PMonoUtf8Char>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoUtf8Char Invoke(PMonoImage pMonoImage) => _func(pMonoImage);

    }


    #endregion



}