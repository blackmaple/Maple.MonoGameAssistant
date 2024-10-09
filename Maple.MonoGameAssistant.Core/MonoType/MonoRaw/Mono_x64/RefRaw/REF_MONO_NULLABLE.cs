using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct REF_MONO_NULLABLE<T>
        where T : unmanaged
    {

        [MarshalAs(UnmanagedType.U1)]
        public readonly System.Boolean hasValue;



        public readonly T value;

    }

}
