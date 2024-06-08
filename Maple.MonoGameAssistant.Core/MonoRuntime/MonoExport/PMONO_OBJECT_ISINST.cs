
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_OBJECT_ISINST


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_OBJECT_ISINST(nint ptr)
    {
        public const string mono = "mono_object_isinst";

        //nint MONO_OBJECT_ISINST (void *obj, void* kls)
        //typedef void* (__cdecl *MONO_OBJECT_ISINST)(void *obj, void* kls);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, PMonoClass, PMonoObject> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, PMonoClass, PMonoObject>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoObject Invoke(PMonoObject pMonoObject, PMonoClass pMonoClass) => _func(pMonoObject, pMonoClass);

    }


    #endregion



}