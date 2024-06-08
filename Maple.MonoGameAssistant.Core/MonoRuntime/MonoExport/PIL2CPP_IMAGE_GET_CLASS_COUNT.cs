
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_IMAGE_GET_CLASS_COUNT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_IMAGE_GET_CLASS_COUNT(nint ptr)
    {
        public const string il2cpp = "il2cpp_image_get_class_count";

        //int IL2CPP_IMAGE_GET_CLASS_COUNT (void* image)
        //typedef int(__cdecl *IL2CPP_IMAGE_GET_CLASS_COUNT)(void* image);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, int>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Invoke(PMonoImage pMonoImage) => _func(pMonoImage);


    }



    #endregion



}