
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_INSTANCE_SIZE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_INSTANCE_SIZE(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_instance_size";
        public const string mono = "mono_class_instance_size";

        //int MONO_CLASS_INSTANCE_SIZE (void *klass)
        //typedef int (__cdecl *MONO_CLASS_INSTANCE_SIZE)(void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, int> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, int>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Invoke(PMonoClass pMonoClass) => _func(pMonoClass);


    }



    #endregion



}