using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_FLAGS(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_flags";
        public const string mono = "mono_class_get_flags";

        //int MONO_FIELD_GET_FLAGS (void *type)
        //typedef int (__cdecl *MONO_FIELD_GET_FLAGS)(void *type);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, uint> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, uint>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Invoke(PMonoClass pMonoClass) => _func(pMonoClass);

    }



}