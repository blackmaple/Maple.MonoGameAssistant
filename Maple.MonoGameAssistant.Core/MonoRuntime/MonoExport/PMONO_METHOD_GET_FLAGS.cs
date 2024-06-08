
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METHOD_GET_FLAGS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METHOD_GET_FLAGS(nint ptr)
    {
        public const string il2cpp = "il2cpp_method_get_flags";
        public const string mono = "mono_method_get_flags";

        //uint32_t MONO_METHOD_GET_FLAGS (void *method, uint32_t *iflags)
        //typedef uint32_t (__cdecl *MONO_METHOD_GET_FLAGS)(void *method, uint32_t *iflags);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMonoAddress, uint> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMonoAddress, uint>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Invoke(PMonoMethod pMonoMethod) => _func(pMonoMethod, nint.Zero);

    }



    #endregion



}