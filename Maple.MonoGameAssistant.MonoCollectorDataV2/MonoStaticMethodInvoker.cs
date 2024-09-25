using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
#if SOURCE_GEN
    internal
#else 
    public
#endif
        readonly struct MonoStaticMethodInvoker
    {
        public readonly IntPtr MonoMethod;
        public readonly IntPtr PtrMethod;

        public MonoStaticMethodInvoker(IntPtr monoMethod, IntPtr func)
        {
            MonoMethod = monoMethod;
            PtrMethod = func;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TFUNC GetInvoker<TFUNC>()
        {
            var tmp = PtrMethod;
            return Unsafe.As<IntPtr, TFUNC>(ref tmp);
        }
    }
}
