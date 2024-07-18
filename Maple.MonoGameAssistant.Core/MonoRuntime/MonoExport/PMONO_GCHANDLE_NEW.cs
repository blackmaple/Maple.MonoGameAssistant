using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{


    #region PMONO_GCHANDLE_NEW

    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_GCHANDLE_NEW(nint ptr)
    {
        public const string il2cpp = "il2cpp_gchandle_new";
        public const string mono = "mono_gchandle_new";
        //MONO_API uint32_t      mono_gchandle_new         (MonoObject *obj, mono_bool pinned);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, MapleBoolean, REF_MONO_GC_HANDLE> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, MapleBoolean, REF_MONO_GC_HANDLE>)ptr;
        public readonly unsafe REF_MONO_GC_HANDLE Invoke(PMonoObject pMonoObject, bool pinned) => _func(pMonoObject, pinned);


    }

    #endregion


}