
using Maple.MonoGameAssistant.Common;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_ARRAY_NEW

    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_ARRAY_NEW(nint ptr)
    {
        public const string il2cpp = "il2cpp_array_new";

        //nint IL2CPP_ARRAY_NEW (void *eclass, uintptr_t n)
        //typedef void* (__cdecl *IL2CPP_ARRAY_NEW)(void *eclass, uintptr_t n);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, nuint, PMonoArray> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, nuint, PMonoArray>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoArray Invoke(PMonoClass pMonoClass, nuint size) => _func(pMonoClass, size);
    }

#endregion

}