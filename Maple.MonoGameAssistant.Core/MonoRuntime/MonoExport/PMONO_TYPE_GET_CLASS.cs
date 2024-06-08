
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_TYPE_GET_CLASS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_TYPE_GET_CLASS(nint ptr)
    {
        public const string il2cpp = "il2cpp_type_get_class";
        public const string il2cpp_element = "il2cpp_type_get_class_or_element_class";
        public const string mono = "mono_type_get_class";

        //nint MONO_TYPE_GET_CLASS (void* type)
        //typedef void* (__cdecl* MONO_TYPE_GET_CLASS)(void* type);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke() => _func();


    }



    #endregion



}