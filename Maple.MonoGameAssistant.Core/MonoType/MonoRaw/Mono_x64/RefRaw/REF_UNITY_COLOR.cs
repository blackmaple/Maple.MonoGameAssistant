using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.RawDotNet
{
    [StructLayout(LayoutKind.Sequential)]
    public struct REF_UNITY_COLOR
    {
        /// const string Name_Field_r = "r";
        /// <summary>
        /// struct 0x8 System.Single r
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public System.Single r;


        /// const string Name_Field_g = "g";
        /// <summary>
        /// struct 0xC System.Single g
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
        public System.Single g;


        /// const string Name_Field_b = "b";
        /// <summary>
        /// struct 0x10 System.Single b
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
        public System.Single b;


        /// const string Name_Field_a = "a";
        /// <summary>
        /// struct 0x14 System.Single a
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0xC)]
        public System.Single a;
    }
}
