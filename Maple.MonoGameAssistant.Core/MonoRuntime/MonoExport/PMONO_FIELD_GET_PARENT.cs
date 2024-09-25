
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_FIELD_GET_PARENT


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_FIELD_GET_PARENT(nint ptr)
    {
        //nint MONO_FIELD_GET_PARENT (void *field)
        //typedef void* (__cdecl *MONO_FIELD_GET_PARENT)(void *field);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, PMonoField> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, PMonoField>)ptr;
        public readonly unsafe PMonoField Invoke(PMonoField pMonoField) => _func(pMonoField);
        public static bool TryCreate(nint hModule, string name, out PMONO_FIELD_GET_PARENT func)
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


    internal readonly unsafe partial struct PMONO_FIELD_GET_PARENT
    {
        public const string il2cpp = "il2cpp_field_get_parent";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_FIELD_GET_PARENT func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_FIELD_GET_PARENT
    {
        public const string mono = "mono_field_get_parent";
        public static bool TryCreate_MONO(nint hModule, out PMONO_FIELD_GET_PARENT func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}