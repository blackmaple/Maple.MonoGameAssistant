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
    /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Sprite"]
    /// [UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], 0x0200014FU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101], [83, 112, 114, 105, 116, 101])]
    //[Maple.MonoGameAssistant.Core.MonoCollectorSearchField<Ptr_Sprite>("_vtable", "VTable", IsReadOnly = false)]
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSearchField(typeof(Ptr_Sprite), "_synchronisation", "Synchronisation", true)]
    public partial class Sprite
    {
        //public const string Const_ImageName = "UnityEngine.CoreModule.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108];

        //public const string Const_Namespace = "UnityEngine";
        //public static byte[] Static_Namespace { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101];

        //public const string Const_ClassName = "Sprite";
        //public static byte[] Static_ClassName { get; } = [83, 112, 114, 105, 116, 101];

        //public const uint Const_TypeToken = 0x0200014FU;




        public readonly unsafe partial struct Const_Sprite
        {



            /// <summary>
            /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
            /// </summary>
            /// public nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";


            /// <summary>
            /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
            /// </summary>
            /// public nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";

        }


        [StructLayout(LayoutKind.Explicit)]
        public readonly unsafe partial struct Static_Sprite
        {



            /// <summary>
            /// struct 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// </summary>
            [FieldOffset(0x0)]
            public readonly System.Int32 OffsetOfInstanceIDInCPlusPlusObject;

        }


        [StructLayout(LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_Sprite
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



            /// <summary>
            /// struct 0x10 System.IntPtr m_CachedPtr
            /// </summary>
            [FieldOffset(0x10)]
            public readonly System.IntPtr m_CachedPtr;

        }
        [StructLayout(LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Sprite(nint ptr)
        {

            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Sprite(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Sprite obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");

            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_Sprite AsRef()
            {
                return ref Unsafe.AsRef<Ref_Sprite>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["UnityEngine.CoreModule.dll"."UnityEngine"."Sprite"]
    /// </summary>
    public partial class Sprite
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


        /// const string Name_Func_CREATE_SPRITE = "CreateSprite";
        /// <summary>
        /// static  UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit,System.UInt32 extrude,UnityEngine.SpriteMeshType meshType,UnityEngine.Vector4 border,System.Boolean generateFallbackPhysicsShape)
        /// </summary>
        /// <param name="texture">class UnityEngine.Texture2D</param>
        /// <param name="rect">struct UnityEngine.Rect</param>
        /// <param name="pivot">struct UnityEngine.Vector2</param>
        /// <param name="pixelsPerUnit">struct System.Single</param>
        /// <param name="extrude">struct System.UInt32</param>
        /// <param name="meshType">enum UnityEngine.SpriteMeshType</param>
        /// <param name="border">struct UnityEngine.Vector4</param>
        /// <param name="generateFallbackPhysicsShape">struct System.Boolean</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_SPRITE (nint texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit,System.UInt32 extrude,UnityEngine.SpriteMeshType meshType,UnityEngine.Vector4 border,System.Boolean generateFallbackPhysicsShape);


        /// const string Name_Func_CREATE_SPRITE_INJECTED = "CreateSprite_Injected";
        /// <summary>
        /// static  UnityEngine.Sprite CreateSprite_Injected(UnityEngine.Texture2D texture,UnityEngine.Rect& rect,UnityEngine.Vector2& pivot,System.Single pixelsPerUnit,System.UInt32 extrude,UnityEngine.SpriteMeshType meshType,UnityEngine.Vector4& border,System.Boolean generateFallbackPhysicsShape)
        /// </summary>
        /// <param name="texture">class UnityEngine.Texture2D</param>
        /// <param name="rect">struct UnityEngine.Rect&</param>
        /// <param name="pivot">struct UnityEngine.Vector2&</param>
        /// <param name="pixelsPerUnit">struct System.Single</param>
        /// <param name="extrude">struct System.UInt32</param>
        /// <param name="meshType">enum UnityEngine.SpriteMeshType</param>
        /// <param name="border">struct UnityEngine.Vector4&</param>
        /// <param name="generateFallbackPhysicsShape">struct System.Boolean</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_SPRITE_INJECTED (nint texture,UnityEngine.Rect& rect,UnityEngine.Vector2& pivot,System.Single pixelsPerUnit,System.UInt32 extrude,UnityEngine.SpriteMeshType meshType,UnityEngine.Vector4& border,System.Boolean generateFallbackPhysicsShape);


        /// const string Name_Func_CREATE_SPRITE_WITHOUT_TEXTURE_SCRIPTING = "CreateSpriteWithoutTextureScripting";
        /// <summary>
        /// static  UnityEngine.Sprite CreateSpriteWithoutTextureScripting(UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsToUnits,UnityEngine.Texture2D texture)
        /// </summary>
        /// <param name="rect">struct UnityEngine.Rect</param>
        /// <param name="pivot">struct UnityEngine.Vector2</param>
        /// <param name="pixelsToUnits">struct System.Single</param>
        /// <param name="texture">class UnityEngine.Texture2D</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_SPRITE_WITHOUT_TEXTURE_SCRIPTING (UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsToUnits,nint texture);


        /// const string Name_Func_CREATE_SPRITE_WITHOUT_TEXTURE_SCRIPTING_INJECTED = "CreateSpriteWithoutTextureScripting_Injected";
        /// <summary>
        /// static  UnityEngine.Sprite CreateSpriteWithoutTextureScripting_Injected(UnityEngine.Rect& rect,UnityEngine.Vector2& pivot,System.Single pixelsToUnits,UnityEngine.Texture2D texture)
        /// </summary>
        /// <param name="rect">struct UnityEngine.Rect&</param>
        /// <param name="pivot">struct UnityEngine.Vector2&</param>
        /// <param name="pixelsToUnits">struct System.Single</param>
        /// <param name="texture">class UnityEngine.Texture2D</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_SPRITE_WITHOUT_TEXTURE_SCRIPTING_INJECTED (UnityEngine.Rect& rect,UnityEngine.Vector2& pivot,System.Single pixelsToUnits,nint texture);


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


        /// const string Name_Func_GET_ASSOCIATED_ALPHA_SPLIT_TEXTURE = "get_associatedAlphaSplitTexture";
        /// <summary>
        ///   UnityEngine.Texture2D get_associatedAlphaSplitTexture()
        /// </summary>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// public  extern nint GET_ASSOCIATED_ALPHA_SPLIT_TEXTURE ();


        /// const string Name_Func_GET_BORDER = "get_border";
        /// <summary>
        ///   UnityEngine.Vector4 get_border()
        /// </summary>
        /// <returns>struct UnityEngine.Vector4</returns>
        /// public  extern UnityEngine.Vector4 GET_BORDER ();


        /// const string Name_Func_GET_BORDER_INJECTED = "get_border_Injected";
        /// <summary>
        ///   System.Void get_border_Injected(UnityEngine.Vector4& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector4&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_BORDER_INJECTED (UnityEngine.Vector4& ret);


        /// const string Name_Func_GET_BOUNDS = "get_bounds";
        /// <summary>
        ///   UnityEngine.Bounds get_bounds()
        /// </summary>
        /// <returns>struct UnityEngine.Bounds</returns>
        /// public  extern UnityEngine.Bounds GET_BOUNDS ();


        /// const string Name_Func_GET_BOUNDS_INJECTED = "get_bounds_Injected";
        /// <summary>
        ///   System.Void get_bounds_Injected(UnityEngine.Bounds& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Bounds&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_BOUNDS_INJECTED (UnityEngine.Bounds& ret);


        /// const string Name_Func_GET_HIDE_FLAGS = "get_hideFlags";
        /// <summary>
        ///   UnityEngine.HideFlags get_hideFlags()
        /// </summary>
        /// <returns>enum UnityEngine.HideFlags</returns>
        /// public  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();


        /// const string Name_Func_GET_NAME = "get_name";
        /// <summary>
        ///   System.String get_name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_NAME ();


        /// const string Name_Func_GET_PACKED = "get_packed";
        /// <summary>
        ///   System.Boolean get_packed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_PACKED ();


        /// const string Name_Func_GET_PACKING_MODE = "get_packingMode";
        /// <summary>
        ///   UnityEngine.SpritePackingMode get_packingMode()
        /// </summary>
        /// <returns>enum UnityEngine.SpritePackingMode</returns>
        /// public  extern UnityEngine.SpritePackingMode GET_PACKING_MODE ();


        /// const string Name_Func_GET_PACKING_ROTATION = "get_packingRotation";
        /// <summary>
        ///   UnityEngine.SpritePackingRotation get_packingRotation()
        /// </summary>
        /// <returns>enum UnityEngine.SpritePackingRotation</returns>
        /// public  extern UnityEngine.SpritePackingRotation GET_PACKING_ROTATION ();


        /// const string Name_Func_GET_PIVOT = "get_pivot";
        /// <summary>
        ///   UnityEngine.Vector2 get_pivot()
        /// </summary>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// public  extern UnityEngine.Vector2 GET_PIVOT ();


        /// const string Name_Func_GET_PIVOT_INJECTED = "get_pivot_Injected";
        /// <summary>
        ///   System.Void get_pivot_Injected(UnityEngine.Vector2& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector2&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_PIVOT_INJECTED (UnityEngine.Vector2& ret);


        /// const string Name_Func_GET_PIXELS_PER_UNIT = "get_pixelsPerUnit";
        /// <summary>
        ///   System.Single get_pixelsPerUnit()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single GET_PIXELS_PER_UNIT ();


        ///const string Name_Func_GET_RECT = "get_rect";
        /// <summary>
        ///   UnityEngine.Rect get_rect()
        /// </summary>
        /// <returns>struct UnityEngine.Rect</returns>
        ///[MonoCollectorMethod(Name_Func_GET_RECT)]
        ///public extern UnityEngine.Rect.Ptr_Rect GET_RECT(out UnityEngine.Rect.Ref_Rect rect);


        ///const string Name_Func_GET_RECT_INJECTED = "get_rect_Injected";
        /// <summary>
        ///   System.Void get_rect_Injected(UnityEngine.Rect& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Rect&</param>
        /// <returns>struct System.Void</returns>
        ///[MonoCollectorMethod(Name_Func_GET_RECT_INJECTED)]
        ///public static extern void GET_RECT_INJECTED(Ptr_Sprite ptr_Sprite, out UnityEngine.Rect.Ref_Rect ret);


        /// const string Name_Func_GET_SPRITE_ATLAS_TEXTURE_SCALE = "get_spriteAtlasTextureScale";
        /// <summary>
        ///   System.Single get_spriteAtlasTextureScale()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single GET_SPRITE_ATLAS_TEXTURE_SCALE ();


        const string Name_Func_GET_TEXTURE = "get_texture";
        /// <summary>
        ///   UnityEngine.Texture2D get_texture()
        /// </summary>
        /// <returns>class UnityEngine.Texture2D</returns>
        [MonoCollectorMethod(Name_Func_GET_TEXTURE)]
        public extern UnityEngine.Texture2D.Ptr_Texture2D GET_TEXTURE();


        /// const string Name_Func_GET_TEXTURE_RECT = "get_textureRect";
        /// <summary>
        ///   UnityEngine.Rect get_textureRect()
        /// </summary>
        /// <returns>struct UnityEngine.Rect</returns>
        /// public  extern UnityEngine.Rect GET_TEXTURE_RECT ();


        /// const string Name_Func_GET_TEXTURE_RECT_OFFSET = "get_textureRectOffset";
        /// <summary>
        ///   UnityEngine.Vector2 get_textureRectOffset()
        /// </summary>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// public  extern UnityEngine.Vector2 GET_TEXTURE_RECT_OFFSET ();


        /// const string Name_Func_GET_TRIANGLES = "get_triangles";
        /// <summary>
        ///   System.UInt16[] get_triangles()
        /// </summary>
        /// <returns>class System.UInt16[]</returns>
        /// public  extern nint GET_TRIANGLES ();


        /// const string Name_Func_GET_UV = "get_uv";
        /// <summary>
        ///   UnityEngine.Vector2[] get_uv()
        /// </summary>
        /// <returns>class UnityEngine.Vector2[]</returns>
        /// public  extern nint GET_UV ();


        /// const string Name_Func_GET_VERTICES = "get_vertices";
        /// <summary>
        ///   UnityEngine.Vector2[] get_vertices()
        /// </summary>
        /// <returns>class UnityEngine.Vector2[]</returns>
        /// public  extern nint GET_VERTICES ();


        /// const string Name_Func_GET_CACHED_PTR = "GetCachedPtr";
        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// public  extern System.IntPtr GET_CACHED_PTR ();


        /// const string Name_Func_GET_HASH_CODE = "GetHashCode";
        /// <summary>
        ///   System.Int32 GetHashCode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_HASH_CODE ();


        /// const string Name_Func_GET_INNER_U_VS = "GetInnerUVs";
        /// <summary>
        ///   UnityEngine.Vector4 GetInnerUVs()
        /// </summary>
        /// <returns>struct UnityEngine.Vector4</returns>
        /// public  extern UnityEngine.Vector4 GET_INNER_U_VS ();


        /// const string Name_Func_GET_INNER_U_VS_INJECTED = "GetInnerUVs_Injected";
        /// <summary>
        ///   System.Void GetInnerUVs_Injected(UnityEngine.Vector4& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector4&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_INNER_U_VS_INJECTED (UnityEngine.Vector4& ret);


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


        /// const string Name_Func_GET_OUTER_U_VS = "GetOuterUVs";
        /// <summary>
        ///   UnityEngine.Vector4 GetOuterUVs()
        /// </summary>
        /// <returns>struct UnityEngine.Vector4</returns>
        /// public  extern UnityEngine.Vector4 GET_OUTER_U_VS ();


        /// const string Name_Func_GET_OUTER_U_VS_INJECTED = "GetOuterUVs_Injected";
        /// <summary>
        ///   System.Void GetOuterUVs_Injected(UnityEngine.Vector4& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector4&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_OUTER_U_VS_INJECTED (UnityEngine.Vector4& ret);


        /// const string Name_Func_GET_PACKED = "GetPacked";
        /// <summary>
        ///   System.Int32 GetPacked()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_PACKED ();


        /// const string Name_Func_GET_PACKING_MODE = "GetPackingMode";
        /// <summary>
        ///   System.Int32 GetPackingMode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_PACKING_MODE ();


        /// const string Name_Func_GET_PACKING_ROTATION = "GetPackingRotation";
        /// <summary>
        ///   System.Int32 GetPackingRotation()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_PACKING_ROTATION ();


        /// const string Name_Func_GET_PADDING = "GetPadding";
        /// <summary>
        ///   UnityEngine.Vector4 GetPadding()
        /// </summary>
        /// <returns>struct UnityEngine.Vector4</returns>
        /// public  extern UnityEngine.Vector4 GET_PADDING ();


        /// const string Name_Func_GET_PADDING_INJECTED = "GetPadding_Injected";
        /// <summary>
        ///   System.Void GetPadding_Injected(UnityEngine.Vector4& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector4&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_PADDING_INJECTED (UnityEngine.Vector4& ret);


        /// const string Name_Func_GET_PHYSICS_SHAPE = "GetPhysicsShape";
        /// <summary>
        ///   System.Int32 GetPhysicsShape(System.Int32 shapeIdx,System.Collections.Generic.List<UnityEngine.Vector2> physicsShape)
        /// </summary>
        /// <param name="shapeIdx">struct System.Int32</param>
        /// <param name="physicsShape">class System.Collections.Generic.List<UnityEngine.Vector2></param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_PHYSICS_SHAPE (System.Int32 shapeIdx,nint physicsShape);


        /// const string Name_Func_GET_PHYSICS_SHAPE_COUNT = "GetPhysicsShapeCount";
        /// <summary>
        ///   System.Int32 GetPhysicsShapeCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_PHYSICS_SHAPE_COUNT ();


        /// const string Name_Func_GET_PHYSICS_SHAPE_IMPL = "GetPhysicsShapeImpl";
        /// <summary>
        /// static  System.Void GetPhysicsShapeImpl(UnityEngine.Sprite sprite,System.Int32 shapeIdx,System.Collections.Generic.List<UnityEngine.Vector2> physicsShape)
        /// </summary>
        /// <param name="sprite">class UnityEngine.Sprite</param>
        /// <param name="shapeIdx">struct System.Int32</param>
        /// <param name="physicsShape">class System.Collections.Generic.List<UnityEngine.Vector2></param>
        /// <returns>struct System.Void</returns>
        /// public static extern void GET_PHYSICS_SHAPE_IMPL (nint sprite,System.Int32 shapeIdx,nint physicsShape);


        /// const string Name_Func_GET_PHYSICS_SHAPE_POINT_COUNT = "GetPhysicsShapePointCount";
        /// <summary>
        ///   System.Int32 GetPhysicsShapePointCount(System.Int32 shapeIdx)
        /// </summary>
        /// <param name="shapeIdx">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_PHYSICS_SHAPE_POINT_COUNT (System.Int32 shapeIdx);


        /// const string Name_Func_GET_SECONDARY_TEXTURE = "GetSecondaryTexture";
        /// <summary>
        ///   UnityEngine.Texture2D GetSecondaryTexture(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// public  extern nint GET_SECONDARY_TEXTURE (System.Int32 index);


        /// const string Name_Func_GET_TEXTURE_RECT = "GetTextureRect";
        /// <summary>
        ///   UnityEngine.Rect GetTextureRect()
        /// </summary>
        /// <returns>struct UnityEngine.Rect</returns>
        /// public  extern UnityEngine.Rect GET_TEXTURE_RECT ();


        /// const string Name_Func_GET_TEXTURE_RECT_INJECTED = "GetTextureRect_Injected";
        /// <summary>
        ///   System.Void GetTextureRect_Injected(UnityEngine.Rect& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Rect&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_TEXTURE_RECT_INJECTED (UnityEngine.Rect& ret);


        /// const string Name_Func_GET_TEXTURE_RECT_OFFSET = "GetTextureRectOffset";
        /// <summary>
        ///   UnityEngine.Vector2 GetTextureRectOffset()
        /// </summary>
        /// <returns>struct UnityEngine.Vector2</returns>
        /// public  extern UnityEngine.Vector2 GET_TEXTURE_RECT_OFFSET ();


        /// const string Name_Func_GET_TEXTURE_RECT_OFFSET_INJECTED = "GetTextureRectOffset_Injected";
        /// <summary>
        ///   System.Void GetTextureRectOffset_Injected(UnityEngine.Vector2& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector2&</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_TEXTURE_RECT_OFFSET_INJECTED (UnityEngine.Vector2& ret);


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


        /// const string Name_Func_INTERNAL_GET_PHYSICS_SHAPE_POINT_COUNT = "Internal_GetPhysicsShapePointCount";
        /// <summary>
        ///   System.Int32 Internal_GetPhysicsShapePointCount(System.Int32 shapeIdx)
        /// </summary>
        /// <param name="shapeIdx">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 INTERNAL_GET_PHYSICS_SHAPE_POINT_COUNT (System.Int32 shapeIdx);


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


        /// const string Name_Func_OVERRIDE_GEOMETRY = "OverrideGeometry";
        /// <summary>
        ///   System.Void OverrideGeometry(UnityEngine.Vector2[] vertices,System.UInt16[] triangles)
        /// </summary>
        /// <param name="vertices">class UnityEngine.Vector2[]</param>
        /// <param name="triangles">class System.UInt16[]</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void OVERRIDE_GEOMETRY (nint vertices,nint triangles);


        /// const string Name_Func_OVERRIDE_PHYSICS_SHAPE_COUNT = "OverridePhysicsShapeCount";
        /// <summary>
        /// static  System.Void OverridePhysicsShapeCount(UnityEngine.Sprite sprite,System.Int32 physicsShapeCount)
        /// </summary>
        /// <param name="sprite">class UnityEngine.Sprite</param>
        /// <param name="physicsShapeCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void OVERRIDE_PHYSICS_SHAPE_COUNT (nint sprite,System.Int32 physicsShapeCount);


        /// const string Name_Func_SET_HIDE_FLAGS = "set_hideFlags";
        /// <summary>
        ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
        /// </summary>
        /// <param name="value">enum UnityEngine.HideFlags</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);


        /// const string Name_Func_SET_NAME = "set_name";
        /// <summary>
        ///   System.Void set_name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_NAME (nint value);


        /// const string Name_Func_SET_NAME = "SetName";
        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj,System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_NAME (nint obj,nint name);



        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_00 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_01 ();


        /// const string Name_Func_CREATE = "Create";
        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsToUnits,UnityEngine.Texture2D texture)
        /// </summary>
        /// <param name="rect">struct UnityEngine.Rect</param>
        /// <param name="pivot">struct UnityEngine.Vector2</param>
        /// <param name="pixelsToUnits">struct System.Single</param>
        /// <param name="texture">class UnityEngine.Texture2D</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_00 (UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsToUnits,nint texture);


        /// const string Name_Func_CREATE = "Create";
        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsToUnits)
        /// </summary>
        /// <param name="rect">struct UnityEngine.Rect</param>
        /// <param name="pivot">struct UnityEngine.Vector2</param>
        /// <param name="pixelsToUnits">struct System.Single</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_01 (UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsToUnits);


        /// const string Name_Func_CREATE = "Create";
        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit,System.UInt32 extrude,UnityEngine.SpriteMeshType meshType,UnityEngine.Vector4 border,System.Boolean generateFallbackPhysicsShape)
        /// </summary>
        /// <param name="texture">class UnityEngine.Texture2D</param>
        /// <param name="rect">struct UnityEngine.Rect</param>
        /// <param name="pivot">struct UnityEngine.Vector2</param>
        /// <param name="pixelsPerUnit">struct System.Single</param>
        /// <param name="extrude">struct System.UInt32</param>
        /// <param name="meshType">enum UnityEngine.SpriteMeshType</param>
        /// <param name="border">struct UnityEngine.Vector4</param>
        /// <param name="generateFallbackPhysicsShape">struct System.Boolean</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_02 (nint texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit,System.UInt32 extrude,UnityEngine.SpriteMeshType meshType,UnityEngine.Vector4 border,System.Boolean generateFallbackPhysicsShape);


        /// const string Name_Func_CREATE = "Create";
        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit,System.UInt32 extrude,UnityEngine.SpriteMeshType meshType,UnityEngine.Vector4 border)
        /// </summary>
        /// <param name="texture">class UnityEngine.Texture2D</param>
        /// <param name="rect">struct UnityEngine.Rect</param>
        /// <param name="pivot">struct UnityEngine.Vector2</param>
        /// <param name="pixelsPerUnit">struct System.Single</param>
        /// <param name="extrude">struct System.UInt32</param>
        /// <param name="meshType">enum UnityEngine.SpriteMeshType</param>
        /// <param name="border">struct UnityEngine.Vector4</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_03 (nint texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit,System.UInt32 extrude,UnityEngine.SpriteMeshType meshType,UnityEngine.Vector4 border);


        /// const string Name_Func_CREATE = "Create";
        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit,System.UInt32 extrude,UnityEngine.SpriteMeshType meshType)
        /// </summary>
        /// <param name="texture">class UnityEngine.Texture2D</param>
        /// <param name="rect">struct UnityEngine.Rect</param>
        /// <param name="pivot">struct UnityEngine.Vector2</param>
        /// <param name="pixelsPerUnit">struct System.Single</param>
        /// <param name="extrude">struct System.UInt32</param>
        /// <param name="meshType">enum UnityEngine.SpriteMeshType</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_04 (nint texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit,System.UInt32 extrude,UnityEngine.SpriteMeshType meshType);


        /// const string Name_Func_CREATE = "Create";
        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit,System.UInt32 extrude)
        /// </summary>
        /// <param name="texture">class UnityEngine.Texture2D</param>
        /// <param name="rect">struct UnityEngine.Rect</param>
        /// <param name="pivot">struct UnityEngine.Vector2</param>
        /// <param name="pixelsPerUnit">struct System.Single</param>
        /// <param name="extrude">struct System.UInt32</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_05 (nint texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit,System.UInt32 extrude);


        /// const string Name_Func_CREATE = "Create";
        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit)
        /// </summary>
        /// <param name="texture">class UnityEngine.Texture2D</param>
        /// <param name="rect">struct UnityEngine.Rect</param>
        /// <param name="pivot">struct UnityEngine.Vector2</param>
        /// <param name="pixelsPerUnit">struct System.Single</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_06 (nint texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot,System.Single pixelsPerUnit);


        /// const string Name_Func_CREATE = "Create";
        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot)
        /// </summary>
        /// <param name="texture">class UnityEngine.Texture2D</param>
        /// <param name="rect">struct UnityEngine.Rect</param>
        /// <param name="pivot">struct UnityEngine.Vector2</param>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public static extern nint CREATE_07 (nint texture,UnityEngine.Rect rect,UnityEngine.Vector2 pivot);


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


        /// const string Name_Func_OVERRIDE_PHYSICS_SHAPE = "OverridePhysicsShape";
        /// <summary>
        ///   System.Void OverridePhysicsShape(System.Collections.Generic.IList<UnityEngine.Vector2[]> physicsShapes)
        /// </summary>
        /// <param name="physicsShapes">interface System.Collections.Generic.IList<UnityEngine.Vector2[]></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void OVERRIDE_PHYSICS_SHAPE_00 (nint physicsShapes);


        /// const string Name_Func_OVERRIDE_PHYSICS_SHAPE = "OverridePhysicsShape";
        /// <summary>
        /// static  System.Void OverridePhysicsShape(UnityEngine.Sprite sprite,UnityEngine.Vector2[] physicsShape,System.Int32 idx)
        /// </summary>
        /// <param name="sprite">class UnityEngine.Sprite</param>
        /// <param name="physicsShape">class UnityEngine.Vector2[]</param>
        /// <param name="idx">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void OVERRIDE_PHYSICS_SHAPE_01 (nint sprite,nint physicsShape,System.Int32 idx);


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


        /// public static partial class Search_Sprite
        /// {
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
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits, UnityEngine.Texture2D texture)
        /// </summary>
        /// public static bool CREATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Create", "UnityEngine.Rect", "UnityEngine.Vector2", "System.Single", "UnityEngine.Texture2D");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits)
        /// </summary>
        /// public static bool CREATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Create", "UnityEngine.Rect", "UnityEngine.Vector2", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, System.Boolean generateFallbackPhysicsShape)
        /// </summary>
        /// public static bool CREATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Create", "UnityEngine.Texture2D", "UnityEngine.Rect", "UnityEngine.Vector2", "System.Single", "System.UInt32", "UnityEngine.SpriteMeshType", "UnityEngine.Vector4", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border)
        /// </summary>
        /// public static bool CREATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Create", "UnityEngine.Texture2D", "UnityEngine.Rect", "UnityEngine.Vector2", "System.Single", "System.UInt32", "UnityEngine.SpriteMeshType", "UnityEngine.Vector4");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType)
        /// </summary>
        /// public static bool CREATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Create", "UnityEngine.Texture2D", "UnityEngine.Rect", "UnityEngine.Vector2", "System.Single", "System.UInt32", "UnityEngine.SpriteMeshType");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude)
        /// </summary>
        /// public static bool CREATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Create", "UnityEngine.Texture2D", "UnityEngine.Rect", "UnityEngine.Vector2", "System.Single", "System.UInt32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit)
        /// </summary>
        /// public static bool CREATE_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Create", "UnityEngine.Texture2D", "UnityEngine.Rect", "UnityEngine.Vector2", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot)
        /// </summary>
        /// public static bool CREATE_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Create", "UnityEngine.Texture2D", "UnityEngine.Rect", "UnityEngine.Vector2");
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
        ///   System.Void OverridePhysicsShape(System.Collections.Generic.IList<UnityEngine.Vector2[]> physicsShapes)
        /// </summary>
        /// public static bool OVERRIDE_PHYSICS_SHAPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OverridePhysicsShape", "System.Collections.Generic.IList<UnityEngine.Vector2[]>");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void OverridePhysicsShape(UnityEngine.Sprite sprite, UnityEngine.Vector2[] physicsShape, System.Int32 idx)
        /// </summary>
        /// public static bool OVERRIDE_PHYSICS_SHAPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OverridePhysicsShape", "UnityEngine.Sprite", "UnityEngine.Vector2[]", "System.Int32");
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
