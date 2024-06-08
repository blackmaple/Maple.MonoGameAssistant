
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_COMPILE_METHOD


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_COMPILE_METHOD(nint ptr)
    {
        public const string il2cpp = "il2cpp_compile_method";
        public const string mono = "mono_compile_method";

        //nint MONO_COMPILE_METHOD (void *method)
        //typedef void* (__cdecl *MONO_COMPILE_METHOD)(void *method);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, MonoMethodPointer> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, MonoMethodPointer>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly MonoMethodPointer Invoke(PMonoMethod pMonoMethod) => _func(pMonoMethod);


    }



    #endregion



}