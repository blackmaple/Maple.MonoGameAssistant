
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_ASSEMBLY_OPEN


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_ASSEMBLY_OPEN(nint ptr)
    {
        public const string il2cpp = "il2cpp_assembly_open";
        public const string mono = "mono_assembly_open";
        //nint MONO_ASSEMBLY_OPEN (void *fname, int *status)
        //typedef void* (__cdecl *MONO_ASSEMBLY_OPEN)(void *fname, int *status);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();


    }



    #endregion



}