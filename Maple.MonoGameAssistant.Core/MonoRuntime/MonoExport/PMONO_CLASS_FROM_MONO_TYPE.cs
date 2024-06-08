
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_FROM_MONO_TYPE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_FROM_MONO_TYPE(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_from_type";
        public const string mono = "mono_class_from_mono_type";

        //nint MONO_CLASS_FROM_MONO_TYPE (void *type)
        //typedef void* (__cdecl *MONO_CLASS_FROM_MONO_TYPE)(void *type);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoType, PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoType, PMonoClass>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoClass Invoke(PMonoType pMonoType) => _func(pMonoType);


    }



    #endregion



}