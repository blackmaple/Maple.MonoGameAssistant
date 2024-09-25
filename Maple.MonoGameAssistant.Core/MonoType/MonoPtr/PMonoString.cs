using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoString(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoString ptr) => ptr._ptr;
        public static implicit operator PMonoString(nint ptr) => new(ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string? ToString()
            => GetString();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string? ToString(int readSize)
            => this.GetString(readSize);

        public override int GetHashCode()
        {
            return _ptr.GetHashCode();
        }
        //public static bool operator ==(PMonoString l, PMonoString r)
        //{
        //    return l._ptr == r._ptr;
        //}
        //public static bool operator !=(PMonoString l, PMonoString r)
        //{
        //    return l._ptr != r._ptr;
        //}

    }





}
