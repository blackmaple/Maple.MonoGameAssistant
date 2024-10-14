
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
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMonoAddress, PMonoObject> _func
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMonoAddress, PMonoObject>)ptr;



        /// <summary>
        /// »º´æÎªÕ»
        /// </summary>
        /// <param name="pMonoMethod"></param>
        /// <param name="pMonoUtf8Chars"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoObject Invoke(PMonoMethod pMonoMethod, in Span<PMonoUtf8Char> pMonoUtf8Chars)
        {
            ref var ref_span = ref MemoryMarshal.GetReference(pMonoUtf8Chars);
            var pBuffer = ref_span.AsPointer();
            return _func(pMonoMethod, pBuffer);
        }

        /// <summary>
        /// ÍÐ¹Ü»º´æ
        /// </summary>
        /// <param name="pMonoMethod"></param>
        /// <param name="pMonoUtf8Chars"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoObject Invoke(PMonoMethod pMonoMethod, PMonoUtf8Char[] pMonoUtf8Chars)
        {
            ref var ref_span = ref MemoryMarshal.GetArrayDataReference(pMonoUtf8Chars);
            fixed (void* pBuffer = &ref_span)
            {
                var obj = _func(pMonoMethod, pBuffer);
                return obj;
            }
        }




    }



    #endregion



}