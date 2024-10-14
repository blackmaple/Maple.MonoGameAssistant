
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET_METHODS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_METHODS(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_methods";
        public const string mono = "mono_class_get_methods";

        //nint MONO_CLASS_GET_METHODS (void *klass, void *iter)
        //typedef void* (__cdecl *MONO_CLASS_GET_METHODS)(void *klass, void *iter);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoAddress, PMonoMethod> _func
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoAddress, PMonoMethod>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoMethod Invoke(PMonoClass pMonoClass, ref PMonoIterator iter) => _func(pMonoClass, iter.AsPointer());


    }



    #endregion



}