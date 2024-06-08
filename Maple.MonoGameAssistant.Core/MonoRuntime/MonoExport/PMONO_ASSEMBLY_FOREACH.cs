
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_ASSEMBLY_FOREACH

    using unsafe PMonoAssemblyFunc = delegate* <PMonoAssembly, PMonoUserData, void>;

    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_ASSEMBLY_FOREACH(nint ptr)
    {
        public const string il2cpp = "il2cpp_assembly_foreach";
        public const string mono = "mono_assembly_foreach";

        //int MONO_ASSEMBLY_FOREACH (GFunc func, void *user_data)
        //typedef int (__cdecl *MONO_ASSEMBLY_FOREACH)(GFunc func, void *user_data);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoAssemblyFunc, PMonoUserData, void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoAssemblyFunc, PMonoUserData, void>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke(PMonoAssemblyFunc pMonoAssemblyFunc, PMonoUserData pMonoUserData) => _func(pMonoAssemblyFunc, pMonoUserData);

    }


    #endregion



}