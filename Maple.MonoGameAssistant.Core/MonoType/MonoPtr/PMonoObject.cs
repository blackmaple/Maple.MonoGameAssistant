﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [DebuggerDisplay("{_ptr}")]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PMonoObject(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoObject ptr) => ptr._ptr;

        public static implicit operator PMonoObject(nint ptr) => new(ptr);
        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        public bool Valid() => _ptr != IntPtr.Zero;

        public ref T_STRUCT To<T_STRUCT>() where T_STRUCT : unmanaged
        {
            return ref Unsafe.As<nint, T_STRUCT>(ref Unsafe.AsRef(in _ptr));
        }

        public static PMonoObject From<T_STRUCT>(T_STRUCT data) where T_STRUCT : unmanaged
        {
            return Unsafe.As<T_STRUCT, PMonoObject>(ref data);
        }

        public PMonoClass MonoClass => _ptr.AsRefStruct<REF_MONO_OBJECT>().MonoClass;
    }

 


}
