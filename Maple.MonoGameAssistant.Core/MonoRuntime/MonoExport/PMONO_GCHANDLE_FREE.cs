using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{


    #region PMONO_GCHANDLE_FREE

    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_GCHANDLE_FREE(nint ptr)
    {
        public const string il2cpp = "il2cpp_gchandle_free";
        public const string mono = "mono_gchandle_free";
        //MONO_API void         mono_gchandle_free        (uint32_t gchandle);

        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<REF_MONO_GC_HANDLE, void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<REF_MONO_GC_HANDLE, void>)ptr;
        public readonly unsafe void Invoke(REF_MONO_GC_HANDLE gchandle) => _func(gchandle);


    }
    #endregion

}