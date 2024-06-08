using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.Core
{

    [StructLayout(LayoutKind.Explicit)]
    public unsafe readonly partial struct Ref_MonoQueue_OptimizationDefault
    {
    }
    unsafe readonly partial struct Ref_MonoQueue_OptimizationDefault : IRefMonoQueue
    {
        public int Size => throw new NotImplementedException();

        public PMonoArray Array => throw new NotImplementedException();

        public int Head => throw new NotImplementedException();


    }
}
