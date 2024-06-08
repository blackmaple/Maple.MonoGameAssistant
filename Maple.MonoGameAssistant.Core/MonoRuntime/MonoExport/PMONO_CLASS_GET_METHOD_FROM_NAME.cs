
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_GET_METHOD_FROM_NAME


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_GET_METHOD_FROM_NAME(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_get_method_from_name";
        public const string mono = "mono_class_get_method_from_name";

        //nint MONO_CLASS_GET_METHOD_FROM_NAME (void *klass, char *methodname, int paramcount)
        //typedef void* (__cdecl *MONO_CLASS_GET_METHOD_FROM_NAME)(void *klass, char *methodname, int paramcount);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoUtf8Char, int, PMonoMethod> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoClass, PMonoUtf8Char, int, PMonoMethod>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoMethod Invoke(PMonoClass pMonoClass, PMonoUtf8Char pMethodName, int paramcount = -1) => _func(pMonoClass, pMethodName, paramcount);

        [SkipLocalsInit]
        public readonly PMonoMethod Invoke(PMonoClass pMonoClass, string methodName, int paramcount = -1)
        {
            using var ref_methodName = methodName.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));
            fixed (void* pMethodName = &ref_methodName.GetPinnableReference())
            {
                return this.Invoke(pMonoClass, pMethodName, paramcount);
            }

        }

    }



    #endregion



}