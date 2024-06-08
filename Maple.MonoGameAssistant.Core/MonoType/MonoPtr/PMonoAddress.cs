using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [DebuggerDisplay("{_ptr}")]
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct PMonoAddress(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoAddress ptr) => ptr._ptr;
        public static implicit operator PMonoAddress(nint ptr) => new(ptr);
        public static implicit operator PMonoAddress(void* ptr) => new nint(ptr);
        public static implicit operator void*(PMonoAddress ptr) => ptr._ptr.ToPointer();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        public bool Valid() => _ptr != IntPtr.Zero;

        public unsafe int ReadInt32() => *(int*)_ptr;
        public unsafe uint ReadUInt32() => *(uint*)_ptr;
        public unsafe long ReadInt64() => *(long*)_ptr;
        public unsafe ulong ReadUInt64() => *(ulong*)_ptr;


        public unsafe T ReadValue<T>()
            where T : unmanaged
        {
            var buffer = new ReadOnlySpan<byte>(_ptr.ToPointer(), Unsafe.SizeOf<T>());
            return MemoryMarshal.Read<T>(buffer);
        }


        public void CopyTo(Span<byte> dest)
        {
            var buffer = new ReadOnlySpan<byte>(_ptr.ToPointer(), dest.Length);
            buffer.CopyTo(dest);
        }

    }

}
