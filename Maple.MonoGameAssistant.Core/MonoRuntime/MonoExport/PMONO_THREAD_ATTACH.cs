
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_THREAD_ATTACH


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_THREAD_ATTACH(nint ptr)
    {
        public const string il2cpp = "il2cpp_thread_attach";
        public const string mono = "mono_thread_attach";
        //nint MONO_THREAD_ATTACH (void *domain)
        //typedef void* (__cdecl *MONO_THREAD_ATTACH)(void *domain);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoThread> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoThread>)ptr;
        public readonly unsafe PMonoThread Invoke(PMonoDomain pMonoDomain) => _func(pMonoDomain);


    }
    #endregion



}