using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [DebuggerDisplay("{_ptr}")]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PMonoMethod(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoMethod ptr) => ptr._ptr;
        public static implicit operator PMonoMethod(nint ptr) => new(ptr);
        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        public bool Valid() => _ptr != IntPtr.Zero;

        /// <summary>
        /// //il2cpp -> fist pointer points to compiled code
        /// </summary>
        /// <returns></returns>
        public unsafe MonoMethodPointer GetMonoMethodPointer_IL2CPP() => *(nint*)_ptr;/*Unsafe.Read<nint>(_ptr.ToPointer());*/// Marshal.ReadInt32(_ptr);



    }




}
