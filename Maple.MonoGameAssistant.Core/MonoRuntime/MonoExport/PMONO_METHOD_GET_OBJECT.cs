
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METHOD_GET_OBJECT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METHOD_GET_OBJECT(nint ptr)
    {
        //nint MONO_METHOD_GET_OBJECT (void *domain, void *method, void* klass)
        //typedef void* (__cdecl *MONO_METHOD_GET_OBJECT)(void *domain, void *method, void* klass);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_METHOD_GET_OBJECT func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;

        }

    }


    internal readonly unsafe partial struct PMONO_METHOD_GET_OBJECT
    {
        public const string mono = "mono_method_get_object";
        public static bool TryCreate_MONO(nint hModule, out PMONO_METHOD_GET_OBJECT func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}