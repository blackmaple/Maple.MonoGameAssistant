
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_GET_ENUM_CLASS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_GET_ENUM_CLASS(nint ptr)
    {
        public const string mono = "mono_get_enum_class";

        //nint MONO_GET_ENUM_CLASS ()
        //typedef void* (__cdecl *MONO_GET_ENUM_CLASS)(void);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoClass Invoke() => _func();

    }



    #endregion



}