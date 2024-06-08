
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_STRING_CHARS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_STRING_CHARS(nint ptr)
    {
        public const string il2cpp = "il2cpp_string_chars";
        //PMono_wchar_t IL2CPP_STRING_CHARS (void *stringobject)
        //typedef wchar_t*(__cdecl *IL2CPP_STRING_CHARS)(void *stringobject);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();


    }



    #endregion



}