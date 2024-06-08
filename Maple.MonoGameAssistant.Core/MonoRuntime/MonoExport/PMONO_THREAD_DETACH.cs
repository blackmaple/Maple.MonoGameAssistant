
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_THREAD_DETACH


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_THREAD_DETACH(nint ptr)
    {
        public const string il2cpp = "il2cpp_thread_detach";
        public const string mono = "mono_thread_detach";

        //void MONO_THREAD_DETACH (void *monothread)
        //typedef void (__cdecl *MONO_THREAD_DETACH)(void *monothread);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoThread, void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoThread, void>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke(PMonoThread pMonoThread) => _func(pMonoThread);


    }



    #endregion



}