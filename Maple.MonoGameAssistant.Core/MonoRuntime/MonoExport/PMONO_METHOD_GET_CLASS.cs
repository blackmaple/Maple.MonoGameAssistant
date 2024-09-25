
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METHOD_GET_CLASS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METHOD_GET_CLASS(nint ptr)
    {
        //nint MONO_METHOD_GET_CLASS (void *method)
        //typedef void* (__cdecl *MONO_METHOD_GET_CLASS)(void *method);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod,PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PMonoClass>)ptr;
        public readonly unsafe PMonoClass Invoke(PMonoMethod pMonoMethod) => _func(pMonoMethod);
        public static bool TryCreate(nint hModule, string name, out PMONO_METHOD_GET_CLASS func)
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


    internal readonly unsafe partial struct PMONO_METHOD_GET_CLASS
    {
        public const string il2cpp = "il2cpp_method_get_class";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_METHOD_GET_CLASS func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_METHOD_GET_CLASS
    {
        public const string mono = "mono_method_get_class";
        public static bool TryCreate_MONO(nint hModule, out PMONO_METHOD_GET_CLASS func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}