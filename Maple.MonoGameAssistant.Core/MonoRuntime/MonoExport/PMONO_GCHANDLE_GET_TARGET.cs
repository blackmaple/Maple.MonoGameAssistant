using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_GCHANDLE_GET_TARGET

    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_GCHANDLE_GET_TARGET(nint ptr)
    {
        public const string il2cpp = "il2cpp_gchandle_get_target";
        public const string mono = "mono_gchandle_get_target";
        //MONO_API MonoObject*  mono_gchandle_get_target  (uint32_t gchandle);

        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<REF_MONO_GC_HANDLE, PMonoObject> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<REF_MONO_GC_HANDLE, PMonoObject>)ptr;
        public readonly unsafe PMonoObject Invoke(REF_MONO_GC_HANDLE gchandle) => _func(gchandle);


    }
    #endregion

}