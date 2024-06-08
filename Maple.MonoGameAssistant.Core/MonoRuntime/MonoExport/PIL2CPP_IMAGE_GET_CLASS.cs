
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_IMAGE_GET_CLASS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_IMAGE_GET_CLASS(nint ptr)
    {
        public const string il2cpp = "il2cpp_image_get_class";

        //nint IL2CPP_IMAGE_GET_CLASS (void *image, int index)
        //typedef void*(__cdecl *IL2CPP_IMAGE_GET_CLASS)(void *image, int index);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, int, PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, int, PMonoClass>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoClass Invoke(PMonoImage pMonoImage, int index) => _func(pMonoImage, index);


    }



    #endregion



}