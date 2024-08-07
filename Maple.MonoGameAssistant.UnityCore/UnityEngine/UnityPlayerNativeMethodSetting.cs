﻿using Maple.MonoGameAssistant.Core;
using static Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D;

namespace Maple.MonoGameAssistant.UnityCore.UnityEngine
{
    public class UnityPlayerNativeMethodSetting
    {
        /// <summary>
        /// UnityEngine.ImageConversion:EncodeToPNG+77 - 48 B8 307087C6FA7F0000 - mov rax,UnityPlayer.dll+217030 { ("@USWH?l$?H???") }
        /// </summary>
        readonly unsafe partial struct Ptr_Func_ENCODE_TO_PNG(nint ptr)
        {
            readonly delegate* unmanaged[SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, Maple.MonoGameAssistant.Core.PMonoArray<byte>> _func = (delegate* unmanaged[SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, Maple.MonoGameAssistant.Core.PMonoArray<byte>>)ptr;

            public static implicit operator Ptr_Func_ENCODE_TO_PNG(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public Maple.MonoGameAssistant.Core.PMonoArray<byte> Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D tex) => _func(tex);
        }
        Ptr_Func_ENCODE_TO_PNG Func_ENCODE_TO_PNG;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public PMonoArray<byte> EncodeToPng(Ptr_Texture2D pDest)
        {
            return Func_ENCODE_TO_PNG.Invoke(pDest);
        }

        /// <summary>
        /// UnityEngine.Graphics:Blit2+7f - 48 B8 C078C247FA7F0000 - mov rax,UnityPlayer.dll+878C0 { ("@USWATAUH?l$?H??0") }
        /// </summary>
        readonly unsafe partial struct Ptr_Func_BLIT2(nint ptr)
        {
            readonly delegate* unmanaged[SuppressGCTransition]<nint, nint, void> _func = (delegate* unmanaged[SuppressGCTransition]<nint, nint, void>)ptr;

            public static implicit operator Ptr_Func_BLIT2(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Invoke(nint source, nint dest) => _func(source, dest);
        }
        Ptr_Func_BLIT2 Func_BLIT2;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void BLIT2(nint source, nint dest)
        {
            Func_BLIT2.Invoke(source, dest);
        }


        /// <summary>
        /// UnityEngine.Sprite::get_rect_Injected(UnityEngine.Rect&)
        /// </summary>
        /// <param name="ptr"></param>
        readonly unsafe partial struct Ptr_Func_GET_RECT_INJECTED(nint ptr)
        {
            readonly delegate* unmanaged[SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, void> _func = (delegate* unmanaged[SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, void>)ptr;

            public static implicit operator Ptr_Func_GET_RECT_INJECTED(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect ret) => _func(ptr_Sprite, out ret);
        }
        static Ptr_Func_GET_RECT_INJECTED Func_GET_RECT_INJECTED;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static void GET_RECT_INJECTED(Sprite.Ptr_Sprite ptr_Sprite, out Rect.Ref_Rect ret)
            => Func_GET_RECT_INJECTED.Invoke(ptr_Sprite, out ret);


        readonly unsafe partial struct Ptr_Func_GET_TEXTURE_RECT_INJECTED(nint ptr)
        {
            readonly delegate* unmanaged[SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, void> _func = (delegate* unmanaged[SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, void>)ptr;

            public static implicit operator Ptr_Func_GET_TEXTURE_RECT_INJECTED(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect ret) => _func(ptr_Sprite, out ret);
        }
        static Ptr_Func_GET_TEXTURE_RECT_INJECTED Func_GET_TEXTURE_RECT_INJECTED;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static void GET_TEXTURE_RECT_INJECTED(Sprite.Ptr_Sprite ptr_Sprite, out Rect.Ref_Rect ret)
            => Func_GET_TEXTURE_RECT_INJECTED.Invoke(ptr_Sprite, out ret);


        public void LoadNativeMethod_MONO(int offset_encode_to_png = 0x217030, int offset_blit2 = 0x878C0)
        {
            var pUnityPlayer = MonoCollectorMember.GetModuleBaseAddress("UnityPlayer.dll");
            Func_ENCODE_TO_PNG = pUnityPlayer + offset_encode_to_png;
            Func_BLIT2 = pUnityPlayer + offset_blit2;
        }
        public void LoadNativeMethod_IL2CPP(MonoRuntimeContext runtimeContext,
            string signature_encode_to_png = "UnityEngine.ImageConversion::EncodeToPNG(UnityEngine.Texture2D)",
            string signature_encode_blit2 = "UnityEngine.Graphics::Blit2(UnityEngine.Texture,UnityEngine.RenderTexture)",
            string signature_get_rect_Injected = "UnityEngine.Sprite::get_rect_Injected(UnityEngine.Rect&)",
             string signature_get_texture_rect_injected = "UnityEngine.Sprite::GetTextureRect_Injected(UnityEngine.Rect&)")
        {
            Func_ENCODE_TO_PNG = runtimeContext.GetInternalCall<Ptr_Func_ENCODE_TO_PNG>(signature_encode_to_png);
            Func_BLIT2 = runtimeContext.GetInternalCall<Ptr_Func_BLIT2>(signature_encode_blit2);
            Func_GET_RECT_INJECTED = runtimeContext.GetInternalCall<Ptr_Func_GET_RECT_INJECTED>(signature_get_rect_Injected);
            Func_GET_TEXTURE_RECT_INJECTED = runtimeContext.GetInternalCall<Ptr_Func_GET_TEXTURE_RECT_INJECTED>(signature_get_texture_rect_injected);

        }
    }

}
