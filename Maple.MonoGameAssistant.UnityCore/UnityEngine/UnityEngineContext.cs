using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using static Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite;
using static Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D;


namespace Maple.MonoGameAssistant.UnityCore.UnityEngine
{
    //    [MonoCollectorOptions(
    //typeof(MonoCollectorContext),
    //typeof(MonoCollectorMember),
    //typeof(MonoRuntimeContext),
    //typeof(MonoCollectorClassInfo)
    //)]
    //    //[MonoCollectorType(typeof(Sprite))]
    //    //[MonoCollectorType(typeof(Texture2D))]
    //    //[MonoCollectorType(typeof(RenderTexture))]
    //    [MonoCollectorType(typeof(Graphics))]
    //    [MonoCollectorType(typeof(ImageConversion))]
    //    public partial class UnityEngineContextGen { }

    public partial class UnityEngineContext : Maple.MonoGameAssistant.Core.MonoCollectorContext
    {

        Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollecotrClassSettings Settings_Sprite { get; } = new Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollecotrClassSettings
        {
            Utf8ImageName = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108],
            ImageName = "UnityEngine.CoreModule.dll",

            Utf8Namespace = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101],
            Namespace = "UnityEngine",

            Utf8ClassName = [83, 112, 114, 105, 116, 101],
            ClassName = "Sprite",


        };
        public Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite Sprite { get; }

        Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollecotrClassSettings Settings_Texture2D { get; } = new Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollecotrClassSettings
        {
            Utf8ImageName = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108],
            ImageName = "UnityEngine.CoreModule.dll",

            Utf8Namespace = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101],
            Namespace = "UnityEngine",

            Utf8ClassName = [84, 101, 120, 116, 117, 114, 101, 50, 68],
            ClassName = "Texture2D",


        };
        public Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D Texture2D { get; }

        Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollecotrClassSettings Settings_RenderTexture { get; } = new Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollecotrClassSettings
        {
            Utf8ImageName = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108],
            ImageName = "UnityEngine.CoreModule.dll",

            Utf8Namespace = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101],
            Namespace = "UnityEngine",

            Utf8ClassName = [82, 101, 110, 100, 101, 114, 84, 101, 120, 116, 117, 114, 101],
            ClassName = "RenderTexture",
        };
        public Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture RenderTexture { get; }

        Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollecotrClassSettings Settings_Graphics { get; } = new Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollecotrClassSettings
        {
            Utf8ImageName = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108],
            ImageName = "UnityEngine.CoreModule.dll",

            Utf8Namespace = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101],
            Namespace = "UnityEngine",

            Utf8ClassName = [71, 114, 97, 112, 104, 105, 99, 115],
            ClassName = "Graphics",


        };
        public Maple.MonoGameAssistant.UnityCore.UnityEngine.Graphics Graphics { get; }

        Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollecotrClassSettings Settings_ImageConversion { get; } = new Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollecotrClassSettings
        {
            Utf8ImageName = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 73, 109, 97, 103, 101, 67, 111, 110, 118, 101, 114, 115, 105, 111, 110, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108],
            ImageName = "UnityEngine.ImageConversionModule.dll",

            Utf8Namespace = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101],
            Namespace = "UnityEngine",

            Utf8ClassName = [73, 109, 97, 103, 101, 67, 111, 110, 118, 101, 114, 115, 105, 111, 110],
            ClassName = "ImageConversion",


        };
        public Maple.MonoGameAssistant.UnityCore.UnityEngine.ImageConversion ImageConversion { get; }

        public UnityEngineContext(Maple.MonoGameAssistant.Core.MonoRuntimeContext runtimeContext, Microsoft.Extensions.Logging.ILogger logger) : base(runtimeContext, EnumMonoCollectorTypeVersion.Unity, logger, "202410061855")
        {
            this.Sprite = this.CreateSprite();
            this.Texture2D = this.CreateTexture2D();
            this.RenderTexture = this.CreateRenderTexture();
            this.Graphics = this.CreateGraphics();
            this.ImageConversion = this.CreateImageConversion();
        }

        //#endregion

        private static void CopyToTexture2D(Ptr_Texture2D pSrc, Ptr_Texture2D pDest)
        {
            var w = pSrc.GET_WIDTH();
            var h = pSrc.GET_HEIGHT();


            var pRenderTexture = RenderTexture.Ptr_RenderTexture.GET_TEMPORARY_0A(w, h, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
            Graphics.Ptr_Graphics.BLIT2(pSrc, pRenderTexture);

            var previous = RenderTexture.Ptr_RenderTexture.GET_ACTIVE();
            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(pRenderTexture);

            pDest.CTOR_08(w, h);
            pDest.READ_PIXELS_IMPL_INJECTED(new Rect.Ref_Rect() { m_XMin = 0, m_YMin = 0, m_Height = h, m_Width = w }, 0, 0, true);
            pDest.APPLY_02();

            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(previous);
            RenderTexture.Ptr_RenderTexture.RELEASE_TEMPORARY(pRenderTexture);

        }
        private static void CopyToTexture2D2(Ptr_Texture2D pSrc, Ptr_Texture2D pDest, in Rect.Ref_Rect ref_Rect)
        {
            var texture2D_width = pSrc.GET_WIDTH();
            var texture2D_height = pSrc.GET_HEIGHT();

            var pRenderTexture = RenderTexture.Ptr_RenderTexture.GET_TEMPORARY_0A(texture2D_width, texture2D_height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
            Graphics.Ptr_Graphics.BLIT2(pSrc, pRenderTexture);

            var previous = RenderTexture.Ptr_RenderTexture.GET_ACTIVE();
            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(pRenderTexture);

            var w = (int)ref_Rect.m_Width;
            var h = (int)ref_Rect.m_Height;
            float textureY = texture2D_height - (ref_Rect.m_YMin + ref_Rect.m_Height);

            pDest.CTOR_08(w, h);
            pDest.READ_PIXELS_IMPL_INJECTED(
                new Rect.Ref_Rect() { m_XMin = ref_Rect.m_XMin, m_YMin = textureY, m_Width = ref_Rect.m_Width, m_Height = ref_Rect.m_Height }, 0, 0, true);
            pDest.APPLY_02();

            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(previous);
            RenderTexture.Ptr_RenderTexture.RELEASE_TEMPORARY(pRenderTexture);

        }
        private static void CopyToTexture2D3(Ptr_Texture2D pSrc, Ptr_Texture2D pDest, in Rect.Ref_Rect ref_Rect)
        {
            var texture2D_width = pSrc.GET_WIDTH();
            var texture2D_height = pSrc.GET_HEIGHT();

            var pRenderTexture = RenderTexture.Ptr_RenderTexture.GET_TEMPORARY_0A(texture2D_width, texture2D_height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
            Graphics.Ptr_Graphics.BLIT2(pSrc, pRenderTexture);

            var previous = RenderTexture.Ptr_RenderTexture.GET_ACTIVE();
            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(pRenderTexture);

            var w = (int)ref_Rect.m_Width;
            var h = (int)ref_Rect.m_Height;

            pDest.CTOR_08(w, h);
            pDest.READ_PIXELS_IMPL_INJECTED(ref_Rect, 0, 0, true);
            pDest.APPLY_02();

            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(previous);
            RenderTexture.Ptr_RenderTexture.RELEASE_TEMPORARY(pRenderTexture);

        }

        public PMonoArray<byte> ReadSprite2Png(Ptr_Sprite pSprite, int type = 2)
        {
            if (false == pSprite.Valid())
            {
                return default;
            }
            var pSrcTexture2D = pSprite.GET_TEXTURE();
            if (false == pSrcTexture2D.Valid())
            {
                return default;
            }
            var pDestTexture2D = this.Texture2D.New<Ptr_Texture2D>(false);
            switch (type)
            {
                case 2:
                    {
                        pSprite.GET_TEXTURE_RECT_INJECTED(out var ref_Rect);
                        CopyToTexture2D2(pSrcTexture2D, pDestTexture2D, ref_Rect);

                        break;
                    }
                case 3:
                    {
                        pSprite.GET_TEXTURE_RECT_INJECTED(out var ref_Rect);
                        CopyToTexture2D3(pSrcTexture2D, pDestTexture2D, ref_Rect);
                        break;
                    }
                case 1:
                default:
                    {
                        CopyToTexture2D(pSrcTexture2D, pDestTexture2D);
                        break;
                    }
            }
            return ImageConversion.Ptr_ImageConversion.ENCODE_TO_PNG(pDestTexture2D);
        }

        public static UnityEngineContext? LoadUnityContext(MonoRuntimeContext runtimeContext, ILogger logger)
        {
            return runtimeContext.RuntimeType switch
            {
                EnumMonoRuntimeType.MONO => new UnityEngineContext_MONO(runtimeContext, logger),
                EnumMonoRuntimeType.IL2CPP => new UnityEngineContext_IL2CPP(runtimeContext, logger),
                _ => default
            };
        }


        protected Sprite CreateSprite()
        {
            var classInfo = this.GetClassInfo(Settings_Sprite);
            var obj = new Sprite(this, classInfo);
            Sprite.Set_Func_GET_TEXTURE(GetMethodPointerIfThrowNotFound(classInfo, Settings_Sprite, Sprite.Name_Func_GET_TEXTURE));
            Sprite.Set_Func_GET_TEXTURE_RECT_INJECTED(GetMethodPointerIfThrowNotFound(classInfo, Settings_Sprite, Sprite.Name_Func_GET_TEXTURE_RECT_INJECTED));
            return obj;

        }
        protected Texture2D CreateTexture2D()
        {
            var classInfo = this.GetClassInfo(Settings_Texture2D);
            var obj = new Texture2D(this, classInfo);


            Texture2D.Set_Func_GET_HEIGHT(GetMethodPointerIfThrowNotFound(classInfo, Settings_Texture2D, Texture2D.Name_Func_GET_HEIGHT));
            Texture2D.Set_Func_GET_WIDTH(GetMethodPointerIfThrowNotFound(classInfo, Settings_Texture2D, Texture2D.Name_Func_GET_WIDTH));
            Texture2D.Set_Func_READ_PIXELS_IMPL_INJECTED(GetMethodPointerIfThrowNotFound(classInfo, Settings_Texture2D, Texture2D.Name_Func_READ_PIXELS_IMPL_INJECTED));
            Texture2D.Set_Func_CTOR_08(GetMethodPointerIfThrowNotFound(classInfo, Settings_Texture2D, Texture2D.Name_Func_CTOR, Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Search_Texture2D.CTOR_08));
            Texture2D.Set_Func_APPLY_02(GetMethodPointerIfThrowNotFound(classInfo, Settings_Texture2D, Texture2D.Name_Func_APPLY, Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Search_Texture2D.APPLY_02));


            return obj;
        }
        protected RenderTexture CreateRenderTexture()
        {
            var classInfo = this.GetClassInfo(Settings_RenderTexture);
            var obj = new RenderTexture(this, classInfo);

            RenderTexture.Set_Func_GET_ACTIVE(GetMethodPointerIfThrowNotFound(classInfo, Settings_RenderTexture, RenderTexture.Name_Func_GET_ACTIVE));

            RenderTexture.Set_Func_RELEASE_TEMPORARY(GetMethodPointerIfThrowNotFound(classInfo, Settings_RenderTexture, RenderTexture.Name_Func_RELEASE_TEMPORARY));

            RenderTexture.Set_Func_SET_ACTIVE(GetMethodPointerIfThrowNotFound(classInfo, Settings_RenderTexture, RenderTexture.Name_Func_SET_ACTIVE));

            RenderTexture.Set_Func_GET_HEIGHT_00(GetMethodPointerIfThrowNotFound(classInfo, Settings_RenderTexture, RenderTexture.Name_Func_GET_HEIGHT));

            RenderTexture.Set_Func_GET_WIDTH_00(GetMethodPointerIfThrowNotFound(classInfo, Settings_RenderTexture, RenderTexture.Name_Func_GET_WIDTH));

            RenderTexture.Set_Func_GET_TEMPORARY_0A(GetMethodPointerIfThrowNotFound(classInfo, Settings_RenderTexture, RenderTexture.Name_Func_GET_TEMPORARY, Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture.Search_RenderTexture.GET_TEMPORARY_0A));


            return obj;
        }

        protected Graphics CreateGraphics()
        {
            Graphics.Set_Func_BLIT2(GetMethodPointerIfThrowNotFound(default, Settings_Graphics, Graphics.Name_Func_BLIT2));
            return default!;
        }
        protected ImageConversion CreateImageConversion()
        {
            ImageConversion.Set_Func_ENCODE_TO_PNG(GetMethodPointerIfThrowNotFound(default, Settings_ImageConversion, ImageConversion.Name_Func_ENCODE_TO_PNG));
            return default!;
        }

        protected virtual bool TryGetCustomMethodPointer(MonoCollecotrClassSettings classSettings, string methodName, out nint address)
        {
            Unsafe.SkipInit(out address);
            return false;
        }
        nint GetMethodPointerIfThrowNotFound(MonoCollectorClassInfo? classInfo, MonoCollecotrClassSettings classSettings, string methodName)
            => GetMethodPointerIfThrowNotFound(classInfo, classSettings, methodName, p => p.Name == methodName);
        nint GetMethodPointerIfThrowNotFound(MonoCollectorClassInfo? classInfo, MonoCollecotrClassSettings classSettings, string methodName, Func<MonoMethodInfoDTO, bool> math)
        {
            if (classInfo is not null && this.TryGetMethodPointer(classInfo, math, out var addr_Func_GET_TEXTURE))
            {
                return addr_Func_GET_TEXTURE;
            }
            if (this.TryGetCustomMethodPointer(classSettings, methodName, out addr_Func_GET_TEXTURE))
            {
                return addr_Func_GET_TEXTURE;
            }
            return MonoCollectorObjectException.Throw<nint>($"{classSettings.ImageName}.{classSettings.Namespace}.{classSettings.ClassName}.{methodName}:NOT FOUND");

        }

    }

    public sealed partial class UnityEngineContext_MONO(MonoRuntimeContext runtimeContext, ILogger logger) : UnityEngineContext(runtimeContext, logger)
    {
        public static nint UnityPlayer { get; set; } = MonoCollectorMember.GetModuleBaseAddress("UnityPlayer.dll");
        public static int Func_ENCODE_TO_PNG { get; set; }
        public static int Func_BLIT2 { get; set; }
        public static int Func_GET_TEXTURE_RECT_INJECTED { get; set; }
        public static int Func_READ_PIXELS_IMPL_INJECTED { get; set; }

        protected sealed override bool TryGetCustomMethodPointer(MonoCollecotrClassSettings classSettings, string methodName, out nint address)
        {
            var offset = methodName switch
            {
                Name_Func_GET_TEXTURE_RECT_INJECTED => Func_GET_TEXTURE_RECT_INJECTED,
                ImageConversion.Name_Func_ENCODE_TO_PNG => Func_ENCODE_TO_PNG,
                Graphics.Name_Func_BLIT2 => Func_BLIT2,
                Name_Func_READ_PIXELS_IMPL_INJECTED => Func_READ_PIXELS_IMPL_INJECTED,
                _ => nint.Zero,
            };
            address = offset + UnityPlayer;
            return offset != nint.Zero;
        }


    }

    public sealed partial class UnityEngineContext_IL2CPP(MonoRuntimeContext runtimeContext, ILogger logger) : UnityEngineContext(runtimeContext, logger)
    {
        /// <summary>
        /// UnityEngine.Sprite.get_texture - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_Sprite_get_texture
            = "UnityEngine.Sprite::get_texture()";

        /// <summary>
        /// UnityEngine.Texture.GetDataHeight - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_Texture_GetDataHeight
            = "UnityEngine.Texture::GetDataHeight()";

        /// <summary>
        /// UnityEngine.Texture.GetDataWidth - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_Texture_GetDataWidth
            = "UnityEngine.Texture::GetDataWidth()";

        /// <summary>
        /// UnityEngine.ImageConversion.EncodeToPNG - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_ImageConversion_EncodeToPNG
            = "UnityEngine.ImageConversion::EncodeToPNG(UnityEngine.Texture2D)";

        /// <summary>
        /// UnityEngine.Graphics.Blit2 - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public const string UnityEngine_Graphics_Blit2
            = "UnityEngine.Graphics::Blit2(UnityEngine.Texture,UnityEngine.RenderTexture)";

        /// <summary>
        /// UnityEngine.Sprite.get_rect_Injected - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public const string UnityEngine_Sprite_get_rect_Injected
            = "UnityEngine.Sprite::get_rect_Injected(UnityEngine.Rect&)";

        /// <summary>
        /// UnityEngine.Sprite.get_textureRect - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public const string UnityEngine_Sprite_GetTextureRect_Injected
            = "UnityEngine.Sprite::GetTextureRect_Injected(UnityEngine.Rect&)";

        public const string UnityEngine_RenderTexture_GetTemporary_Internal_Injected
            = "UnityEngine.RenderTexture::GetTemporary_Internal_Injected(UnityEngine.RenderTextureDescriptor&)";

        /// <summary>
        /// UnityEngine.RenderTexture.get_active - 48 83 EC 28           - sub rsp,28 { 40 }
        /// </summary>
        public const string UnityEngine_RenderTexture_GetActive = "UnityEngine.RenderTexture::GetActive()";

        /// <summary>
        /// UnityEngine.RenderTexture.SetActive - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_RenderTexture_SetActive = "UnityEngine.RenderTexture::SetActive(UnityEngine.RenderTexture)";


        /// <summary>
        /// UnityEngine.RenderTexture.ReleaseTemporary - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_RenderTexture_ReleaseTemporary = "UnityEngine.RenderTexture::ReleaseTemporary(UnityEngine.RenderTexture)";

        /// <summary>
        /// 
        /// UnityEngine.Texture2D.ReadPixelsImpl_Injected - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public const string UnityEngine_Texture2D_ReadPixelsImpl_Injected = "UnityEngine.Texture2D::ReadPixelsImpl_Injected(UnityEngine.Rect&,System.Int32,System.Int32,System.Boolean)";



        protected sealed override bool TryGetCustomMethodPointer(MonoCollecotrClassSettings classSettings, string methodName, out nint address)
        {
            address = methodName switch
            {
                Name_Func_GET_TEXTURE_RECT_INJECTED => (nint)RuntimeContext.GetInternalCall(UnityEngine_Sprite_GetTextureRect_Injected),
                ImageConversion.Name_Func_ENCODE_TO_PNG => (nint)RuntimeContext.GetInternalCall(UnityEngine_ImageConversion_EncodeToPNG),
                Graphics.Name_Func_BLIT2 => (nint)RuntimeContext.GetInternalCall(UnityEngine_Graphics_Blit2),
                Name_Func_READ_PIXELS_IMPL_INJECTED => (nint)RuntimeContext.GetInternalCall(UnityEngine_Texture2D_ReadPixelsImpl_Injected),
                _ => nint.Zero,
            };
            return address != nint.Zero;
        }
    }



}
