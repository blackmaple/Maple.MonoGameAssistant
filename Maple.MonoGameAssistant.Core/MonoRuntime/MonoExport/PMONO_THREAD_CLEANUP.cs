
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_THREAD_CLEANUP


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_THREAD_CLEANUP(nint ptr)
    {
        //void MONO_THREAD_CLEANUP ()
        //typedef void (__cdecl *MONO_THREAD_CLEANUP)(void);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_THREAD_CLEANUP func)
        {
            Unsafe.SkipInit(out func);
            if (NativeLibrary.TryGetExport(hModule, name, out var address))
            {
                func = new(address);
                return true;
            }
            return false;
        }

    }


    internal readonly unsafe partial struct PMONO_THREAD_CLEANUP
    {
        public const string mono = "mono_thread_cleanup";
        public static bool TryCreate_MONO(nint hModule, out PMONO_THREAD_CLEANUP func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}