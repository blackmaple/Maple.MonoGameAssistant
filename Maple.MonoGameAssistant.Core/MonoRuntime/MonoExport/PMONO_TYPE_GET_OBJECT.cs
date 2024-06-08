
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_TYPE_GET_OBJECT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_TYPE_GET_OBJECT(nint ptr)
    {
        //nint MONO_TYPE_GET_OBJECT (void *domain, void *type)
        //typedef void* (__cdecl *MONO_TYPE_GET_OBJECT)(void *domain, void *type);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_TYPE_GET_OBJECT func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;
        }

    }


    internal readonly unsafe partial struct PMONO_TYPE_GET_OBJECT
    {
        public const string mono = "mono_type_get_object";
        public static bool TryCreate_MONO(nint hModule, out PMONO_TYPE_GET_OBJECT func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}