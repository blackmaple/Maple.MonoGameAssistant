
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METHOD_HEADER_GET_CODE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METHOD_HEADER_GET_CODE(nint ptr)
    {
        public const string il2cpp = "il2cpp_method_header_get_code";
        public const string mono = "mono_method_header_get_code";

        //nint MONO_METHOD_HEADER_GET_CODE (void *methodheader, UINT32 *code_size, UINT32 *max_stack)
        //typedef void* (__cdecl *MONO_METHOD_HEADER_GET_CODE)(void *methodheader, UINT32 *code_size, UINT32 *max_stack);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethodHeader, out uint, out uint, PMonoILCode> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethodHeader, out uint, out uint, PMonoILCode>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoILCode Invoke(PMonoMethodHeader pMonoMethodHeader, out uint code_size, out uint max_stack) => _func(pMonoMethodHeader, out code_size, out max_stack);


    }



    #endregion



}