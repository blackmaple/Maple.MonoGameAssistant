using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.UnityCore.UnityEngine
{

    /// <summary>
    /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Texture2D"]
    /// [UnityEngine.Texture]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], 0x020000B6U)]
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101], [84, 101, 120, 116, 117, 114, 101, 50, 68])]
    public partial class Texture2D
    {
        //public const string Const_ImageName = "UnityEngine.CoreModule.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108];

        //public const string Const_Namespace = "UnityEngine";
        //public static byte[] Static_Namespace { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101];

        //public const string Const_ClassName = "Texture2D";
        //public static byte[] Static_ClassName { get; } = [84, 101, 120, 116, 117, 114, 101, 50, 68];

        //public const uint Const_TypeToken = 0x020000B6U;




        //public readonly unsafe partial struct Const_Texture2D
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
        //public readonly unsafe partial struct Static_Texture2D
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
        //public readonly unsafe partial struct Ref_Texture2D
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
        public readonly unsafe partial struct Ptr_Texture2D(nint ptr)
        {

            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Texture2D(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Texture2D obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            //[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            //public ref Ref_Texture2D AsRef()
            //{
            //    return ref Unsafe.AsRef<Ref_Texture2D>(_ptr.ToPointer());
            //}
        }

    }

    /// <summary>
    /// ["UnityEngine.CoreModule.dll"."UnityEngine"."Texture2D"]
    /// </summary>
    public partial class Texture2D
    {



        /// const string Name_Func_APPLY_IMPL = "ApplyImpl";
        /// <summary>
        ///   System.Void ApplyImpl(System.Boolean updateMipmaps,System.Boolean makeNoLongerReadable)
        /// </summary>
        /// <param name="updateMipmaps">struct System.Boolean</param>
        /// <param name="makeNoLongerReadable">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void APPLY_IMPL (System.Boolean updateMipmaps,System.Boolean makeNoLongerReadable);


        /// const string Name_Func_CHECK_NULL_ARGUMENT = "CheckNullArgument";
        /// <summary>
        /// static  System.Void CheckNullArgument(System.Object arg,System.String message)
        /// </summary>
        /// <param name="arg">class System.Object</param>
        /// <param name="message">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void CHECK_NULL_ARGUMENT (nint arg,nint message);


        /// const string Name_Func_CLEAR_MINIMUM_MIPMAP_LEVEL = "ClearMinimumMipmapLevel";
        /// <summary>
        ///   System.Void ClearMinimumMipmapLevel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void CLEAR_MINIMUM_MIPMAP_LEVEL ();


        /// const string Name_Func_CLEAR_REQUESTED_MIPMAP_LEVEL = "ClearRequestedMipmapLevel";
        /// <summary>
        ///   System.Void ClearRequestedMipmapLevel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void CLEAR_REQUESTED_MIPMAP_LEVEL ();


        /// const string Name_Func_COMPARE_BASE_OBJECTS = "CompareBaseObjects";
        /// <summary>
        /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs,UnityEngine.Object rhs)
        /// </summary>
        /// <param name="lhs">class UnityEngine.Object</param>
        /// <param name="rhs">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean COMPARE_BASE_OBJECTS (nint lhs,nint rhs);


        /// const string Name_Func_COMPRESS = "Compress";
        /// <summary>
        ///   System.Void Compress(System.Boolean highQuality)
        /// </summary>
        /// <param name="highQuality">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void COMPRESS (System.Boolean highQuality);


        /// const string Name_Func_CREATE_EXTERNAL_TEXTURE = "CreateExternalTexture";
        /// <summary>
        /// static  UnityEngine.Texture2D CreateExternalTexture(System.Int32 width,System.Int32 height,UnityEngine.TextureFormat format,System.Boolean mipChain,System.Boolean linear,System.IntPtr nativeTex)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.TextureFormat</param>
        /// <param name="mipChain">struct System.Boolean</param>
        /// <param name="linear">struct System.Boolean</param>
        /// <param name="nativeTex">struct System.IntPtr</param>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// public static extern nint CREATE_EXTERNAL_TEXTURE (System.Int32 width,System.Int32 height,UnityEngine.TextureFormat format,System.Boolean mipChain,System.Boolean linear,System.IntPtr nativeTex);


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


        /// const string Name_Func_GENERATE_ATLAS = "GenerateAtlas";
        /// <summary>
        /// static  System.Boolean GenerateAtlas(UnityEngine.Vector2[] sizes,System.Int32 padding,System.Int32 atlasSize,System.Collections.Generic.List<UnityEngine.Rect> results)
        /// </summary>
        /// <param name="sizes">class UnityEngine.Vector2[]</param>
        /// <param name="padding">struct System.Int32</param>
        /// <param name="atlasSize">struct System.Int32</param>
        /// <param name="results">class System.Collections.Generic.List<UnityEngine.Rect></param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean GENERATE_ATLAS (nint sizes,System.Int32 padding,System.Int32 atlasSize,nint results);


        /// const string Name_Func_GENERATE_ATLAS_IMPL = "GenerateAtlasImpl";
        /// <summary>
        /// static  System.Void GenerateAtlasImpl(UnityEngine.Vector2[] sizes,System.Int32 padding,System.Int32 atlasSize,UnityEngine.Rect[] rect)
        /// </summary>
        /// <param name="sizes">class UnityEngine.Vector2[]</param>
        /// <param name="padding">struct System.Int32</param>
        /// <param name="atlasSize">struct System.Int32</param>
        /// <param name="rect">class UnityEngine.Rect[]</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void GENERATE_ATLAS_IMPL (nint sizes,System.Int32 padding,System.Int32 atlasSize,nint rect);


        /// const string Name_Func_GET_ACTIVE_TEXTURE_COLOR_SPACE = "get_activeTextureColorSpace";
        /// <summary>
        ///   UnityEngine.ColorSpace get_activeTextureColorSpace()
        /// </summary>
        /// <returns>enum UnityEngine.ColorSpace</returns>
        /// public  extern UnityEngine.ColorSpace GET_ACTIVE_TEXTURE_COLOR_SPACE ();


        ///const string Name_Func_GET_ALLOW_THREADED_TEXTURE_CREATION = "get_allowThreadedTextureCreation";
        /// <summary>
        /// static  System.Boolean get_allowThreadedTextureCreation()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        ///static extern System.Boolean GET_ALLOW_THREADED_TEXTURE_CREATION();


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


        /// const string Name_Func_GET_BLACK_TEXTURE = "get_blackTexture";
        /// <summary>
        /// static  UnityEngine.Texture2D get_blackTexture()
        /// </summary>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// public static extern nint GET_BLACK_TEXTURE ();


        /// const string Name_Func_GET_CALCULATED_MIPMAP_LEVEL = "get_calculatedMipmapLevel";
        /// <summary>
        ///   System.Int32 get_calculatedMipmapLevel()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_CALCULATED_MIPMAP_LEVEL ();


        /// const string Name_Func_GET_DESIRED_MIPMAP_LEVEL = "get_desiredMipmapLevel";
        /// <summary>
        ///   System.Int32 get_desiredMipmapLevel()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_DESIRED_MIPMAP_LEVEL ();


        /// const string Name_Func_GET_DIMENSION = "get_dimension";
        /// <summary>
        ///   UnityEngine.Rendering.TextureDimension get_dimension()
        /// </summary>
        /// <returns>enum UnityEngine.Rendering.TextureDimension</returns>
        /// public  extern UnityEngine.Rendering.TextureDimension GET_DIMENSION ();


        /// const string Name_Func_GET_FILTER_MODE = "get_filterMode";
        /// <summary>
        ///   UnityEngine.FilterMode get_filterMode()
        /// </summary>
        /// <returns>enum UnityEngine.FilterMode</returns>
        /// public  extern UnityEngine.FilterMode GET_FILTER_MODE ();


        ///const string Name_Func_GET_FORMAT = "get_format";
        /// <summary>
        ///   UnityEngine.TextureFormat get_format()
        /// </summary>
        /// <returns>enum UnityEngine.TextureFormat</returns>
        ///[MonoCollectorMethod(Name_Func_GET_FORMAT)]
        ///extern UnityEngine.TextureFormat GET_FORMAT();


        /// const string Name_Func_GET_GRAPHICS_FORMAT = "get_graphicsFormat";
        /// <summary>
        ///   UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
        /// </summary>
        /// <returns>enum UnityEngine.Experimental.Rendering.GraphicsFormat</returns>
        /// public  extern UnityEngine.Experimental.Rendering.GraphicsFormat GET_GRAPHICS_FORMAT ();


        /// const string Name_Func_GET_GRAY_TEXTURE = "get_grayTexture";
        /// <summary>
        /// static  UnityEngine.Texture2D get_grayTexture()
        /// </summary>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// public static extern nint GET_GRAY_TEXTURE ();


        public const string Name_Func_GET_HEIGHT = "get_height";
        /// <summary>
        ///   System.Int32 get_height()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [MonoCollectorMethod(Name_Func_GET_HEIGHT, CallConvs = [typeof(CallConvCdecl)])]
        extern System.Int32 GET_HEIGHT();


        /// const string Name_Func_GET_HIDE_FLAGS = "get_hideFlags";
        /// <summary>
        ///   UnityEngine.HideFlags get_hideFlags()
        /// </summary>
        /// <returns>enum UnityEngine.HideFlags</returns>
        /// public  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();


        /// const string Name_Func_GET_IS_PRE_PROCESSED = "get_isPreProcessed";
        /// <summary>
        ///   System.Boolean get_isPreProcessed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_PRE_PROCESSED ();


        /// const string Name_Func_GET_LINEAR_GRAY_TEXTURE = "get_linearGrayTexture";
        /// <summary>
        /// static  UnityEngine.Texture2D get_linearGrayTexture()
        /// </summary>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// public static extern nint GET_LINEAR_GRAY_TEXTURE ();


        /// const string Name_Func_GET_LOAD_ALL_MIPS = "get_loadAllMips";
        /// <summary>
        ///   System.Boolean get_loadAllMips()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_LOAD_ALL_MIPS ();


        /// const string Name_Func_GET_LOADED_MIPMAP_LEVEL = "get_loadedMipmapLevel";
        /// <summary>
        ///   System.Int32 get_loadedMipmapLevel()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_LOADED_MIPMAP_LEVEL ();


        /// const string Name_Func_GET_LOADING_MIPMAP_LEVEL = "get_loadingMipmapLevel";
        /// <summary>
        ///   System.Int32 get_loadingMipmapLevel()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_LOADING_MIPMAP_LEVEL ();


        /// const string Name_Func_GET_MASTER_TEXTURE_LIMIT = "get_masterTextureLimit";
        /// <summary>
        /// static  System.Int32 get_masterTextureLimit()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public static extern System.Int32 GET_MASTER_TEXTURE_LIMIT ();


        /// const string Name_Func_GET_MINIMUM_MIPMAP_LEVEL = "get_minimumMipmapLevel";
        /// <summary>
        ///   System.Int32 get_minimumMipmapLevel()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_MINIMUM_MIPMAP_LEVEL ();


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


        /// const string Name_Func_GET_NORMAL_TEXTURE = "get_normalTexture";
        /// <summary>
        /// static  UnityEngine.Texture2D get_normalTexture()
        /// </summary>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// public static extern nint GET_NORMAL_TEXTURE ();


        /// const string Name_Func_GET_RED_TEXTURE = "get_redTexture";
        /// <summary>
        /// static  UnityEngine.Texture2D get_redTexture()
        /// </summary>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// public static extern nint GET_RED_TEXTURE ();


        /// const string Name_Func_GET_REQUESTED_MIPMAP_LEVEL = "get_requestedMipmapLevel";
        /// <summary>
        ///   System.Int32 get_requestedMipmapLevel()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_REQUESTED_MIPMAP_LEVEL ();


        /// const string Name_Func_GET_STREAMING_MIPMAPS = "get_streamingMipmaps";
        /// <summary>
        ///   System.Boolean get_streamingMipmaps()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_STREAMING_MIPMAPS ();


        /// const string Name_Func_GET_STREAMING_MIPMAPS_PRIORITY = "get_streamingMipmapsPriority";
        /// <summary>
        ///   System.Int32 get_streamingMipmapsPriority()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_STREAMING_MIPMAPS_PRIORITY ();


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


        /// const string Name_Func_GET_VT_ONLY = "get_vtOnly";
        /// <summary>
        ///   System.Boolean get_vtOnly()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_VT_ONLY ();


        /// const string Name_Func_GET_WHITE_TEXTURE = "get_whiteTexture";
        /// <summary>
        /// static  UnityEngine.Texture2D get_whiteTexture()
        /// </summary>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// public static extern nint GET_WHITE_TEXTURE ();


        public const string Name_Func_GET_WIDTH = "get_width";
        /// <summary>
        ///   System.Int32 get_width()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [MonoCollectorMethod(Name_Func_GET_WIDTH, CallConvs = [typeof(CallConvCdecl)])]
        extern System.Int32 GET_WIDTH();


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


        /// const string Name_Func_GET_CACHED_PTR = "GetCachedPtr";
        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// public  extern System.IntPtr GET_CACHED_PTR ();


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


        /// const string Name_Func_GET_NAME = "GetName";
        /// <summary>
        /// static  System.String GetName(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// public static extern nint GET_NAME (nint obj);


        /// const string Name_Func_GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT = "GetOffsetOfInstanceIDInCPlusPlusObject";
        /// <summary>
        /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();


        /// const string Name_Func_GET_PIXEL_BILINEAR_IMPL = "GetPixelBilinearImpl";
        /// <summary>
        ///   UnityEngine.Color GetPixelBilinearImpl(System.Int32 image,System.Single u,System.Single v)
        /// </summary>
        /// <param name="image">struct System.Int32</param>
        /// <param name="u">struct System.Single</param>
        /// <param name="v">struct System.Single</param>
        /// <returns>struct UnityEngine.Color</returns>
        /// public  extern UnityEngine.Color GET_PIXEL_BILINEAR_IMPL (System.Int32 image,System.Single u,System.Single v);


        /// const string Name_Func_GET_PIXEL_BILINEAR_IMPL_INJECTED = "GetPixelBilinearImpl_Injected";
        /// <summary>
        ///   System.Void GetPixelBilinearImpl_Injected(System.Int32 image,System.Single u,System.Single v,UnityEngine.Color& ret)
        /// </summary>
        /// <param name="image">struct System.Int32</param>
        /// <param name="u">struct System.Single</param>
        /// <param name="v">struct System.Single</param>
        /// <param name="ret">struct UnityEngine.Color&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_PIXEL_BILINEAR_IMPL_INJECTED (System.Int32 image,System.Single u,System.Single v,UnityEngine.Color& ret);


        /// const string Name_Func_GET_PIXEL_DATA = "GetPixelData";
        /// <summary>
        ///   Unity.Collections.NativeArray<T> GetPixelData(System.Int32 mipLevel)
        /// </summary>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <returns>struct Unity.Collections.NativeArray<T></returns>
        /// public  extern Unity.Collections.NativeArray<T> GET_PIXEL_DATA (System.Int32 mipLevel);


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


        /// const string Name_Func_GET_PIXEL_IMPL = "GetPixelImpl";
        /// <summary>
        ///   UnityEngine.Color GetPixelImpl(System.Int32 image,System.Int32 x,System.Int32 y)
        /// </summary>
        /// <param name="image">struct System.Int32</param>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <returns>struct UnityEngine.Color</returns>
        /// public  extern UnityEngine.Color GET_PIXEL_IMPL (System.Int32 image,System.Int32 x,System.Int32 y);


        /// const string Name_Func_GET_PIXEL_IMPL_INJECTED = "GetPixelImpl_Injected";
        /// <summary>
        ///   System.Void GetPixelImpl_Injected(System.Int32 image,System.Int32 x,System.Int32 y,UnityEngine.Color& ret)
        /// </summary>
        /// <param name="image">struct System.Int32</param>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="ret">struct UnityEngine.Color&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_PIXEL_IMPL_INJECTED (System.Int32 image,System.Int32 x,System.Int32 y,UnityEngine.Color& ret);


        /// const string Name_Func_GET_RAW_IMAGE_DATA_SIZE = "GetRawImageDataSize";
        /// <summary>
        ///   System.Int64 GetRawImageDataSize()
        /// </summary>
        /// <returns>struct System.Int64</returns>
        /// public  extern System.Int64 GET_RAW_IMAGE_DATA_SIZE ();


        /// const string Name_Func_GET_WRITABLE_IMAGE_DATA = "GetWritableImageData";
        /// <summary>
        ///   System.IntPtr GetWritableImageData(System.Int32 frame)
        /// </summary>
        /// <param name="frame">struct System.Int32</param>
        /// <returns>struct System.IntPtr</returns>
        /// public  extern System.IntPtr GET_WRITABLE_IMAGE_DATA (System.Int32 frame);


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
        /// static  System.Void Internal_Create(UnityEngine.Texture2D mono,System.Int32 w,System.Int32 h,System.Int32 mipCount,UnityEngine.Experimental.Rendering.GraphicsFormat format,UnityEngine.Experimental.Rendering.TextureCreationFlags flags,System.IntPtr nativeTex)
        /// </summary>
        /// <param name="mono">class UnityEngine.Texture2D</param>
        /// <param name="w">struct System.Int32</param>
        /// <param name="h">struct System.Int32</param>
        /// <param name="mipCount">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
        /// <param name="nativeTex">struct System.IntPtr</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void INTERNAL_CREATE (nint mono,System.Int32 w,System.Int32 h,System.Int32 mipCount,UnityEngine.Experimental.Rendering.GraphicsFormat format,UnityEngine.Experimental.Rendering.TextureCreationFlags flags,System.IntPtr nativeTex);


        /// const string Name_Func_INTERNAL_CREATE_IMPL = "Internal_CreateImpl";
        /// <summary>
        /// static  System.Boolean Internal_CreateImpl(UnityEngine.Texture2D mono,System.Int32 w,System.Int32 h,System.Int32 mipCount,UnityEngine.Experimental.Rendering.GraphicsFormat format,UnityEngine.Experimental.Rendering.TextureCreationFlags flags,System.IntPtr nativeTex)
        /// </summary>
        /// <param name="mono">class UnityEngine.Texture2D</param>
        /// <param name="w">struct System.Int32</param>
        /// <param name="h">struct System.Int32</param>
        /// <param name="mipCount">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
        /// <param name="nativeTex">struct System.IntPtr</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean INTERNAL_CREATE_IMPL (nint mono,System.Int32 w,System.Int32 h,System.Int32 mipCount,UnityEngine.Experimental.Rendering.GraphicsFormat format,UnityEngine.Experimental.Rendering.TextureCreationFlags flags,System.IntPtr nativeTex);


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


        /// const string Name_Func_IS_REQUESTED_MIPMAP_LEVEL_LOADED = "IsRequestedMipmapLevelLoaded";
        /// <summary>
        ///   System.Boolean IsRequestedMipmapLevelLoaded()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_REQUESTED_MIPMAP_LEVEL_LOADED ();


        /// const string Name_Func_LOAD_RAW_TEXTURE_DATA_IMPL = "LoadRawTextureDataImpl";
        /// <summary>
        ///   System.Boolean LoadRawTextureDataImpl(System.IntPtr data,System.Int32 size)
        /// </summary>
        /// <param name="data">struct System.IntPtr</param>
        /// <param name="size">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean LOAD_RAW_TEXTURE_DATA_IMPL (System.IntPtr data,System.Int32 size);


        /// const string Name_Func_LOAD_RAW_TEXTURE_DATA_IMPL_ARRAY = "LoadRawTextureDataImplArray";
        /// <summary>
        ///   System.Boolean LoadRawTextureDataImplArray(System.Byte[] data)
        /// </summary>
        /// <param name="data">class System.Byte[]</param>
        /// <returns>struct System.Boolean</returns>
        ///extern System.Boolean LOAD_RAW_TEXTURE_DATA_IMPL_ARRAY(nint data);


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


        /// const string Name_Func_READ_PIXELS_IMPL = "ReadPixelsImpl";
        /// <summary>
        ///   System.Void ReadPixelsImpl(UnityEngine.Rect source,System.Int32 destX,System.Int32 destY,System.Boolean recalculateMipMaps)
        /// </summary>
        /// <param name="source">struct UnityEngine.Rect</param>
        /// <param name="destX">struct System.Int32</param>
        /// <param name="destY">struct System.Int32</param>
        /// <param name="recalculateMipMaps">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void READ_PIXELS_IMPL (UnityEngine.Rect source,System.Int32 destX,System.Int32 destY,System.Boolean recalculateMipMaps);


        public const string Name_Func_READ_PIXELS_IMPL_INJECTED = "ReadPixelsImpl_Injected";
        /// <summary>
        ///   System.Void ReadPixelsImpl_Injected(UnityEngine.Rect& source,System.Int32 destX,System.Int32 destY,System.Boolean recalculateMipMaps)
        /// </summary>
        /// <param name="source">struct UnityEngine.Rect&</param>
        /// <param name="destX">struct System.Int32</param>
        /// <param name="destY">struct System.Int32</param>
        /// <param name="recalculateMipMaps">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        [MonoCollectorMethod(Name_Func_READ_PIXELS_IMPL_INJECTED, CallConvs = [typeof(CallConvCdecl)])]
        public extern void READ_PIXELS_IMPL_INJECTED(in UnityEngine.Rect.Ref_Rect source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps);


        /// const string Name_Func_RESIZE_IMPL = "ResizeImpl";
        /// <summary>
        ///   System.Boolean ResizeImpl(System.Int32 width,System.Int32 height)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean RESIZE_IMPL (System.Int32 width,System.Int32 height);


        /// const string Name_Func_RESIZE_WITH_FORMAT_IMPL = "ResizeWithFormatImpl";
        /// <summary>
        ///   System.Boolean ResizeWithFormatImpl(System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Boolean hasMipMap)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="hasMipMap">struct System.Boolean</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean RESIZE_WITH_FORMAT_IMPL (System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Boolean hasMipMap);


        ///const string Name_Func_SET_ALLOW_THREADED_TEXTURE_CREATION = "set_allowThreadedTextureCreation";
        /// <summary>
        /// static  System.Void set_allowThreadedTextureCreation(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        ///static extern void SET_ALLOW_THREADED_TEXTURE_CREATION(System.Boolean value);


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


        /// const string Name_Func_SET_DIMENSION = "set_dimension";
        /// <summary>
        ///   System.Void set_dimension(UnityEngine.Rendering.TextureDimension value)
        /// </summary>
        /// <param name="value">enum UnityEngine.Rendering.TextureDimension</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_DIMENSION (UnityEngine.Rendering.TextureDimension value);


        /// const string Name_Func_SET_FILTER_MODE = "set_filterMode";
        /// <summary>
        ///   System.Void set_filterMode(UnityEngine.FilterMode value)
        /// </summary>
        /// <param name="value">enum UnityEngine.FilterMode</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FILTER_MODE (UnityEngine.FilterMode value);


        /// const string Name_Func_SET_HEIGHT = "set_height";
        /// <summary>
        ///   System.Void set_height(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_HEIGHT (System.Int32 value);


        /// const string Name_Func_SET_HIDE_FLAGS = "set_hideFlags";
        /// <summary>
        ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
        /// </summary>
        /// <param name="value">enum UnityEngine.HideFlags</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);


        /// const string Name_Func_SET_LOAD_ALL_MIPS = "set_loadAllMips";
        /// <summary>
        ///   System.Void set_loadAllMips(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_LOAD_ALL_MIPS (System.Boolean value);


        /// const string Name_Func_SET_MASTER_TEXTURE_LIMIT = "set_masterTextureLimit";
        /// <summary>
        /// static  System.Void set_masterTextureLimit(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_MASTER_TEXTURE_LIMIT (System.Int32 value);


        /// const string Name_Func_SET_MINIMUM_MIPMAP_LEVEL = "set_minimumMipmapLevel";
        /// <summary>
        ///   System.Void set_minimumMipmapLevel(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MINIMUM_MIPMAP_LEVEL (System.Int32 value);


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


        /// const string Name_Func_SET_REQUESTED_MIPMAP_LEVEL = "set_requestedMipmapLevel";
        /// <summary>
        ///   System.Void set_requestedMipmapLevel(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_REQUESTED_MIPMAP_LEVEL (System.Int32 value);


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


        /// const string Name_Func_SET_WIDTH = "set_width";
        /// <summary>
        ///   System.Void set_width(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_WIDTH (System.Int32 value);


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


        /// const string Name_Func_SET_ALL_PIXELS32 = "SetAllPixels32";
        /// <summary>
        ///   System.Void SetAllPixels32(UnityEngine.Color32[] colors,System.Int32 miplevel)
        /// </summary>
        /// <param name="colors">class UnityEngine.Color32[]</param>
        /// <param name="miplevel">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_ALL_PIXELS32 (nint colors,System.Int32 miplevel);


        /// const string Name_Func_SET_BLOCK_OF_PIXELS32 = "SetBlockOfPixels32";
        /// <summary>
        ///   System.Void SetBlockOfPixels32(System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,UnityEngine.Color32[] colors,System.Int32 miplevel)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="blockWidth">struct System.Int32</param>
        /// <param name="blockHeight">struct System.Int32</param>
        /// <param name="colors">class UnityEngine.Color32[]</param>
        /// <param name="miplevel">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_BLOCK_OF_PIXELS32 (System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,nint colors,System.Int32 miplevel);


        /// const string Name_Func_SET_NAME = "SetName";
        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj,System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_NAME (nint obj,nint name);


        /// const string Name_Func_SET_PIXEL_DATA_IMPL = "SetPixelDataImpl";
        /// <summary>
        ///   System.Boolean SetPixelDataImpl(System.IntPtr data,System.Int32 mipLevel,System.Int32 elementSize,System.Int32 dataArraySize,System.Int32 sourceDataStartIndex)
        /// </summary>
        /// <param name="data">struct System.IntPtr</param>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <param name="elementSize">struct System.Int32</param>
        /// <param name="dataArraySize">struct System.Int32</param>
        /// <param name="sourceDataStartIndex">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean SET_PIXEL_DATA_IMPL (System.IntPtr data,System.Int32 mipLevel,System.Int32 elementSize,System.Int32 dataArraySize,System.Int32 sourceDataStartIndex);


        /// const string Name_Func_SET_PIXEL_DATA_IMPL_ARRAY = "SetPixelDataImplArray";
        /// <summary>
        ///   System.Boolean SetPixelDataImplArray(System.Array data,System.Int32 mipLevel,System.Int32 elementSize,System.Int32 dataArraySize,System.Int32 sourceDataStartIndex)
        /// </summary>
        /// <param name="data">abstract class System.Array</param>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <param name="elementSize">struct System.Int32</param>
        /// <param name="dataArraySize">struct System.Int32</param>
        /// <param name="sourceDataStartIndex">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean SET_PIXEL_DATA_IMPL_ARRAY (nint data,System.Int32 mipLevel,System.Int32 elementSize,System.Int32 dataArraySize,System.Int32 sourceDataStartIndex);


        /// const string Name_Func_SET_PIXEL_IMPL = "SetPixelImpl";
        /// <summary>
        ///   System.Void SetPixelImpl(System.Int32 image,System.Int32 x,System.Int32 y,UnityEngine.Color color)
        /// </summary>
        /// <param name="image">struct System.Int32</param>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="color">struct UnityEngine.Color</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXEL_IMPL (System.Int32 image,System.Int32 x,System.Int32 y,UnityEngine.Color color);


        /// const string Name_Func_SET_PIXEL_IMPL_INJECTED = "SetPixelImpl_Injected";
        /// <summary>
        ///   System.Void SetPixelImpl_Injected(System.Int32 image,System.Int32 x,System.Int32 y,UnityEngine.Color& color)
        /// </summary>
        /// <param name="image">struct System.Int32</param>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="color">struct UnityEngine.Color&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXEL_IMPL_INJECTED (System.Int32 image,System.Int32 x,System.Int32 y,UnityEngine.Color& color);


        /// const string Name_Func_SET_PIXELS_IMPL = "SetPixelsImpl";
        /// <summary>
        ///   System.Void SetPixelsImpl(System.Int32 x,System.Int32 y,System.Int32 w,System.Int32 h,UnityEngine.Color[] pixel,System.Int32 miplevel,System.Int32 frame)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="w">struct System.Int32</param>
        /// <param name="h">struct System.Int32</param>
        /// <param name="pixel">class UnityEngine.Color[]</param>
        /// <param name="miplevel">struct System.Int32</param>
        /// <param name="frame">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXELS_IMPL (System.Int32 x,System.Int32 y,System.Int32 w,System.Int32 h,nint pixel,System.Int32 miplevel,System.Int32 frame);


        /// const string Name_Func_UPDATE_EXTERNAL_TEXTURE = "UpdateExternalTexture";
        /// <summary>
        ///   System.Void UpdateExternalTexture(System.IntPtr nativeTex)
        /// </summary>
        /// <param name="nativeTex">struct System.IntPtr</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void UPDATE_EXTERNAL_TEXTURE (System.IntPtr nativeTex);



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
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.GraphicsFormat format,UnityEngine.Experimental.Rendering.TextureCreationFlags flags,System.Int32 mipCount,System.IntPtr nativeTex)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
        /// <param name="mipCount">struct System.Int32</param>
        /// <param name="nativeTex">struct System.IntPtr</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_00 (System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.GraphicsFormat format,UnityEngine.Experimental.Rendering.TextureCreationFlags flags,System.Int32 mipCount,System.IntPtr nativeTex);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.DefaultFormat format,UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.DefaultFormat</param>
        /// <param name="flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_01 (System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.DefaultFormat format,UnityEngine.Experimental.Rendering.TextureCreationFlags flags);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.GraphicsFormat format,UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_02 (System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.GraphicsFormat format,UnityEngine.Experimental.Rendering.TextureCreationFlags flags);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 mipCount,UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="mipCount">struct System.Int32</param>
        /// <param name="flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_03 (System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Int32 mipCount,UnityEngine.Experimental.Rendering.TextureCreationFlags flags);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,UnityEngine.TextureFormat textureFormat,System.Int32 mipCount,System.Boolean linear,System.IntPtr nativeTex)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="textureFormat">enum UnityEngine.TextureFormat</param>
        /// <param name="mipCount">struct System.Int32</param>
        /// <param name="linear">struct System.Boolean</param>
        /// <param name="nativeTex">struct System.IntPtr</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_04 (System.Int32 width,System.Int32 height,UnityEngine.TextureFormat textureFormat,System.Int32 mipCount,System.Boolean linear,System.IntPtr nativeTex);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,UnityEngine.TextureFormat textureFormat,System.Int32 mipCount,System.Boolean linear)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="textureFormat">enum UnityEngine.TextureFormat</param>
        /// <param name="mipCount">struct System.Int32</param>
        /// <param name="linear">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_05 (System.Int32 width,System.Int32 height,UnityEngine.TextureFormat textureFormat,System.Int32 mipCount,System.Boolean linear);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,UnityEngine.TextureFormat textureFormat,System.Boolean mipChain,System.Boolean linear)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="textureFormat">enum UnityEngine.TextureFormat</param>
        /// <param name="mipChain">struct System.Boolean</param>
        /// <param name="linear">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_06 (System.Int32 width,System.Int32 height,UnityEngine.TextureFormat textureFormat,System.Boolean mipChain,System.Boolean linear);


        public const string Name_Func_CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height,UnityEngine.TextureFormat textureFormat,System.Boolean mipChain)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="textureFormat">enum UnityEngine.TextureFormat</param>
        /// <param name="mipChain">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        ///[MonoCollectorMethod(Name_Func_CTOR, Search = typeof(Search_Texture2D), CallConvs = [typeof(CallConvCdecl)])]
        ///public extern void CTOR_07(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain);


        /// <summary>
        ///   System.Void .ctor(System.Int32 width,System.Int32 height)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [MonoCollectorMethod(Name_Func_CTOR, Search = typeof(Search_Texture2D), CallConvs = [typeof(CallConvCdecl)])]
        extern void CTOR_08(System.Int32 width, System.Int32 height);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_09 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_0A ();


        ///const string Name_Func_APPLY = "Apply";
        /// <summary>
        ///   System.Void Apply(System.Boolean updateMipmaps,System.Boolean makeNoLongerReadable)
        /// </summary>
        /// <param name="updateMipmaps">struct System.Boolean</param>
        /// <param name="makeNoLongerReadable">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        ///extern void APPLY_00(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable);


        /// const string Name_Func_APPLY = "Apply";
        /// <summary>
        ///   System.Void Apply(System.Boolean updateMipmaps)
        /// </summary>
        /// <param name="updateMipmaps">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void APPLY_01 (System.Boolean updateMipmaps);


        public const string Name_Func_APPLY = "Apply";
        /// <summary>
        ///   System.Void Apply()
        /// </summary>
        /// <returns>struct System.Void</returns>
        [MonoCollectorMethod(Name_Func_APPLY, Search = typeof(Search_Texture2D), CallConvs = [typeof(CallConvCdecl)])]
        extern void APPLY_02();


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


        /// const string Name_Func_GET_IS_READABLE = "get_isReadable";
        /// <summary>
        ///   System.Boolean get_isReadable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_READABLE_00 ();


        /// const string Name_Func_GET_IS_READABLE = "get_isReadable";
        /// <summary>
        ///   System.Boolean get_isReadable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_READABLE_01 ();


        /// const string Name_Func_GET_PIXEL = "GetPixel";
        /// <summary>
        ///   UnityEngine.Color GetPixel(System.Int32 x,System.Int32 y)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <returns>struct UnityEngine.Color</returns>
        /// public  extern UnityEngine.Color GET_PIXEL_00 (System.Int32 x,System.Int32 y);


        /// const string Name_Func_GET_PIXEL = "GetPixel";
        /// <summary>
        ///   UnityEngine.Color GetPixel(System.Int32 x,System.Int32 y,System.Int32 mipLevel)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <returns>struct UnityEngine.Color</returns>
        /// public  extern UnityEngine.Color GET_PIXEL_01 (System.Int32 x,System.Int32 y,System.Int32 mipLevel);


        /// const string Name_Func_GET_PIXEL_BILINEAR = "GetPixelBilinear";
        /// <summary>
        ///   UnityEngine.Color GetPixelBilinear(System.Single u,System.Single v)
        /// </summary>
        /// <param name="u">struct System.Single</param>
        /// <param name="v">struct System.Single</param>
        /// <returns>struct UnityEngine.Color</returns>
        /// public  extern UnityEngine.Color GET_PIXEL_BILINEAR_00 (System.Single u,System.Single v);


        /// const string Name_Func_GET_PIXEL_BILINEAR = "GetPixelBilinear";
        /// <summary>
        ///   UnityEngine.Color GetPixelBilinear(System.Single u,System.Single v,System.Int32 mipLevel)
        /// </summary>
        /// <param name="u">struct System.Single</param>
        /// <param name="v">struct System.Single</param>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <returns>struct UnityEngine.Color</returns>
        /// public  extern UnityEngine.Color GET_PIXEL_BILINEAR_01 (System.Single u,System.Single v,System.Int32 mipLevel);


        /// const string Name_Func_GET_PIXELS = "GetPixels";
        /// <summary>
        ///   UnityEngine.Color[] GetPixels(System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,System.Int32 miplevel)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="blockWidth">struct System.Int32</param>
        /// <param name="blockHeight">struct System.Int32</param>
        /// <param name="miplevel">struct System.Int32</param>
        /// <returns>class UnityEngine.Color[]</returns>
        /// public  extern nint GET_PIXELS_00 (System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,System.Int32 miplevel);


        /// const string Name_Func_GET_PIXELS = "GetPixels";
        /// <summary>
        ///   UnityEngine.Color[] GetPixels(System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="blockWidth">struct System.Int32</param>
        /// <param name="blockHeight">struct System.Int32</param>
        /// <returns>class UnityEngine.Color[]</returns>
        /// public  extern nint GET_PIXELS_01 (System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight);


        /// const string Name_Func_GET_PIXELS = "GetPixels";
        /// <summary>
        ///   UnityEngine.Color[] GetPixels(System.Int32 miplevel)
        /// </summary>
        /// <param name="miplevel">struct System.Int32</param>
        /// <returns>class UnityEngine.Color[]</returns>
        /// public  extern nint GET_PIXELS_02 (System.Int32 miplevel);


        /// const string Name_Func_GET_PIXELS = "GetPixels";
        /// <summary>
        ///   UnityEngine.Color[] GetPixels()
        /// </summary>
        /// <returns>class UnityEngine.Color[]</returns>
        /// public  extern nint GET_PIXELS_03 ();


        /// const string Name_Func_GET_PIXELS32 = "GetPixels32";
        /// <summary>
        ///   UnityEngine.Color32[] GetPixels32(System.Int32 miplevel)
        /// </summary>
        /// <param name="miplevel">struct System.Int32</param>
        /// <returns>class UnityEngine.Color32[]</returns>
        /// public  extern nint GET_PIXELS32_00 (System.Int32 miplevel);


        /// const string Name_Func_GET_PIXELS32 = "GetPixels32";
        /// <summary>
        ///   UnityEngine.Color32[] GetPixels32()
        /// </summary>
        /// <returns>class UnityEngine.Color32[]</returns>
        /// public  extern nint GET_PIXELS32_01 ();


        ///const string Name_Func_GET_RAW_TEXTURE_DATA = "GetRawTextureData";
        /// <summary>
        ///   System.Byte[] GetRawTextureData()
        /// </summary>
        /// <returns>class System.Byte[]</returns>
        /// 
        ///extern PMonoArray<byte> GET_RAW_TEXTURE_DATA_00();


        /// const string Name_Func_GET_RAW_TEXTURE_DATA = "GetRawTextureData";
        /// <summary>
        ///   Unity.Collections.NativeArray<T> GetRawTextureData()
        /// </summary>
        /// <returns>struct Unity.Collections.NativeArray<T></returns>
        /// public  extern Unity.Collections.NativeArray<T> GET_RAW_TEXTURE_DATA_01 ();


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


        /// const string Name_Func_LOAD_RAW_TEXTURE_DATA = "LoadRawTextureData";
        /// <summary>
        ///   System.Void LoadRawTextureData(System.IntPtr data,System.Int32 size)
        /// </summary>
        /// <param name="data">struct System.IntPtr</param>
        /// <param name="size">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void LOAD_RAW_TEXTURE_DATA_00 (System.IntPtr data,System.Int32 size);


        ///const string Name_Func_LOAD_RAW_TEXTURE_DATA = "LoadRawTextureData";
        /// <summary>
        ///   System.Void LoadRawTextureData(System.Byte[] data)
        /// </summary>
        /// <param name="data">class System.Byte[]</param>
        /// <returns>struct System.Void</returns>
        ///extern void LOAD_RAW_TEXTURE_DATA_01(nint data);


        /// const string Name_Func_LOAD_RAW_TEXTURE_DATA = "LoadRawTextureData";
        /// <summary>
        ///   System.Void LoadRawTextureData(Unity.Collections.NativeArray<T> data)
        /// </summary>
        /// <param name="data">struct Unity.Collections.NativeArray<T></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void LOAD_RAW_TEXTURE_DATA_02 (Unity.Collections.NativeArray<T> data);


        /// const string Name_Func_PACK_TEXTURES = "PackTextures";
        /// <summary>
        ///   UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures,System.Int32 padding,System.Int32 maximumAtlasSize,System.Boolean makeNoLongerReadable)
        /// </summary>
        /// <param name="textures">class UnityEngine.Texture2D[]</param>
        /// <param name="padding">struct System.Int32</param>
        /// <param name="maximumAtlasSize">struct System.Int32</param>
        /// <param name="makeNoLongerReadable">struct System.Boolean</param>
        /// <returns>class UnityEngine.Rect[]</returns>
        /// public  extern nint PACK_TEXTURES_00 (nint textures,System.Int32 padding,System.Int32 maximumAtlasSize,System.Boolean makeNoLongerReadable);


        /// const string Name_Func_PACK_TEXTURES = "PackTextures";
        /// <summary>
        ///   UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures,System.Int32 padding,System.Int32 maximumAtlasSize)
        /// </summary>
        /// <param name="textures">class UnityEngine.Texture2D[]</param>
        /// <param name="padding">struct System.Int32</param>
        /// <param name="maximumAtlasSize">struct System.Int32</param>
        /// <returns>class UnityEngine.Rect[]</returns>
        /// public  extern nint PACK_TEXTURES_01 (nint textures,System.Int32 padding,System.Int32 maximumAtlasSize);


        /// const string Name_Func_PACK_TEXTURES = "PackTextures";
        /// <summary>
        ///   UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures,System.Int32 padding)
        /// </summary>
        /// <param name="textures">class UnityEngine.Texture2D[]</param>
        /// <param name="padding">struct System.Int32</param>
        /// <returns>class UnityEngine.Rect[]</returns>
        /// public  extern nint PACK_TEXTURES_02 (nint textures,System.Int32 padding);


        /// const string Name_Func_READ_PIXELS = "ReadPixels";
        /// <summary>
        ///   System.Void ReadPixels(UnityEngine.Rect source,System.Int32 destX,System.Int32 destY,System.Boolean recalculateMipMaps)
        /// </summary>
        /// <param name="source">struct UnityEngine.Rect</param>
        /// <param name="destX">struct System.Int32</param>
        /// <param name="destY">struct System.Int32</param>
        /// <param name="recalculateMipMaps">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void READ_PIXELS_00 (UnityEngine.Rect source,System.Int32 destX,System.Int32 destY,System.Boolean recalculateMipMaps);


        ///const string Name_Func_READ_PIXELS = "ReadPixels";
        /// <summary>
        ///   System.Void ReadPixels(UnityEngine.Rect source,System.Int32 destX,System.Int32 destY)
        /// </summary>
        /// <param name="source">struct UnityEngine.Rect</param>
        /// <param name="destX">struct System.Int32</param>
        /// <param name="destY">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        ///[MonoCollectorMethod(Name_Func_READ_PIXELS, Search = typeof(Search_Texture2D), CallConvs = [typeof(CallConvCdecl)])]
        ///extern void READ_PIXELS_01(UnityEngine.Rect.Ref_Rect source, System.Int32 destX, System.Int32 destY);


        /// const string Name_Func_RESIZE = "Resize";
        /// <summary>
        ///   System.Boolean Resize(System.Int32 width,System.Int32 height)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean RESIZE_00 (System.Int32 width,System.Int32 height);


        /// const string Name_Func_RESIZE = "Resize";
        /// <summary>
        ///   System.Boolean Resize(System.Int32 width,System.Int32 height,UnityEngine.TextureFormat format,System.Boolean hasMipMap)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.TextureFormat</param>
        /// <param name="hasMipMap">struct System.Boolean</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean RESIZE_01 (System.Int32 width,System.Int32 height,UnityEngine.TextureFormat format,System.Boolean hasMipMap);


        /// const string Name_Func_RESIZE = "Resize";
        /// <summary>
        ///   System.Boolean Resize(System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Boolean hasMipMap)
        /// </summary>
        /// <param name="width">struct System.Int32</param>
        /// <param name="height">struct System.Int32</param>
        /// <param name="format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
        /// <param name="hasMipMap">struct System.Boolean</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean RESIZE_02 (System.Int32 width,System.Int32 height,UnityEngine.Experimental.Rendering.GraphicsFormat format,System.Boolean hasMipMap);


        /// const string Name_Func_SET_PIXEL = "SetPixel";
        /// <summary>
        ///   System.Void SetPixel(System.Int32 x,System.Int32 y,UnityEngine.Color color)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="color">struct UnityEngine.Color</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXEL_00 (System.Int32 x,System.Int32 y,UnityEngine.Color color);


        /// const string Name_Func_SET_PIXEL = "SetPixel";
        /// <summary>
        ///   System.Void SetPixel(System.Int32 x,System.Int32 y,UnityEngine.Color color,System.Int32 mipLevel)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="color">struct UnityEngine.Color</param>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXEL_01 (System.Int32 x,System.Int32 y,UnityEngine.Color color,System.Int32 mipLevel);


        /// const string Name_Func_SET_PIXEL_DATA = "SetPixelData";
        /// <summary>
        ///   System.Void SetPixelData(T[] data,System.Int32 mipLevel,System.Int32 sourceDataStartIndex)
        /// </summary>
        /// <param name="data">class T[]</param>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <param name="sourceDataStartIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXEL_DATA_00 (nint data,System.Int32 mipLevel,System.Int32 sourceDataStartIndex);


        /// const string Name_Func_SET_PIXEL_DATA = "SetPixelData";
        /// <summary>
        ///   System.Void SetPixelData(Unity.Collections.NativeArray<T> data,System.Int32 mipLevel,System.Int32 sourceDataStartIndex)
        /// </summary>
        /// <param name="data">struct Unity.Collections.NativeArray<T></param>
        /// <param name="mipLevel">struct System.Int32</param>
        /// <param name="sourceDataStartIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXEL_DATA_01 (Unity.Collections.NativeArray<T> data,System.Int32 mipLevel,System.Int32 sourceDataStartIndex);


        /// const string Name_Func_SET_PIXELS = "SetPixels";
        /// <summary>
        ///   System.Void SetPixels(System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,UnityEngine.Color[] colors,System.Int32 miplevel)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="blockWidth">struct System.Int32</param>
        /// <param name="blockHeight">struct System.Int32</param>
        /// <param name="colors">class UnityEngine.Color[]</param>
        /// <param name="miplevel">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXELS_00 (System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,nint colors,System.Int32 miplevel);


        /// const string Name_Func_SET_PIXELS = "SetPixels";
        /// <summary>
        ///   System.Void SetPixels(System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,UnityEngine.Color[] colors)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="blockWidth">struct System.Int32</param>
        /// <param name="blockHeight">struct System.Int32</param>
        /// <param name="colors">class UnityEngine.Color[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXELS_01 (System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,nint colors);


        /// const string Name_Func_SET_PIXELS = "SetPixels";
        /// <summary>
        ///   System.Void SetPixels(UnityEngine.Color[] colors,System.Int32 miplevel)
        /// </summary>
        /// <param name="colors">class UnityEngine.Color[]</param>
        /// <param name="miplevel">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXELS_02 (nint colors,System.Int32 miplevel);


        /// const string Name_Func_SET_PIXELS = "SetPixels";
        /// <summary>
        ///   System.Void SetPixels(UnityEngine.Color[] colors)
        /// </summary>
        /// <param name="colors">class UnityEngine.Color[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXELS_03 (nint colors);


        /// const string Name_Func_SET_PIXELS32 = "SetPixels32";
        /// <summary>
        ///   System.Void SetPixels32(UnityEngine.Color32[] colors,System.Int32 miplevel)
        /// </summary>
        /// <param name="colors">class UnityEngine.Color32[]</param>
        /// <param name="miplevel">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXELS32_00 (nint colors,System.Int32 miplevel);


        /// const string Name_Func_SET_PIXELS32 = "SetPixels32";
        /// <summary>
        ///   System.Void SetPixels32(UnityEngine.Color32[] colors)
        /// </summary>
        /// <param name="colors">class UnityEngine.Color32[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXELS32_01 (nint colors);


        /// const string Name_Func_SET_PIXELS32 = "SetPixels32";
        /// <summary>
        ///   System.Void SetPixels32(System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,UnityEngine.Color32[] colors,System.Int32 miplevel)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="blockWidth">struct System.Int32</param>
        /// <param name="blockHeight">struct System.Int32</param>
        /// <param name="colors">class UnityEngine.Color32[]</param>
        /// <param name="miplevel">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXELS32_02 (System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,nint colors,System.Int32 miplevel);


        /// const string Name_Func_SET_PIXELS32 = "SetPixels32";
        /// <summary>
        ///   System.Void SetPixels32(System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,UnityEngine.Color32[] colors)
        /// </summary>
        /// <param name="x">struct System.Int32</param>
        /// <param name="y">struct System.Int32</param>
        /// <param name="blockWidth">struct System.Int32</param>
        /// <param name="blockHeight">struct System.Int32</param>
        /// <param name="colors">class UnityEngine.Color32[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_PIXELS32_03 (System.Int32 x,System.Int32 y,System.Int32 blockWidth,System.Int32 blockHeight,nint colors);


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


        public static partial class Search_Texture2D
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
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount, System.IntPtr nativeTex)
            /// </summary>
            /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.GraphicsFormat", "UnityEngine.Experimental.Rendering.TextureCreationFlags", "System.Int32", "System.IntPtr");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
            /// </summary>
            /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.DefaultFormat", "UnityEngine.Experimental.Rendering.TextureCreationFlags");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
            /// </summary>
            /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.GraphicsFormat", "UnityEngine.Experimental.Rendering.TextureCreationFlags");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
            /// </summary>
            /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.GraphicsFormat", "System.Int32", "UnityEngine.Experimental.Rendering.TextureCreationFlags");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear, System.IntPtr nativeTex)
            /// </summary>
            /// public static bool .CTOR_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "UnityEngine.TextureFormat", "System.Int32", "System.Boolean", "System.IntPtr");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear)
            /// </summary>
            /// public static bool .CTOR_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "UnityEngine.TextureFormat", "System.Int32", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.Boolean linear)
            /// </summary>
            /// public static bool .CTOR_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "UnityEngine.TextureFormat", "System.Boolean", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain)
            /// </summary>
            ///public static bool CTOR_07(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///    => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "UnityEngine.TextureFormat", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height)
            /// </summary>
            public static bool CTOR_08(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
               => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_09 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
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
            ///   System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
            /// </summary>
            /// public static bool APPLY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Apply", "System.Boolean", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Apply(System.Boolean updateMipmaps)
            /// </summary>
            /// public static bool APPLY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Apply", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Apply()
            /// </summary>
            public static bool APPLY_02(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Apply");
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
            ///   System.Boolean get_isReadable()
            /// </summary>
            /// public static bool GET_IS_READABLE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_isReadable");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean get_isReadable()
            /// </summary>
            /// public static bool GET_IS_READABLE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_isReadable");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Color GetPixel(System.Int32 x, System.Int32 y)
            /// </summary>
            /// public static bool GET_PIXEL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPixel", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Color GetPixel(System.Int32 x, System.Int32 y, System.Int32 mipLevel)
            /// </summary>
            /// public static bool GET_PIXEL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPixel", "System.Int32", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Color GetPixelBilinear(System.Single u, System.Single v)
            /// </summary>
            /// public static bool GET_PIXEL_BILINEAR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPixelBilinear", "System.Single", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Color GetPixelBilinear(System.Single u, System.Single v, System.Int32 mipLevel)
            /// </summary>
            /// public static bool GET_PIXEL_BILINEAR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPixelBilinear", "System.Single", "System.Single", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Color[] GetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, System.Int32 miplevel)
            /// </summary>
            /// public static bool GET_PIXELS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPixels", "System.Int32", "System.Int32", "System.Int32", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Color[] GetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight)
            /// </summary>
            /// public static bool GET_PIXELS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPixels", "System.Int32", "System.Int32", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Color[] GetPixels(System.Int32 miplevel)
            /// </summary>
            /// public static bool GET_PIXELS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPixels", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Color[] GetPixels()
            /// </summary>
            /// public static bool GET_PIXELS_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPixels");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Color32[] GetPixels32(System.Int32 miplevel)
            /// </summary>
            /// public static bool GET_PIXELS32_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPixels32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Color32[] GetPixels32()
            /// </summary>
            /// public static bool GET_PIXELS32_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPixels32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Byte[] GetRawTextureData()
            /// </summary>
            public static bool GET_RAW_TEXTURE_DATA_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfoEx(monoMethodInfoDTO, "GetRawTextureData", "System.Byte[]");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Unity.Collections.NativeArray<T> GetRawTextureData()
            /// </summary>
            /// public static bool GET_RAW_TEXTURE_DATA_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetRawTextureData");
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
            ///   System.Void LoadRawTextureData(System.IntPtr data, System.Int32 size)
            /// </summary>
            /// public static bool LOAD_RAW_TEXTURE_DATA_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LoadRawTextureData", "System.IntPtr", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void LoadRawTextureData(System.Byte[] data)
            /// </summary>
            public static bool LOAD_RAW_TEXTURE_DATA_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LoadRawTextureData", "System.Byte[]");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void LoadRawTextureData(Unity.Collections.NativeArray<T> data)
            /// </summary>
            /// public static bool LOAD_RAW_TEXTURE_DATA_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LoadRawTextureData", "Unity.Collections.NativeArray<T>");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding, System.Int32 maximumAtlasSize, System.Boolean makeNoLongerReadable)
            /// </summary>
            /// public static bool PACK_TEXTURES_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "PackTextures", "UnityEngine.Texture2D[]", "System.Int32", "System.Int32", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding, System.Int32 maximumAtlasSize)
            /// </summary>
            /// public static bool PACK_TEXTURES_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "PackTextures", "UnityEngine.Texture2D[]", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding)
            /// </summary>
            /// public static bool PACK_TEXTURES_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "PackTextures", "UnityEngine.Texture2D[]", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void ReadPixels(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps)
            /// </summary>
            /// public static bool READ_PIXELS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReadPixels", "UnityEngine.Rect", "System.Int32", "System.Int32", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void ReadPixels(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY)
            /// </summary>
            public static bool READ_PIXELS_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReadPixels", "UnityEngine.Rect", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean Resize(System.Int32 width, System.Int32 height)
            /// </summary>
            /// public static bool RESIZE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Resize", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean Resize(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean hasMipMap)
            /// </summary>
            /// public static bool RESIZE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Resize", "System.Int32", "System.Int32", "UnityEngine.TextureFormat", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean Resize(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap)
            /// </summary>
            /// public static bool RESIZE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Resize", "System.Int32", "System.Int32", "UnityEngine.Experimental.Rendering.GraphicsFormat", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixel(System.Int32 x, System.Int32 y, UnityEngine.Color color)
            /// </summary>
            /// public static bool SET_PIXEL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixel", "System.Int32", "System.Int32", "UnityEngine.Color");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixel(System.Int32 x, System.Int32 y, UnityEngine.Color color, System.Int32 mipLevel)
            /// </summary>
            /// public static bool SET_PIXEL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixel", "System.Int32", "System.Int32", "UnityEngine.Color", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixelData(T[] data, System.Int32 mipLevel, System.Int32 sourceDataStartIndex)
            /// </summary>
            /// public static bool SET_PIXEL_DATA_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixelData", "T[]", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixelData(Unity.Collections.NativeArray<T> data, System.Int32 mipLevel, System.Int32 sourceDataStartIndex)
            /// </summary>
            /// public static bool SET_PIXEL_DATA_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixelData", "Unity.Collections.NativeArray<T>", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color[] colors, System.Int32 miplevel)
            /// </summary>
            /// public static bool SET_PIXELS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixels", "System.Int32", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Color[]", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color[] colors)
            /// </summary>
            /// public static bool SET_PIXELS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixels", "System.Int32", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Color[]");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixels(UnityEngine.Color[] colors, System.Int32 miplevel)
            /// </summary>
            /// public static bool SET_PIXELS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixels", "UnityEngine.Color[]", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixels(UnityEngine.Color[] colors)
            /// </summary>
            /// public static bool SET_PIXELS_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixels", "UnityEngine.Color[]");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixels32(UnityEngine.Color32[] colors, System.Int32 miplevel)
            /// </summary>
            /// public static bool SET_PIXELS32_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixels32", "UnityEngine.Color32[]", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixels32(UnityEngine.Color32[] colors)
            /// </summary>
            /// public static bool SET_PIXELS32_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixels32", "UnityEngine.Color32[]");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixels32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color32[] colors, System.Int32 miplevel)
            /// </summary>
            /// public static bool SET_PIXELS32_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixels32", "System.Int32", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Color32[]", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetPixels32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color32[] colors)
            /// </summary>
            /// public static bool SET_PIXELS32_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetPixels32", "System.Int32", "System.Int32", "System.Int32", "System.Int32", "UnityEngine.Color32[]");
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

    partial class Texture2D(Maple.MonoGameAssistant.Core.MonoCollectorContext collectorContext, Maple.MonoGameAssistant.MonoCollector.MonoCollectorClassInfo classInfo) : Maple.MonoGameAssistant.Core.MonoCollectorMember(collectorContext, classInfo)
    {

        public Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D New(bool execDefCtor)
            => New<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D>(execDefCtor);

        public Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D Ctor()
            => Ctor<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D>();

        public Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D IsFrom(Maple.MonoGameAssistant.Core.PMonoObject pMonoObject)
            => IsFrom<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D>(pMonoObject);

        public Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D IsFrom(nint pObj)
            => IsFrom<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D>(pObj);




        readonly unsafe partial struct Ptr_Func_GET_HEIGHT(nint ptr)
        {
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, int>)ptr;

            public static implicit operator Ptr_Func_GET_HEIGHT(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public int Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D __this__) => _func(__this__);
        }

        static Ptr_Func_GET_HEIGHT Func_GET_HEIGHT;

        readonly unsafe partial struct Ptr_Texture2D
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public int GET_HEIGHT() => Func_GET_HEIGHT.Invoke(this);
        }

        readonly unsafe partial struct Ptr_Func_GET_WIDTH(nint ptr)
        {
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, int>)ptr;

            public static implicit operator Ptr_Func_GET_WIDTH(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public int Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D __this__) => _func(__this__);
        }

        static Ptr_Func_GET_WIDTH Func_GET_WIDTH;

        readonly unsafe partial struct Ptr_Texture2D
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public int GET_WIDTH() => Func_GET_WIDTH.Invoke(this);
        }

        readonly unsafe partial struct Ptr_Func_READ_PIXELS_IMPL_INJECTED(nint ptr)
        {
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, in Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, int, int, bool, void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, in Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect, int, int, bool, void>)ptr;

            public static implicit operator Ptr_Func_READ_PIXELS_IMPL_INJECTED(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D __this__, in Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect source, int destX, int destY, bool recalculateMipMaps) => _func(__this__, in source, destX, destY, recalculateMipMaps);
        }

        static Ptr_Func_READ_PIXELS_IMPL_INJECTED Func_READ_PIXELS_IMPL_INJECTED;

        readonly unsafe partial struct Ptr_Texture2D
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void READ_PIXELS_IMPL_INJECTED(in Maple.MonoGameAssistant.UnityCore.UnityEngine.Rect.Ref_Rect source, int destX, int destY, bool recalculateMipMaps) => Func_READ_PIXELS_IMPL_INJECTED.Invoke(this, in source, destX, destY, recalculateMipMaps);
        }

        readonly unsafe partial struct Ptr_Func_CTOR_08(nint ptr)
        {
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, int, int, void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, int, int, void>)ptr;

            public static implicit operator Ptr_Func_CTOR_08(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D __this__, int width, int height) => _func(__this__, width, height);
        }

        static Ptr_Func_CTOR_08 Func_CTOR_08;

        readonly unsafe partial struct Ptr_Texture2D
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void CTOR_08(int width, int height) => Func_CTOR_08.Invoke(this, width, height);
        }

        readonly unsafe partial struct Ptr_Func_APPLY_02(nint ptr)
        {
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, void>)ptr;

            public static implicit operator Ptr_Func_APPLY_02(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D __this__) => _func(__this__);
        }

        static Ptr_Func_APPLY_02 Func_APPLY_02;

        readonly unsafe partial struct Ptr_Texture2D
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void APPLY_02() => Func_APPLY_02.Invoke(this);
        }




        //protected sealed override void InitMember()
        //{

        //    Func_GET_HEIGHT = GetMethodPointer("get_height");

        //    Func_GET_WIDTH = GetMethodPointer("get_width");

        //    Func_READ_PIXELS_IMPL_INJECTED = GetMethodPointer("ReadPixelsImpl_Injected");

        //    Func_CTOR_08 = GetMethodPointer(".ctor", Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Search_Texture2D.CTOR_08);

        //    Func_APPLY_02 = GetMethodPointer("Apply", Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Search_Texture2D.APPLY_02);


        //}


    }


    partial class Texture2D
    {
        public static void Set_Func_GET_HEIGHT(nint addr) => Func_GET_HEIGHT = addr;
        public static void Set_Func_GET_WIDTH(nint addr) => Func_GET_WIDTH = addr;
        public static void Set_Func_READ_PIXELS_IMPL_INJECTED(nint addr) => Func_READ_PIXELS_IMPL_INJECTED = addr;
        public static void Set_Func_CTOR_08(nint addr) => Func_CTOR_08 = addr;
        public static void Set_Func_APPLY_02(nint addr) => Func_APPLY_02 = addr;

    }
}
