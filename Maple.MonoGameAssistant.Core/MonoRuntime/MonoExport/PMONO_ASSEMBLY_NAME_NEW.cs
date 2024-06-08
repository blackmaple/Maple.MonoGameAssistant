
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_ASSEMBLY_NAME_NEW


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_ASSEMBLY_NAME_NEW(nint ptr)
    {
        public const string il2cpp = "il2cpp_assembly_name_new";
        public const string mono = "mono_assembly_name_new";
        //nint MONO_ASSEMBLY_NAME_NEW (const char *name)
        //typedef void* (__cdecl *MONO_ASSEMBLY_NAME_NEW)(const char *name);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();


    }



    #endregion



}