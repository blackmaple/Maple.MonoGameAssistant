using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public struct REF_MONO_VECTOR2INT
    {
        /// const string Name_Field_m_X = "m_X";
        /// <summary>
        /// struct 0x10 System.Int32 m_X
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.Int32 m_X;


        /// const string Name_Field_m_Y = "m_Y";
        /// <summary>
        /// struct 0x14 System.Int32 m_Y
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
        public readonly System.Int32 m_Y;

    }
}
