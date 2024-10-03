using Maple.MonoGameAssistant.Core;
using System.Text;
using static Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D;

namespace Maple.MonoGameAssistant.UnityCore.UnityEngine
{
    public class UnityPlayerNativeMethodSetting
    {

        readonly unsafe partial struct Ptr_Func_Sprite_GET_TEXTURE(nint ptr)
        {
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D> _func
                = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D>)ptr;

            public static implicit operator Ptr_Func_Sprite_GET_TEXTURE(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite __this__) => _func(__this__);
        }
        Ptr_Func_Sprite_GET_TEXTURE Func_Sprite_GET_TEXTURE;
        public Texture2D.Ptr_Texture2D Sprite_GET_TEXTURE(Sprite.Ptr_Sprite ptr_Sprite) => Func_Sprite_GET_TEXTURE.Invoke(ptr_Sprite);

        readonly unsafe partial struct Ptr_Func_Texture2D_GET_WIDTH(nint ptr)
        {
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, int>)ptr;

            public static implicit operator Ptr_Func_Texture2D_GET_WIDTH(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public int Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D __this__) => _func(__this__);
        }
        Ptr_Func_Texture2D_GET_WIDTH Func_Texture2D_GET_WIDTH;
        public int Texture2D_GET_WIDTH(Ptr_Texture2D pDest)
        {
            return Func_Texture2D_GET_WIDTH.Invoke(pDest);
        }

        readonly unsafe partial struct Ptr_Func_Texture2D_GET_HEIGHT(nint ptr)
        {
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, int>)ptr;

            public static implicit operator Ptr_Func_Texture2D_GET_HEIGHT(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public int Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D __this__) => _func(__this__);
        }
        Ptr_Func_Texture2D_GET_HEIGHT Func_Texture2D_GET_HEIGHT;
        public int Texture2D_GET_HEIGHT(Ptr_Texture2D pDest)
        {
            return Func_Texture2D_GET_HEIGHT.Invoke(pDest);
        }


        /// <summary>
        /// UnityEngine.ImageConversion:EncodeToPNG+77 - 48 B8 307087C6FA7F0000 - mov rax,UnityPlayer.dll+217030 { ("@USWH?l$?H???") }
        /// </summary>
        readonly unsafe partial struct Ptr_Func_Texture2D_ENCODE_TO_PNG(nint ptr)
        {
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, Maple.MonoGameAssistant.Core.PMonoArray<byte>> _func
                = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, Maple.MonoGameAssistant.Core.PMonoArray<byte>>)ptr;

            public static implicit operator Ptr_Func_Texture2D_ENCODE_TO_PNG(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public Maple.MonoGameAssistant.Core.PMonoArray<byte> Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D tex) => _func(tex);
        }
        Ptr_Func_Texture2D_ENCODE_TO_PNG Func_Texture2D_ENCODE_TO_PNG;
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public PMonoArray<byte> Texture2D_ENCODE_TO_PNG(Ptr_Texture2D pDest)
        {
            return Func_Texture2D_ENCODE_TO_PNG.Invoke(pDest);
        }

        /// <summary>
        /// UnityEngine.Graphics:Blit2+7f - 48 B8 C078C247FA7F0000 - mov rax,UnityPlayer.dll+878C0 { ("@USWATAUH?l$?H??0") }
        /// </summary>
        readonly unsafe partial struct Ptr_Func_BLIT2(nint ptr)
        {
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<nint, nint, void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<nint, nint, void>)ptr;

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
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, void> _func
                = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, void>)ptr;

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
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, void> _func
                = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, void>)ptr;

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


        //readonly unsafe partial struct Ptr_Func_APPLYIMP
        //{
        //    readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, void> _func
        //        = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite.Ptr_Sprite, out Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, void>)ptr;

        //}

        public void LoadNativeMethod_MONO(int offset_encode_to_png = 0x217030, int offset_blit2 = 0x878C0)
        {
            var pUnityPlayer = MonoCollectorMember.GetModuleBaseAddress("UnityPlayer.dll");
            Func_Texture2D_ENCODE_TO_PNG = pUnityPlayer + offset_encode_to_png;
            Func_BLIT2 = pUnityPlayer + offset_blit2;
        }
        public void LoadNativeMethod_MONO(in UnityNativeMethodOffset nativeMethodOffset)
        {
            var pUnityPlayer = MonoCollectorMember.GetModuleBaseAddress("UnityPlayer.dll");
            Func_Texture2D_ENCODE_TO_PNG = pUnityPlayer + nativeMethodOffset.Func_ENCODE_TO_PNG;
            Func_BLIT2 = pUnityPlayer + nativeMethodOffset.Func_BLIT2;
            Func_GET_RECT_INJECTED = pUnityPlayer + nativeMethodOffset.Func_GET_RECT_INJECTED;
            Func_GET_TEXTURE_RECT_INJECTED = pUnityPlayer + nativeMethodOffset.Func_GET_TEXTURE_RECT_INJECTED;
        }
        public void LoadNativeMethod_IL2CPP(MonoRuntimeContext runtimeContext,
            string signature_encode_to_png = "UnityEngine.ImageConversion::EncodeToPNG(UnityEngine.Texture2D)",
            string signature_encode_blit2 = "UnityEngine.Graphics::Blit2(UnityEngine.Texture,UnityEngine.RenderTexture)",
            string signature_get_rect_Injected = "UnityEngine.Sprite::get_rect_Injected(UnityEngine.Rect&)",
             string signature_get_texture_rect_injected = "UnityEngine.Sprite::GetTextureRect_Injected(UnityEngine.Rect&)")
        {
            Func_Texture2D_ENCODE_TO_PNG = runtimeContext.GetInternalCall<Ptr_Func_Texture2D_ENCODE_TO_PNG>(signature_encode_to_png);
            Func_BLIT2 = runtimeContext.GetInternalCall<Ptr_Func_BLIT2>(signature_encode_blit2);
            Func_GET_RECT_INJECTED = runtimeContext.GetInternalCall<Ptr_Func_GET_RECT_INJECTED>(signature_get_rect_Injected);
            Func_GET_TEXTURE_RECT_INJECTED = runtimeContext.GetInternalCall<Ptr_Func_GET_TEXTURE_RECT_INJECTED>(signature_get_texture_rect_injected);

        }


        public string DebugOutput()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Func_ENCODE_TO_PNG:{Func_Texture2D_ENCODE_TO_PNG.ToString()}");
            sb.AppendLine($"Func_BLIT2:{Func_BLIT2.ToString()}");
            sb.AppendLine($"Func_GET_RECT_INJECTED:{Func_GET_RECT_INJECTED.ToString()}");
            sb.AppendLine($"Func_GET_TEXTURE_RECT_INJECTED:{Func_GET_TEXTURE_RECT_INJECTED.ToString()}");
            return sb.ToString();
        }
    }


    public struct UnityNativeMethodOffset
    {
        public int Func_ENCODE_TO_PNG { set; get; }
        public int Func_BLIT2 { set; get; }
        public int Func_GET_RECT_INJECTED { set; get; }
        public int Func_GET_TEXTURE_RECT_INJECTED { set; get; }



    }



    public struct UnityNativeMethodSignature()
    {

        /// <summary>
        /// UnityEngine.Sprite.get_texture - 40 53                 - push rbx
        /// </summary>
        public string UnityEngine_Sprite_get_texture { set; get; }
            = "UnityEngine.Sprite::get_texture()";

        /// <summary>
        /// UnityEngine.Texture.GetDataHeight - 40 53                 - push rbx
        /// </summary>
        public string UnityEngine_Texture_GetDataHeight { set; get; }
            = "UnityEngine.Texture::GetDataHeight()";

        /// <summary>
        /// UnityEngine.Texture.GetDataWidth - 40 53                 - push rbx
        /// </summary>
        public string UnityEngine_Texture_GetDataWidth { set; get; }
            = "UnityEngine.Texture::GetDataWidth()";

        /// <summary>
        /// UnityEngine.ImageConversion.EncodeToPNG - 40 53                 - push rbx
        /// </summary>
        public string UnityEngine_ImageConversion_EncodeToPNG { set; get; }
            = "UnityEngine.ImageConversion::EncodeToPNG(UnityEngine.Texture2D)";

        /// <summary>
        /// UnityEngine.Graphics.Blit2 - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public string UnityEngine_Graphics_Blit2 { set; get; }
            = "UnityEngine.Graphics::Blit2(UnityEngine.Texture,UnityEngine.RenderTexture)";

        /// <summary>
        /// UnityEngine.Sprite.get_rect_Injected - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public string UnityEngine_Sprite_get_rect_Injected { set; get; }
            = "UnityEngine.Sprite::get_rect_Injected(UnityEngine.Rect&)";

        /// <summary>
        /// UnityEngine.Sprite.get_textureRect - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public string UnityEngine_Sprite_GetTextureRect_Injected { set; get; }
            = "UnityEngine.Sprite::GetTextureRect_Injected(UnityEngine.Rect&)";

        public string UnityEngine_RenderTexture_GetTemporary_Internal_Injected { set; get; }
            = "UnityEngine.RenderTexture::GetTemporary_Internal_Injected(UnityEngine.RenderTextureDescriptor&)";

        /// <summary>
        /// UnityEngine.RenderTexture.get_active - 48 83 EC 28           - sub rsp,28 { 40 }
        /// </summary>
        public string UnityEngine_RenderTexture_GetActive = "UnityEngine.RenderTexture::GetActive()";

        /// <summary>
        /// UnityEngine.RenderTexture.SetActive - 40 53                 - push rbx
        /// </summary>
        public string UnityEngine_RenderTexture_SetActive = "UnityEngine.RenderTexture::SetActive(UnityEngine.RenderTexture)";


        /// <summary>
        /// UnityEngine.RenderTexture.ReleaseTemporary - 40 53                 - push rbx
        /// </summary>
        public string UnityEngine_RenderTexture_ReleaseTemporary = "UnityEngine.RenderTexture::ReleaseTemporary(UnityEngine.RenderTexture)";

        /// <summary>
        /// UnityEngine.Texture2D.ReadPixelsImpl_Injected - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public string UnityEngine_Texture2D_ReadPixelsImpl_Injected = "UnityEngine.Texture2D::ReadPixelsImpl_Injected(UnityEngine.Rect&,System.Int32,System.Int32,System.Boolean)";
    }
}
