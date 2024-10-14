
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
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoAddress, PMonoObject> _func
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoAddress, PMonoObject>)ptr;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ReadOnlySpan<PMonoAssembly> Invoke(PMonoDomain pMonoDomain)
        {
            nuint size = nuint.Zero;
            ref var ref_size = ref size;
            var pMonoAssembly = _func(pMonoDomain, ref_size.ToPointer());
            ref var ref_MonoAssembly = ref pMonoAssembly.To<PMonoAssembly>();
            return MemoryMarshal.CreateReadOnlySpan(ref ref_MonoAssembly, (int)(uint)size);
        }


    }



    #endregion



}