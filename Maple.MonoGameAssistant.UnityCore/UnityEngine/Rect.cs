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
    /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Rect"]
    /// 
    /// [System.IEquatable<UnityEngine.Rect>]=>[System.IFormattable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], 0x02000072U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101], [82, 101, 99, 116])]
    public partial class Rect
    {
        //public const string Const_ImageName = "UnityEngine.CoreModule.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108];

        //public const string Const_Namespace = "UnityEngine";
        //public static byte[] Static_Namespace { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101];

        //public const string Const_ClassName = "Rect";
        //public static byte[] Static_ClassName { get; } = [82, 101, 99, 116];

        //public const uint Const_TypeToken = 0x02000072U;








        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct Ref_Rect
        {





            /// <summary>
            /// struct 0x10 System.Single m_XMin
            /// </summary>
            //[FieldOffset(0x0)]
            [MarshalAs( UnmanagedType.R4)]
            public System.Single m_XMin;


            /// <summary>
            /// struct 0x14 System.Single m_YMin
            /// </summary>
            //[FieldOffset(0x4)]
            [MarshalAs(UnmanagedType.R4)]
            public System.Single m_YMin;


            /// <summary>
            /// struct 0x18 System.Single m_Width
            /// </summary>
            // [FieldOffset(0x8)]
            [MarshalAs(UnmanagedType.R4)]
            public System.Single m_Width;


            /// <summary>
            /// struct 0x1C System.Single m_Height
            /// </summary>
            //[FieldOffset(0xC)]
            [MarshalAs(UnmanagedType.R4)]
            public System.Single m_Height;

        }
        [StructLayout(LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Rect(nint ptr)
        {

            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Rect(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Rect obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_Rect AsRef()
            {
                return ref Unsafe.AsRef<Ref_Rect>(_ptr.ToPointer());
            }
        }

    }

}
