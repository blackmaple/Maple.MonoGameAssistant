
using Maple.MonoGameAssistant.Common;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_METADATA_DECODE_ROW_COL


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_METADATA_DECODE_ROW_COL(nint ptr)
    {
        //int MONO_METADATA_DECODE_ROW_COL (void *tableinfo, int idx, unsigned int col)
        //typedef int (__cdecl *MONO_METADATA_DECODE_ROW_COL)(void *tableinfo, int idx, unsigned int col);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<void>)ptr;
        public readonly unsafe void Invoke() => _func();
        public static bool TryCreate(nint hModule, string name, out PMONO_METADATA_DECODE_ROW_COL func)
        {
            var address = WinApi.GetProcAddress(hModule, name);
            func = new(address);
            return address != nint.Zero;

        }

    }


    internal readonly unsafe partial struct PMONO_METADATA_DECODE_ROW_COL
    {
        public const string il2cpp = "il2cpp_metadata_decode_row_col";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_METADATA_DECODE_ROW_COL func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_METADATA_DECODE_ROW_COL
    {
        public const string mono = "mono_metadata_decode_row_col";
        public static bool TryCreate_MONO(nint hModule, out PMONO_METADATA_DECODE_ROW_COL func)
            => TryCreate(hModule, mono, out func);
    }
#endregion



}