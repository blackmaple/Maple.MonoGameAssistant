using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET_TYPE_TOKEN

    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_TYPE_TOKEN(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_type_token";
        public const string mono = "mono_class_get_type_token";

        //uint32_t PMONO_CLASS_GET_TYPE_TOKEN (void *klass)
        //typedef uint32_t  (__cdecl *PMONO_CLASS_GET_TYPE_TOKEN)(void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, uint> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, uint>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Invoke(PMonoClass pMonoClass) => _func(pMonoClass);

    }



    #endregion

}