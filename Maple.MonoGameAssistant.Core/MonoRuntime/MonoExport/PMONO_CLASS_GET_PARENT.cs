
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET_PARENT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_PARENT(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_parent";
        public const string mono = "mono_class_get_parent";

        //nint MONO_CLASS_GET_PARENT (void *klass)
        //typedef void* (__cdecl *MONO_CLASS_GET_PARENT)(void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoClass>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoClass Invoke(PMonoClass pMonoClass) => _func(pMonoClass);


    }



    #endregion



}