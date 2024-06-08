using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{


    #region PIL2CPP_OBJECT_NEW


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_OBJECT_NEW(nint ptr)
    {
        public const string il2cpp = "il2cpp_object_new";

        //nint MONO_OBJECT_NEW (void *domain, void *klass)
        //typedef void* (__cdecl *MONO_OBJECT_NEW)(void *domain, void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoObject> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoObject>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoObject Invoke(PMonoClass pMonoClass) => _func(pMonoClass);


    }



    #endregion

}