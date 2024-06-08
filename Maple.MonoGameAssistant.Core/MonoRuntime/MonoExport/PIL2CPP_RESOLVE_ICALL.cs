using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.Core
{


    #region IL2CPP_RESOLVE_ICALL
    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_RESOLVE_ICALL(nint ptr)
    {
        public const string il2cpp = "il2cpp_resolve_icall";

        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoUtf8Char, PDelegatePointer> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoUtf8Char, PDelegatePointer>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PDelegatePointer Invoke(PMonoUtf8Char signature) => _func(signature);

        [SkipLocalsInit]
        public readonly PDelegatePointer Invoke(string content)
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