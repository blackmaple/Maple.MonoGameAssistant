using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct REF_MONO_NULLABLE<T>
        where T : unmanaged
    {
        public REF_MONO_NULLABLE(T? val)
        {
            if (val.HasValue)
            {
                hasValue = true;
                value = val.Value;
            }
        }

        [MarshalAs(UnmanagedType.U1)]
        public readonly System.Boolean hasValue;

        public readonly T value;

    }

}
