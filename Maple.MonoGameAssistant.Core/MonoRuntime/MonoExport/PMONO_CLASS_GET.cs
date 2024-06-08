
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get";
        public const string mono = "mono_class_get";

        //nint MONO_CLASS_GET (void *image, UINT32 type_token)
        //typedef void* (__cdecl *MONO_CLASS_GET)(void *image, UINT32 type_token);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, uint, PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, uint, PMonoClass>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoClass Invoke(PMonoImage pMonoImage, uint type_token) => _func(pMonoImage, type_token);


    }



    #endregion



}