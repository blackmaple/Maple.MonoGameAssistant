using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.UnityCore.UnityEngine
{

    /// <summary>
    /// static class ["UnityEngine.ImageConversionModule.dll"."UnityEngine"."ImageConversion"]
    /// [System.Object]
    /// 
    /// </summary>
    // [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 73, 109, 97, 103, 101, 67, 111, 110, 118, 101, 114, 115, 105, 111, 110, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], 0x02000002U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 73, 109, 97, 103, 101, 67, 111, 110, 118, 101, 114, 115, 105, 111, 110, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101], [73, 109, 97, 103, 101, 67, 111, 110, 118, 101, 114, 115, 105, 111, 110])]
    public partial class ImageConversion
    {
        //public const string Const_ImageName = "UnityEngine.ImageConversionModule.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 73, 109, 97, 103, 101, 67, 111, 110, 118, 101, 114, 115, 105, 111, 110, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108];

        //public const string Const_Namespace = "UnityEngine";
        //public static byte[] Static_Namespace { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101];

        //public const string Const_ClassName = "ImageConversion";
        //public static byte[] Static_ClassName { get; } = [73, 109, 97, 103, 101, 67, 111, 110, 118, 101, 114, 115, 105, 111, 110];

        //public const uint Const_TypeToken = 0x02000002U;








        [StructLayout(LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_ImageConversion
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
        public readonly unsafe partial struct Ptr_ImageConversion(nint ptr)
        {

            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ImageConversion(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ImageConversion obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_ImageConversion AsRef()
            {
                return ref Unsafe.AsRef<Ref_ImageConversion>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["UnityEngine.ImageConversionModule.dll"."UnityEngine"."ImageConversion"]
    /// </summary>
    public partial class ImageConversion
    {
        /// <summary>
        /// static  System.Byte[] EncodeToPNG(UnityEngine.Texture2D tex)
        /// </summary>
        /// <param name="tex">class UnityEngine.Texture2D</param>
        /// <returns>class System.Byte[]</returns>
        //[MonoCollectorBaseAddress("UnityPlayer.dll", 0xAFFB90, RealTime = false, CallConvs = [typeof(CallConvCdecl)])]
        //static unsafe extern PMonoArray<byte> ENCODE_TO_PNG2(UnityEngine.Texture2D.Ptr_Texture2D tex);



        public const string Name_Func_ENCODE_TO_PNG = "EncodeToPNG";
        /// <summary>
        /// static  System.Byte[] EncodeToPNG(UnityEngine.Texture2D tex)
        /// </summary>
        /// <param name="tex">class UnityEngine.Texture2D</param>
        /// <returns>class System.Byte[]</returns>
        [MonoCollectorMethod(Name_Func_ENCODE_TO_PNG, CallConvs = [typeof(CallConvCdecl)])]
        static extern PMonoArray<byte> ENCODE_TO_PNG(UnityEngine.Texture2D.Ptr_Texture2D tex);



        /// const string Name_Func_ENCODE_TO_JPG = "EncodeToJPG";
        /// <summary>
        /// static  System.Byte[] EncodeToJPG(UnityEngine.Texture2D tex,System.Int32 quality)
        /// </summary>
        /// <param name="tex">class UnityEngine.Texture2D</param>
        /// <param name="quality">struct System.Int32</param>
        /// <returns>class System.Byte[]</returns>
        /// public static extern nint ENCODE_TO_JPG_00 (nint tex,System.Int32 quality);


        ///const string Name_Func_ENCODE_TO_JPG = "EncodeToJPG";
        /// <summary>
        /// static  System.Byte[] EncodeToJPG(UnityEngine.Texture2D tex)
        /// </summary>
        /// <param name="tex">class UnityEngine.Texture2D</param>
        /// <returns>class System.Byte[]</returns>
        ///[MonoCollectorMethod(Name_Func_ENCODE_TO_JPG, Search = typeof(Search_ImageConversion), CallConvs = [typeof(CallConvCdecl)])]
        /// static extern nint ENCODE_TO_JPG_01(nint tex);


        /// const string Name_Func_LOAD_IMAGE = "LoadImage";
        /// <summary>
        /// static  System.Boolean LoadImage(UnityEngine.Texture2D tex,System.Byte[] data,System.Boolean markNonReadable)
        /// </summary>
        /// <param name="tex">class UnityEngine.Texture2D</param>
        /// <param name="data">class System.Byte[]</param>
        /// <param name="markNonReadable">struct System.Boolean</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean LOAD_IMAGE_00 (nint tex,nint data,System.Boolean markNonReadable);


        /// const string Name_Func_LOAD_IMAGE = "LoadImage";
        /// <summary>
        /// static  System.Boolean LoadImage(UnityEngine.Texture2D tex,System.Byte[] data)
        /// </summary>
        /// <param name="tex">class UnityEngine.Texture2D</param>
        /// <param name="data">class System.Byte[]</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean LOAD_IMAGE_01 (nint tex,nint data);


        public static partial class Search_ImageConversion
        {
            /// 
            ///     

            /// <summary>
            /// static  System.Byte[] EncodeToJPG(UnityEngine.Texture2D tex, System.Int32 quality)
            /// </summary>
            /// public static bool ENCODE_TO_JPG_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncodeToJPG", "UnityEngine.Texture2D", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Byte[] EncodeToJPG(UnityEngine.Texture2D tex)
            /// </summary>
            public static bool ENCODE_TO_JPG_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncodeToJPG", "UnityEngine.Texture2D");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Boolean LoadImage(UnityEngine.Texture2D tex, System.Byte[] data, System.Boolean markNonReadable)
            /// </summary>
            /// public static bool LOAD_IMAGE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LoadImage", "UnityEngine.Texture2D", "System.Byte[]", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Boolean LoadImage(UnityEngine.Texture2D tex, System.Byte[] data)
            /// </summary>
            /// public static bool LOAD_IMAGE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LoadImage", "UnityEngine.Texture2D", "System.Byte[]");
            ///     
            ///  
            /// 
            /// 
        }

    }

    partial class ImageConversion(Maple.MonoGameAssistant.Core.MonoCollectorContext collectorContext, Maple.MonoGameAssistant.MonoCollector.MonoCollectorClassInfo classInfo) : Maple.MonoGameAssistant.Core.MonoCollectorMember(collectorContext, classInfo)
    {

        public Maple.MonoGameAssistant.UnityCore.UnityEngine.ImageConversion.Ptr_ImageConversion New(bool execDefCtor)
            => New<Maple.MonoGameAssistant.UnityCore.UnityEngine.ImageConversion.Ptr_ImageConversion>(execDefCtor);

        public Maple.MonoGameAssistant.UnityCore.UnityEngine.ImageConversion.Ptr_ImageConversion Ctor()
            => Ctor<Maple.MonoGameAssistant.UnityCore.UnityEngine.ImageConversion.Ptr_ImageConversion>();

        public Maple.MonoGameAssistant.UnityCore.UnityEngine.ImageConversion.Ptr_ImageConversion IsFrom(Maple.MonoGameAssistant.Core.PMonoObject pMonoObject)
            => IsFrom<Maple.MonoGameAssistant.UnityCore.UnityEngine.ImageConversion.Ptr_ImageConversion>(pMonoObject);

        public Maple.MonoGameAssistant.UnityCore.UnityEngine.ImageConversion.Ptr_ImageConversion IsFrom(nint pObj)
            => IsFrom<Maple.MonoGameAssistant.UnityCore.UnityEngine.ImageConversion.Ptr_ImageConversion>(pObj);




        readonly unsafe partial struct Ptr_Func_ENCODE_TO_PNG(nint ptr)
        {
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, Maple.MonoGameAssistant.Core.PMonoArray<byte>> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D, Maple.MonoGameAssistant.Core.PMonoArray<byte>>)ptr;

            public static implicit operator Ptr_Func_ENCODE_TO_PNG(nint ptr) => new(ptr);

            public override string ToString()
            {
                return ((nint)((void*)_func)).ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public Maple.MonoGameAssistant.Core.PMonoArray<byte> Invoke(Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D tex) => _func(tex);
        }

        static Ptr_Func_ENCODE_TO_PNG Func_ENCODE_TO_PNG;

        readonly unsafe partial struct Ptr_ImageConversion
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static Maple.MonoGameAssistant.Core.PMonoArray<byte> ENCODE_TO_PNG(Maple.MonoGameAssistant.UnityCore.UnityEngine.Texture2D.Ptr_Texture2D tex) => Func_ENCODE_TO_PNG.Invoke(tex);
        }




        protected sealed override void InitMember()
        {

            Func_ENCODE_TO_PNG = GetMethodPointer("EncodeToPNG");


        }


    }


    partial class ImageConversion
    {
        public static void Set_Func_ENCODE_TO_PNG(nint addr) => Func_ENCODE_TO_PNG = addr;
    }
}
