
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_JIT_EXEC


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_JIT_EXEC(nint ptr)
    {
        //int MONO_JIT_EXEC (void *domain, void *assembly, int argc, char *argv[])
        //typedef int (__cdecl *MONO_JIT_EXEC)(void *domain, void *assembly, int argc, char *argv[]);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_JIT_EXEC func)
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


    internal readonly unsafe partial struct PMONO_JIT_EXEC
    {
        public const string il2cpp = "il2cpp_jit_exec";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_JIT_EXEC func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_JIT_EXEC
    {
        public const string mono = "mono_jit_exec";
        public static bool TryCreate_MONO(nint hModule, out PMONO_JIT_EXEC func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}