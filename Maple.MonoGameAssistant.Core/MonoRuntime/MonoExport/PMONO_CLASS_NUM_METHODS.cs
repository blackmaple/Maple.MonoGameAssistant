
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_CLASS_NUM_METHODS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_CLASS_NUM_METHODS(nint ptr)
    {
        //int MONO_CLASS_NUM_METHODS (void *klass)
        //typedef int (__cdecl *MONO_CLASS_NUM_METHODS)(void *klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_CLASS_NUM_METHODS func)
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


    internal readonly unsafe partial struct PMONO_CLASS_NUM_METHODS
    {
        public const string il2cpp = "il2cpp_class_num_methods";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_CLASS_NUM_METHODS func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_CLASS_NUM_METHODS
    {
        public const string mono = "mono_class_num_methods";
        public static bool TryCreate_MONO(nint hModule, out PMONO_CLASS_NUM_METHODS func)
            => TryCreate(hModule, mono, out func);
    }
    #endregion



}