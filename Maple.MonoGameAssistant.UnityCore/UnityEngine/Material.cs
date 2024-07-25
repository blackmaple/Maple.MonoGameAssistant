using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.UnityCore.UnityEngine
{

    /// <summary>
    /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Material"]
    /// [UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], 0x020000AEU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101], [77, 97, 116, 101, 114, 105, 97, 108])]
    public partial class Material
    {
        //public const string Const_ImageName = "UnityEngine.CoreModule.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108];

        //public const string Const_Namespace = "UnityEngine";
        //public static byte[] Static_Namespace { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101];

        //public const string Const_ClassName = "Material";
        //public static byte[] Static_ClassName { get; } = [77, 97, 116, 101, 114, 105, 97, 108];

        //public const uint Const_TypeToken = 0x020000AEU;




        //public readonly unsafe partial struct Const_Material
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


        //[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        //public readonly unsafe partial struct Static_Material
        //{



        //    /// const string Name_Field_OffsetOfInstanceIDInCPlusPlusObject = "OffsetOfInstanceIDInCPlusPlusObject";
        //    /// <summary>
        //    /// struct 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
        //    /// </summary>
        //    [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        //    public readonly System.Int32 OffsetOfInstanceIDInCPlusPlusObject;

        //}


        //[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        //public readonly unsafe partial struct Ref_Material
        //{


        //    /// <summary>
        //    /// REF_MONO_OBJECT._vtable
        //    /// </summary>
        //    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        //    [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        //    public readonly nint _vtable;

        //    /// <summary>
        //    /// REF_MONO_OBJECT._synchronisation
        //    /// </summary>
        //    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        //    [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
        //    public readonly nint _synchronisation;



        //    /// const string Name_Field_m_CachedPtr = "m_CachedPtr";
        //    /// <summary>
        //    /// struct 0x10 System.IntPtr m_CachedPtr
        //    /// </summary>
        //    [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
        //    public readonly System.IntPtr m_CachedPtr;

        //}

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Material(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Material(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Material obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            //[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            //public ref Ref_Material AsRef()
            //{
            //    return ref Unsafe.AsRef<Ref_Material>(_ptr.ToPointer());
            //}
        }

    }

    /// <summary>
    /// ["UnityEngine.CoreModule.dll"."UnityEngine"."Material"]
    /// </summary>
    public partial class Material
    {



        /// const string Name_Func_.CCTOR = ".cctor";
        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void .CCTOR ();


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


        /// const string Name_Func_COMPUTE_CRC = "ComputeCRC";
        /// <summary>
        ///   System.Int32 ComputeCRC()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 COMPUTE_CRC ();


        /// const string Name_Func_COPY_MATCHING_PROPERTIES_FROM_MATERIAL = "CopyMatchingPropertiesFromMaterial";
        /// <summary>
        ///   System.Void CopyMatchingPropertiesFromMaterial(UnityEngine.Material mat)
        /// </summary>
        /// <param name="mat">class UnityEngine.Material</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void COPY_MATCHING_PROPERTIES_FROM_MATERIAL (nint mat);


        /// const string Name_Func_COPY_PROPERTIES_FROM_MATERIAL = "CopyPropertiesFromMaterial";
        /// <summary>
        ///   System.Void CopyPropertiesFromMaterial(UnityEngine.Material mat)
        /// </summary>
        /// <param name="mat">class UnityEngine.Material</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void COPY_PROPERTIES_FROM_MATERIAL (nint mat);


        /// const string Name_Func_CREATE = "Create";
        /// <summary>
        /// static  UnityEngine.Material Create(System.String scriptContents)
        /// </summary>
        /// <param name="scriptContents">class System.String</param>
        /// <returns>class UnityEngine.Material</returns>
        /// public static extern nint CREATE (nint scriptContents);


        /// const string Name_Func_CREATE_WITH_MATERIAL = "CreateWithMaterial";
        /// <summary>
        /// static  System.Void CreateWithMaterial(UnityEngine.Material self,UnityEngine.Material source)
        /// </summary>
        /// <param name="self">class UnityEngine.Material</param>
        /// <param name="source">class UnityEngine.Material</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void CREATE_WITH_MATERIAL (nint self,nint source);


        /// const string Name_Func_CREATE_WITH_SHADER = "CreateWithShader";
        /// <summary>
        /// static  System.Void CreateWithShader(UnityEngine.Material self,UnityEngine.Shader shader)
        /// </summary>
        /// <param name="self">class UnityEngine.Material</param>
        /// <param name="shader">class UnityEngine.Shader</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void CREATE_WITH_SHADER (nint self,nint shader);


        /// const string Name_Func_CREATE_WITH_STRING = "CreateWithString";
        /// <summary>
        /// static  System.Void CreateWithString(UnityEngine.Material self)
        /// </summary>
        /// <param name="self">class UnityEngine.Material</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void CREATE_WITH_STRING (nint self);


        /// const string Name_Func_CURRENT_THREAD_IS_MAIN_THREAD = "CurrentThreadIsMainThread";
        /// <summary>
        /// static  System.Boolean CurrentThreadIsMainThread()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean CURRENT_THREAD_IS_MAIN_THREAD ();


        /// const string Name_Func_DISABLE_LOCAL_KEYWORD = "DisableLocalKeyword";
        /// <summary>
        ///   System.Void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void DISABLE_LOCAL_KEYWORD (UnityEngine.Rendering.LocalKeyword keyword);


        /// const string Name_Func_DISABLE_LOCAL_KEYWORD_INJECTED = "DisableLocalKeyword_Injected";
        /// <summary>
        ///   System.Void DisableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword& keyword)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void DISABLE_LOCAL_KEYWORD_INJECTED (UnityEngine.Rendering.LocalKeyword& keyword);


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


        /// const string Name_Func_ENABLE_LOCAL_KEYWORD = "EnableLocalKeyword";
        /// <summary>
        ///   System.Void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ENABLE_LOCAL_KEYWORD (UnityEngine.Rendering.LocalKeyword keyword);


        /// const string Name_Func_ENABLE_LOCAL_KEYWORD_INJECTED = "EnableLocalKeyword_Injected";
        /// <summary>
        ///   System.Void EnableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword& keyword)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ENABLE_LOCAL_KEYWORD_INJECTED (UnityEngine.Rendering.LocalKeyword& keyword);


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


        /// const string Name_Func_EXTRACT_COLOR_ARRAY = "ExtractColorArray";
        /// <summary>
        ///   System.Void ExtractColorArray(System.Int32 name,System.Collections.Generic.List<UnityEngine.Color> values)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Color></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXTRACT_COLOR_ARRAY (System.Int32 name,nint values);


        /// const string Name_Func_EXTRACT_COLOR_ARRAY_IMPL = "ExtractColorArrayImpl";
        /// <summary>
        ///   System.Void ExtractColorArrayImpl(System.Int32 name,UnityEngine.Color[] val)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="val">class UnityEngine.Color[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXTRACT_COLOR_ARRAY_IMPL (System.Int32 name,nint val);


        /// const string Name_Func_EXTRACT_FLOAT_ARRAY = "ExtractFloatArray";
        /// <summary>
        ///   System.Void ExtractFloatArray(System.Int32 name,System.Collections.Generic.List<System.Single> values)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<System.Single></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXTRACT_FLOAT_ARRAY (System.Int32 name,nint values);


        /// const string Name_Func_EXTRACT_FLOAT_ARRAY_IMPL = "ExtractFloatArrayImpl";
        /// <summary>
        ///   System.Void ExtractFloatArrayImpl(System.Int32 name,System.Single[] val)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="val">class System.Single[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXTRACT_FLOAT_ARRAY_IMPL (System.Int32 name,nint val);


        /// const string Name_Func_EXTRACT_MATRIX_ARRAY = "ExtractMatrixArray";
        /// <summary>
        ///   System.Void ExtractMatrixArray(System.Int32 name,System.Collections.Generic.List<UnityEngine.Matrix4x4> values)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXTRACT_MATRIX_ARRAY (System.Int32 name,nint values);


        /// const string Name_Func_EXTRACT_MATRIX_ARRAY_IMPL = "ExtractMatrixArrayImpl";
        /// <summary>
        ///   System.Void ExtractMatrixArrayImpl(System.Int32 name,UnityEngine.Matrix4x4[] val)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="val">class UnityEngine.Matrix4x4[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXTRACT_MATRIX_ARRAY_IMPL (System.Int32 name,nint val);


        /// const string Name_Func_EXTRACT_VECTOR_ARRAY = "ExtractVectorArray";
        /// <summary>
        ///   System.Void ExtractVectorArray(System.Int32 name,System.Collections.Generic.List<UnityEngine.Vector4> values)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Vector4></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXTRACT_VECTOR_ARRAY (System.Int32 name,nint values);


        /// const string Name_Func_EXTRACT_VECTOR_ARRAY_IMPL = "ExtractVectorArrayImpl";
        /// <summary>
        ///   System.Void ExtractVectorArrayImpl(System.Int32 name,UnityEngine.Vector4[] val)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="val">class UnityEngine.Vector4[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXTRACT_VECTOR_ARRAY_IMPL (System.Int32 name,nint val);


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


        /// const string Name_Func_FIND_PASS = "FindPass";
        /// <summary>
        ///   System.Int32 FindPass(System.String passName)
        /// </summary>
        /// <param name="passName">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 FIND_PASS (nint passName);


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


        /// const string Name_Func_GET_COLOR = "get_color";
        /// <summary>
        ///   UnityEngine.Color get_color()
        /// </summary>
        /// <returns>struct UnityEngine.Color</returns>
        /// public  extern UnityEngine.Color GET_COLOR ();


        /// const string Name_Func_GET_DOUBLE_SIDED_GI = "get_doubleSidedGI";
        /// <summary>
        ///   System.Boolean get_doubleSidedGI()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_DOUBLE_SIDED_GI ();


        /// const string Name_Func_GET_ENABLED_KEYWORDS = "get_enabledKeywords";
        /// <summary>
        ///   UnityEngine.Rendering.LocalKeyword[] get_enabledKeywords()
        /// </summary>
        /// <returns>class UnityEngine.Rendering.LocalKeyword[]</returns>
        /// public  extern nint GET_ENABLED_KEYWORDS ();


        /// const string Name_Func_GET_ENABLE_INSTANCING = "get_enableInstancing";
        /// <summary>
        ///   System.Boolean get_enableInstancing()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_ENABLE_INSTANCING ();


        /// const string Name_Func_GET_GLOBAL_ILLUMINATION_FLAGS = "get_globalIlluminationFlags";
        /// <summary>
        ///   UnityEngine.MaterialGlobalIlluminationFlags get_globalIlluminationFlags()
        /// </summary>
        /// <returns>enum UnityEngine.MaterialGlobalIlluminationFlags</returns>
        /// public  extern UnityEngine.MaterialGlobalIlluminationFlags GET_GLOBAL_ILLUMINATION_FLAGS ();


        /// const string Name_Func_GET_HIDE_FLAGS = "get_hideFlags";
        /// <summary>
        ///   UnityEngine.HideFlags get_hideFlags()
        /// </summary>
        /// <returns>enum UnityEngine.HideFlags</returns>
        /// public  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();


        /// const string Name_Func_GET_MAIN_TEXTURE = "get_mainTexture";
        /// <summary>
        ///   UnityEngine.Texture get_mainTexture()
        /// </summary>
        /// <returns>class UnityEngine.Texture</returns>
        /// public  extern nint GET_MAIN_TEXTURE ();


        /// const string Name_Func_GET_MAIN_TEXTURE_OFFSET = "get_mainTextureOffset";
        /// <summary>
        ///   UnityEngine.Vector2 get_mainTextureOffset()
        /// </summary>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// public  extern UnityEngine.Vector2 GET_MAIN_TEXTURE_OFFSET ();


        /// const string Name_Func_GET_MAIN_TEXTURE_SCALE = "get_mainTextureScale";
        /// <summary>
        ///   UnityEngine.Vector2 get_mainTextureScale()
        /// </summary>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// public  extern UnityEngine.Vector2 GET_MAIN_TEXTURE_SCALE ();


        /// const string Name_Func_GET_NAME = "get_name";
        /// <summary>
        ///   System.String get_name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_NAME ();


        /// const string Name_Func_GET_PASS_COUNT = "get_passCount";
        /// <summary>
        ///   System.Int32 get_passCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_PASS_COUNT ();


        /// const string Name_Func_GET_RAW_RENDER_QUEUE = "get_rawRenderQueue";
        /// <summary>
        ///   System.Int32 get_rawRenderQueue()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_RAW_RENDER_QUEUE ();


        /// const string Name_Func_GET_RENDER_QUEUE = "get_renderQueue";
        /// <summary>
        ///   System.Int32 get_renderQueue()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_RENDER_QUEUE ();


        /// const string Name_Func_GET_SHADER = "get_shader";
        /// <summary>
        ///   UnityEngine.Shader get_shader()
        /// </summary>
        /// <returns>class UnityEngine.Shader</returns>
        /// public  extern nint GET_SHADER ();


        /// const string Name_Func_GET_SHADER_KEYWORDS = "get_shaderKeywords";
        /// <summary>
        ///   System.String[] get_shaderKeywords()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// public  extern nint GET_SHADER_KEYWORDS ();


        /// const string Name_Func_GET_CACHED_PTR = "GetCachedPtr";
        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// public  extern System.IntPtr GET_CACHED_PTR ();


        /// const string Name_Func_GET_COLOR_ARRAY_COUNT_IMPL = "GetColorArrayCountImpl";
        /// <summary>
        ///   System.Int32 GetColorArrayCountImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_COLOR_ARRAY_COUNT_IMPL (System.Int32 name);


        /// const string Name_Func_GET_COLOR_ARRAY_IMPL = "GetColorArrayImpl";
        /// <summary>
        ///   UnityEngine.Color[] GetColorArrayImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>class UnityEngine.Color[]</returns>
        /// public  extern nint GET_COLOR_ARRAY_IMPL (System.Int32 name);


        /// const string Name_Func_GET_COLOR_IMPL = "GetColorImpl";
        /// <summary>
        ///   UnityEngine.Color GetColorImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct UnityEngine.Color</returns>
        /// public  extern UnityEngine.Color GET_COLOR_IMPL (System.Int32 name);


        /// const string Name_Func_GET_COLOR_IMPL_INJECTED = "GetColorImpl_Injected";
        /// <summary>
        ///   System.Void GetColorImpl_Injected(System.Int32 name,UnityEngine.Color& ret)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="ret">struct UnityEngine.Color&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_COLOR_IMPL_INJECTED (System.Int32 name,UnityEngine.Color& ret);


        /// const string Name_Func_GET_DEFAULT_LINE_MATERIAL = "GetDefaultLineMaterial";
        /// <summary>
        /// static  UnityEngine.Material GetDefaultLineMaterial()
        /// </summary>
        /// <returns>class UnityEngine.Material</returns>
        /// public static extern nint GET_DEFAULT_LINE_MATERIAL ();


         const string Name_Func_GET_DEFAULT_MATERIAL = "GetDefaultMaterial";
        /// <summary>
        /// static  UnityEngine.Material GetDefaultMaterial()
        /// </summary>
        /// <returns>class UnityEngine.Material</returns>
        [MonoCollectorMethod(Name_Func_GET_DEFAULT_MATERIAL)]
        static extern nint GET_DEFAULT_MATERIAL ();


        /// const string Name_Func_GET_DEFAULT_PARTICLE_MATERIAL = "GetDefaultParticleMaterial";
        /// <summary>
        /// static  UnityEngine.Material GetDefaultParticleMaterial()
        /// </summary>
        /// <returns>class UnityEngine.Material</returns>
        /// public static extern nint GET_DEFAULT_PARTICLE_MATERIAL ();


        /// const string Name_Func_GET_ENABLED_KEYWORDS = "GetEnabledKeywords";
        /// <summary>
        ///   UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords()
        /// </summary>
        /// <returns>class UnityEngine.Rendering.LocalKeyword[]</returns>
        /// public  extern nint GET_ENABLED_KEYWORDS ();


        /// const string Name_Func_GET_FIRST_PROPERTY_NAME_ID_BY_ATTRIBUTE = "GetFirstPropertyNameIdByAttribute";
        /// <summary>
        ///   System.Int32 GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag)
        /// </summary>
        /// <param name="attributeFlag">enum UnityEngine.Rendering.ShaderPropertyFlags</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_FIRST_PROPERTY_NAME_ID_BY_ATTRIBUTE (UnityEngine.Rendering.ShaderPropertyFlags attributeFlag);


        /// const string Name_Func_GET_FLOAT_ARRAY_COUNT_IMPL = "GetFloatArrayCountImpl";
        /// <summary>
        ///   System.Int32 GetFloatArrayCountImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_FLOAT_ARRAY_COUNT_IMPL (System.Int32 name);


        /// const string Name_Func_GET_FLOAT_ARRAY_IMPL = "GetFloatArrayImpl";
        /// <summary>
        ///   System.Single[] GetFloatArrayImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>class System.Single[]</returns>
        /// public  extern nint GET_FLOAT_ARRAY_IMPL (System.Int32 name);


        /// const string Name_Func_GET_FLOAT_IMPL = "GetFloatImpl";
        /// <summary>
        ///   System.Single GetFloatImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single GET_FLOAT_IMPL (System.Int32 name);


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


        /// const string Name_Func_GET_INT_IMPL = "GetIntImpl";
        /// <summary>
        ///   System.Int32 GetIntImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_INT_IMPL (System.Int32 name);


        /// const string Name_Func_GET_MATRIX_ARRAY_COUNT_IMPL = "GetMatrixArrayCountImpl";
        /// <summary>
        ///   System.Int32 GetMatrixArrayCountImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_MATRIX_ARRAY_COUNT_IMPL (System.Int32 name);


        /// const string Name_Func_GET_MATRIX_ARRAY_IMPL = "GetMatrixArrayImpl";
        /// <summary>
        ///   UnityEngine.Matrix4x4[] GetMatrixArrayImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>class UnityEngine.Matrix4x4[]</returns>
        /// public  extern nint GET_MATRIX_ARRAY_IMPL (System.Int32 name);


        /// const string Name_Func_GET_MATRIX_IMPL = "GetMatrixImpl";
        /// <summary>
        ///   UnityEngine.Matrix4x4 GetMatrixImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct UnityEngine.Matrix4x4</returns>
        /// public  extern UnityEngine.Matrix4x4 GET_MATRIX_IMPL (System.Int32 name);


        /// const string Name_Func_GET_MATRIX_IMPL_INJECTED = "GetMatrixImpl_Injected";
        /// <summary>
        ///   System.Void GetMatrixImpl_Injected(System.Int32 name,UnityEngine.Matrix4x4& ret)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="ret">struct UnityEngine.Matrix4x4&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_MATRIX_IMPL_INJECTED (System.Int32 name,UnityEngine.Matrix4x4& ret);


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


        /// const string Name_Func_GET_PASS_NAME = "GetPassName";
        /// <summary>
        ///   System.String GetPassName(System.Int32 pass)
        /// </summary>
        /// <param name="pass">struct System.Int32</param>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_PASS_NAME (System.Int32 pass);


        /// const string Name_Func_GET_SHADER_KEYWORDS = "GetShaderKeywords";
        /// <summary>
        ///   System.String[] GetShaderKeywords()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// public  extern nint GET_SHADER_KEYWORDS ();


        /// const string Name_Func_GET_SHADER_PASS_ENABLED = "GetShaderPassEnabled";
        /// <summary>
        ///   System.Boolean GetShaderPassEnabled(System.String passName)
        /// </summary>
        /// <param name="passName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_SHADER_PASS_ENABLED (nint passName);


        /// const string Name_Func_GET_TAG_IMPL = "GetTagImpl";
        /// <summary>
        ///   System.String GetTagImpl(System.String tag,System.Boolean currentSubShaderOnly,System.String defaultValue)
        /// </summary>
        /// <param name="tag">class System.String</param>
        /// <param name="currentSubShaderOnly">struct System.Boolean</param>
        /// <param name="defaultValue">class System.String</param>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_TAG_IMPL (nint tag,System.Boolean currentSubShaderOnly,nint defaultValue);


        /// const string Name_Func_GET_TEXTURE_IMPL = "GetTextureImpl";
        /// <summary>
        ///   UnityEngine.Texture GetTextureImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>class UnityEngine.Texture</returns>
        /// public  extern nint GET_TEXTURE_IMPL (System.Int32 name);


        /// const string Name_Func_GET_TEXTURE_PROPERTY_NAME_I_DS_INTERNAL = "GetTexturePropertyNameIDsInternal";
        /// <summary>
        ///   System.Void GetTexturePropertyNameIDsInternal(System.Object outNames)
        /// </summary>
        /// <param name="outNames">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_TEXTURE_PROPERTY_NAME_I_DS_INTERNAL (nint outNames);


        /// const string Name_Func_GET_TEXTURE_PROPERTY_NAMES_INTERNAL = "GetTexturePropertyNamesInternal";
        /// <summary>
        ///   System.Void GetTexturePropertyNamesInternal(System.Object outNames)
        /// </summary>
        /// <param name="outNames">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_TEXTURE_PROPERTY_NAMES_INTERNAL (nint outNames);


        /// const string Name_Func_GET_TEXTURE_SCALE_AND_OFFSET_IMPL = "GetTextureScaleAndOffsetImpl";
        /// <summary>
        ///   UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct UnityEngine.Vector4</returns>
        /// public  extern UnityEngine.Vector4 GET_TEXTURE_SCALE_AND_OFFSET_IMPL (System.Int32 name);


        /// const string Name_Func_GET_TEXTURE_SCALE_AND_OFFSET_IMPL_INJECTED = "GetTextureScaleAndOffsetImpl_Injected";
        /// <summary>
        ///   System.Void GetTextureScaleAndOffsetImpl_Injected(System.Int32 name,UnityEngine.Vector4& ret)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="ret">struct UnityEngine.Vector4&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_TEXTURE_SCALE_AND_OFFSET_IMPL_INJECTED (System.Int32 name,UnityEngine.Vector4& ret);


        /// const string Name_Func_GET_VECTOR_ARRAY_COUNT_IMPL = "GetVectorArrayCountImpl";
        /// <summary>
        ///   System.Int32 GetVectorArrayCountImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_VECTOR_ARRAY_COUNT_IMPL (System.Int32 name);


        /// const string Name_Func_GET_VECTOR_ARRAY_IMPL = "GetVectorArrayImpl";
        /// <summary>
        ///   UnityEngine.Vector4[] GetVectorArrayImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>class UnityEngine.Vector4[]</returns>
        /// public  extern nint GET_VECTOR_ARRAY_IMPL (System.Int32 name);


        /// const string Name_Func_HAS_BUFFER_IMPL = "HasBufferImpl";
        /// <summary>
        ///   System.Boolean HasBufferImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_BUFFER_IMPL (System.Int32 name);


        /// const string Name_Func_HAS_CONSTANT_BUFFER_IMPL = "HasConstantBufferImpl";
        /// <summary>
        ///   System.Boolean HasConstantBufferImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_CONSTANT_BUFFER_IMPL (System.Int32 name);


        /// const string Name_Func_HAS_FLOAT_IMPL = "HasFloatImpl";
        /// <summary>
        ///   System.Boolean HasFloatImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_FLOAT_IMPL (System.Int32 name);


        /// const string Name_Func_HAS_INT_IMPL = "HasIntImpl";
        /// <summary>
        ///   System.Boolean HasIntImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_INT_IMPL (System.Int32 name);


        /// const string Name_Func_HAS_MATRIX_IMPL = "HasMatrixImpl";
        /// <summary>
        ///   System.Boolean HasMatrixImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_MATRIX_IMPL (System.Int32 name);


        /// const string Name_Func_HAS_TEXTURE_IMPL = "HasTextureImpl";
        /// <summary>
        ///   System.Boolean HasTextureImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_TEXTURE_IMPL (System.Int32 name);


        /// const string Name_Func_HAS_VECTOR_IMPL = "HasVectorImpl";
        /// <summary>
        ///   System.Boolean HasVectorImpl(System.Int32 name)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_VECTOR_IMPL (System.Int32 name);


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


        /// const string Name_Func_IS_LOCAL_KEYWORD_ENABLED = "IsLocalKeywordEnabled";
        /// <summary>
        ///   System.Boolean IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword keyword)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_LOCAL_KEYWORD_ENABLED (UnityEngine.Rendering.LocalKeyword keyword);


        /// const string Name_Func_IS_LOCAL_KEYWORD_ENABLED_INJECTED = "IsLocalKeywordEnabled_Injected";
        /// <summary>
        ///   System.Boolean IsLocalKeywordEnabled_Injected(UnityEngine.Rendering.LocalKeyword& keyword)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword&</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_LOCAL_KEYWORD_ENABLED_INJECTED (UnityEngine.Rendering.LocalKeyword& keyword);


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


        /// const string Name_Func_LERP = "Lerp";
        /// <summary>
        ///   System.Void Lerp(UnityEngine.Material start,UnityEngine.Material end,System.Single t)
        /// </summary>
        /// <param name="start">class UnityEngine.Material</param>
        /// <param name="end">class UnityEngine.Material</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void LERP (nint start,nint end,System.Single t);


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


        /// const string Name_Func_SET_COLOR = "set_color";
        /// <summary>
        ///   System.Void set_color(UnityEngine.Color value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Color</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COLOR (UnityEngine.Color value);


        /// const string Name_Func_SET_DOUBLE_SIDED_GI = "set_doubleSidedGI";
        /// <summary>
        ///   System.Void set_doubleSidedGI(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_DOUBLE_SIDED_GI (System.Boolean value);


        /// const string Name_Func_SET_ENABLED_KEYWORDS = "set_enabledKeywords";
        /// <summary>
        ///   System.Void set_enabledKeywords(UnityEngine.Rendering.LocalKeyword[] value)
        /// </summary>
        /// <param name="value">class UnityEngine.Rendering.LocalKeyword[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_ENABLED_KEYWORDS (nint value);


        /// const string Name_Func_SET_ENABLE_INSTANCING = "set_enableInstancing";
        /// <summary>
        ///   System.Void set_enableInstancing(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_ENABLE_INSTANCING (System.Boolean value);


        /// const string Name_Func_SET_GLOBAL_ILLUMINATION_FLAGS = "set_globalIlluminationFlags";
        /// <summary>
        ///   System.Void set_globalIlluminationFlags(UnityEngine.MaterialGlobalIlluminationFlags value)
        /// </summary>
        /// <param name="value">enum UnityEngine.MaterialGlobalIlluminationFlags</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_GLOBAL_ILLUMINATION_FLAGS (UnityEngine.MaterialGlobalIlluminationFlags value);


        /// const string Name_Func_SET_HIDE_FLAGS = "set_hideFlags";
        /// <summary>
        ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
        /// </summary>
        /// <param name="value">enum UnityEngine.HideFlags</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);


        /// const string Name_Func_SET_MAIN_TEXTURE = "set_mainTexture";
        /// <summary>
        ///   System.Void set_mainTexture(UnityEngine.Texture value)
        /// </summary>
        /// <param name="value">class UnityEngine.Texture</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MAIN_TEXTURE (nint value);


        /// const string Name_Func_SET_MAIN_TEXTURE_OFFSET = "set_mainTextureOffset";
        /// <summary>
        ///   System.Void set_mainTextureOffset(UnityEngine.Vector2 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MAIN_TEXTURE_OFFSET (UnityEngine.Vector2 value);


        /// const string Name_Func_SET_MAIN_TEXTURE_SCALE = "set_mainTextureScale";
        /// <summary>
        ///   System.Void set_mainTextureScale(UnityEngine.Vector2 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MAIN_TEXTURE_SCALE (UnityEngine.Vector2 value);


        /// const string Name_Func_SET_NAME = "set_name";
        /// <summary>
        ///   System.Void set_name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_NAME (nint value);


        /// const string Name_Func_SET_RENDER_QUEUE = "set_renderQueue";
        /// <summary>
        ///   System.Void set_renderQueue(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_RENDER_QUEUE (System.Int32 value);


        /// const string Name_Func_SET_SHADER = "set_shader";
        /// <summary>
        ///   System.Void set_shader(UnityEngine.Shader value)
        /// </summary>
        /// <param name="value">class UnityEngine.Shader</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_SHADER (nint value);


        /// const string Name_Func_SET_SHADER_KEYWORDS = "set_shaderKeywords";
        /// <summary>
        ///   System.Void set_shaderKeywords(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_SHADER_KEYWORDS (nint value);


        /// const string Name_Func_SET_BUFFER_IMPL = "SetBufferImpl";
        /// <summary>
        ///   System.Void SetBufferImpl(System.Int32 name,UnityEngine.ComputeBuffer value)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">class UnityEngine.ComputeBuffer</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_BUFFER_IMPL (System.Int32 name,nint value);


        /// const string Name_Func_SET_COLOR_ARRAY_IMPL = "SetColorArrayImpl";
        /// <summary>
        ///   System.Void SetColorArrayImpl(System.Int32 name,UnityEngine.Color[] values,System.Int32 count)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class UnityEngine.Color[]</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COLOR_ARRAY_IMPL (System.Int32 name,nint values,System.Int32 count);


        /// const string Name_Func_SET_COLOR_IMPL = "SetColorImpl";
        /// <summary>
        ///   System.Void SetColorImpl(System.Int32 name,UnityEngine.Color value)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">struct UnityEngine.Color</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COLOR_IMPL (System.Int32 name,UnityEngine.Color value);


        /// const string Name_Func_SET_COLOR_IMPL_INJECTED = "SetColorImpl_Injected";
        /// <summary>
        ///   System.Void SetColorImpl_Injected(System.Int32 name,UnityEngine.Color& value)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">struct UnityEngine.Color&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COLOR_IMPL_INJECTED (System.Int32 name,UnityEngine.Color& value);


        /// const string Name_Func_SET_CONSTANT_BUFFER_IMPL = "SetConstantBufferImpl";
        /// <summary>
        ///   System.Void SetConstantBufferImpl(System.Int32 name,UnityEngine.ComputeBuffer value,System.Int32 offset,System.Int32 size)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">class UnityEngine.ComputeBuffer</param>
        /// <param name="offset">struct System.Int32</param>
        /// <param name="size">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_CONSTANT_BUFFER_IMPL (System.Int32 name,nint value,System.Int32 offset,System.Int32 size);


        /// const string Name_Func_SET_CONSTANT_GRAPHICS_BUFFER_IMPL = "SetConstantGraphicsBufferImpl";
        /// <summary>
        ///   System.Void SetConstantGraphicsBufferImpl(System.Int32 name,UnityEngine.GraphicsBuffer value,System.Int32 offset,System.Int32 size)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">class UnityEngine.GraphicsBuffer</param>
        /// <param name="offset">struct System.Int32</param>
        /// <param name="size">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_CONSTANT_GRAPHICS_BUFFER_IMPL (System.Int32 name,nint value,System.Int32 offset,System.Int32 size);


        /// const string Name_Func_SET_ENABLED_KEYWORDS = "SetEnabledKeywords";
        /// <summary>
        ///   System.Void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[] keywords)
        /// </summary>
        /// <param name="keywords">class UnityEngine.Rendering.LocalKeyword[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_ENABLED_KEYWORDS (nint keywords);


        /// const string Name_Func_SET_FLOAT_ARRAY_IMPL = "SetFloatArrayImpl";
        /// <summary>
        ///   System.Void SetFloatArrayImpl(System.Int32 name,System.Single[] values,System.Int32 count)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class System.Single[]</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FLOAT_ARRAY_IMPL (System.Int32 name,nint values,System.Int32 count);


        /// const string Name_Func_SET_FLOAT_IMPL = "SetFloatImpl";
        /// <summary>
        ///   System.Void SetFloatImpl(System.Int32 name,System.Single value)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FLOAT_IMPL (System.Int32 name,System.Single value);


        /// const string Name_Func_SET_GRAPHICS_BUFFER_IMPL = "SetGraphicsBufferImpl";
        /// <summary>
        ///   System.Void SetGraphicsBufferImpl(System.Int32 name,UnityEngine.GraphicsBuffer value)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">class UnityEngine.GraphicsBuffer</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_GRAPHICS_BUFFER_IMPL (System.Int32 name,nint value);


        /// const string Name_Func_SET_INTEGER = "SetInteger";
        /// <summary>
        ///   System.Void SetInteger(System.String name,System.Int32 value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_INTEGER (nint name,System.Int32 value);



        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(UnityEngine.Shader shader)
        /// </summary>
        /// <param name="shader">class UnityEngine.Shader</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_00 (nint shader);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(UnityEngine.Material source)
        /// </summary>
        /// <param name="source">class UnityEngine.Material</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_01 (nint source);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor(System.String contents)
        /// </summary>
        /// <param name="contents">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_02 (nint contents);


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_03 ();


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


        /// const string Name_Func_DISABLE_KEYWORD = "DisableKeyword";
        /// <summary>
        ///   System.Void DisableKeyword(System.String keyword)
        /// </summary>
        /// <param name="keyword">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void DISABLE_KEYWORD_00 (nint keyword);


        /// const string Name_Func_DISABLE_KEYWORD = "DisableKeyword";
        /// <summary>
        ///   System.Void DisableKeyword(UnityEngine.Rendering.LocalKeyword& keyword)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void DISABLE_KEYWORD_01 (UnityEngine.Rendering.LocalKeyword& keyword);


        /// const string Name_Func_ENABLE_KEYWORD = "EnableKeyword";
        /// <summary>
        ///   System.Void EnableKeyword(System.String keyword)
        /// </summary>
        /// <param name="keyword">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ENABLE_KEYWORD_00 (nint keyword);


        /// const string Name_Func_ENABLE_KEYWORD = "EnableKeyword";
        /// <summary>
        ///   System.Void EnableKeyword(UnityEngine.Rendering.LocalKeyword& keyword)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ENABLE_KEYWORD_01 (UnityEngine.Rendering.LocalKeyword& keyword);


        /// const string Name_Func_FIND_ANY_OBJECT_BY_TYPE = "FindAnyObjectByType";
        /// <summary>
        /// static  T FindAnyObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// public static extern nint FIND_ANY_OBJECT_BY_TYPE_00 ();


        /// const string Name_Func_FIND_ANY_OBJECT_BY_TYPE = "FindAnyObjectByType";
        /// <summary>
        /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// public static extern nint FIND_ANY_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// const string Name_Func_FIND_ANY_OBJECT_BY_TYPE = "FindAnyObjectByType";
        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint FIND_ANY_OBJECT_BY_TYPE_02 (nint type);


        /// const string Name_Func_FIND_ANY_OBJECT_BY_TYPE = "FindAnyObjectByType";
        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type,UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint FIND_ANY_OBJECT_BY_TYPE_03 (nint type,UnityEngine.FindObjectsInactive findObjectsInactive);


        /// const string Name_Func_FIND_FIRST_OBJECT_BY_TYPE = "FindFirstObjectByType";
        /// <summary>
        /// static  T FindFirstObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// public static extern nint FIND_FIRST_OBJECT_BY_TYPE_00 ();


        /// const string Name_Func_FIND_FIRST_OBJECT_BY_TYPE = "FindFirstObjectByType";
        /// <summary>
        /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// public static extern nint FIND_FIRST_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// const string Name_Func_FIND_FIRST_OBJECT_BY_TYPE = "FindFirstObjectByType";
        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint FIND_FIRST_OBJECT_BY_TYPE_02 (nint type);


        /// const string Name_Func_FIND_FIRST_OBJECT_BY_TYPE = "FindFirstObjectByType";
        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type,UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint FIND_FIRST_OBJECT_BY_TYPE_03 (nint type,UnityEngine.FindObjectsInactive findObjectsInactive);


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


        /// const string Name_Func_FIND_OBJECTS_BY_TYPE = "FindObjectsByType";
        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type,UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// public static extern nint FIND_OBJECTS_BY_TYPE_00 (nint type,UnityEngine.FindObjectsSortMode sortMode);


        /// const string Name_Func_FIND_OBJECTS_BY_TYPE = "FindObjectsByType";
        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type,UnityEngine.FindObjectsInactive findObjectsInactive,UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// public static extern nint FIND_OBJECTS_BY_TYPE_01 (nint type,UnityEngine.FindObjectsInactive findObjectsInactive,UnityEngine.FindObjectsSortMode sortMode);


        /// const string Name_Func_FIND_OBJECTS_BY_TYPE = "FindObjectsByType";
        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// public static extern nint FIND_OBJECTS_BY_TYPE_02 (UnityEngine.FindObjectsSortMode sortMode);


        /// const string Name_Func_FIND_OBJECTS_BY_TYPE = "FindObjectsByType";
        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive,UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// public static extern nint FIND_OBJECTS_BY_TYPE_03 (UnityEngine.FindObjectsInactive findObjectsInactive,UnityEngine.FindObjectsSortMode sortMode);


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


        /// const string Name_Func_GET_COLOR = "GetColor";
        /// <summary>
        ///   UnityEngine.Color GetColor(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct UnityEngine.Color</returns>
        /// public  extern UnityEngine.Color GET_COLOR_00 (nint name);


        /// const string Name_Func_GET_COLOR = "GetColor";
        /// <summary>
        ///   UnityEngine.Color GetColor(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct UnityEngine.Color</returns>
        /// public  extern UnityEngine.Color GET_COLOR_01 (System.Int32 nameID);


        /// const string Name_Func_GET_COLOR_ARRAY = "GetColorArray";
        /// <summary>
        ///   UnityEngine.Color[] GetColorArray(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>class UnityEngine.Color[]</returns>
        /// public  extern nint GET_COLOR_ARRAY_00 (nint name);


        /// const string Name_Func_GET_COLOR_ARRAY = "GetColorArray";
        /// <summary>
        ///   UnityEngine.Color[] GetColorArray(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>class UnityEngine.Color[]</returns>
        /// public  extern nint GET_COLOR_ARRAY_01 (System.Int32 nameID);


        /// const string Name_Func_GET_COLOR_ARRAY = "GetColorArray";
        /// <summary>
        ///   System.Void GetColorArray(System.String name,System.Collections.Generic.List<UnityEngine.Color> values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Color></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_COLOR_ARRAY_02 (nint name,nint values);


        /// const string Name_Func_GET_COLOR_ARRAY = "GetColorArray";
        /// <summary>
        ///   System.Void GetColorArray(System.Int32 nameID,System.Collections.Generic.List<UnityEngine.Color> values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Color></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_COLOR_ARRAY_03 (System.Int32 nameID,nint values);


        /// const string Name_Func_GET_FLOAT = "GetFloat";
        /// <summary>
        ///   System.Single GetFloat(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single GET_FLOAT_00 (nint name);


        /// const string Name_Func_GET_FLOAT = "GetFloat";
        /// <summary>
        ///   System.Single GetFloat(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single GET_FLOAT_01 (System.Int32 nameID);


        /// const string Name_Func_GET_FLOAT_ARRAY = "GetFloatArray";
        /// <summary>
        ///   System.Single[] GetFloatArray(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>class System.Single[]</returns>
        /// public  extern nint GET_FLOAT_ARRAY_00 (nint name);


        /// const string Name_Func_GET_FLOAT_ARRAY = "GetFloatArray";
        /// <summary>
        ///   System.Single[] GetFloatArray(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>class System.Single[]</returns>
        /// public  extern nint GET_FLOAT_ARRAY_01 (System.Int32 nameID);


        /// const string Name_Func_GET_FLOAT_ARRAY = "GetFloatArray";
        /// <summary>
        ///   System.Void GetFloatArray(System.String name,System.Collections.Generic.List<System.Single> values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class System.Collections.Generic.List<System.Single></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_FLOAT_ARRAY_02 (nint name,nint values);


        /// const string Name_Func_GET_FLOAT_ARRAY = "GetFloatArray";
        /// <summary>
        ///   System.Void GetFloatArray(System.Int32 nameID,System.Collections.Generic.List<System.Single> values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<System.Single></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_FLOAT_ARRAY_03 (System.Int32 nameID,nint values);


        /// const string Name_Func_GET_INT = "GetInt";
        /// <summary>
        ///   System.Int32 GetInt(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_INT_00 (nint name);


        /// const string Name_Func_GET_INT = "GetInt";
        /// <summary>
        ///   System.Int32 GetInt(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_INT_01 (System.Int32 nameID);


        /// const string Name_Func_GET_INTEGER = "GetInteger";
        /// <summary>
        ///   System.Int32 GetInteger(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_INTEGER_00 (nint name);


        /// const string Name_Func_GET_INTEGER = "GetInteger";
        /// <summary>
        ///   System.Int32 GetInteger(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_INTEGER_01 (System.Int32 nameID);


        /// const string Name_Func_GET_MATRIX = "GetMatrix";
        /// <summary>
        ///   UnityEngine.Matrix4x4 GetMatrix(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct UnityEngine.Matrix4x4</returns>
        /// public  extern UnityEngine.Matrix4x4 GET_MATRIX_00 (nint name);


        /// const string Name_Func_GET_MATRIX = "GetMatrix";
        /// <summary>
        ///   UnityEngine.Matrix4x4 GetMatrix(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct UnityEngine.Matrix4x4</returns>
        /// public  extern UnityEngine.Matrix4x4 GET_MATRIX_01 (System.Int32 nameID);


        /// const string Name_Func_GET_MATRIX_ARRAY = "GetMatrixArray";
        /// <summary>
        ///   UnityEngine.Matrix4x4[] GetMatrixArray(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>class UnityEngine.Matrix4x4[]</returns>
        /// public  extern nint GET_MATRIX_ARRAY_00 (nint name);


        /// const string Name_Func_GET_MATRIX_ARRAY = "GetMatrixArray";
        /// <summary>
        ///   UnityEngine.Matrix4x4[] GetMatrixArray(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>class UnityEngine.Matrix4x4[]</returns>
        /// public  extern nint GET_MATRIX_ARRAY_01 (System.Int32 nameID);


        /// const string Name_Func_GET_MATRIX_ARRAY = "GetMatrixArray";
        /// <summary>
        ///   System.Void GetMatrixArray(System.String name,System.Collections.Generic.List<UnityEngine.Matrix4x4> values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_MATRIX_ARRAY_02 (nint name,nint values);


        /// const string Name_Func_GET_MATRIX_ARRAY = "GetMatrixArray";
        /// <summary>
        ///   System.Void GetMatrixArray(System.Int32 nameID,System.Collections.Generic.List<UnityEngine.Matrix4x4> values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_MATRIX_ARRAY_03 (System.Int32 nameID,nint values);


        /// const string Name_Func_GET_TAG = "GetTag";
        /// <summary>
        ///   System.String GetTag(System.String tag,System.Boolean searchFallbacks,System.String defaultValue)
        /// </summary>
        /// <param name="tag">class System.String</param>
        /// <param name="searchFallbacks">struct System.Boolean</param>
        /// <param name="defaultValue">class System.String</param>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_TAG_00 (nint tag,System.Boolean searchFallbacks,nint defaultValue);


        /// const string Name_Func_GET_TAG = "GetTag";
        /// <summary>
        ///   System.String GetTag(System.String tag,System.Boolean searchFallbacks)
        /// </summary>
        /// <param name="tag">class System.String</param>
        /// <param name="searchFallbacks">struct System.Boolean</param>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_TAG_01 (nint tag,System.Boolean searchFallbacks);


        /// const string Name_Func_GET_TEXTURE = "GetTexture";
        /// <summary>
        ///   UnityEngine.Texture GetTexture(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>class UnityEngine.Texture</returns>
        /// public  extern nint GET_TEXTURE_00 (nint name);


        /// const string Name_Func_GET_TEXTURE = "GetTexture";
        /// <summary>
        ///   UnityEngine.Texture GetTexture(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>class UnityEngine.Texture</returns>
        /// public  extern nint GET_TEXTURE_01 (System.Int32 nameID);


        /// const string Name_Func_GET_TEXTURE_OFFSET = "GetTextureOffset";
        /// <summary>
        ///   UnityEngine.Vector2 GetTextureOffset(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// public  extern UnityEngine.Vector2 GET_TEXTURE_OFFSET_00 (nint name);


        /// const string Name_Func_GET_TEXTURE_OFFSET = "GetTextureOffset";
        /// <summary>
        ///   UnityEngine.Vector2 GetTextureOffset(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// public  extern UnityEngine.Vector2 GET_TEXTURE_OFFSET_01 (System.Int32 nameID);


        /// const string Name_Func_GET_TEXTURE_PROPERTY_NAME_I_DS = "GetTexturePropertyNameIDs";
        /// <summary>
        ///   System.Int32[] GetTexturePropertyNameIDs()
        /// </summary>
        /// <returns>class System.Int32[]</returns>
        /// public  extern nint GET_TEXTURE_PROPERTY_NAME_I_DS_00 ();


        /// const string Name_Func_GET_TEXTURE_PROPERTY_NAME_I_DS = "GetTexturePropertyNameIDs";
        /// <summary>
        ///   System.Void GetTexturePropertyNameIDs(System.Collections.Generic.List<System.Int32> outNames)
        /// </summary>
        /// <param name="outNames">class System.Collections.Generic.List<System.Int32></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_TEXTURE_PROPERTY_NAME_I_DS_01 (nint outNames);


        /// const string Name_Func_GET_TEXTURE_PROPERTY_NAMES = "GetTexturePropertyNames";
        /// <summary>
        ///   System.String[] GetTexturePropertyNames()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// public  extern nint GET_TEXTURE_PROPERTY_NAMES_00 ();


        /// const string Name_Func_GET_TEXTURE_PROPERTY_NAMES = "GetTexturePropertyNames";
        /// <summary>
        ///   System.Void GetTexturePropertyNames(System.Collections.Generic.List<System.String> outNames)
        /// </summary>
        /// <param name="outNames">class System.Collections.Generic.List<System.String></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_TEXTURE_PROPERTY_NAMES_01 (nint outNames);


        /// const string Name_Func_GET_TEXTURE_SCALE = "GetTextureScale";
        /// <summary>
        ///   UnityEngine.Vector2 GetTextureScale(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// public  extern UnityEngine.Vector2 GET_TEXTURE_SCALE_00 (nint name);


        /// const string Name_Func_GET_TEXTURE_SCALE = "GetTextureScale";
        /// <summary>
        ///   UnityEngine.Vector2 GetTextureScale(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// public  extern UnityEngine.Vector2 GET_TEXTURE_SCALE_01 (System.Int32 nameID);


        /// const string Name_Func_GET_VECTOR = "GetVector";
        /// <summary>
        ///   UnityEngine.Vector4 GetVector(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct UnityEngine.Vector4</returns>
        /// public  extern UnityEngine.Vector4 GET_VECTOR_00 (nint name);


        /// const string Name_Func_GET_VECTOR = "GetVector";
        /// <summary>
        ///   UnityEngine.Vector4 GetVector(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct UnityEngine.Vector4</returns>
        /// public  extern UnityEngine.Vector4 GET_VECTOR_01 (System.Int32 nameID);


        /// const string Name_Func_GET_VECTOR_ARRAY = "GetVectorArray";
        /// <summary>
        ///   UnityEngine.Vector4[] GetVectorArray(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>class UnityEngine.Vector4[]</returns>
        /// public  extern nint GET_VECTOR_ARRAY_00 (nint name);


        /// const string Name_Func_GET_VECTOR_ARRAY = "GetVectorArray";
        /// <summary>
        ///   UnityEngine.Vector4[] GetVectorArray(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>class UnityEngine.Vector4[]</returns>
        /// public  extern nint GET_VECTOR_ARRAY_01 (System.Int32 nameID);


        /// const string Name_Func_GET_VECTOR_ARRAY = "GetVectorArray";
        /// <summary>
        ///   System.Void GetVectorArray(System.String name,System.Collections.Generic.List<UnityEngine.Vector4> values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Vector4></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_VECTOR_ARRAY_02 (nint name,nint values);


        /// const string Name_Func_GET_VECTOR_ARRAY = "GetVectorArray";
        /// <summary>
        ///   System.Void GetVectorArray(System.Int32 nameID,System.Collections.Generic.List<UnityEngine.Vector4> values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Vector4></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_VECTOR_ARRAY_03 (System.Int32 nameID,nint values);


        /// const string Name_Func_HAS_BUFFER = "HasBuffer";
        /// <summary>
        ///   System.Boolean HasBuffer(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_BUFFER_00 (nint name);


        /// const string Name_Func_HAS_BUFFER = "HasBuffer";
        /// <summary>
        ///   System.Boolean HasBuffer(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_BUFFER_01 (System.Int32 nameID);


        /// const string Name_Func_HAS_COLOR = "HasColor";
        /// <summary>
        ///   System.Boolean HasColor(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_COLOR_00 (nint name);


        /// const string Name_Func_HAS_COLOR = "HasColor";
        /// <summary>
        ///   System.Boolean HasColor(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_COLOR_01 (System.Int32 nameID);


        /// const string Name_Func_HAS_CONSTANT_BUFFER = "HasConstantBuffer";
        /// <summary>
        ///   System.Boolean HasConstantBuffer(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_CONSTANT_BUFFER_00 (nint name);


        /// const string Name_Func_HAS_CONSTANT_BUFFER = "HasConstantBuffer";
        /// <summary>
        ///   System.Boolean HasConstantBuffer(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_CONSTANT_BUFFER_01 (System.Int32 nameID);


        /// const string Name_Func_HAS_FLOAT = "HasFloat";
        /// <summary>
        ///   System.Boolean HasFloat(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_FLOAT_00 (nint name);


        /// const string Name_Func_HAS_FLOAT = "HasFloat";
        /// <summary>
        ///   System.Boolean HasFloat(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_FLOAT_01 (System.Int32 nameID);


        /// const string Name_Func_HAS_INT = "HasInt";
        /// <summary>
        ///   System.Boolean HasInt(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_INT_00 (nint name);


        /// const string Name_Func_HAS_INT = "HasInt";
        /// <summary>
        ///   System.Boolean HasInt(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_INT_01 (System.Int32 nameID);


        /// const string Name_Func_HAS_INTEGER = "HasInteger";
        /// <summary>
        ///   System.Boolean HasInteger(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_INTEGER_00 (nint name);


        /// const string Name_Func_HAS_INTEGER = "HasInteger";
        /// <summary>
        ///   System.Boolean HasInteger(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_INTEGER_01 (System.Int32 nameID);


        /// const string Name_Func_HAS_MATRIX = "HasMatrix";
        /// <summary>
        ///   System.Boolean HasMatrix(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_MATRIX_00 (nint name);


        /// const string Name_Func_HAS_MATRIX = "HasMatrix";
        /// <summary>
        ///   System.Boolean HasMatrix(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_MATRIX_01 (System.Int32 nameID);


        /// const string Name_Func_HAS_PROPERTY = "HasProperty";
        /// <summary>
        ///   System.Boolean HasProperty(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_PROPERTY_00 (System.Int32 nameID);


        /// const string Name_Func_HAS_PROPERTY = "HasProperty";
        /// <summary>
        ///   System.Boolean HasProperty(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_PROPERTY_01 (nint name);


        /// const string Name_Func_HAS_TEXTURE = "HasTexture";
        /// <summary>
        ///   System.Boolean HasTexture(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_TEXTURE_00 (nint name);


        /// const string Name_Func_HAS_TEXTURE = "HasTexture";
        /// <summary>
        ///   System.Boolean HasTexture(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_TEXTURE_01 (System.Int32 nameID);


        /// const string Name_Func_HAS_VECTOR = "HasVector";
        /// <summary>
        ///   System.Boolean HasVector(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_VECTOR_00 (nint name);


        /// const string Name_Func_HAS_VECTOR = "HasVector";
        /// <summary>
        ///   System.Boolean HasVector(System.Int32 nameID)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAS_VECTOR_01 (System.Int32 nameID);


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


        /// const string Name_Func_IS_KEYWORD_ENABLED = "IsKeywordEnabled";
        /// <summary>
        ///   System.Boolean IsKeywordEnabled(System.String keyword)
        /// </summary>
        /// <param name="keyword">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_KEYWORD_ENABLED_00 (nint keyword);


        /// const string Name_Func_IS_KEYWORD_ENABLED = "IsKeywordEnabled";
        /// <summary>
        ///   System.Boolean IsKeywordEnabled(UnityEngine.Rendering.LocalKeyword& keyword)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword&</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_KEYWORD_ENABLED_01 (UnityEngine.Rendering.LocalKeyword& keyword);


        /// const string Name_Func_SET_BUFFER = "SetBuffer";
        /// <summary>
        ///   System.Void SetBuffer(System.String name,UnityEngine.ComputeBuffer value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">class UnityEngine.ComputeBuffer</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_BUFFER_00 (nint name,nint value);


        /// const string Name_Func_SET_BUFFER = "SetBuffer";
        /// <summary>
        ///   System.Void SetBuffer(System.Int32 nameID,UnityEngine.ComputeBuffer value)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">class UnityEngine.ComputeBuffer</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_BUFFER_01 (System.Int32 nameID,nint value);


        /// const string Name_Func_SET_BUFFER = "SetBuffer";
        /// <summary>
        ///   System.Void SetBuffer(System.String name,UnityEngine.GraphicsBuffer value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">class UnityEngine.GraphicsBuffer</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_BUFFER_02 (nint name,nint value);


        /// const string Name_Func_SET_BUFFER = "SetBuffer";
        /// <summary>
        ///   System.Void SetBuffer(System.Int32 nameID,UnityEngine.GraphicsBuffer value)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">class UnityEngine.GraphicsBuffer</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_BUFFER_03 (System.Int32 nameID,nint value);


        /// const string Name_Func_SET_COLOR = "SetColor";
        /// <summary>
        ///   System.Void SetColor(System.String name,UnityEngine.Color value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct UnityEngine.Color</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COLOR_00 (nint name,UnityEngine.Color value);


        /// const string Name_Func_SET_COLOR = "SetColor";
        /// <summary>
        ///   System.Void SetColor(System.Int32 nameID,UnityEngine.Color value)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">struct UnityEngine.Color</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COLOR_01 (System.Int32 nameID,UnityEngine.Color value);


        /// const string Name_Func_SET_COLOR_ARRAY = "SetColorArray";
        /// <summary>
        ///   System.Void SetColorArray(System.Int32 name,UnityEngine.Color[] values,System.Int32 count)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class UnityEngine.Color[]</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COLOR_ARRAY_00 (System.Int32 name,nint values,System.Int32 count);


        /// const string Name_Func_SET_COLOR_ARRAY = "SetColorArray";
        /// <summary>
        ///   System.Void SetColorArray(System.String name,System.Collections.Generic.List<UnityEngine.Color> values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Color></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COLOR_ARRAY_01 (nint name,nint values);


        /// const string Name_Func_SET_COLOR_ARRAY = "SetColorArray";
        /// <summary>
        ///   System.Void SetColorArray(System.Int32 nameID,System.Collections.Generic.List<UnityEngine.Color> values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Color></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COLOR_ARRAY_02 (System.Int32 nameID,nint values);


        /// const string Name_Func_SET_COLOR_ARRAY = "SetColorArray";
        /// <summary>
        ///   System.Void SetColorArray(System.String name,UnityEngine.Color[] values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class UnityEngine.Color[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COLOR_ARRAY_03 (nint name,nint values);


        /// const string Name_Func_SET_COLOR_ARRAY = "SetColorArray";
        /// <summary>
        ///   System.Void SetColorArray(System.Int32 nameID,UnityEngine.Color[] values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class UnityEngine.Color[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COLOR_ARRAY_04 (System.Int32 nameID,nint values);


        /// const string Name_Func_SET_CONSTANT_BUFFER = "SetConstantBuffer";
        /// <summary>
        ///   System.Void SetConstantBuffer(System.String name,UnityEngine.ComputeBuffer value,System.Int32 offset,System.Int32 size)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">class UnityEngine.ComputeBuffer</param>
        /// <param name="offset">struct System.Int32</param>
        /// <param name="size">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_CONSTANT_BUFFER_00 (nint name,nint value,System.Int32 offset,System.Int32 size);


        /// const string Name_Func_SET_CONSTANT_BUFFER = "SetConstantBuffer";
        /// <summary>
        ///   System.Void SetConstantBuffer(System.Int32 nameID,UnityEngine.ComputeBuffer value,System.Int32 offset,System.Int32 size)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">class UnityEngine.ComputeBuffer</param>
        /// <param name="offset">struct System.Int32</param>
        /// <param name="size">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_CONSTANT_BUFFER_01 (System.Int32 nameID,nint value,System.Int32 offset,System.Int32 size);


        /// const string Name_Func_SET_CONSTANT_BUFFER = "SetConstantBuffer";
        /// <summary>
        ///   System.Void SetConstantBuffer(System.String name,UnityEngine.GraphicsBuffer value,System.Int32 offset,System.Int32 size)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">class UnityEngine.GraphicsBuffer</param>
        /// <param name="offset">struct System.Int32</param>
        /// <param name="size">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_CONSTANT_BUFFER_02 (nint name,nint value,System.Int32 offset,System.Int32 size);


        /// const string Name_Func_SET_CONSTANT_BUFFER = "SetConstantBuffer";
        /// <summary>
        ///   System.Void SetConstantBuffer(System.Int32 nameID,UnityEngine.GraphicsBuffer value,System.Int32 offset,System.Int32 size)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">class UnityEngine.GraphicsBuffer</param>
        /// <param name="offset">struct System.Int32</param>
        /// <param name="size">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_CONSTANT_BUFFER_03 (System.Int32 nameID,nint value,System.Int32 offset,System.Int32 size);


        /// const string Name_Func_SET_FLOAT = "SetFloat";
        /// <summary>
        ///   System.Void SetFloat(System.String name,System.Single value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FLOAT_00 (nint name,System.Single value);


        /// const string Name_Func_SET_FLOAT = "SetFloat";
        /// <summary>
        ///   System.Void SetFloat(System.Int32 nameID,System.Single value)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FLOAT_01 (System.Int32 nameID,System.Single value);


        /// const string Name_Func_SET_FLOAT_ARRAY = "SetFloatArray";
        /// <summary>
        ///   System.Void SetFloatArray(System.Int32 name,System.Single[] values,System.Int32 count)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class System.Single[]</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FLOAT_ARRAY_00 (System.Int32 name,nint values,System.Int32 count);


        /// const string Name_Func_SET_FLOAT_ARRAY = "SetFloatArray";
        /// <summary>
        ///   System.Void SetFloatArray(System.String name,System.Collections.Generic.List<System.Single> values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class System.Collections.Generic.List<System.Single></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FLOAT_ARRAY_01 (nint name,nint values);


        /// const string Name_Func_SET_FLOAT_ARRAY = "SetFloatArray";
        /// <summary>
        ///   System.Void SetFloatArray(System.Int32 nameID,System.Collections.Generic.List<System.Single> values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<System.Single></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FLOAT_ARRAY_02 (System.Int32 nameID,nint values);


        /// const string Name_Func_SET_FLOAT_ARRAY = "SetFloatArray";
        /// <summary>
        ///   System.Void SetFloatArray(System.String name,System.Single[] values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class System.Single[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FLOAT_ARRAY_03 (nint name,nint values);


        /// const string Name_Func_SET_FLOAT_ARRAY = "SetFloatArray";
        /// <summary>
        ///   System.Void SetFloatArray(System.Int32 nameID,System.Single[] values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class System.Single[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_FLOAT_ARRAY_04 (System.Int32 nameID,nint values);


        /// const string Name_Func_SET_INT = "SetInt";
        /// <summary>
        ///   System.Void SetInt(System.String name,System.Int32 value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_INT_00 (nint name,System.Int32 value);


        /// const string Name_Func_SET_INT = "SetInt";
        /// <summary>
        ///   System.Void SetInt(System.Int32 nameID,System.Int32 value)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_INT_01 (System.Int32 nameID,System.Int32 value);


        /// public static partial class Search_Material
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor(UnityEngine.Shader shader)
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "UnityEngine.Shader");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(UnityEngine.Material source)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "UnityEngine.Material");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(System.String contents)
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
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
        ///   System.Void DisableKeyword(System.String keyword)
        /// </summary>
        /// public static bool DISABLE_KEYWORD_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DisableKeyword", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void DisableKeyword(UnityEngine.Rendering.LocalKeyword& keyword)
        /// </summary>
        /// public static bool DISABLE_KEYWORD_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DisableKeyword", "UnityEngine.Rendering.LocalKeyword&");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void EnableKeyword(System.String keyword)
        /// </summary>
        /// public static bool ENABLE_KEYWORD_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EnableKeyword", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void EnableKeyword(UnityEngine.Rendering.LocalKeyword& keyword)
        /// </summary>
        /// public static bool ENABLE_KEYWORD_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EnableKeyword", "UnityEngine.Rendering.LocalKeyword&");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindAnyObjectByType()
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "UnityEngine.FindObjectsInactive");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "System.Type", "UnityEngine.FindObjectsInactive");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindFirstObjectByType()
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "UnityEngine.FindObjectsInactive");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "System.Type", "UnityEngine.FindObjectsInactive");
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
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "System.Type", "UnityEngine.FindObjectsSortMode");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "System.Type", "UnityEngine.FindObjectsInactive", "UnityEngine.FindObjectsSortMode");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "UnityEngine.FindObjectsSortMode");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "UnityEngine.FindObjectsInactive", "UnityEngine.FindObjectsSortMode");
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
        ///   UnityEngine.Color GetColor(System.String name)
        /// </summary>
        /// public static bool GET_COLOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetColor", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Color GetColor(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_COLOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetColor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Color[] GetColorArray(System.String name)
        /// </summary>
        /// public static bool GET_COLOR_ARRAY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetColorArray", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Color[] GetColorArray(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_COLOR_ARRAY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetColorArray", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetColorArray(System.String name, System.Collections.Generic.List<UnityEngine.Color> values)
        /// </summary>
        /// public static bool GET_COLOR_ARRAY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetColorArray", "System.String", "System.Collections.Generic.List<UnityEngine.Color>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetColorArray(System.Int32 nameID, System.Collections.Generic.List<UnityEngine.Color> values)
        /// </summary>
        /// public static bool GET_COLOR_ARRAY_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetColorArray", "System.Int32", "System.Collections.Generic.List<UnityEngine.Color>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Single GetFloat(System.String name)
        /// </summary>
        /// public static bool GET_FLOAT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetFloat", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Single GetFloat(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_FLOAT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetFloat", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Single[] GetFloatArray(System.String name)
        /// </summary>
        /// public static bool GET_FLOAT_ARRAY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetFloatArray", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Single[] GetFloatArray(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_FLOAT_ARRAY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetFloatArray", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetFloatArray(System.String name, System.Collections.Generic.List<System.Single> values)
        /// </summary>
        /// public static bool GET_FLOAT_ARRAY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetFloatArray", "System.String", "System.Collections.Generic.List<System.Single>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetFloatArray(System.Int32 nameID, System.Collections.Generic.List<System.Single> values)
        /// </summary>
        /// public static bool GET_FLOAT_ARRAY_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetFloatArray", "System.Int32", "System.Collections.Generic.List<System.Single>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 GetInt(System.String name)
        /// </summary>
        /// public static bool GET_INT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetInt", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 GetInt(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_INT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetInt", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 GetInteger(System.String name)
        /// </summary>
        /// public static bool GET_INTEGER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetInteger", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 GetInteger(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_INTEGER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetInteger", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Matrix4x4 GetMatrix(System.String name)
        /// </summary>
        /// public static bool GET_MATRIX_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMatrix", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Matrix4x4 GetMatrix(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_MATRIX_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMatrix", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Matrix4x4[] GetMatrixArray(System.String name)
        /// </summary>
        /// public static bool GET_MATRIX_ARRAY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMatrixArray", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Matrix4x4[] GetMatrixArray(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_MATRIX_ARRAY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMatrixArray", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetMatrixArray(System.String name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values)
        /// </summary>
        /// public static bool GET_MATRIX_ARRAY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMatrixArray", "System.String", "System.Collections.Generic.List<UnityEngine.Matrix4x4>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetMatrixArray(System.Int32 nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values)
        /// </summary>
        /// public static bool GET_MATRIX_ARRAY_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMatrixArray", "System.Int32", "System.Collections.Generic.List<UnityEngine.Matrix4x4>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.String GetTag(System.String tag, System.Boolean searchFallbacks, System.String defaultValue)
        /// </summary>
        /// public static bool GET_TAG_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTag", "System.String", "System.Boolean", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.String GetTag(System.String tag, System.Boolean searchFallbacks)
        /// </summary>
        /// public static bool GET_TAG_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTag", "System.String", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Texture GetTexture(System.String name)
        /// </summary>
        /// public static bool GET_TEXTURE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTexture", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Texture GetTexture(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_TEXTURE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTexture", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector2 GetTextureOffset(System.String name)
        /// </summary>
        /// public static bool GET_TEXTURE_OFFSET_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTextureOffset", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector2 GetTextureOffset(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_TEXTURE_OFFSET_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTextureOffset", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32[] GetTexturePropertyNameIDs()
        /// </summary>
        /// public static bool GET_TEXTURE_PROPERTY_NAME_I_DS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTexturePropertyNameIDs");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetTexturePropertyNameIDs(System.Collections.Generic.List<System.Int32> outNames)
        /// </summary>
        /// public static bool GET_TEXTURE_PROPERTY_NAME_I_DS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTexturePropertyNameIDs", "System.Collections.Generic.List<System.Int32>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.String[] GetTexturePropertyNames()
        /// </summary>
        /// public static bool GET_TEXTURE_PROPERTY_NAMES_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTexturePropertyNames");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetTexturePropertyNames(System.Collections.Generic.List<System.String> outNames)
        /// </summary>
        /// public static bool GET_TEXTURE_PROPERTY_NAMES_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTexturePropertyNames", "System.Collections.Generic.List<System.String>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector2 GetTextureScale(System.String name)
        /// </summary>
        /// public static bool GET_TEXTURE_SCALE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTextureScale", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector2 GetTextureScale(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_TEXTURE_SCALE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTextureScale", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector4 GetVector(System.String name)
        /// </summary>
        /// public static bool GET_VECTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetVector", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector4 GetVector(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_VECTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetVector", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector4[] GetVectorArray(System.String name)
        /// </summary>
        /// public static bool GET_VECTOR_ARRAY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetVectorArray", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector4[] GetVectorArray(System.Int32 nameID)
        /// </summary>
        /// public static bool GET_VECTOR_ARRAY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetVectorArray", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetVectorArray(System.String name, System.Collections.Generic.List<UnityEngine.Vector4> values)
        /// </summary>
        /// public static bool GET_VECTOR_ARRAY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetVectorArray", "System.String", "System.Collections.Generic.List<UnityEngine.Vector4>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetVectorArray(System.Int32 nameID, System.Collections.Generic.List<UnityEngine.Vector4> values)
        /// </summary>
        /// public static bool GET_VECTOR_ARRAY_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetVectorArray", "System.Int32", "System.Collections.Generic.List<UnityEngine.Vector4>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasBuffer(System.String name)
        /// </summary>
        /// public static bool HAS_BUFFER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasBuffer", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasBuffer(System.Int32 nameID)
        /// </summary>
        /// public static bool HAS_BUFFER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasBuffer", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasColor(System.String name)
        /// </summary>
        /// public static bool HAS_COLOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasColor", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasColor(System.Int32 nameID)
        /// </summary>
        /// public static bool HAS_COLOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasColor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasConstantBuffer(System.String name)
        /// </summary>
        /// public static bool HAS_CONSTANT_BUFFER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasConstantBuffer", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasConstantBuffer(System.Int32 nameID)
        /// </summary>
        /// public static bool HAS_CONSTANT_BUFFER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasConstantBuffer", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasFloat(System.String name)
        /// </summary>
        /// public static bool HAS_FLOAT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasFloat", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasFloat(System.Int32 nameID)
        /// </summary>
        /// public static bool HAS_FLOAT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasFloat", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasInt(System.String name)
        /// </summary>
        /// public static bool HAS_INT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasInt", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasInt(System.Int32 nameID)
        /// </summary>
        /// public static bool HAS_INT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasInt", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasInteger(System.String name)
        /// </summary>
        /// public static bool HAS_INTEGER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasInteger", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasInteger(System.Int32 nameID)
        /// </summary>
        /// public static bool HAS_INTEGER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasInteger", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasMatrix(System.String name)
        /// </summary>
        /// public static bool HAS_MATRIX_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasMatrix", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasMatrix(System.Int32 nameID)
        /// </summary>
        /// public static bool HAS_MATRIX_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasMatrix", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasProperty(System.Int32 nameID)
        /// </summary>
        /// public static bool HAS_PROPERTY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasProperty", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasProperty(System.String name)
        /// </summary>
        /// public static bool HAS_PROPERTY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasProperty", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasTexture(System.String name)
        /// </summary>
        /// public static bool HAS_TEXTURE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasTexture", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasTexture(System.Int32 nameID)
        /// </summary>
        /// public static bool HAS_TEXTURE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasTexture", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasVector(System.String name)
        /// </summary>
        /// public static bool HAS_VECTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasVector", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean HasVector(System.Int32 nameID)
        /// </summary>
        /// public static bool HAS_VECTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HasVector", "System.Int32");
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
        ///   System.Boolean IsKeywordEnabled(System.String keyword)
        /// </summary>
        /// public static bool IS_KEYWORD_ENABLED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsKeywordEnabled", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean IsKeywordEnabled(UnityEngine.Rendering.LocalKeyword& keyword)
        /// </summary>
        /// public static bool IS_KEYWORD_ENABLED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsKeywordEnabled", "UnityEngine.Rendering.LocalKeyword&");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetBuffer(System.String name, UnityEngine.ComputeBuffer value)
        /// </summary>
        /// public static bool SET_BUFFER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetBuffer", "System.String", "UnityEngine.ComputeBuffer");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value)
        /// </summary>
        /// public static bool SET_BUFFER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetBuffer", "System.Int32", "UnityEngine.ComputeBuffer");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetBuffer(System.String name, UnityEngine.GraphicsBuffer value)
        /// </summary>
        /// public static bool SET_BUFFER_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetBuffer", "System.String", "UnityEngine.GraphicsBuffer");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetBuffer(System.Int32 nameID, UnityEngine.GraphicsBuffer value)
        /// </summary>
        /// public static bool SET_BUFFER_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetBuffer", "System.Int32", "UnityEngine.GraphicsBuffer");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetColor(System.String name, UnityEngine.Color value)
        /// </summary>
        /// public static bool SET_COLOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetColor", "System.String", "UnityEngine.Color");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetColor(System.Int32 nameID, UnityEngine.Color value)
        /// </summary>
        /// public static bool SET_COLOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetColor", "System.Int32", "UnityEngine.Color");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetColorArray(System.Int32 name, UnityEngine.Color[] values, System.Int32 count)
        /// </summary>
        /// public static bool SET_COLOR_ARRAY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetColorArray", "System.Int32", "UnityEngine.Color[]", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetColorArray(System.String name, System.Collections.Generic.List<UnityEngine.Color> values)
        /// </summary>
        /// public static bool SET_COLOR_ARRAY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetColorArray", "System.String", "System.Collections.Generic.List<UnityEngine.Color>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetColorArray(System.Int32 nameID, System.Collections.Generic.List<UnityEngine.Color> values)
        /// </summary>
        /// public static bool SET_COLOR_ARRAY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetColorArray", "System.Int32", "System.Collections.Generic.List<UnityEngine.Color>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetColorArray(System.String name, UnityEngine.Color[] values)
        /// </summary>
        /// public static bool SET_COLOR_ARRAY_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetColorArray", "System.String", "UnityEngine.Color[]");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetColorArray(System.Int32 nameID, UnityEngine.Color[] values)
        /// </summary>
        /// public static bool SET_COLOR_ARRAY_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetColorArray", "System.Int32", "UnityEngine.Color[]");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetConstantBuffer(System.String name, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size)
        /// </summary>
        /// public static bool SET_CONSTANT_BUFFER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetConstantBuffer", "System.String", "UnityEngine.ComputeBuffer", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetConstantBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size)
        /// </summary>
        /// public static bool SET_CONSTANT_BUFFER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetConstantBuffer", "System.Int32", "UnityEngine.ComputeBuffer", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetConstantBuffer(System.String name, UnityEngine.GraphicsBuffer value, System.Int32 offset, System.Int32 size)
        /// </summary>
        /// public static bool SET_CONSTANT_BUFFER_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetConstantBuffer", "System.String", "UnityEngine.GraphicsBuffer", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetConstantBuffer(System.Int32 nameID, UnityEngine.GraphicsBuffer value, System.Int32 offset, System.Int32 size)
        /// </summary>
        /// public static bool SET_CONSTANT_BUFFER_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetConstantBuffer", "System.Int32", "UnityEngine.GraphicsBuffer", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetFloat(System.String name, System.Single value)
        /// </summary>
        /// public static bool SET_FLOAT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetFloat", "System.String", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetFloat(System.Int32 nameID, System.Single value)
        /// </summary>
        /// public static bool SET_FLOAT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetFloat", "System.Int32", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetFloatArray(System.Int32 name, System.Single[] values, System.Int32 count)
        /// </summary>
        /// public static bool SET_FLOAT_ARRAY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetFloatArray", "System.Int32", "System.Single[]", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetFloatArray(System.String name, System.Collections.Generic.List<System.Single> values)
        /// </summary>
        /// public static bool SET_FLOAT_ARRAY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetFloatArray", "System.String", "System.Collections.Generic.List<System.Single>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetFloatArray(System.Int32 nameID, System.Collections.Generic.List<System.Single> values)
        /// </summary>
        /// public static bool SET_FLOAT_ARRAY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetFloatArray", "System.Int32", "System.Collections.Generic.List<System.Single>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetFloatArray(System.String name, System.Single[] values)
        /// </summary>
        /// public static bool SET_FLOAT_ARRAY_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetFloatArray", "System.String", "System.Single[]");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetFloatArray(System.Int32 nameID, System.Single[] values)
        /// </summary>
        /// public static bool SET_FLOAT_ARRAY_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetFloatArray", "System.Int32", "System.Single[]");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetInt(System.String name, System.Int32 value)
        /// </summary>
        /// public static bool SET_INT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetInt", "System.String", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetInt(System.Int32 nameID, System.Int32 value)
        /// </summary>
        /// public static bool SET_INT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetInt", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["UnityEngine.CoreModule.dll"."UnityEngine"."Material"]
    /// </summary>
    public partial class Material
    {



        /// const string Name_Func_SET_INTEGER = "SetInteger";
        /// <summary>
        ///   System.Void SetInteger(System.Int32 nameID,System.Int32 value)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_INTEGER (System.Int32 nameID,System.Int32 value);


        /// const string Name_Func_SET_INT_IMPL = "SetIntImpl";
        /// <summary>
        ///   System.Void SetIntImpl(System.Int32 name,System.Int32 value)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_INT_IMPL (System.Int32 name,System.Int32 value);


        /// const string Name_Func_SET_KEYWORD = "SetKeyword";
        /// <summary>
        ///   System.Void SetKeyword(UnityEngine.Rendering.LocalKeyword& keyword,System.Boolean value)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword&</param>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_KEYWORD (UnityEngine.Rendering.LocalKeyword& keyword,System.Boolean value);


        /// const string Name_Func_SET_LOCAL_KEYWORD = "SetLocalKeyword";
        /// <summary>
        ///   System.Void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword,System.Boolean value)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword</param>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_LOCAL_KEYWORD (UnityEngine.Rendering.LocalKeyword keyword,System.Boolean value);


        /// const string Name_Func_SET_LOCAL_KEYWORD_INJECTED = "SetLocalKeyword_Injected";
        /// <summary>
        ///   System.Void SetLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword& keyword,System.Boolean value)
        /// </summary>
        /// <param name="keyword">struct UnityEngine.Rendering.LocalKeyword&</param>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_LOCAL_KEYWORD_INJECTED (UnityEngine.Rendering.LocalKeyword& keyword,System.Boolean value);


        /// const string Name_Func_SET_MATRIX_ARRAY_IMPL = "SetMatrixArrayImpl";
        /// <summary>
        ///   System.Void SetMatrixArrayImpl(System.Int32 name,UnityEngine.Matrix4x4[] values,System.Int32 count)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class UnityEngine.Matrix4x4[]</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MATRIX_ARRAY_IMPL (System.Int32 name,nint values,System.Int32 count);


        /// const string Name_Func_SET_MATRIX_IMPL = "SetMatrixImpl";
        /// <summary>
        ///   System.Void SetMatrixImpl(System.Int32 name,UnityEngine.Matrix4x4 value)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">struct UnityEngine.Matrix4x4</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MATRIX_IMPL (System.Int32 name,UnityEngine.Matrix4x4 value);


        /// const string Name_Func_SET_MATRIX_IMPL_INJECTED = "SetMatrixImpl_Injected";
        /// <summary>
        ///   System.Void SetMatrixImpl_Injected(System.Int32 name,UnityEngine.Matrix4x4& value)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">struct UnityEngine.Matrix4x4&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MATRIX_IMPL_INJECTED (System.Int32 name,UnityEngine.Matrix4x4& value);


        /// const string Name_Func_SET_NAME = "SetName";
        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj,System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_NAME (nint obj,nint name);


        /// const string Name_Func_SET_OVERRIDE_TAG = "SetOverrideTag";
        /// <summary>
        ///   System.Void SetOverrideTag(System.String tag,System.String val)
        /// </summary>
        /// <param name="tag">class System.String</param>
        /// <param name="val">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_OVERRIDE_TAG (nint tag,nint val);


        /// const string Name_Func_SET_PASS = "SetPass";
        /// <summary>
        ///   System.Boolean SetPass(System.Int32 pass)
        /// </summary>
        /// <param name="pass">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean SET_PASS (System.Int32 pass);


        /// const string Name_Func_SET_RENDER_TEXTURE_IMPL = "SetRenderTextureImpl";
        /// <summary>
        ///   System.Void SetRenderTextureImpl(System.Int32 name,UnityEngine.RenderTexture value,UnityEngine.Rendering.RenderTextureSubElement element)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">class UnityEngine.RenderTexture</param>
        /// <param name="element">enum UnityEngine.Rendering.RenderTextureSubElement</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_RENDER_TEXTURE_IMPL (System.Int32 name,nint value,UnityEngine.Rendering.RenderTextureSubElement element);


        /// const string Name_Func_SET_SHADER_KEYWORDS = "SetShaderKeywords";
        /// <summary>
        ///   System.Void SetShaderKeywords(System.String[] names)
        /// </summary>
        /// <param name="names">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_SHADER_KEYWORDS (nint names);


        /// const string Name_Func_SET_SHADER_PASS_ENABLED = "SetShaderPassEnabled";
        /// <summary>
        ///   System.Void SetShaderPassEnabled(System.String passName,System.Boolean enabled)
        /// </summary>
        /// <param name="passName">class System.String</param>
        /// <param name="enabled">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_SHADER_PASS_ENABLED (nint passName,System.Boolean enabled);


        /// const string Name_Func_SET_TEXTURE_IMPL = "SetTextureImpl";
        /// <summary>
        ///   System.Void SetTextureImpl(System.Int32 name,UnityEngine.Texture value)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="value">class UnityEngine.Texture</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_IMPL (System.Int32 name,nint value);


        /// const string Name_Func_SET_TEXTURE_OFFSET_IMPL = "SetTextureOffsetImpl";
        /// <summary>
        ///   System.Void SetTextureOffsetImpl(System.Int32 name,UnityEngine.Vector2 offset)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="offset">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_OFFSET_IMPL (System.Int32 name,UnityEngine.Vector2 offset);


        /// const string Name_Func_SET_TEXTURE_OFFSET_IMPL_INJECTED = "SetTextureOffsetImpl_Injected";
        /// <summary>
        ///   System.Void SetTextureOffsetImpl_Injected(System.Int32 name,UnityEngine.Vector2& offset)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="offset">struct UnityEngine.Vector2&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_OFFSET_IMPL_INJECTED (System.Int32 name,UnityEngine.Vector2& offset);


        /// const string Name_Func_SET_TEXTURE_SCALE_IMPL = "SetTextureScaleImpl";
        /// <summary>
        ///   System.Void SetTextureScaleImpl(System.Int32 name,UnityEngine.Vector2 scale)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="scale">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_SCALE_IMPL (System.Int32 name,UnityEngine.Vector2 scale);


        /// const string Name_Func_SET_TEXTURE_SCALE_IMPL_INJECTED = "SetTextureScaleImpl_Injected";
        /// <summary>
        ///   System.Void SetTextureScaleImpl_Injected(System.Int32 name,UnityEngine.Vector2& scale)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="scale">struct UnityEngine.Vector2&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_SCALE_IMPL_INJECTED (System.Int32 name,UnityEngine.Vector2& scale);


        /// const string Name_Func_SET_VECTOR_ARRAY_IMPL = "SetVectorArrayImpl";
        /// <summary>
        ///   System.Void SetVectorArrayImpl(System.Int32 name,UnityEngine.Vector4[] values,System.Int32 count)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class UnityEngine.Vector4[]</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_VECTOR_ARRAY_IMPL (System.Int32 name,nint values,System.Int32 count);



        /// const string Name_Func_SET_MATRIX = "SetMatrix";
        /// <summary>
        ///   System.Void SetMatrix(System.String name,UnityEngine.Matrix4x4 value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct UnityEngine.Matrix4x4</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MATRIX_00 (nint name,UnityEngine.Matrix4x4 value);


        /// const string Name_Func_SET_MATRIX = "SetMatrix";
        /// <summary>
        ///   System.Void SetMatrix(System.Int32 nameID,UnityEngine.Matrix4x4 value)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">struct UnityEngine.Matrix4x4</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MATRIX_01 (System.Int32 nameID,UnityEngine.Matrix4x4 value);


        /// const string Name_Func_SET_MATRIX_ARRAY = "SetMatrixArray";
        /// <summary>
        ///   System.Void SetMatrixArray(System.Int32 name,UnityEngine.Matrix4x4[] values,System.Int32 count)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class UnityEngine.Matrix4x4[]</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MATRIX_ARRAY_00 (System.Int32 name,nint values,System.Int32 count);


        /// const string Name_Func_SET_MATRIX_ARRAY = "SetMatrixArray";
        /// <summary>
        ///   System.Void SetMatrixArray(System.String name,System.Collections.Generic.List<UnityEngine.Matrix4x4> values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MATRIX_ARRAY_01 (nint name,nint values);


        /// const string Name_Func_SET_MATRIX_ARRAY = "SetMatrixArray";
        /// <summary>
        ///   System.Void SetMatrixArray(System.Int32 nameID,System.Collections.Generic.List<UnityEngine.Matrix4x4> values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MATRIX_ARRAY_02 (System.Int32 nameID,nint values);


        /// const string Name_Func_SET_MATRIX_ARRAY = "SetMatrixArray";
        /// <summary>
        ///   System.Void SetMatrixArray(System.String name,UnityEngine.Matrix4x4[] values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class UnityEngine.Matrix4x4[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MATRIX_ARRAY_03 (nint name,nint values);


        /// const string Name_Func_SET_MATRIX_ARRAY = "SetMatrixArray";
        /// <summary>
        ///   System.Void SetMatrixArray(System.Int32 nameID,UnityEngine.Matrix4x4[] values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class UnityEngine.Matrix4x4[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MATRIX_ARRAY_04 (System.Int32 nameID,nint values);


        /// const string Name_Func_SET_TEXTURE = "SetTexture";
        /// <summary>
        ///   System.Void SetTexture(System.String name,UnityEngine.Texture value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">class UnityEngine.Texture</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_00 (nint name,nint value);


        /// const string Name_Func_SET_TEXTURE = "SetTexture";
        /// <summary>
        ///   System.Void SetTexture(System.Int32 nameID,UnityEngine.Texture value)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">class UnityEngine.Texture</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_01 (System.Int32 nameID,nint value);


        /// const string Name_Func_SET_TEXTURE = "SetTexture";
        /// <summary>
        ///   System.Void SetTexture(System.String name,UnityEngine.RenderTexture value,UnityEngine.Rendering.RenderTextureSubElement element)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">class UnityEngine.RenderTexture</param>
        /// <param name="element">enum UnityEngine.Rendering.RenderTextureSubElement</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_02 (nint name,nint value,UnityEngine.Rendering.RenderTextureSubElement element);


        /// const string Name_Func_SET_TEXTURE = "SetTexture";
        /// <summary>
        ///   System.Void SetTexture(System.Int32 nameID,UnityEngine.RenderTexture value,UnityEngine.Rendering.RenderTextureSubElement element)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">class UnityEngine.RenderTexture</param>
        /// <param name="element">enum UnityEngine.Rendering.RenderTextureSubElement</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_03 (System.Int32 nameID,nint value,UnityEngine.Rendering.RenderTextureSubElement element);


        /// const string Name_Func_SET_TEXTURE_OFFSET = "SetTextureOffset";
        /// <summary>
        ///   System.Void SetTextureOffset(System.String name,UnityEngine.Vector2 value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_OFFSET_00 (nint name,UnityEngine.Vector2 value);


        /// const string Name_Func_SET_TEXTURE_OFFSET = "SetTextureOffset";
        /// <summary>
        ///   System.Void SetTextureOffset(System.Int32 nameID,UnityEngine.Vector2 value)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_OFFSET_01 (System.Int32 nameID,UnityEngine.Vector2 value);


        /// const string Name_Func_SET_TEXTURE_SCALE = "SetTextureScale";
        /// <summary>
        ///   System.Void SetTextureScale(System.String name,UnityEngine.Vector2 value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_SCALE_00 (nint name,UnityEngine.Vector2 value);


        /// const string Name_Func_SET_TEXTURE_SCALE = "SetTextureScale";
        /// <summary>
        ///   System.Void SetTextureScale(System.Int32 nameID,UnityEngine.Vector2 value)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_TEXTURE_SCALE_01 (System.Int32 nameID,UnityEngine.Vector2 value);


        /// const string Name_Func_SET_VECTOR = "SetVector";
        /// <summary>
        ///   System.Void SetVector(System.String name,UnityEngine.Vector4 value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct UnityEngine.Vector4</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_VECTOR_00 (nint name,UnityEngine.Vector4 value);


        /// const string Name_Func_SET_VECTOR = "SetVector";
        /// <summary>
        ///   System.Void SetVector(System.Int32 nameID,UnityEngine.Vector4 value)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="value">struct UnityEngine.Vector4</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_VECTOR_01 (System.Int32 nameID,UnityEngine.Vector4 value);


        /// const string Name_Func_SET_VECTOR_ARRAY = "SetVectorArray";
        /// <summary>
        ///   System.Void SetVectorArray(System.Int32 name,UnityEngine.Vector4[] values,System.Int32 count)
        /// </summary>
        /// <param name="name">struct System.Int32</param>
        /// <param name="values">class UnityEngine.Vector4[]</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_VECTOR_ARRAY_00 (System.Int32 name,nint values,System.Int32 count);


        /// const string Name_Func_SET_VECTOR_ARRAY = "SetVectorArray";
        /// <summary>
        ///   System.Void SetVectorArray(System.String name,System.Collections.Generic.List<UnityEngine.Vector4> values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Vector4></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_VECTOR_ARRAY_01 (nint name,nint values);


        /// const string Name_Func_SET_VECTOR_ARRAY = "SetVectorArray";
        /// <summary>
        ///   System.Void SetVectorArray(System.Int32 nameID,System.Collections.Generic.List<UnityEngine.Vector4> values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class System.Collections.Generic.List<UnityEngine.Vector4></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_VECTOR_ARRAY_02 (System.Int32 nameID,nint values);


        /// const string Name_Func_SET_VECTOR_ARRAY = "SetVectorArray";
        /// <summary>
        ///   System.Void SetVectorArray(System.String name,UnityEngine.Vector4[] values)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="values">class UnityEngine.Vector4[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_VECTOR_ARRAY_03 (nint name,nint values);


        /// const string Name_Func_SET_VECTOR_ARRAY = "SetVectorArray";
        /// <summary>
        ///   System.Void SetVectorArray(System.Int32 nameID,UnityEngine.Vector4[] values)
        /// </summary>
        /// <param name="nameID">struct System.Int32</param>
        /// <param name="values">class UnityEngine.Vector4[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_VECTOR_ARRAY_04 (System.Int32 nameID,nint values);


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


        /// public static partial class Search_Material
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void SetMatrix(System.String name, UnityEngine.Matrix4x4 value)
        /// </summary>
        /// public static bool SET_MATRIX_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetMatrix", "System.String", "UnityEngine.Matrix4x4");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetMatrix(System.Int32 nameID, UnityEngine.Matrix4x4 value)
        /// </summary>
        /// public static bool SET_MATRIX_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetMatrix", "System.Int32", "UnityEngine.Matrix4x4");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetMatrixArray(System.Int32 name, UnityEngine.Matrix4x4[] values, System.Int32 count)
        /// </summary>
        /// public static bool SET_MATRIX_ARRAY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetMatrixArray", "System.Int32", "UnityEngine.Matrix4x4[]", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetMatrixArray(System.String name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values)
        /// </summary>
        /// public static bool SET_MATRIX_ARRAY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetMatrixArray", "System.String", "System.Collections.Generic.List<UnityEngine.Matrix4x4>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetMatrixArray(System.Int32 nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values)
        /// </summary>
        /// public static bool SET_MATRIX_ARRAY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetMatrixArray", "System.Int32", "System.Collections.Generic.List<UnityEngine.Matrix4x4>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetMatrixArray(System.String name, UnityEngine.Matrix4x4[] values)
        /// </summary>
        /// public static bool SET_MATRIX_ARRAY_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetMatrixArray", "System.String", "UnityEngine.Matrix4x4[]");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetMatrixArray(System.Int32 nameID, UnityEngine.Matrix4x4[] values)
        /// </summary>
        /// public static bool SET_MATRIX_ARRAY_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetMatrixArray", "System.Int32", "UnityEngine.Matrix4x4[]");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetTexture(System.String name, UnityEngine.Texture value)
        /// </summary>
        /// public static bool SET_TEXTURE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetTexture", "System.String", "UnityEngine.Texture");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetTexture(System.Int32 nameID, UnityEngine.Texture value)
        /// </summary>
        /// public static bool SET_TEXTURE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetTexture", "System.Int32", "UnityEngine.Texture");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetTexture(System.String name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
        /// </summary>
        /// public static bool SET_TEXTURE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetTexture", "System.String", "UnityEngine.RenderTexture", "UnityEngine.Rendering.RenderTextureSubElement");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetTexture(System.Int32 nameID, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
        /// </summary>
        /// public static bool SET_TEXTURE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetTexture", "System.Int32", "UnityEngine.RenderTexture", "UnityEngine.Rendering.RenderTextureSubElement");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetTextureOffset(System.String name, UnityEngine.Vector2 value)
        /// </summary>
        /// public static bool SET_TEXTURE_OFFSET_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetTextureOffset", "System.String", "UnityEngine.Vector2");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetTextureOffset(System.Int32 nameID, UnityEngine.Vector2 value)
        /// </summary>
        /// public static bool SET_TEXTURE_OFFSET_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetTextureOffset", "System.Int32", "UnityEngine.Vector2");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetTextureScale(System.String name, UnityEngine.Vector2 value)
        /// </summary>
        /// public static bool SET_TEXTURE_SCALE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetTextureScale", "System.String", "UnityEngine.Vector2");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetTextureScale(System.Int32 nameID, UnityEngine.Vector2 value)
        /// </summary>
        /// public static bool SET_TEXTURE_SCALE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetTextureScale", "System.Int32", "UnityEngine.Vector2");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetVector(System.String name, UnityEngine.Vector4 value)
        /// </summary>
        /// public static bool SET_VECTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVector", "System.String", "UnityEngine.Vector4");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetVector(System.Int32 nameID, UnityEngine.Vector4 value)
        /// </summary>
        /// public static bool SET_VECTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVector", "System.Int32", "UnityEngine.Vector4");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetVectorArray(System.Int32 name, UnityEngine.Vector4[] values, System.Int32 count)
        /// </summary>
        /// public static bool SET_VECTOR_ARRAY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVectorArray", "System.Int32", "UnityEngine.Vector4[]", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetVectorArray(System.String name, System.Collections.Generic.List<UnityEngine.Vector4> values)
        /// </summary>
        /// public static bool SET_VECTOR_ARRAY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVectorArray", "System.String", "System.Collections.Generic.List<UnityEngine.Vector4>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetVectorArray(System.Int32 nameID, System.Collections.Generic.List<UnityEngine.Vector4> values)
        /// </summary>
        /// public static bool SET_VECTOR_ARRAY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVectorArray", "System.Int32", "System.Collections.Generic.List<UnityEngine.Vector4>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetVectorArray(System.String name, UnityEngine.Vector4[] values)
        /// </summary>
        /// public static bool SET_VECTOR_ARRAY_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVectorArray", "System.String", "UnityEngine.Vector4[]");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetVectorArray(System.Int32 nameID, UnityEngine.Vector4[] values)
        /// </summary>
        /// public static bool SET_VECTOR_ARRAY_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVectorArray", "System.Int32", "UnityEngine.Vector4[]");
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
        /// 
        /// }

    }

}
