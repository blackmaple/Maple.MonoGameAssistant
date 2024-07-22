using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;
using static Maple.MonoGameAssistant.UnityCore.UnityEngine.Sprite;
using static Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D;

namespace Maple.MonoGameAssistant.UnityCore.UnityEngine
{

    [MonoCollectorOptions(
    typeof(MonoCollectorContext),
    typeof(MonoCollectorMember),
    typeof(MonoRuntimeContext),
    typeof(MonoCollectorClassInfo)
    )]
    [MonoCollectorType(typeof(Sprite))]
    [MonoCollectorType(typeof(Texture2D))]
    [MonoCollectorType(typeof(RenderTexture))]
    // [MonoCollectorType(typeof(Graphics))]
    // [MonoCollectorType(typeof(Material))]

    //[MonoCollectorTypeVersion(typeof(UnityEngineContext_MONO), EnumMonoCollectorTypeVersion.Ver_MONO)]
    //[MonoCollectorTypeVersion(typeof(UnityEngineContext_IL2CPP), EnumMonoCollectorTypeVersion.Ver_IL2CPP)]
    // [MonoCollectorType(typeof(ImageConversion), Ver = EnumMonoCollectorTypeVersion.Ver_IL2CPP)]
    public partial class UnityEngineContext
    {
        protected UnityPlayerNativeMethodSetting NativeMethodSetting { get; } = new UnityPlayerNativeMethodSetting();

        private void CopyToTexture2D(Ptr_Texture2D pSrc, Ptr_Texture2D pDest)
        {
            var w = pSrc.GET_WIDTH();
            var h = pSrc.GET_HEIGHT();


            var pRenderTexture = RenderTexture.Ptr_RenderTexture.GET_TEMPORARY_0A(w, h, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
            // Graphics.Ptr_Graphics.BLIT_02(pSrc, pRenderTexture, defMaterial);
            NativeMethodSetting.BLIT2(pSrc, pRenderTexture);

            var previous = RenderTexture.Ptr_RenderTexture.GET_ACTIVE();
            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(pRenderTexture);

            pDest.CTOR_08(w, h);
            pDest.READ_PIXELS_01(new Rect.Ref_Rect() { m_XMin = 0, m_YMin = 0, m_Height = h, m_Width = w }, 0, 0);
            pDest.APPLY_02();

            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(previous);
            RenderTexture.Ptr_RenderTexture.RELEASE_TEMPORARY(pRenderTexture);

        }
        private void CopyToTexture2D2(Ptr_Texture2D pSrc, Ptr_Texture2D pDest, in Rect.Ref_Rect ref_Rect)
        {
            var texture2D_width = pSrc.GET_WIDTH();
            var texture2D_height = pSrc.GET_HEIGHT();

            var pRenderTexture = RenderTexture.Ptr_RenderTexture.GET_TEMPORARY_0A(texture2D_width, texture2D_height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
            // Graphics.Ptr_Graphics.BLIT_02(pSrc, pRenderTexture, defMaterial);
            NativeMethodSetting.BLIT2(pSrc, pRenderTexture);

            var previous = RenderTexture.Ptr_RenderTexture.GET_ACTIVE();
            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(pRenderTexture);

            var w = (int)ref_Rect.m_Width;
            var h = (int)ref_Rect.m_Height;
            float textureY = texture2D_height - (ref_Rect.m_YMin + ref_Rect.m_Height);

            pDest.CTOR_08(w, h);
            pDest.READ_PIXELS_01(
                new Rect.Ref_Rect() { m_XMin = ref_Rect.m_XMin, m_YMin = textureY, m_Width = ref_Rect.m_Width, m_Height = ref_Rect.m_Height }, 0, 0);
            pDest.APPLY_02();

            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(previous);
            RenderTexture.Ptr_RenderTexture.RELEASE_TEMPORARY(pRenderTexture);

        }

        public PMonoArray<byte> ReadSprite2Png(Ptr_Sprite pSprite)
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
            CopyToTexture2D(pSrcTexture2D, pDestTexture2D);
            return NativeMethodSetting.EncodeToPng(pDestTexture2D);
        }

        public PMonoArray<byte> ReadSprite2Png2(Ptr_Sprite pSprite)
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

            UnityPlayerNativeMethodSetting.GET_TEXTURE_RECT_INJECTED(pSprite, out var ref_Rect);
            this.Logger.LogInformation("{x}/{y}/{h}/{w}", ref_Rect.m_XMin, ref_Rect.m_YMin, ref_Rect.m_Height, ref_Rect.m_Width);

            var pDestTexture2D = this.Texture2D.New<Ptr_Texture2D>(false);
            CopyToTexture2D2(pSrcTexture2D, pDestTexture2D, ref_Rect);
            return NativeMethodSetting.EncodeToPng(pDestTexture2D);
        }

    }

    public sealed partial class UnityEngineContext_MONO : UnityEngineContext
    {
        public UnityEngineContext_MONO(MonoRuntimeContext runtimeContext, ILogger logger) : base(runtimeContext, EnumMonoCollectorTypeVersion.MONO, logger, "202407222110")
        {
            //用MONO 编译的GAME 获取到UnityPlayer.dll 函数地址偏移不一样 需要根据每个游戏修改
            this.NativeMethodSetting.LoadNativeMethod_MONO(offset_encode_to_png: 0x217030, offset_blit2: 0x878C0);
        }
    }

    public sealed partial class UnityEngineContext_IL2CPP : UnityEngineContext
    {
        public UnityEngineContext_IL2CPP(MonoRuntimeContext runtimeContext, ILogger logger) : base(runtimeContext, EnumMonoCollectorTypeVersion.IL2CPP, logger, "202407222110")
        {
            this.NativeMethodSetting.LoadNativeMethod_IL2CPP(runtimeContext);
        }



    }

}
