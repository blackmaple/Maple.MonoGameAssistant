using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.UnityCore.UnityEngine
{

    /// <summary>
    /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Graphics"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], 0x02000080U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101], [71, 114, 97, 112, 104, 105, 99, 115])]
    public partial class Graphics
    {
        //public const string Const_ImageName = "UnityEngine.CoreModule.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108];

        //public const string Const_Namespace = "UnityEngine";
        //public static byte[] Static_Namespace { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101];

        //public const string Const_ClassName = "Graphics";
        //public static byte[] Static_ClassName { get; } = [71, 114, 97, 112, 104, 105, 99, 115];

        //public const uint Const_TypeToken = 0x02000080U;






        [StructLayout(LayoutKind.Explicit)]
        public readonly unsafe partial struct Static_Graphics
        {



            /// <summary>
            /// struct 0x0 System.Int32 kMaxDrawMeshInstanceCount
            /// </summary>
            [FieldOffset(0x0)]
            public readonly System.Int32 kMaxDrawMeshInstanceCount;

        }


        [StructLayout(LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_Graphics
        {


            /// <summary>
            /// REF_MONO_OBJECT._vtable
            /// </summary>
            [MarshalAs(UnmanagedType.SysInt)]
            [FieldOffset(0)]
            public readonly nint _vtable;

            /// <summary>
            /// REF_MONO_OBJECT._synchronisation
            /// </summary>
            [MarshalAs(UnmanagedType.SysInt)]
            [FieldOffset(8)]
            public readonly nint _synchronisation;



        }
        [StructLayout(LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Graphics(nint ptr)
        {

            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Graphics(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Graphics obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_Graphics AsRef()
            {
                return ref Unsafe.AsRef<Ref_Graphics>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["UnityEngine.CoreModule.dll"."UnityEngine"."Graphics"]
    /// </summary>
    public partial class Graphics
    {



        /// const string Name_Func_.CCTOR = ".cctor";
        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void .CCTOR ();


        /// const string Name_Func_BLIT2 = "Blit2";
        /// <summary>
        /// static  System.Void Blit2(UnityEngine.Texture source,UnityEngine.RenderTexture dest)
        /// </summary>
        /// <param name="source">class UnityEngine.Texture</param>
        /// <param name="dest">class UnityEngine.RenderTexture</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void BLIT2 (nint source,nint dest);


        /// const string Name_Func_COPY_TEXTURE_REGION = "CopyTexture_Region";
        /// <summary>
        /// static  System.Void CopyTexture_Region(UnityEngine.Texture src,System.Int32 srcElement,System.Int32 srcMip,System.Int32 srcX,System.Int32 srcY,System.Int32 srcWidth,System.Int32 srcHeight,UnityEngine.Texture dst,System.Int32 dstElement,System.Int32 dstMip,System.Int32 dstX,System.Int32 dstY)
        /// </summary>
        /// <param name="src">class UnityEngine.Texture</param>
        /// <param name="srcElement">struct System.Int32</param>
        /// <param name="srcMip">struct System.Int32</param>
        /// <param name="srcX">struct System.Int32</param>
        /// <param name="srcY">struct System.Int32</param>
        /// <param name="srcWidth">struct System.Int32</param>
        /// <param name="srcHeight">struct System.Int32</param>
        /// <param name="dst">class UnityEngine.Texture</param>
        /// <param name="dstElement">struct System.Int32</param>
        /// <param name="dstMip">struct System.Int32</param>
        /// <param name="dstX">struct System.Int32</param>
        /// <param name="dstY">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void COPY_TEXTURE_REGION (nint src,System.Int32 srcElement,System.Int32 srcMip,System.Int32 srcX,System.Int32 srcY,System.Int32 srcWidth,System.Int32 srcHeight,nint dst,System.Int32 dstElement,System.Int32 dstMip,System.Int32 dstX,System.Int32 dstY);


        /// const string Name_Func_COPY_TEXTURE_SLICE = "CopyTexture_Slice";
        /// <summary>
        /// static  System.Void CopyTexture_Slice(UnityEngine.Texture src,System.Int32 srcElement,System.Int32 srcMip,UnityEngine.Texture dst,System.Int32 dstElement,System.Int32 dstMip)
        /// </summary>
        /// <param name="src">class UnityEngine.Texture</param>
        /// <param name="srcElement">struct System.Int32</param>
        /// <param name="srcMip">struct System.Int32</param>
        /// <param name="dst">class UnityEngine.Texture</param>
        /// <param name="dstElement">struct System.Int32</param>
        /// <param name="dstMip">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void COPY_TEXTURE_SLICE (nint src,System.Int32 srcElement,System.Int32 srcMip,nint dst,System.Int32 dstElement,System.Int32 dstMip);


        /// const string Name_Func_EXECUTE_COMMAND_BUFFER = "ExecuteCommandBuffer";
        /// <summary>
        /// static  System.Void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer)
        /// </summary>
        /// <param name="buffer">class UnityEngine.Rendering.CommandBuffer</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void EXECUTE_COMMAND_BUFFER (nint buffer);


        /// const string Name_Func_GET_ACTIVE_TIER = "get_activeTier";
        /// <summary>
        /// static  UnityEngine.Rendering.GraphicsTier get_activeTier()
        /// </summary>
        /// <returns>enum UnityEngine.Rendering.GraphicsTier</returns>
        /// public static extern UnityEngine.Rendering.GraphicsTier GET_ACTIVE_TIER ();


        /// const string Name_Func_GET_MIN_OPEN_GLES_VERSION = "get_minOpenGLESVersion";
        /// <summary>
        /// static  UnityEngine.Rendering.OpenGLESVersion get_minOpenGLESVersion()
        /// </summary>
        /// <returns>enum UnityEngine.Rendering.OpenGLESVersion</returns>
        /// public static extern UnityEngine.Rendering.OpenGLESVersion GET_MIN_OPEN_GLES_VERSION ();


        /// const string Name_Func_GET_PRESERVE_FRAMEBUFFER_ALPHA = "get_preserveFramebufferAlpha";
        /// <summary>
        /// static  System.Boolean get_preserveFramebufferAlpha()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean GET_PRESERVE_FRAMEBUFFER_ALPHA ();


        /// const string Name_Func_GET_MIN_OPEN_GLES_VERSION = "GetMinOpenGLESVersion";
        /// <summary>
        /// static  UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion()
        /// </summary>
        /// <returns>enum UnityEngine.Rendering.OpenGLESVersion</returns>
        /// public static extern UnityEngine.Rendering.OpenGLESVersion GET_MIN_OPEN_GLES_VERSION ();


        /// const string Name_Func_GET_PRESERVE_FRAMEBUFFER_ALPHA = "GetPreserveFramebufferAlpha";
        /// <summary>
        /// static  System.Boolean GetPreserveFramebufferAlpha()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean GET_PRESERVE_FRAMEBUFFER_ALPHA ();


        /// const string Name_Func_INTERNAL_BLIT_MATERIAL5 = "Internal_BlitMaterial5";
        /// <summary>
        /// static  System.Void Internal_BlitMaterial5(UnityEngine.Texture source,UnityEngine.RenderTexture dest,UnityEngine.Material mat,System.Int32 pass,System.Boolean setRT)
        /// </summary>
        /// <param name="source">class UnityEngine.Texture</param>
        /// <param name="dest">class UnityEngine.RenderTexture</param>
        /// <param name="mat">class UnityEngine.Material</param>
        /// <param name="pass">struct System.Int32</param>
        /// <param name="setRT">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void INTERNAL_BLIT_MATERIAL5 (nint source,nint dest,nint mat,System.Int32 pass,System.Boolean setRT);


        /// const string Name_Func_INTERNAL_DRAW_MESH_NOW2 = "Internal_DrawMeshNow2";
        /// <summary>
        /// static  System.Void Internal_DrawMeshNow2(UnityEngine.Mesh mesh,System.Int32 subsetIndex,UnityEngine.Matrix4x4 matrix)
        /// </summary>
        /// <param name="mesh">class UnityEngine.Mesh</param>
        /// <param name="subsetIndex">struct System.Int32</param>
        /// <param name="matrix">struct UnityEngine.Matrix4x4</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void INTERNAL_DRAW_MESH_NOW2 (nint mesh,System.Int32 subsetIndex,UnityEngine.Matrix4x4 matrix);


        /// const string Name_Func_INTERNAL_DRAW_MESH_NOW2_INJECTED = "Internal_DrawMeshNow2_Injected";
        /// <summary>
        /// static  System.Void Internal_DrawMeshNow2_Injected(UnityEngine.Mesh mesh,System.Int32 subsetIndex,UnityEngine.Matrix4x4& matrix)
        /// </summary>
        /// <param name="mesh">class UnityEngine.Mesh</param>
        /// <param name="subsetIndex">struct System.Int32</param>
        /// <param name="matrix">struct UnityEngine.Matrix4x4&</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void INTERNAL_DRAW_MESH_NOW2_INJECTED (nint mesh,System.Int32 subsetIndex,UnityEngine.Matrix4x4& matrix);


        /// const string Name_Func_INTERNAL_GET_MAX_DRAW_MESH_INSTANCE_COUNT = "Internal_GetMaxDrawMeshInstanceCount";
        /// <summary>
        /// static  System.Int32 Internal_GetMaxDrawMeshInstanceCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public static extern System.Int32 INTERNAL_GET_MAX_DRAW_MESH_INSTANCE_COUNT ();


        /// const string Name_Func_INTERNAL_SET_NULL_RT = "Internal_SetNullRT";
        /// <summary>
        /// static  System.Void Internal_SetNullRT()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void INTERNAL_SET_NULL_RT ();


        /// const string Name_Func_INTERNAL_SET_RT_SIMPLE = "Internal_SetRTSimple";
        /// <summary>
        /// static  System.Void Internal_SetRTSimple(UnityEngine.RenderBuffer color,UnityEngine.RenderBuffer depth,System.Int32 mip,UnityEngine.CubemapFace face,System.Int32 depthSlice)
        /// </summary>
        /// <param name="color">struct UnityEngine.RenderBuffer</param>
        /// <param name="depth">struct UnityEngine.RenderBuffer</param>
        /// <param name="mip">struct System.Int32</param>
        /// <param name="face">enum UnityEngine.CubemapFace</param>
        /// <param name="depthSlice">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void INTERNAL_SET_RT_SIMPLE (UnityEngine.RenderBuffer color,UnityEngine.RenderBuffer depth,System.Int32 mip,UnityEngine.CubemapFace face,System.Int32 depthSlice);


        /// const string Name_Func_INTERNAL_SET_RT_SIMPLE_INJECTED = "Internal_SetRTSimple_Injected";
        /// <summary>
        /// static  System.Void Internal_SetRTSimple_Injected(UnityEngine.RenderBuffer& color,UnityEngine.RenderBuffer& depth,System.Int32 mip,UnityEngine.CubemapFace face,System.Int32 depthSlice)
        /// </summary>
        /// <param name="color">struct UnityEngine.RenderBuffer&</param>
        /// <param name="depth">struct UnityEngine.RenderBuffer&</param>
        /// <param name="mip">struct System.Int32</param>
        /// <param name="face">enum UnityEngine.CubemapFace</param>
        /// <param name="depthSlice">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void INTERNAL_SET_RT_SIMPLE_INJECTED (UnityEngine.RenderBuffer& color,UnityEngine.RenderBuffer& depth,System.Int32 mip,UnityEngine.CubemapFace face,System.Int32 depthSlice);


        /// const string Name_Func_SET_ACTIVE_TIER = "set_activeTier";
        /// <summary>
        /// static  System.Void set_activeTier(UnityEngine.Rendering.GraphicsTier value)
        /// </summary>
        /// <param name="value">enum UnityEngine.Rendering.GraphicsTier</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_ACTIVE_TIER (UnityEngine.Rendering.GraphicsTier value);



        ///const string Name_Func_BLIT = "Blit";
        /// <summary>
        /// static  System.Void Blit(UnityEngine.Texture source,UnityEngine.RenderTexture dest)
        /// </summary>
        /// <param name="source">class UnityEngine.Texture</param>
        /// <param name="dest">class UnityEngine.RenderTexture</param>
        /// <returns>struct System.Void</returns>
        ///[MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethod(Name_Func_BLIT, Search = typeof(Search_Graphics))]
        ///static extern void BLIT_00(nint source, nint dest);


        /// const string Name_Func_BLIT = "Blit";
        /// <summary>
        /// static  System.Void Blit(UnityEngine.Texture source,UnityEngine.RenderTexture dest,UnityEngine.Material mat,System.Int32 pass)
        /// </summary>
        /// <param name="source">class UnityEngine.Texture</param>
        /// <param name="dest">class UnityEngine.RenderTexture</param>
        /// <param name="mat">class UnityEngine.Material</param>
        /// <param name="pass">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void BLIT_01 (nint source,nint dest,nint mat,System.Int32 pass);


         const string Name_Func_BLIT = "Blit";
        /// <summary>
        /// static  System.Void Blit(UnityEngine.Texture source,UnityEngine.RenderTexture dest,UnityEngine.Material mat)
        /// </summary>
        /// <param name="source">class UnityEngine.Texture</param>
        /// <param name="dest">class UnityEngine.RenderTexture</param>
        /// <param name="mat">class UnityEngine.Material</param>
        /// <returns>struct System.Void</returns>
        [MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethod(Name_Func_BLIT, Search = typeof(Search_Graphics))]
        static extern void BLIT_02 (nint source,nint dest,nint mat);


        /// const string Name_Func_COPY_TEXTURE = "CopyTexture";
        /// <summary>
        /// static  System.Void CopyTexture(UnityEngine.Texture src,System.Int32 srcElement,System.Int32 srcMip,UnityEngine.Texture dst,System.Int32 dstElement,System.Int32 dstMip)
        /// </summary>
        /// <param name="src">class UnityEngine.Texture</param>
        /// <param name="srcElement">struct System.Int32</param>
        /// <param name="srcMip">struct System.Int32</param>
        /// <param name="dst">class UnityEngine.Texture</param>
        /// <param name="dstElement">struct System.Int32</param>
        /// <param name="dstMip">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void COPY_TEXTURE_00 (nint src,System.Int32 srcElement,System.Int32 srcMip,nint dst,System.Int32 dstElement,System.Int32 dstMip);


        /// const string Name_Func_COPY_TEXTURE = "CopyTexture";
        /// <summary>
        /// static  System.Void CopyTexture(UnityEngine.Texture src,System.Int32 srcElement,System.Int32 srcMip,System.Int32 srcX,System.Int32 srcY,System.Int32 srcWidth,System.Int32 srcHeight,UnityEngine.Texture dst,System.Int32 dstElement,System.Int32 dstMip,System.Int32 dstX,System.Int32 dstY)
        /// </summary>
        /// <param name="src">class UnityEngine.Texture</param>
        /// <param name="srcElement">struct System.Int32</param>
        /// <param name="srcMip">struct System.Int32</param>
        /// <param name="srcX">struct System.Int32</param>
        /// <param name="srcY">struct System.Int32</param>
        /// <param name="srcWidth">struct System.Int32</param>
        /// <param name="srcHeight">struct System.Int32</param>
        /// <param name="dst">class UnityEngine.Texture</param>
        /// <param name="dstElement">struct System.Int32</param>
        /// <param name="dstMip">struct System.Int32</param>
        /// <param name="dstX">struct System.Int32</param>
        /// <param name="dstY">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void COPY_TEXTURE_01 (nint src,System.Int32 srcElement,System.Int32 srcMip,System.Int32 srcX,System.Int32 srcY,System.Int32 srcWidth,System.Int32 srcHeight,nint dst,System.Int32 dstElement,System.Int32 dstMip,System.Int32 dstX,System.Int32 dstY);


        /// const string Name_Func_DRAW_MESH_NOW = "DrawMeshNow";
        /// <summary>
        /// static  System.Void DrawMeshNow(UnityEngine.Mesh mesh,UnityEngine.Matrix4x4 matrix,System.Int32 materialIndex)
        /// </summary>
        /// <param name="mesh">class UnityEngine.Mesh</param>
        /// <param name="matrix">struct UnityEngine.Matrix4x4</param>
        /// <param name="materialIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DRAW_MESH_NOW_00 (nint mesh,UnityEngine.Matrix4x4 matrix,System.Int32 materialIndex);


        /// const string Name_Func_DRAW_MESH_NOW = "DrawMeshNow";
        /// <summary>
        /// static  System.Void DrawMeshNow(UnityEngine.Mesh mesh,UnityEngine.Matrix4x4 matrix)
        /// </summary>
        /// <param name="mesh">class UnityEngine.Mesh</param>
        /// <param name="matrix">struct UnityEngine.Matrix4x4</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DRAW_MESH_NOW_01 (nint mesh,UnityEngine.Matrix4x4 matrix);


        /// const string Name_Func_SET_RENDER_TARGET = "SetRenderTarget";
        /// <summary>
        /// static  System.Void SetRenderTarget(UnityEngine.RenderTexture rt,System.Int32 mipLevel,UnityEngine.CubemapFace face,System.Int32 depthSlice)
        /// </summary>
        /// <param name="rt">class UnityEngine.RenderTexture</param>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <param name="face">enum UnityEngine.CubemapFace</param>
        /// <param name="depthSlice">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_RENDER_TARGET_00 (nint rt,System.Int32 mipLevel,UnityEngine.CubemapFace face,System.Int32 depthSlice);


        /// const string Name_Func_SET_RENDER_TARGET = "SetRenderTarget";
        /// <summary>
        /// static  System.Void SetRenderTarget(UnityEngine.RenderTexture rt)
        /// </summary>
        /// <param name="rt">class UnityEngine.RenderTexture</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_RENDER_TARGET_01 (nint rt);


        /// const string Name_Func_SET_RENDER_TARGET_IMPL = "SetRenderTargetImpl";
        /// <summary>
        /// static  System.Void SetRenderTargetImpl(UnityEngine.RenderBuffer colorBuffer,UnityEngine.RenderBuffer depthBuffer,System.Int32 mipLevel,UnityEngine.CubemapFace face,System.Int32 depthSlice)
        /// </summary>
        /// <param name="colorBuffer">struct UnityEngine.RenderBuffer</param>
        /// <param name="depthBuffer">struct UnityEngine.RenderBuffer</param>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <param name="face">enum UnityEngine.CubemapFace</param>
        /// <param name="depthSlice">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_RENDER_TARGET_IMPL_00 (UnityEngine.RenderBuffer colorBuffer,UnityEngine.RenderBuffer depthBuffer,System.Int32 mipLevel,UnityEngine.CubemapFace face,System.Int32 depthSlice);


        /// const string Name_Func_SET_RENDER_TARGET_IMPL = "SetRenderTargetImpl";
        /// <summary>
        /// static  System.Void SetRenderTargetImpl(UnityEngine.RenderTexture rt,System.Int32 mipLevel,UnityEngine.CubemapFace face,System.Int32 depthSlice)
        /// </summary>
        /// <param name="rt">class UnityEngine.RenderTexture</param>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <param name="face">enum UnityEngine.CubemapFace</param>
        /// <param name="depthSlice">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_RENDER_TARGET_IMPL_01 (nint rt,System.Int32 mipLevel,UnityEngine.CubemapFace face,System.Int32 depthSlice);


        public static partial class Search_Graphics
        {
            /// 
            ///     

            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest)
            /// </summary>
            public static bool BLIT_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Blit", "UnityEngine.Texture", "UnityEngine.RenderTexture");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass)
            /// </summary>
            /// public static bool BLIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Blit", "UnityEngine.Texture", "UnityEngine.RenderTexture", "UnityEngine.Material", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat)
            /// </summary>
             public static bool BLIT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                 =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Blit", "UnityEngine.Texture", "UnityEngine.RenderTexture", "UnityEngine.Material");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void CopyTexture(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip)
            /// </summary>
            /// public static bool COPY_TEXTURE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CopyTexture", "UnityEngine.Texture", "System.Int32", "System.Int32", "UnityEngine.Texture", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void CopyTexture(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY)
            /// </summary>
            /// public static bool COPY_TEXTURE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CopyTexture", "UnityEngine.Texture", "System.Int32", "System.Int32", "System.Int32", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Texture", "System.Int32", "System.Int32", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, System.Int32 materialIndex)
            /// </summary>
            /// public static bool DRAW_MESH_NOW_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DrawMeshNow", "UnityEngine.Mesh", "UnityEngine.Matrix4x4", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix)
            /// </summary>
            /// public static bool DRAW_MESH_NOW_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DrawMeshNow", "UnityEngine.Mesh", "UnityEngine.Matrix4x4");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderTexture rt, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// public static bool SET_RENDER_TARGET_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetRenderTarget", "UnityEngine.RenderTexture", "System.Int32", "UnityEngine.CubemapFace", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderTexture rt)
            /// </summary>
            /// public static bool SET_RENDER_TARGET_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetRenderTarget", "UnityEngine.RenderTexture");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void SetRenderTargetImpl(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// public static bool SET_RENDER_TARGET_IMPL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetRenderTargetImpl", "UnityEngine.RenderBuffer", "UnityEngine.RenderBuffer", "System.Int32", "UnityEngine.CubemapFace", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void SetRenderTargetImpl(UnityEngine.RenderTexture rt, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// public static bool SET_RENDER_TARGET_IMPL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetRenderTargetImpl", "UnityEngine.RenderTexture", "System.Int32", "UnityEngine.CubemapFace", "System.Int32");
            ///     
            ///  
            /// 
            /// 
        }

    }

}
