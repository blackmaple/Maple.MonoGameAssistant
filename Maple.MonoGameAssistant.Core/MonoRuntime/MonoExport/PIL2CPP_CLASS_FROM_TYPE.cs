
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_CLASS_FROM_TYPE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_CLASS_FROM_TYPE(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_from_type";

        //nint IL2CPP_CLASS_FROM_TYPE (void *type)
        //typedef void*(__cdecl *IL2CPP_CLASS_FROM_TYPE)(void *type);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoType,PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoType, PMonoClass>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoClass Invoke(PMonoType pMonoType) => _func(pMonoType);


    }


#endregion



}