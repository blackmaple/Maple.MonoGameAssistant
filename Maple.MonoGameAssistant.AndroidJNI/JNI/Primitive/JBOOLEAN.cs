﻿using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JBOOLEAN(bool val)
    {
        private const byte TRUE = 1;
        private const byte FALSE = 0;

        [MarshalAs(UnmanagedType.U1)]
        readonly byte _value = val ? TRUE : FALSE;
        public static implicit operator JBOOLEAN(bool val) => new(val);
        public static implicit operator bool(JBOOLEAN val) => val._value == TRUE;
        public static implicit operator JVALUE(JBOOLEAN val) => new(val);

    }

}
