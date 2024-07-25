using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct Ref_MonoString_AnyCpu
    {
        //[FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;

        /// <summary>
        /// 0x10 System.Int32 m_stringLength
        /// </summary>
        //[FieldOffset(0x10)]
        [MarshalAs(UnmanagedType.I4)]
        public readonly System.Int32 m_stringLength;


        /// <summary>
        /// 0x14 System.Char m_firstChar
        /// </summary>
        //[FieldOffset(0x14)]
        [MarshalAs(UnmanagedType.U2)]
        public readonly System.Char m_firstChar;

    }

    readonly unsafe partial struct Ref_MonoString_AnyCpu : IRefMonoString
    {
        public int Length => m_stringLength;
        public ref readonly char FirstChar => ref Unsafe.AsRef(in m_firstChar);
    }

}
