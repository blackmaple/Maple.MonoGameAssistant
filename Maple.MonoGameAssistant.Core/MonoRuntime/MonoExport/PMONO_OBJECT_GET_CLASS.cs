
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_OBJECT_GET_CLASS


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_OBJECT_GET_CLASS(nint ptr)
    {
        //nint MONO_OBJECT_GET_CLASS (void *object)
        //typedef void* (__cdecl *MONO_OBJECT_GET_CLASS)(void *object);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject,PMonoClass> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, PMonoClass>)ptr;
        public readonly PMonoClass Invoke(PMonoObject pMonoObject) => _func(pMonoObject);
        public static bool TryCreate(nint hModule, string name, out PMONO_OBJECT_GET_CLASS func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;

        }

    }


    internal readonly unsafe partial struct PMONO_OBJECT_GET_CLASS
    {
        public const string il2cpp = "il2cpp_object_get_class";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_OBJECT_GET_CLASS func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_OBJECT_GET_CLASS
    {
        public const string mono = "mono_object_get_class";
        public static bool TryCreate_MONO(nint hModule, out PMONO_OBJECT_GET_CLASS func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}