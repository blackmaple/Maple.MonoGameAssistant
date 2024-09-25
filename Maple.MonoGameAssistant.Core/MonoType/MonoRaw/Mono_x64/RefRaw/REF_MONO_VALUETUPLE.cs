using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.RawDotNet
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct REF_MONO_VALUETUPLE<TITEM1, TITEM2>
        where TITEM1 : unmanaged
        where TITEM2 : unmanaged
    {

        public readonly TITEM1 Item1;

        public readonly TITEM2 Item2;

    }

}
