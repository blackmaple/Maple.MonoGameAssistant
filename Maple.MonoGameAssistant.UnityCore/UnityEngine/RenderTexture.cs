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
    /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."RenderTexture"]
    /// [UnityEngine.Texture]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], 0x020000C0U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101], [82, 101, 110, 100, 101, 114, 84, 101, 120, 116, 117, 114, 101])]
    public partial class RenderTexture
    {
        //public const string Const_ImageName = "UnityEngine.CoreModule.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108];

        //public const string Const_Namespace = "UnityEngine";
        //public static byte[] Static_Namespace { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101];

        //public const string Const_ClassName = "RenderTexture";
        //public static byte[] Static_ClassName { get; } = [82, 101, 110, 100, 101, 114, 84, 101, 120, 116, 117, 114, 101];

        //public const uint Const_TypeToken = 0x020000C0U;




        //public readonly unsafe partial struct Const_RenderTexture
        //{



        //    /// <summary>
        //    /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
        //    /// </summary>
        //    /// public nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";


        //    /// <summary>
        //    /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
        //    /// </summary>
        //    /// public nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";

        //}


        //[StructLayout(LayoutKind.Explicit)]
        //public readonly unsafe partial struct Static_RenderTexture
        //{



        //    /// <summary>
        //    /// struct 0x0 System.Int32 GenerateAllMips
        //    /// </summary>
        //    [FieldOffset(0x0)]
        //    public readonly System.Int32 GenerateAllMips;


        //    /// <summary>
        //    /// struct 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
        //    /// </summary>
        //    [FieldOffset(0x0)]
        //    public readonly System.Int32 OffsetOfInstanceIDInCPlusPlusObject;

        //}


        //[StructLayout(LayoutKind.Explicit)]
        //public readonly unsafe partial struct Ref_RenderTexture
        //{


        //    /// <summary>
        //    /// REF_MONO_OBJECT._vtable
        //    /// </summary>
        //    [MarshalAs(UnmanagedType.SysInt)]
        //    [FieldOffset(0)]
        //    public readonly nint _vtable;

        //    /// <summary>
        //    /// REF_MONO_OBJECT._synchronisation
        //    /// </summary>
        //    [MarshalAs(UnmanagedType.SysInt)]
        //    [FieldOffset(8)]
        //    public readonly nint _synchronisation;



        //    /// <summary>
        //    /// struct 0x10 System.IntPtr m_CachedPtr
        //    /// </summary>
        //    [FieldOffset(0x10)]
        //    public readonly System.IntPtr m_CachedPtr;

        //}

        [StructLayout(LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_RenderTexture(nint ptr)
        {

            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_RenderTexture(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_RenderTexture obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            //[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            //public ref Ref_RenderTexture AsRef()
            //{
            //    return ref Unsafe.AsRef<Ref_RenderTexture>(_ptr.ToPointer());
            //}
        }

    }

    /// <summary>
    /// ["UnityEngine.CoreModule.dll"."UnityEngine"."RenderTexture"]
    /// </summary>
    public partial class RenderTexture
    {



        /// const string Name_Func_CHECK_NULL_ARGUMENT = "CheckNullArgument";
        /// <summary>
        /// static  System.Void CheckNullArgument(System.Object arg,System.String message)
        /// </summary>
        /// <param name="arg">class System.Object</param>
        /// <param name="message">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void CHECK_NULL_ARGUMENT (nint arg,nint message);


        /// const string Name_Func_COMPARE_BASE_OBJECTS = "CompareBaseObjects";
        /// <summary>
        /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs,UnityEngine.Object rhs)
        /// </summary>
        /// <param name="lhs">class UnityEngine.Object</param>
        /// <param name="rhs">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean COMPARE_BASE_OBJECTS (nint lhs,nint rhs);


        /// const string Name_Func_CONVERT_TO_EQUIRECT = "ConvertToEquirect";
        /// <summary>
        ///   System.Void ConvertToEquirect(UnityEngine.RenderTexture equirect,UnityEngine.Camera.MonoOrStereoscopicEye eye)
        /// </summary>
        /// <param name="equirect">class UnityEngine.RenderTexture</param>
        /// <param name="eye">enum UnityEngine.Camera.MonoOrStereoscopicEye</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void CONVERT_TO_EQUIRECT (nint equirect,UnityEngine.Camera.MonoOrStereoscopicEye eye);


        /// const string Name_Func_CREATE = "Create";
        /// <summary>
        ///   System.Boolean Create()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CREATE ();


        /// const string Name_Func_CREATE_NON_READABLE_EXCEPTION = "CreateNonReadableException";
        /// <summary>
        ///   UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture t)
        /// </summary>
        /// <param name="t">class UnityEngine.Texture</param>
        /// <returns>class UnityEngine.UnityException</returns>
        /// public  extern nint CREATE_NON_READABLE_EXCEPTION (nint t);


        /// const string Name_Func_CURRENT_THREAD_IS_MAIN_THREAD = "CurrentThreadIsMainThread";
        /// <summary>
        /// static  System.Boolean CurrentThreadIsMainThread()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean CURRENT_THREAD_IS_MAIN_THREAD ();


        /// const string Name_Func_DOES_OBJECT_WITH_INSTANCE_ID_EXIST = "DoesObjectWithInstanceIDExist";
        /// <summary>
        /// static  System.Boolean DoesObjectWithInstanceIDExist(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean DOES_OBJECT_WITH_INSTANCE_ID_EXIST (System.Int32 instanceID);


        /// const string Name_Func_DONT_DESTROY_ON_LOAD = "DontDestroyOnLoad";
        /// <summary>
        /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
        /// </summary>
        /// <param name="target">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DONT_DESTROY_ON_LOAD (nint target);


        /// const string Name_Func_ENSURE_RUNNING_ON_MAIN_THREAD = "EnsureRunningOnMainThread";
        /// <summary>
        ///   System.Void EnsureRunningOnMainThread()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void ENSURE_RUNNING_ON_MAIN_THREAD ();


        /// const string Name_Func_EQUALS = "Equals";
        /// <summary>
        ///   System.Boolean Equals(System.Object other)
        /// </summary>
        /// <param name="other">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean EQUALS (nint other);


        /// const string Name_Func_FIND_OBJECT_FROM_INSTANCE_ID = "FindObjectFromInstanceID";
        /// <summary>
        /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint FIND_OBJECT_FROM_INSTANCE_ID (System.Int32 instanceID);


        /// const string Name_Func_FIND_OBJECTS_OF_TYPE_ALL = "FindObjectsOfTypeAll";
        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// public static extern nint FIND_OBJECTS_OF_TYPE_ALL (nint type);


        /// const string Name_Func_FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS = "FindObjectsOfTypeIncludingAssets";
        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// public static extern nint FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS (nint type);


        /// const string Name_Func_FIND_SCENE_OBJECTS_OF_TYPE = "FindSceneObjectsOfType";
        /// <summary>
        /// static  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// public static extern nint FIND_SCENE_OBJECTS_OF_TYPE (nint type);


        /// const string Name_Func_FORCE_LOAD_FROM_INSTANCE_ID = "ForceLoadFromInstanceID";
        /// <summary>
        /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint FORCE_LOAD_FROM_INSTANCE_ID (System.Int32 instanceID);


        /// const string Name_Func_GENERATE_MIPS = "GenerateMips";
        /// <summary>
        ///   System.Void GenerateMips()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void GENERATE_MIPS ();


        const string Name_Func_GET_ACTIVE = "get_active";
        /// <summary>
        /// static  UnityEngine.RenderTexture get_active()
        /// </summary>
        /// <returns>class UnityEngine.RenderTexture</returns>
        [MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethod(Name_Func_GET_ACTIVE, CallConvs = [typeof(CallConvCdecl)])]
        static extern nint GET_ACTIVE();


        /// const string Name_Func_GET_ACTIVE_TEXTURE_COLOR_SPACE = "get_activeTextureColorSpace";
        /// <summary>
        ///   UnityEngine.ColorSpace get_activeTextureColorSpace()
        /// </summary>
        /// <returns>enum UnityEngine.ColorSpace</returns>
        /// public  extern UnityEngine.ColorSpace GET_ACTIVE_TEXTURE_COLOR_SPACE ();


        /// const string Name_Func_GET_ALLOW_THREADED_TEXTURE_CREATION = "get_allowThreadedTextureCreation";
        /// <summary>
        /// static  System.Boolean get_allowThreadedTextureCreation()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean GET_ALLOW_THREADED_TEXTURE_CREATION ();


        /// const string Name_Func_GET_ANISO_LEVEL = "get_anisoLevel";
        /// <summary>
        ///   System.Int32 get_anisoLevel()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_ANISO_LEVEL ();


        /// const string Name_Func_GET_ANISOTROPIC_FILTERING = "get_anisotropicFiltering";
        /// <summary>
        /// static  UnityEngine.AnisotropicFiltering get_anisotropicFiltering()
        /// </summary>
        /// <returns>enum UnityEngine.AnisotropicFiltering</returns>
        /// public static extern UnityEngine.AnisotropicFiltering GET_ANISOTROPIC_FILTERING ();


        /// const string Name_Func_GET_ANTI_ALIASING = "get_antiAliasing";
        /// <summary>
        ///   System.Int32 get_antiAliasing()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_ANTI_ALIASING ();


        /// const string Name_Func_GET_AUTO_GENERATE_MIPS = "get_autoGenerateMips";
        /// <summary>
        ///   System.Boolean get_autoGenerateMips()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_AUTO_GENERATE_MIPS ();


        /// const string Name_Func_GET_BIND_TEXTURE_MS = "get_bindTextureMS";
        /// <summary>
        ///   System.Boolean get_bindTextureMS()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_BIND_TEXTURE_MS ();


        /// const string Name_Func_GET_COLOR_BUFFER = "get_colorBuffer";
        /// <summary>
        ///   UnityEngine.RenderBuffer get_colorBuffer()
        /// </summary>
        /// <returns>struct UnityEngine.RenderBuffer</returns>
        /// public  extern UnityEngine.RenderBuffer GET_COLOR_BUFFER ();


        /// const string Name_Func_GET_DEPTH = "get_depth";
        /// <summary>
        ///   System.Int32 get_depth()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_DEPTH ();


        /// const string Name_Func_GET_DEPTH_BUFFER = "get_depthBuffer";
        /// <summary>
        ///   UnityEngine.RenderBuffer get_depthBuffer()
        /// </summary>
        /// <returns>struct UnityEngine.RenderBuffer</returns>
        /// public  extern UnityEngine.RenderBuffer GET_DEPTH_BUFFER ();


        /// const string Name_Func_GET_DESCRIPTOR = "get_descriptor";
        /// <summary>
        ///   UnityEngine.RenderTextureDescriptor get_descriptor()
        /// </summary>
        /// <returns>struct UnityEngine.RenderTextureDescriptor</returns>
        /// public  extern UnityEngine.RenderTextureDescriptor GET_DESCRIPTOR ();


        /// const string Name_Func_GET_ENABLED = "get_enabled";
        /// <summary>
        /// static  System.Boolean get_enabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean GET_ENABLED ();


        /// const string Name_Func_GET_ENABLE_RANDOM_WRITE = "get_enableRandomWrite";
        /// <summary>
        ///   System.Boolean get_enableRandomWrite()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_ENABLE_RANDOM_WRITE ();


        /// const string Name_Func_GET_FILTER_MODE = "get_filterMode";
        /// <summary>
        ///   UnityEngine.FilterMode get_filterMode()
        /// </summary>
        /// <returns>enum UnityEngine.FilterMode</returns>
        /// public  extern UnityEngine.FilterMode GET_FILTER_MODE ();


        /// const string Name_Func_GET_FORMAT = "get_format";
        /// <summary>
        ///   UnityEngine.RenderTextureFormat get_format()
        /// </summary>
        /// <returns>enum UnityEngine.RenderTextureFormat</returns>
        /// public  extern UnityEngine.RenderTextureFormat GET_FORMAT ();


        /// const string Name_Func_GET_HIDE_FLAGS = "get_hideFlags";
        /// <summary>
        ///   UnityEngine.HideFlags get_hideFlags()
        /// </summary>
        /// <returns>enum UnityEngine.HideFlags</returns>
        /// public  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();


        /// const string Name_Func_GET_IS_CUBEMAP = "get_isCubemap";
        /// <summary>
        ///   System.Boolean get_isCubemap()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_CUBEMAP ();


        /// const string Name_Func_GET_IS_POWER_OF_TWO = "get_isPowerOfTwo";
        /// <summary>
        ///   System.Boolean get_isPowerOfTwo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_POWER_OF_TWO ();


        /// const string Name_Func_GET_IS_READABLE = "get_isReadable";
        /// <summary>
        ///   System.Boolean get_isReadable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_READABLE ();


        /// const string Name_Func_GET_IS_VOLUME = "get_isVolume";
        /// <summary>
        ///   System.Boolean get_isVolume()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_VOLUME ();


        /// const string Name_Func_GET_MASTER_TEXTURE_LIMIT = "get_masterTextureLimit";
        /// <summary>
        /// static  System.Int32 get_masterTextureLimit()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public static extern System.Int32 GET_MASTER_TEXTURE_LIMIT ();


        /// const string Name_Func_GET_MEMORYLESS_MODE = "get_memorylessMode";
        /// <summary>
        ///   UnityEngine.RenderTextureMemoryless get_memorylessMode()
        /// </summary>
        /// <returns>enum UnityEngine.RenderTextureMemoryless</returns>
        /// public  extern UnityEngine.RenderTextureMemoryless GET_MEMORYLESS_MODE ();


        /// const string Name_Func_GET_MIP_MAP_BIAS = "get_mipMapBias";
        /// <summary>
        ///   System.Single get_mipMapBias()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single GET_MIP_MAP_BIAS ();


        /// const string Name_Func_GET_MIPMAP_COUNT = "get_mipmapCount";
        /// <summary>
        ///   System.Int32 get_mipmapCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_MIPMAP_COUNT ();


        /// const string Name_Func_GET_NAME = "get_name";
        /// <summary>
        ///   System.String get_name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_NAME ();


        /// const string Name_Func_GET_S_RGB = "get_sRGB";
        /// <summary>
        ///   System.Boolean get_sRGB()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_S_RGB ();


        /// const string Name_Func_GET_STENCIL_FORMAT = "get_stencilFormat";
        /// <summary>
        ///   UnityEngine.Experimental.Rendering.GraphicsFormat get_stencilFormat()
        /// </summary>
        /// <returns>enum UnityEngine.Experimental.Rendering.GraphicsFormat</returns>
        /// public  extern UnityEngine.Experimental.Rendering.GraphicsFormat GET_STENCIL_FORMAT ();


        /// const string Name_Func_GET_STREAMING_TEXTURE_DISCARD_UNUSED_MIPS = "get_streamingTextureDiscardUnusedMips";
        /// <summary>
        /// static  System.Boolean get_streamingTextureDiscardUnusedMips()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean GET_STREAMING_TEXTURE_DISCARD_UNUSED_MIPS ();


        /// const string Name_Func_GET_STREAMING_TEXTURE_FORCE_LOAD_ALL = "get_streamingTextureForceLoadAll";
        /// <summary>
        /// static  System.Boolean get_streamingTextureForceLoadAll()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean GET_STREAMING_TEXTURE_FORCE_LOAD_ALL ();


        /// const string Name_Func_GET_TEXEL_SIZE = "get_texelSize";
        /// <summary>
        ///   UnityEngine.Vector2 get_texelSize()
        /// </summary>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// public  extern UnityEngine.Vector2 GET_TEXEL_SIZE ();


        /// const string Name_Func_GET_TEXEL_SIZE_INJECTED = "get_texelSize_Injected";
        /// <summary>
        ///   System.Void get_texelSize_Injected(UnityEngine.Vector2& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector2&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_TEXEL_SIZE_INJECTED (UnityEngine.Vector2& ret);


        /// const string Name_Func_GET_USE_DYNAMIC_SCALE = "get_useDynamicScale";
        /// <summary>
        ///   System.Boolean get_useDynamicScale()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_USE_DYNAMIC_SCALE ();


        /// const string Name_Func_GET_USE_MIP_MAP = "get_useMipMap";
        /// <summary>
        ///   System.Boolean get_useMipMap()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_USE_MIP_MAP ();


        /// const string Name_Func_GET_VOLUME_DEPTH = "get_volumeDepth";
        /// <summary>
        ///   System.Int32 get_volumeDepth()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_VOLUME_DEPTH ();


        /// const string Name_Func_GET_VR_USAGE = "get_vrUsage";
        /// <summary>
        ///   UnityEngine.VRTextureUsage get_vrUsage()
        /// </summary>
        /// <returns>enum UnityEngine.VRTextureUsage</returns>
        /// public  extern UnityEngine.VRTextureUsage GET_VR_USAGE ();


        /// const string Name_Func_GET_WRAP_MODE = "get_wrapMode";
        /// <summary>
        ///   UnityEngine.TextureWrapMode get_wrapMode()
        /// </summary>
        /// <returns>enum UnityEngine.TextureWrapMode</returns>
        /// public  extern UnityEngine.TextureWrapMode GET_WRAP_MODE ();


        /// const string Name_Func_GET_WRAP_MODE_U = "get_wrapModeU";
        /// <summary>
        ///   UnityEngine.TextureWrapMode get_wrapModeU()
        /// </summary>
        /// <returns>enum UnityEngine.TextureWrapMode</returns>
        /// public  extern UnityEngine.TextureWrapMode GET_WRAP_MODE_U ();


        /// const string Name_Func_GET_WRAP_MODE_V = "get_wrapModeV";
        /// <summary>
        ///   UnityEngine.TextureWrapMode get_wrapModeV()
        /// </summary>
        /// <returns>enum UnityEngine.TextureWrapMode</returns>
        /// public  extern UnityEngine.TextureWrapMode GET_WRAP_MODE_V ();


        /// const string Name_Func_GET_WRAP_MODE_W = "get_wrapModeW";
        /// <summary>
        ///   UnityEngine.TextureWrapMode get_wrapModeW()
        /// </summary>
        /// <returns>enum UnityEngine.TextureWrapMode</returns>
        /// public  extern UnityEngine.TextureWrapMode GET_WRAP_MODE_W ();


        /// const string Name_Func_GET_ACTIVE = "GetActive";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetActive()
        /// </summary>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_ACTIVE ();


        /// const string Name_Func_GET_CACHED_PTR = "GetCachedPtr";
        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// public  extern System.IntPtr GET_CACHED_PTR ();


        /// const string Name_Func_GET_COLOR_BUFFER = "GetColorBuffer";
        /// <summary>
        ///   UnityEngine.RenderBuffer GetColorBuffer()
        /// </summary>
        /// <returns>struct UnityEngine.RenderBuffer</returns>
        /// public  extern UnityEngine.RenderBuffer GET_COLOR_BUFFER ();


        /// const string Name_Func_GET_COLOR_BUFFER_INJECTED = "GetColorBuffer_Injected";
        /// <summary>
        ///   System.Void GetColorBuffer_Injected(UnityEngine.RenderBuffer& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.RenderBuffer&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_COLOR_BUFFER_INJECTED (UnityEngine.RenderBuffer& ret);


        /// const string Name_Func_GET_COMPATIBLE_FORMAT = "GetCompatibleFormat";
        /// <summary>
        /// static  UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat renderTextureFormat,UnityEngine.RenderTextureReadWrite readWrite)
        /// </summary>
        /// <param name="renderTextureFormat">enum UnityEngine.RenderTextureFormat</param>
        /// <param name="readWrite">enum UnityEngine.RenderTextureReadWrite</param>
        /// <returns>enum UnityEngine.Experimental.Rendering.GraphicsFormat</returns>
        /// public static extern UnityEngine.Experimental.Rendering.GraphicsFormat GET_COMPATIBLE_FORMAT (UnityEngine.RenderTextureFormat renderTextureFormat,UnityEngine.RenderTextureReadWrite readWrite);


        /// const string Name_Func_GET_DATA_HEIGHT = "GetDataHeight";
        /// <summary>
        ///   System.Int32 GetDataHeight()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_DATA_HEIGHT ();


        /// const string Name_Func_GET_DATA_WIDTH = "GetDataWidth";
        /// <summary>
        ///   System.Int32 GetDataWidth()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_DATA_WIDTH ();


        /// const string Name_Func_GET_DEPTH_BUFFER = "GetDepthBuffer";
        /// <summary>
        ///   UnityEngine.RenderBuffer GetDepthBuffer()
        /// </summary>
        /// <returns>struct UnityEngine.RenderBuffer</returns>
        /// public  extern UnityEngine.RenderBuffer GET_DEPTH_BUFFER ();


        /// const string Name_Func_GET_DEPTH_BUFFER_INJECTED = "GetDepthBuffer_Injected";
        /// <summary>
        ///   System.Void GetDepthBuffer_Injected(UnityEngine.RenderBuffer& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.RenderBuffer&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_DEPTH_BUFFER_INJECTED (UnityEngine.RenderBuffer& ret);


        /// const string Name_Func_GET_DESCRIPTOR = "GetDescriptor";
        /// <summary>
        ///   UnityEngine.RenderTextureDescriptor GetDescriptor()
        /// </summary>
        /// <returns>struct UnityEngine.RenderTextureDescriptor</returns>
        /// public  extern UnityEngine.RenderTextureDescriptor GET_DESCRIPTOR ();


        /// const string Name_Func_GET_DESCRIPTOR_INJECTED = "GetDescriptor_Injected";
        /// <summary>
        ///   System.Void GetDescriptor_Injected(UnityEngine.RenderTextureDescriptor& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.RenderTextureDescriptor&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_DESCRIPTOR_INJECTED (UnityEngine.RenderTextureDescriptor& ret);


        /// const string Name_Func_GET_DIMENSION = "GetDimension";
        /// <summary>
        ///   UnityEngine.Rendering.TextureDimension GetDimension()
        /// </summary>
        /// <returns>enum UnityEngine.Rendering.TextureDimension</returns>
        /// public  extern UnityEngine.Rendering.TextureDimension GET_DIMENSION ();


        /// const string Name_Func_GET_HASH_CODE = "GetHashCode";
        /// <summary>
        ///   System.Int32 GetHashCode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_HASH_CODE ();


        /// const string Name_Func_GET_INSTANCE_ID = "GetInstanceID";
        /// <summary>
        ///   System.Int32 GetInstanceID()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_INSTANCE_ID ();


        /// const string Name_Func_GET_IS_POWER_OF_TWO = "GetIsPowerOfTwo";
        /// <summary>
        ///   System.Boolean GetIsPowerOfTwo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_POWER_OF_TWO ();


        /// const string Name_Func_GET_NAME = "GetName";
        /// <summary>
        /// static  System.String GetName(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// public static extern nint GET_NAME (nint obj);


        /// const string Name_Func_GET_NATIVE_DEPTH_BUFFER_PTR = "GetNativeDepthBufferPtr";
        /// <summary>
        ///   System.IntPtr GetNativeDepthBufferPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// public  extern System.IntPtr GET_NATIVE_DEPTH_BUFFER_PTR ();


        /// const string Name_Func_GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT = "GetOffsetOfInstanceIDInCPlusPlusObject";
        /// <summary>
        /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();


        /// const string Name_Func_GET_PIXEL_DATA_OFFSET = "GetPixelDataOffset";
        /// <summary>
        ///   System.Int32 GetPixelDataOffset(System.Int32 mipLevel,System.Int32 element)
        /// </summary>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <param name="element">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_PIXEL_DATA_OFFSET (System.Int32 mipLevel,System.Int32 element);


        /// const string Name_Func_GET_PIXEL_DATA_SIZE = "GetPixelDataSize";
        /// <summary>
        ///   System.Int32 GetPixelDataSize(System.Int32 mipLevel,System.Int32 element)
        /// </summary>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <param name="element">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_PIXEL_DATA_SIZE (System.Int32 mipLevel,System.Int32 element);


        /// const string Name_Func_GET_TEMPORARY_INTERNAL = "GetTemporary_Internal";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor desc)
        /// </summary>
        /// <param name="desc">struct UnityEngine.RenderTextureDescriptor</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_INTERNAL (UnityEngine.RenderTextureDescriptor desc);


        /// const string Name_Func_GET_TEMPORARY_INTERNAL_INJECTED = "GetTemporary_Internal_Injected";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary_Internal_Injected(UnityEngine.RenderTextureDescriptor& desc)
        /// </summary>
        /// <param name="desc">struct UnityEngine.RenderTextureDescriptor&</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_INTERNAL_INJECTED (UnityEngine.RenderTextureDescriptor& desc);


        /// const string Name_Func_GET_TEMPORARY_IMPL = "GetTemporaryImpl";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporaryImpl(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode,UnityEngine.VRTextureUsage vrUsage,System.Boolean useDynamicScale)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="antiAliasing">struct System.Int32</param>
        /// <param name="memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
        /// <param name="vrUsage">enum UnityEngine.VRTextureUsage</param>
        /// <param name="useDynamicScale">struct System.Boolean</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_IMPL (System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode,UnityEngine.VRTextureUsage vrUsage,System.Boolean useDynamicScale);


        /// const string Name_Func_GET_TEXEL_OFFSET = "GetTexelOffset";
        /// <summary>
        ///   UnityEngine.Vector2 GetTexelOffset()
        /// </summary>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// public  extern UnityEngine.Vector2 GET_TEXEL_OFFSET ();


        /// const string Name_Func_INTERNAL_CLONE_SINGLE = "Internal_CloneSingle";
        /// <summary>
        /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_CLONE_SINGLE (nint data);


        /// const string Name_Func_INTERNAL_CLONE_SINGLE_WITH_PARENT = "Internal_CloneSingleWithParent";
        /// <summary>
        /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data,UnityEngine.Transform parent,System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_CLONE_SINGLE_WITH_PARENT (nint data,nint parent,System.Boolean worldPositionStays);


        /// const string Name_Func_INTERNAL_CREATE = "Internal_Create";
        /// <summary>
        /// static  System.Void Internal_Create(UnityEngine.RenderTexture rt)
        /// </summary>
        /// <param name="rt">class UnityEngine.RenderTexture</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void INTERNAL_CREATE (nint rt);


        /// const string Name_Func_INTERNAL_GET_ACTIVE_TEXTURE_COLOR_SPACE = "Internal_GetActiveTextureColorSpace";
        /// <summary>
        ///   System.Int32 Internal_GetActiveTextureColorSpace()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 INTERNAL_GET_ACTIVE_TEXTURE_COLOR_SPACE ();


        /// const string Name_Func_INTERNAL_INSTANTIATE_SINGLE = "Internal_InstantiateSingle";
        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data,UnityEngine.Vector3 pos,UnityEngine.Quaternion rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="rot">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_INSTANTIATE_SINGLE (nint data,UnityEngine.Vector3 pos,UnityEngine.Quaternion rot);


        /// const string Name_Func_INTERNAL_INSTANTIATE_SINGLE_INJECTED = "Internal_InstantiateSingle_Injected";
        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data,UnityEngine.Vector3& pos,UnityEngine.Quaternion& rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="pos">struct UnityEngine.Vector3&</param>
        /// <param name="rot">struct UnityEngine.Quaternion&</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_INSTANTIATE_SINGLE_INJECTED (nint data,UnityEngine.Vector3& pos,UnityEngine.Quaternion& rot);


        /// const string Name_Func_INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT = "Internal_InstantiateSingleWithParent";
        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data,UnityEngine.Transform parent,UnityEngine.Vector3 pos,UnityEngine.Quaternion rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="rot">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT (nint data,nint parent,UnityEngine.Vector3 pos,UnityEngine.Quaternion rot);


        /// const string Name_Func_INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED = "Internal_InstantiateSingleWithParent_Injected";
        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data,UnityEngine.Transform parent,UnityEngine.Vector3& pos,UnityEngine.Quaternion& rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="pos">struct UnityEngine.Vector3&</param>
        /// <param name="rot">struct UnityEngine.Quaternion&</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED (nint data,nint parent,UnityEngine.Vector3& pos,UnityEngine.Quaternion& rot);


        /// const string Name_Func_IS_CREATED = "IsCreated";
        /// <summary>
        ///   System.Boolean IsCreated()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_CREATED ();


        /// const string Name_Func_IS_NATIVE_OBJECT_ALIVE = "IsNativeObjectAlive";
        /// <summary>
        /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
        /// </summary>
        /// <param name="o">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean IS_NATIVE_OBJECT_ALIVE (nint o);


        /// const string Name_Func_IS_PERSISTENT = "IsPersistent";
        /// <summary>
        /// static  System.Boolean IsPersistent(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean IS_PERSISTENT (nint obj);


        /// const string Name_Func_MARK_RESTORE_EXPECTED = "MarkRestoreExpected";
        /// <summary>
        ///   System.Void MarkRestoreExpected()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void MARK_RESTORE_EXPECTED ();


        /// const string Name_Func_OP_EQUALITY = "op_Equality";
        /// <summary>
        /// static  System.Boolean op_Equality(UnityEngine.Object x,UnityEngine.Object y)
        /// </summary>
        /// <param name="x">class UnityEngine.Object</param>
        /// <param name="y">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean OP_EQUALITY (nint x,nint y);


        /// const string Name_Func_OP_IMPLICIT = "op_Implicit";
        /// <summary>
        /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
        /// </summary>
        /// <param name="exists">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean OP_IMPLICIT (nint exists);


        /// const string Name_Func_OP_INEQUALITY = "op_Inequality";
        /// <summary>
        /// static  System.Boolean op_Inequality(UnityEngine.Object x,UnityEngine.Object y)
        /// </summary>
        /// <param name="x">class UnityEngine.Object</param>
        /// <param name="y">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean OP_INEQUALITY (nint x,nint y);


        /// const string Name_Func_RELEASE = "Release";
        /// <summary>
        ///   System.Void Release()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void RELEASE ();


        const string Name_Func_RELEASE_TEMPORARY = "ReleaseTemporary";
        /// <summary>
        /// static  System.Void ReleaseTemporary(UnityEngine.RenderTexture temp)
        /// </summary>
        /// <param name="temp">class UnityEngine.RenderTexture</param>
        /// <returns>struct System.Void</returns>
        [MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethod(Name_Func_RELEASE_TEMPORARY, CallConvs = [typeof(CallConvCdecl)])]
        static extern void RELEASE_TEMPORARY(nint temp);


        /// const string Name_Func_RESOLVE_AA = "ResolveAA";
        /// <summary>
        ///   System.Void ResolveAA()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void RESOLVE_AA ();


        /// const string Name_Func_RESOLVE_AA_TO = "ResolveAATo";
        /// <summary>
        ///   System.Void ResolveAATo(UnityEngine.RenderTexture rt)
        /// </summary>
        /// <param name="rt">class UnityEngine.RenderTexture</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void RESOLVE_AA_TO (nint rt);


        const string Name_Func_SET_ACTIVE = "set_active";
        /// <summary>
        /// static  System.Void set_active(UnityEngine.RenderTexture value)
        /// </summary>
        /// <param name="value">class UnityEngine.RenderTexture</param>
        /// <returns>struct System.Void</returns>
        [MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethod(Name_Func_SET_ACTIVE, CallConvs = [typeof(CallConvCdecl)])]
        static extern void SET_ACTIVE(nint value);


        /// const string Name_Func_SET_ALLOW_THREADED_TEXTURE_CREATION = "set_allowThreadedTextureCreation";
        /// <summary>
        /// static  System.Void set_allowThreadedTextureCreation(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_ALLOW_THREADED_TEXTURE_CREATION (System.Boolean value);


        /// const string Name_Func_SET_ANISO_LEVEL = "set_anisoLevel";
        /// <summary>
        ///   System.Void set_anisoLevel(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_ANISO_LEVEL (System.Int32 value);


        /// const string Name_Func_SET_ANISOTROPIC_FILTERING = "set_anisotropicFiltering";
        /// <summary>
        /// static  System.Void set_anisotropicFiltering(UnityEngine.AnisotropicFiltering value)
        /// </summary>
        /// <param name="value">enum UnityEngine.AnisotropicFiltering</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_ANISOTROPIC_FILTERING (UnityEngine.AnisotropicFiltering value);


        /// const string Name_Func_SET_ANTI_ALIASING = "set_antiAliasing";
        /// <summary>
        ///   System.Void set_antiAliasing(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_ANTI_ALIASING (System.Int32 value);


        /// const string Name_Func_SET_AUTO_GENERATE_MIPS = "set_autoGenerateMips";
        /// <summary>
        ///   System.Void set_autoGenerateMips(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_AUTO_GENERATE_MIPS (System.Boolean value);


        /// const string Name_Func_SET_BIND_TEXTURE_MS = "set_bindTextureMS";
        /// <summary>
        ///   System.Void set_bindTextureMS(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_BIND_TEXTURE_MS (System.Boolean value);


        /// const string Name_Func_SET_DEPTH = "set_depth";
        /// <summary>
        ///   System.Void set_depth(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_DEPTH (System.Int32 value);


        /// const string Name_Func_SET_DESCRIPTOR = "set_descriptor";
        /// <summary>
        ///   System.Void set_descriptor(UnityEngine.RenderTextureDescriptor value)
        /// </summary>
        /// <param name="value">struct UnityEngine.RenderTextureDescriptor</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_DESCRIPTOR (UnityEngine.RenderTextureDescriptor value);


        /// const string Name_Func_SET_ENABLED = "set_enabled";
        /// <summary>
        /// static  System.Void set_enabled(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_ENABLED (System.Boolean value);


        /// const string Name_Func_SET_ENABLE_RANDOM_WRITE = "set_enableRandomWrite";
        /// <summary>
        ///   System.Void set_enableRandomWrite(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_ENABLE_RANDOM_WRITE (System.Boolean value);


        /// const string Name_Func_SET_FILTER_MODE = "set_filterMode";
        /// <summary>
        ///   System.Void set_filterMode(UnityEngine.FilterMode value)
        /// </summary>
        /// <param name="value">enum UnityEngine.FilterMode</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FILTER_MODE (UnityEngine.FilterMode value);


        /// const string Name_Func_SET_FORMAT = "set_format";
        /// <summary>
        ///   System.Void set_format(UnityEngine.RenderTextureFormat value)
        /// </summary>
        /// <param name="value">enum UnityEngine.RenderTextureFormat</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FORMAT (UnityEngine.RenderTextureFormat value);


        /// const string Name_Func_SET_GRAPHICS_FORMAT = "set_graphicsFormat";
        /// <summary>
        ///   System.Void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value)
        /// </summary>
        /// <param name="value">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_GRAPHICS_FORMAT (UnityEngine.Experimental.Rendering.GraphicsFormat value);


        /// const string Name_Func_SET_HIDE_FLAGS = "set_hideFlags";
        /// <summary>
        ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
        /// </summary>
        /// <param name="value">enum UnityEngine.HideFlags</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);


        /// const string Name_Func_SET_IS_CUBEMAP = "set_isCubemap";
        /// <summary>
        ///   System.Void set_isCubemap(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_IS_CUBEMAP (System.Boolean value);


        /// const string Name_Func_SET_IS_POWER_OF_TWO = "set_isPowerOfTwo";
        /// <summary>
        ///   System.Void set_isPowerOfTwo(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_IS_POWER_OF_TWO (System.Boolean value);


        /// const string Name_Func_SET_IS_VOLUME = "set_isVolume";
        /// <summary>
        ///   System.Void set_isVolume(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_IS_VOLUME (System.Boolean value);


        /// const string Name_Func_SET_MASTER_TEXTURE_LIMIT = "set_masterTextureLimit";
        /// <summary>
        /// static  System.Void set_masterTextureLimit(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_MASTER_TEXTURE_LIMIT (System.Int32 value);


        /// const string Name_Func_SET_MEMORYLESS_MODE = "set_memorylessMode";
        /// <summary>
        ///   System.Void set_memorylessMode(UnityEngine.RenderTextureMemoryless value)
        /// </summary>
        /// <param name="value">enum UnityEngine.RenderTextureMemoryless</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MEMORYLESS_MODE (UnityEngine.RenderTextureMemoryless value);


        /// const string Name_Func_SET_MIP_MAP_BIAS = "set_mipMapBias";
        /// <summary>
        ///   System.Void set_mipMapBias(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MIP_MAP_BIAS (System.Single value);


        /// const string Name_Func_SET_NAME = "set_name";
        /// <summary>
        ///   System.Void set_name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_NAME (nint value);


        /// const string Name_Func_SET_STENCIL_FORMAT = "set_stencilFormat";
        /// <summary>
        ///   System.Void set_stencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value)
        /// </summary>
        /// <param name="value">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_STENCIL_FORMAT (UnityEngine.Experimental.Rendering.GraphicsFormat value);


        /// const string Name_Func_SET_STREAMING_TEXTURE_DISCARD_UNUSED_MIPS = "set_streamingTextureDiscardUnusedMips";
        /// <summary>
        /// static  System.Void set_streamingTextureDiscardUnusedMips(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_STREAMING_TEXTURE_DISCARD_UNUSED_MIPS (System.Boolean value);


        /// const string Name_Func_SET_STREAMING_TEXTURE_FORCE_LOAD_ALL = "set_streamingTextureForceLoadAll";
        /// <summary>
        /// static  System.Void set_streamingTextureForceLoadAll(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_STREAMING_TEXTURE_FORCE_LOAD_ALL (System.Boolean value);


        /// const string Name_Func_SET_USE_DYNAMIC_SCALE = "set_useDynamicScale";
        /// <summary>
        ///   System.Void set_useDynamicScale(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_USE_DYNAMIC_SCALE (System.Boolean value);


        /// const string Name_Func_SET_USE_MIP_MAP = "set_useMipMap";
        /// <summary>
        ///   System.Void set_useMipMap(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_USE_MIP_MAP (System.Boolean value);


        /// const string Name_Func_SET_VOLUME_DEPTH = "set_volumeDepth";
        /// <summary>
        ///   System.Void set_volumeDepth(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_VOLUME_DEPTH (System.Int32 value);


        /// const string Name_Func_SET_VR_USAGE = "set_vrUsage";
        /// <summary>
        ///   System.Void set_vrUsage(UnityEngine.VRTextureUsage value)
        /// </summary>
        /// <param name="value">enum UnityEngine.VRTextureUsage</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_VR_USAGE (UnityEngine.VRTextureUsage value);


        /// const string Name_Func_SET_WRAP_MODE = "set_wrapMode";
        /// <summary>
        ///   System.Void set_wrapMode(UnityEngine.TextureWrapMode value)
        /// </summary>
        /// <param name="value">enum UnityEngine.TextureWrapMode</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_WRAP_MODE (UnityEngine.TextureWrapMode value);


        /// const string Name_Func_SET_WRAP_MODE_U = "set_wrapModeU";
        /// <summary>
        ///   System.Void set_wrapModeU(UnityEngine.TextureWrapMode value)
        /// </summary>
        /// <param name="value">enum UnityEngine.TextureWrapMode</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_WRAP_MODE_U (UnityEngine.TextureWrapMode value);


        /// const string Name_Func_SET_WRAP_MODE_V = "set_wrapModeV";
        /// <summary>
        ///   System.Void set_wrapModeV(UnityEngine.TextureWrapMode value)
        /// </summary>
        /// <param name="value">enum UnityEngine.TextureWrapMode</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_WRAP_MODE_V (UnityEngine.TextureWrapMode value);


        /// const string Name_Func_SET_WRAP_MODE_W = "set_wrapModeW";
        /// <summary>
        ///   System.Void set_wrapModeW(UnityEngine.TextureWrapMode value)
        /// </summary>
        /// <param name="value">enum UnityEngine.TextureWrapMode</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_WRAP_MODE_W (UnityEngine.TextureWrapMode value);


        /// const string Name_Func_SET_ACTIVE = "SetActive";
        /// <summary>
        /// static  System.Void SetActive(UnityEngine.RenderTexture rt)
        /// </summary>
        /// <param name="rt">class UnityEngine.RenderTexture</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_ACTIVE (nint rt);


        /// const string Name_Func_SET_GLOBAL_SHADER_PROPERTY = "SetGlobalShaderProperty";
        /// <summary>
        ///   System.Void SetGlobalShaderProperty(System.String propertyName)
        /// </summary>
        /// <param name="propertyName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_GLOBAL_SHADER_PROPERTY (nint propertyName);


        /// const string Name_Func_SET_NAME = "SetName";
        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj,System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_NAME (nint obj,nint name);


        /// const string Name_Func_SET_RENDER_TEXTURE_DESCRIPTOR = "SetRenderTextureDescriptor";
        /// <summary>
        ///   System.Void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor desc)
        /// </summary>
        /// <param name="desc">struct UnityEngine.RenderTextureDescriptor</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_RENDER_TEXTURE_DESCRIPTOR (UnityEngine.RenderTextureDescriptor desc);


        /// const string Name_Func_SET_RENDER_TEXTURE_DESCRIPTOR_INJECTED = "SetRenderTextureDescriptor_Injected";
        /// <summary>
        ///   System.Void SetRenderTextureDescriptor_Injected(UnityEngine.RenderTextureDescriptor& desc)
        /// </summary>
        /// <param name="desc">struct UnityEngine.RenderTextureDescriptor&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_RENDER_TEXTURE_DESCRIPTOR_INJECTED (UnityEngine.RenderTextureDescriptor& desc);


        /// const string Name_Func_SET_SRGB_READ_WRITE = "SetSRGBReadWrite";
        /// <summary>
        ///   System.Void SetSRGBReadWrite(System.Boolean srgb)
        /// </summary>
        /// <param name="srgb">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_SRGB_READ_WRITE (System.Boolean srgb);


        /// const string Name_Func_SUPPORTS_STENCIL = "SupportsStencil";
        /// <summary>
        /// static  System.Boolean SupportsStencil(UnityEngine.RenderTexture rt)
        /// </summary>
        /// <param name="rt">class UnityEngine.RenderTexture</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean SUPPORTS_STENCIL (nint rt);


        /// const string Name_Func_VALIDATE_RENDER_TEXTURE_DESC = "ValidateRenderTextureDesc";
        /// <summary>
        /// static  System.Void ValidateRenderTextureDesc(UnityEngine.RenderTextureDescriptor desc)
        /// </summary>
        /// <param name="desc">struct UnityEngine.RenderTextureDescriptor</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void VALIDATE_RENDER_TEXTURE_DESC (UnityEngine.RenderTextureDescriptor desc);



        /// const string Name_Func_.CCTOR = ".cctor";
        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void .CCTOR_00 ();


        /// const string Name_Func_.CCTOR = ".cctor";
        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void .CCTOR_01 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_00 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(UnityEngine.RenderTextureDescriptor desc)
        /// </summary>
        /// <param name="desc">struct UnityEngine.RenderTextureDescriptor</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_01 (UnityEngine.RenderTextureDescriptor desc);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(UnityEngine.RenderTexture textureToCopy)
        /// </summary>
        /// <param name="textureToCopy">class UnityEngine.RenderTexture</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_02 (nint textureToCopy);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.Experimental.Rendering.DefaultFormat format)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depth">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.DefaultFormat</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_03 (System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.Experimental.Rendering.DefaultFormat format);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.Experimental.Rendering.GraphicsFormat format)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depth">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_04 (System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.Experimental.Rendering.GraphicsFormat format);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 mipCount)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depth">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="mipCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_05 (System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 mipCount);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.RenderTextureFormat format,UnityEngine.RenderTextureReadWrite readWrite)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depth">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.RenderTextureFormat</param>
        /// <param name="readWrite">enum UnityEngine.RenderTextureReadWrite</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_06 (System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.RenderTextureFormat format,UnityEngine.RenderTextureReadWrite readWrite);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.RenderTextureFormat format)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depth">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.RenderTextureFormat</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_07 (System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.RenderTextureFormat format);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,System.Int32 depth)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depth">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_08 (System.Int32 width,System.Int32 height,System.Int32 depth);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.RenderTextureFormat format,System.Int32 mipCount)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depth">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.RenderTextureFormat</param>
        /// <param name="mipCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_09 (System.Int32 width,System.Int32 height,System.Int32 depth,UnityEngine.RenderTextureFormat format,System.Int32 mipCount);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_0A ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_0B ();


        /// const string Name_Func_DESTROY = "Destroy";
        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj,System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DESTROY_00 (nint obj,System.Single t);


        /// const string Name_Func_DESTROY = "Destroy";
        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DESTROY_01 (nint obj);


        /// const string Name_Func_DESTROY_IMMEDIATE = "DestroyImmediate";
        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj,System.Boolean allowDestroyingAssets)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="allowDestroyingAssets">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DESTROY_IMMEDIATE_00 (nint obj,System.Boolean allowDestroyingAssets);


        /// const string Name_Func_DESTROY_IMMEDIATE = "DestroyImmediate";
        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DESTROY_IMMEDIATE_01 (nint obj);


        /// const string Name_Func_DESTROY_OBJECT = "DestroyObject";
        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj,System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DESTROY_OBJECT_00 (nint obj,System.Single t);


        /// const string Name_Func_DESTROY_OBJECT = "DestroyObject";
        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DESTROY_OBJECT_01 (nint obj);


        /// const string Name_Func_DISCARD_CONTENTS = "DiscardContents";
        /// <summary>
        ///   System.Void DiscardContents(System.Boolean discardColor,System.Boolean discardDepth)
        /// </summary>
        /// <param name="discardColor">struct System.Boolean</param>
        /// <param name="discardDepth">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void DISCARD_CONTENTS_00 (System.Boolean discardColor,System.Boolean discardDepth);


        /// const string Name_Func_DISCARD_CONTENTS = "DiscardContents";
        /// <summary>
        ///   System.Void DiscardContents()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void DISCARD_CONTENTS_01 ();


        /// const string Name_Func_FIND_OBJECT_OF_TYPE = "FindObjectOfType";
        /// <summary>
        /// static  T FindObjectOfType()
        /// </summary>
        /// <returns>class T</returns>
        /// public static extern nint FIND_OBJECT_OF_TYPE_00 ();


        /// const string Name_Func_FIND_OBJECT_OF_TYPE = "FindObjectOfType";
        /// <summary>
        /// static  T FindObjectOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// public static extern nint FIND_OBJECT_OF_TYPE_01 (System.Boolean includeInactive);


        /// const string Name_Func_FIND_OBJECT_OF_TYPE = "FindObjectOfType";
        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint FIND_OBJECT_OF_TYPE_02 (nint type);


        /// const string Name_Func_FIND_OBJECT_OF_TYPE = "FindObjectOfType";
        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type,System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint FIND_OBJECT_OF_TYPE_03 (nint type,System.Boolean includeInactive);


        /// const string Name_Func_FIND_OBJECTS_OF_TYPE = "FindObjectsOfType";
        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// public static extern nint FIND_OBJECTS_OF_TYPE_00 (nint type);


        /// const string Name_Func_FIND_OBJECTS_OF_TYPE = "FindObjectsOfType";
        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type,System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// public static extern nint FIND_OBJECTS_OF_TYPE_01 (nint type,System.Boolean includeInactive);


        /// const string Name_Func_FIND_OBJECTS_OF_TYPE = "FindObjectsOfType";
        /// <summary>
        /// static  T[] FindObjectsOfType()
        /// </summary>
        /// <returns>class T[]</returns>
        /// public static extern nint FIND_OBJECTS_OF_TYPE_02 ();


        /// const string Name_Func_FIND_OBJECTS_OF_TYPE = "FindObjectsOfType";
        /// <summary>
        /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// public static extern nint FIND_OBJECTS_OF_TYPE_03 (System.Boolean includeInactive);


        /// const string Name_Func_GET_DIMENSION = "get_dimension";
        /// <summary>
        ///   UnityEngine.Rendering.TextureDimension get_dimension()
        /// </summary>
        /// <returns>enum UnityEngine.Rendering.TextureDimension</returns>
        /// public  extern UnityEngine.Rendering.TextureDimension GET_DIMENSION_00 ();


        /// const string Name_Func_GET_DIMENSION = "get_dimension";
        /// <summary>
        ///   UnityEngine.Rendering.TextureDimension get_dimension()
        /// </summary>
        /// <returns>enum UnityEngine.Rendering.TextureDimension</returns>
        /// public  extern UnityEngine.Rendering.TextureDimension GET_DIMENSION_01 ();


        /// const string Name_Func_GET_GRAPHICS_FORMAT = "get_graphicsFormat";
        /// <summary>
        ///   UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
        /// </summary>
        /// <returns>enum UnityEngine.Experimental.Rendering.GraphicsFormat</returns>
        /// public  extern UnityEngine.Experimental.Rendering.GraphicsFormat GET_GRAPHICS_FORMAT_00 ();


        /// const string Name_Func_GET_GRAPHICS_FORMAT = "get_graphicsFormat";
        /// <summary>
        ///   UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
        /// </summary>
        /// <returns>enum UnityEngine.Experimental.Rendering.GraphicsFormat</returns>
        /// public  extern UnityEngine.Experimental.Rendering.GraphicsFormat GET_GRAPHICS_FORMAT_01 ();


        const string Name_Func_GET_HEIGHT = "get_height";
        /// <summary>
        ///   System.Int32 get_height()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethod(Name_Func_GET_HEIGHT, CallConvs = [typeof(CallConvCdecl)])]
        extern System.Int32 GET_HEIGHT_00();


        /// const string Name_Func_GET_HEIGHT = "get_height";
        /// <summary>
        ///   System.Int32 get_height()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_HEIGHT_01 ();


        const string Name_Func_GET_WIDTH = "get_width";
        /// <summary>
        ///   System.Int32 get_width()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethod(Name_Func_GET_WIDTH, CallConvs = [typeof(CallConvCdecl)])]
        extern System.Int32 GET_WIDTH_00();


        /// const string Name_Func_GET_WIDTH = "get_width";
        /// <summary>
        ///   System.Int32 get_width()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_WIDTH_01 ();


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc)
        /// </summary>
        /// <param name="desc">struct UnityEngine.RenderTextureDescriptor</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        ///static extern nint GET_TEMPORARY_00 (UnityEngine.RenderTextureDescriptor desc);


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode,UnityEngine.VRTextureUsage vrUsage,System.Boolean useDynamicScale)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="antiAliasing">struct System.Int32</param>
        /// <param name="memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
        /// <param name="vrUsage">enum UnityEngine.VRTextureUsage</param>
        /// <param name="useDynamicScale">struct System.Boolean</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_01 (System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode,UnityEngine.VRTextureUsage vrUsage,System.Boolean useDynamicScale);


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode,UnityEngine.VRTextureUsage vrUsage)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="antiAliasing">struct System.Int32</param>
        /// <param name="memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
        /// <param name="vrUsage">enum UnityEngine.VRTextureUsage</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_02 (System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode,UnityEngine.VRTextureUsage vrUsage);


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="antiAliasing">struct System.Int32</param>
        /// <param name="memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_03 (System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode);


        ///const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 antiAliasing)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="antiAliasing">struct System.Int32</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        ///static extern nint GET_TEMPORARY_04(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing);


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.Experimental.Rendering.GraphicsFormat format)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_05 (System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.Experimental.Rendering.GraphicsFormat format);


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.RenderTextureFormat format,UnityEngine.RenderTextureReadWrite readWrite,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode,UnityEngine.VRTextureUsage vrUsage,System.Boolean useDynamicScale)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.RenderTextureFormat</param>
        /// <param name="readWrite">enum UnityEngine.RenderTextureReadWrite</param>
        /// <param name="antiAliasing">struct System.Int32</param>
        /// <param name="memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
        /// <param name="vrUsage">enum UnityEngine.VRTextureUsage</param>
        /// <param name="useDynamicScale">struct System.Boolean</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_06 (System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.RenderTextureFormat format,UnityEngine.RenderTextureReadWrite readWrite,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode,UnityEngine.VRTextureUsage vrUsage,System.Boolean useDynamicScale);


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.RenderTextureFormat format,UnityEngine.RenderTextureReadWrite readWrite,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode,UnityEngine.VRTextureUsage vrUsage)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.RenderTextureFormat</param>
        /// <param name="readWrite">enum UnityEngine.RenderTextureReadWrite</param>
        /// <param name="antiAliasing">struct System.Int32</param>
        /// <param name="memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
        /// <param name="vrUsage">enum UnityEngine.VRTextureUsage</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_07 (System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.RenderTextureFormat format,UnityEngine.RenderTextureReadWrite readWrite,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode,UnityEngine.VRTextureUsage vrUsage);


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.RenderTextureFormat format,UnityEngine.RenderTextureReadWrite readWrite,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.RenderTextureFormat</param>
        /// <param name="readWrite">enum UnityEngine.RenderTextureReadWrite</param>
        /// <param name="antiAliasing">struct System.Int32</param>
        /// <param name="memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_08 (System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.RenderTextureFormat format,UnityEngine.RenderTextureReadWrite readWrite,System.Int32 antiAliasing,UnityEngine.RenderTextureMemoryless memorylessMode);


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.RenderTextureFormat format,UnityEngine.RenderTextureReadWrite readWrite,System.Int32 antiAliasing)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.RenderTextureFormat</param>
        /// <param name="readWrite">enum UnityEngine.RenderTextureReadWrite</param>
        /// <param name="antiAliasing">struct System.Int32</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_09 (System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.RenderTextureFormat format,UnityEngine.RenderTextureReadWrite readWrite,System.Int32 antiAliasing);


        const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.RenderTextureFormat format,UnityEngine.RenderTextureReadWrite readWrite)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.RenderTextureFormat</param>
        /// <param name="readWrite">enum UnityEngine.RenderTextureReadWrite</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        [MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethod(Name_Func_GET_TEMPORARY, Search = typeof(Search_RenderTexture), CallConvs = [typeof(CallConvCdecl)])]
        static extern RenderTexture.Ptr_RenderTexture GET_TEMPORARY_0A(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.RenderTextureFormat format)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.RenderTextureFormat</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_0B (System.Int32 width,System.Int32 height,System.Int32 depthBuffer,UnityEngine.RenderTextureFormat format);


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height,System.Int32 depthBuffer)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="depthBuffer">struct System.Int32</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_0C (System.Int32 width,System.Int32 height,System.Int32 depthBuffer);


        /// const string Name_Func_GET_TEMPORARY = "GetTemporary";
        /// <summary>
        /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width,System.Int32 height)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <returns>class UnityEngine.RenderTexture</returns>
        /// public static extern nint GET_TEMPORARY_0D (System.Int32 width,System.Int32 height);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INSTANTIATE_00 (nint original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation,UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INSTANTIATE_01 (nint original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation,nint parent);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INSTANTIATE_02 (nint original);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original,UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INSTANTIATE_03 (nint original,nint parent);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original,UnityEngine.Transform parent,System.Boolean instantiateInWorldSpace)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INSTANTIATE_04 (nint original,nint parent,System.Boolean instantiateInWorldSpace);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  T Instantiate(T original)
        /// </summary>
        /// <param name="original">class T</param>
        /// <returns>class T</returns>
        /// public static extern nint INSTANTIATE_05 (nint original);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  T Instantiate(T original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class T</returns>
        /// public static extern nint INSTANTIATE_06 (nint original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  T Instantiate(T original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation,UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// public static extern nint INSTANTIATE_07 (nint original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation,nint parent);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  T Instantiate(T original,UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// public static extern nint INSTANTIATE_08 (nint original,nint parent);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  T Instantiate(T original,UnityEngine.Transform parent,System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// public static extern nint INSTANTIATE_09 (nint original,nint parent,System.Boolean worldPositionStays);


        /// const string Name_Func_RESOLVE_ANTI_ALIASED_SURFACE = "ResolveAntiAliasedSurface";
        /// <summary>
        ///   System.Void ResolveAntiAliasedSurface()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void RESOLVE_ANTI_ALIASED_SURFACE_00 ();


        /// const string Name_Func_RESOLVE_ANTI_ALIASED_SURFACE = "ResolveAntiAliasedSurface";
        /// <summary>
        ///   System.Void ResolveAntiAliasedSurface(UnityEngine.RenderTexture target)
        /// </summary>
        /// <param name="target">class UnityEngine.RenderTexture</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void RESOLVE_ANTI_ALIASED_SURFACE_01 (nint target);


        /// const string Name_Func_SET_DIMENSION = "set_dimension";
        /// <summary>
        ///   System.Void set_dimension(UnityEngine.Rendering.TextureDimension value)
        /// </summary>
        /// <param name="value">enum UnityEngine.Rendering.TextureDimension</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_DIMENSION_00 (UnityEngine.Rendering.TextureDimension value);


        /// const string Name_Func_SET_DIMENSION = "set_dimension";
        /// <summary>
        ///   System.Void set_dimension(UnityEngine.Rendering.TextureDimension value)
        /// </summary>
        /// <param name="value">enum UnityEngine.Rendering.TextureDimension</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_DIMENSION_01 (UnityEngine.Rendering.TextureDimension value);


        /// const string Name_Func_SET_HEIGHT = "set_height";
        /// <summary>
        ///   System.Void set_height(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_HEIGHT_00 (System.Int32 value);


        /// const string Name_Func_SET_HEIGHT = "set_height";
        /// <summary>
        ///   System.Void set_height(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_HEIGHT_01 (System.Int32 value);


        /// const string Name_Func_SET_WIDTH = "set_width";
        /// <summary>
        ///   System.Void set_width(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_WIDTH_00 (System.Int32 value);


        /// const string Name_Func_SET_WIDTH = "set_width";
        /// <summary>
        ///   System.Void set_width(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_WIDTH_01 (System.Int32 value);


        /// const string Name_Func_TO_STRING = "ToString";
        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint TO_STRING_00 ();


        /// const string Name_Func_TO_STRING = "ToString";
        /// <summary>
        /// static  System.String ToString(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// public static extern nint TO_STRING_01 (nint obj);


        /// const string Name_Func_VALIDATE_FORMAT = "ValidateFormat";
        /// <summary>
        ///   System.Boolean ValidateFormat(UnityEngine.TextureFormat format)
        /// </summary>
        /// <param name="format">enum UnityEngine.TextureFormat</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean VALIDATE_FORMAT_00 (UnityEngine.TextureFormat format);


        /// const string Name_Func_VALIDATE_FORMAT = "ValidateFormat";
        /// <summary>
        ///   System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format,UnityEngine.Experimental.Rendering.FormatUsage usage)
        /// </summary>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="usage">enum UnityEngine.Experimental.Rendering.FormatUsage</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean VALIDATE_FORMAT_01 (UnityEngine.Experimental.Rendering.GraphicsFormat format,UnityEngine.Experimental.Rendering.FormatUsage usage);


        public static partial class Search_RenderTexture
        {
            /// 
            ///     

            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// public static bool .CCTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".cctor");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// public static bool .CCTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".cctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(UnityEngine.RenderTextureDescriptor desc)
            /// </summary>
            /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "UnityEngine.RenderTextureDescriptor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(UnityEngine.RenderTexture textureToCopy)
            /// </summary>
            /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "UnityEngine.RenderTexture");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.DefaultFormat format)
            /// </summary>
            /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.DefaultFormat");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format)
            /// </summary>
            /// public static bool .CTOR_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.GraphicsFormat");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 mipCount)
            /// </summary>
            /// public static bool .CTOR_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.GraphicsFormat", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite)
            /// </summary>
            /// public static bool .CTOR_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.RenderTextureFormat", "UnityEngine.RenderTextureReadWrite");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format)
            /// </summary>
            /// public static bool .CTOR_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.RenderTextureFormat");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth)
            /// </summary>
            /// public static bool .CTOR_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, System.Int32 mipCount)
            /// </summary>
            /// public static bool .CTOR_09 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.RenderTextureFormat", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_0A (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_0B (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// public static bool DESTROY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj)
            /// </summary>
            /// public static bool DESTROY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
            /// </summary>
            /// public static bool DESTROY_IMMEDIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
            /// </summary>
            /// public static bool DESTROY_IMMEDIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// public static bool DESTROY_OBJECT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj)
            /// </summary>
            /// public static bool DESTROY_OBJECT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void DiscardContents(System.Boolean discardColor, System.Boolean discardDepth)
            /// </summary>
            /// public static bool DISCARD_CONTENTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DiscardContents", "System.Boolean", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void DiscardContents()
            /// </summary>
            /// public static bool DISCARD_CONTENTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DiscardContents");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T FindObjectOfType()
            /// </summary>
            /// public static bool FIND_OBJECT_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T FindObjectOfType(System.Boolean includeInactive)
            /// </summary>
            /// public static bool FIND_OBJECT_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type)
            /// </summary>
            /// public static bool FIND_OBJECT_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// public static bool FIND_OBJECT_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
            /// </summary>
            /// public static bool FIND_OBJECTS_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// public static bool FIND_OBJECTS_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T[] FindObjectsOfType()
            /// </summary>
            /// public static bool FIND_OBJECTS_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
            /// </summary>
            /// public static bool FIND_OBJECTS_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Rendering.TextureDimension get_dimension()
            /// </summary>
            /// public static bool GET_DIMENSION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_dimension");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Rendering.TextureDimension get_dimension()
            /// </summary>
            /// public static bool GET_DIMENSION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_dimension");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
            /// </summary>
            /// public static bool GET_GRAPHICS_FORMAT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_graphicsFormat");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
            /// </summary>
            /// public static bool GET_GRAPHICS_FORMAT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_graphicsFormat");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 get_height()
            /// </summary>
            /// public static bool GET_HEIGHT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_height");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 get_height()
            /// </summary>
            /// public static bool GET_HEIGHT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_height");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 get_width()
            /// </summary>
            /// public static bool GET_WIDTH_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_width");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 get_width()
            /// </summary>
            /// public static bool GET_WIDTH_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_width");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc)
            /// </summary>
            /// public static bool GET_TEMPORARY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "UnityEngine.RenderTextureDescriptor");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale)
            /// </summary>
            /// public static bool GET_TEMPORARY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.GraphicsFormat", "System.Int32", "UnityEngine.RenderTextureMemoryless", "UnityEngine.VRTextureUsage", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage)
            /// </summary>
            /// public static bool GET_TEMPORARY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.GraphicsFormat", "System.Int32", "UnityEngine.RenderTextureMemoryless", "UnityEngine.VRTextureUsage");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode)
            /// </summary>
            /// public static bool GET_TEMPORARY_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.GraphicsFormat", "System.Int32", "UnityEngine.RenderTextureMemoryless");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing)
            /// </summary>
            public static bool GET_TEMPORARY_04(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.GraphicsFormat", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format)
            /// </summary>
            /// public static bool GET_TEMPORARY_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.GraphicsFormat");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale)
            /// </summary>
            /// public static bool GET_TEMPORARY_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.RenderTextureFormat", "UnityEngine.RenderTextureReadWrite", "System.Int32", "UnityEngine.RenderTextureMemoryless", "UnityEngine.VRTextureUsage", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage)
            /// </summary>
            /// public static bool GET_TEMPORARY_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.RenderTextureFormat", "UnityEngine.RenderTextureReadWrite", "System.Int32", "UnityEngine.RenderTextureMemoryless", "UnityEngine.VRTextureUsage");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode)
            /// </summary>
            /// public static bool GET_TEMPORARY_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.RenderTextureFormat", "UnityEngine.RenderTextureReadWrite", "System.Int32", "UnityEngine.RenderTextureMemoryless");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing)
            /// </summary>
            /// public static bool GET_TEMPORARY_09 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.RenderTextureFormat", "UnityEngine.RenderTextureReadWrite", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite)
            /// </summary>
            public static bool GET_TEMPORARY_0A(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.RenderTextureFormat", "UnityEngine.RenderTextureReadWrite");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format)
            /// </summary>
            /// public static bool GET_TEMPORARY_0B (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.RenderTextureFormat");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer)
            /// </summary>
            /// public static bool GET_TEMPORARY_0C (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height)
            /// </summary>
            /// public static bool GET_TEMPORARY_0D (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTemporary", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// public static bool INSTANTIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// public static bool INSTANTIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
            /// </summary>
            /// public static bool INSTANTIATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
            /// </summary>
            /// public static bool INSTANTIATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
            /// </summary>
            /// public static bool INSTANTIATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T Instantiate(T original)
            /// </summary>
            /// public static bool INSTANTIATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// public static bool INSTANTIATE_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// public static bool INSTANTIATE_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent)
            /// </summary>
            /// public static bool INSTANTIATE_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// public static bool INSTANTIATE_09 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void ResolveAntiAliasedSurface()
            /// </summary>
            /// public static bool RESOLVE_ANTI_ALIASED_SURFACE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ResolveAntiAliasedSurface");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void ResolveAntiAliasedSurface(UnityEngine.RenderTexture target)
            /// </summary>
            /// public static bool RESOLVE_ANTI_ALIASED_SURFACE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ResolveAntiAliasedSurface", "UnityEngine.RenderTexture");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void set_dimension(UnityEngine.Rendering.TextureDimension value)
            /// </summary>
            /// public static bool SET_DIMENSION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_dimension", "UnityEngine.Rendering.TextureDimension");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void set_dimension(UnityEngine.Rendering.TextureDimension value)
            /// </summary>
            /// public static bool SET_DIMENSION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_dimension", "UnityEngine.Rendering.TextureDimension");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void set_height(System.Int32 value)
            /// </summary>
            /// public static bool SET_HEIGHT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_height", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void set_height(System.Int32 value)
            /// </summary>
            /// public static bool SET_HEIGHT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_height", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void set_width(System.Int32 value)
            /// </summary>
            /// public static bool SET_WIDTH_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_width", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void set_width(System.Int32 value)
            /// </summary>
            /// public static bool SET_WIDTH_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_width", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// public static bool TO_STRING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.String ToString(UnityEngine.Object obj)
            /// </summary>
            /// public static bool TO_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "UnityEngine.Object");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean ValidateFormat(UnityEngine.TextureFormat format)
            /// </summary>
            /// public static bool VALIDATE_FORMAT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ValidateFormat", "UnityEngine.TextureFormat");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
            /// </summary>
            /// public static bool VALIDATE_FORMAT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ValidateFormat", "UnityEngine.Experimental.Rendering.GraphicsFormat", "UnityEngine.Experimental.Rendering.FormatUsage");
            ///     
            ///  
            /// 
            /// 
        }

    }

}
