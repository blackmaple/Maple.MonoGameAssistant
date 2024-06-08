
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METHOD_GET_PARAM_NAMES


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METHOD_GET_PARAM_NAMES(nint ptr)
    {
        public const string il2cpp = "il2cpp_method_get_param_names";
        public const string mono = "mono_method_get_param_names";

        //nint MONO_METHOD_GET_PARAM_NAMES (void *method, const char **names)
        //typedef void* (__cdecl *MONO_METHOD_GET_PARAM_NAMES)(void *method, const char **names);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, ref PMonoUtf8Char, PMonoObject> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, ref PMonoUtf8Char, PMonoObject>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoObject Invoke(PMonoMethod pMonoMethod, ref PMonoUtf8Char pMonoUtf8Chars) => _func(pMonoMethod, ref pMonoUtf8Chars);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoObject Invoke(PMonoMethod pMonoMethod, in Span<PMonoUtf8Char> pMonoUtf8Chars)
            => Invoke(pMonoMethod, ref MemoryMarshal.GetReference(pMonoUtf8Chars));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoObject Invoke(PMonoMethod pMonoMethod, PMonoUtf8Char[] pMonoUtf8Chars)
            => Invoke(pMonoMethod, ref MemoryMarshal.GetArrayDataReference(pMonoUtf8Chars));





    }



    #endregion



}