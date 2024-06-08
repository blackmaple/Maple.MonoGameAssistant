
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_STRING_NEW


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_STRING_NEW(nint ptr)
    {
        public const string il2cpp = "il2cpp_string_new";

        //nint MONO_STRING_NEW (void *domain, const char *text)
        //typedef void* (__cdecl *MONO_STRING_NEW)(void *domain, const char *text);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoUtf8Char, PMonoString> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoUtf8Char, PMonoString>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PMonoString Invoke(PMonoUtf8Char pMonoUtf8Char) => _func(pMonoUtf8Char);

        [SkipLocalsInit]
        public readonly PMonoString Invoke(string content)
        {
            using var ref_Content = content.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));
            fixed (void* pContent = &ref_Content.GetPinnableReference())
            {
                return this.Invoke(pContent);
            }
        }
    }



    #endregion

}