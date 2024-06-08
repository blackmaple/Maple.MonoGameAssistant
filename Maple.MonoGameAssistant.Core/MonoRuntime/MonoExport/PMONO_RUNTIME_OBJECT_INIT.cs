
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_RUNTIME_OBJECT_INIT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_RUNTIME_OBJECT_INIT(nint ptr)
    {
        public const string il2cpp = "il2cpp_runtime_object_init";
        public const string mono = "mono_runtime_object_init";

        //nint MONO_RUNTIME_OBJECT_INIT (void *object)
        //typedef void* (__cdecl *MONO_RUNTIME_OBJECT_INIT)(void *object);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, void>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke(PMonoObject pMonoObject) => _func(pMonoObject);

    }



    #endregion



}