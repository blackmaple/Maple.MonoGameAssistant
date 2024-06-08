
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_ASSEMBLY_LOADED


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_ASSEMBLY_LOADED(nint ptr)
    {
        public const string il2cpp = "il2cpp_assembly_loaded";
        public const string mono = "mono_assembly_loaded";
        //nint MONO_ASSEMBLY_LOADED (void *aname)
        //typedef void* (__cdecl *MONO_ASSEMBLY_LOADED)(void *aname);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();


    }



    #endregion



}