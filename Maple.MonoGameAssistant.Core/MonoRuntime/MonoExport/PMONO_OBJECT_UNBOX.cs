
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_OBJECT_UNBOX


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_OBJECT_UNBOX(nint ptr)
    {
        public const string il2cpp = "il2cpp_object_unbox";
        public const string mono = "mono_object_unbox";

        //nint MONO_OBJECT_UNBOX (void *obj)
        //typedef void* (__cdecl *MONO_OBJECT_UNBOX)(void *obj);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, PMonoAddress> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, PMonoAddress>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoAddress Invoke(PMonoObject pMonoObject) => _func(pMonoObject);


    }



    #endregion



}