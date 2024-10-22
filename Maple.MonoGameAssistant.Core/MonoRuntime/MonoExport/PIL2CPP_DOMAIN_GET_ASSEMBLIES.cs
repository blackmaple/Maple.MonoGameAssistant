
using Maple.MonoGameAssistant.Common;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_DOMAIN_GET_ASSEMBLIES


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_DOMAIN_GET_ASSEMBLIES(nint ptr)
    {
        public const string il2cpp = "il2cpp_domain_get_assemblies";

        //uint* IL2CPP_DOMAIN_GET_ASSEMBLIES (void * domain, SIZE_T *size)
        //typedef UINT_PTR* (__cdecl *IL2CPP_DOMAIN_GET_ASSEMBLIES)(void * domain, SIZE_T *size);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, RefValue<nuint>, RefValue<PMonoAssembly>> _func
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, RefValue<nuint>, RefValue<PMonoAssembly>>)ptr;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ReadOnlySpan<PMonoAssembly> Invoke(PMonoDomain pMonoDomain)
        {
            var pMonoAssembly = _func(pMonoDomain, RefValue<nuint>.CreateOutValue(out var size));
            return MemoryMarshal.CreateReadOnlySpan(ref pMonoAssembly.Raw, (int)(uint)size);
        }


    }



    #endregion



}