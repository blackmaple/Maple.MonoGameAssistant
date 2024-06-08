
using Maple.MonoGameAssistant.Common;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_FROM_NAME


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_FROM_NAME(nint ptr)
    {
        public const string il2cpp = "il2cpp_class_from_name";
        public const string mono = "mono_class_from_name";

        //nint MONO_CLASS_FROM_NAME (void *image, char *name_space, char *name)
        //typedef void* (__cdecl *MONO_CLASS_FROM_NAME)(void *image, char *name_space, char *name);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, PMonoUtf8Char, PMonoUtf8Char, PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoImage, PMonoUtf8Char, PMonoUtf8Char, PMonoClass>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoClass Invoke(PMonoImage pMonoImage, PMonoUtf8Char pNameSpace, PMonoUtf8Char pClassName) => _func(pMonoImage, pNameSpace, pClassName);

        [SkipLocalsInit]
        public readonly PMonoClass Invoke(PMonoImage pMonoImage, ReadOnlySpan<byte> utf8Namespace, ReadOnlySpan<byte> utf8ClassName)
        {
            var buffer_namespace = (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]);
            utf8Namespace.CopyTo(buffer_namespace);
            //null-terminate
            buffer_namespace[utf8Namespace.Length] = 0;
            ref var ref_buffer_namespace = ref MemoryMarshal.GetReference(buffer_namespace);
            var pNameSpace = Unsafe.AsPointer(ref ref_buffer_namespace);

            var buffer_ClassName = (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]);
            utf8ClassName.CopyTo(buffer_ClassName);
            //null-terminate
            buffer_ClassName[utf8ClassName.Length] = 0;
            ref var ref_buffer_ClassName = ref MemoryMarshal.GetReference(buffer_ClassName);
            var pClassName = Unsafe.AsPointer(ref ref_buffer_ClassName);

            return Invoke(pMonoImage, pNameSpace, pClassName);

        }
    }


    #endregion



}