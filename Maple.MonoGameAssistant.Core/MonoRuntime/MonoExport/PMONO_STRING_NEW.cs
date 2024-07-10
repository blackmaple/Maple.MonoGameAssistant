
using Maple.MonoGameAssistant.Common;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_STRING_NEW


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_STRING_NEW(nint ptr)
    {
        public const string mono = "mono_string_new";

        //nint MONO_STRING_NEW (void *domain, const char *text)
        //typedef void* (__cdecl *MONO_STRING_NEW)(void *domain, const char *text);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoUtf8Char, PMonoString> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, PMonoUtf8Char, PMonoString>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoString Invoke(PMonoDomain pMonoDomain, PMonoUtf8Char pMonoUtf8Char) => _func(pMonoDomain, pMonoUtf8Char);

        [SkipLocalsInit]
        public readonly PMonoString Invoke(PMonoDomain pMonoDomain, string content)
        {
            using var ref_Content = content.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));
            fixed (void* pContent = &ref_Content.GetPinnableReference())
            {
                return this.Invoke(pMonoDomain, pContent);
            }
        }

        [SkipLocalsInit]
        public readonly PMonoString Invoke(PMonoDomain pMonoDomain, in ReadOnlySpan<char> content)
        {
            using var ref_Content = content.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));
            fixed (void* pContent = &ref_Content.GetPinnableReference())
            {
                return this.Invoke(pMonoDomain, pContent);
            }
        }

    }

    #endregion


}