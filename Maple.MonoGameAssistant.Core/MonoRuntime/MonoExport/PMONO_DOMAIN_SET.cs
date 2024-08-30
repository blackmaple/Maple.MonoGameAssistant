
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_DOMAIN_SET


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_DOMAIN_SET(nint ptr)
    {
        //int MONO_DOMAIN_SET (void *domain, BOOL force)
        //typedef int (__cdecl *MONO_DOMAIN_SET)(void *domain, BOOL force);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, MapleBoolean, MapleBoolean> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoDomain, MapleBoolean, MapleBoolean>)ptr;
        public readonly MapleBoolean Invoke(PMonoDomain pMonoDomain, MapleBoolean force) => _func(pMonoDomain, force);
        public static bool TryCreate(nint hModule, string name, out PMONO_DOMAIN_SET func)
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


    internal readonly unsafe partial struct PMONO_DOMAIN_SET
    {
        public const string il2cpp = "il2cpp_domain_set";
        public static bool TryCreate_IL2CPP(nint hModule, out PMONO_DOMAIN_SET func)
            => TryCreate(hModule, il2cpp, out func);

    }


    internal readonly unsafe partial struct PMONO_DOMAIN_SET
    {
        public const string mono = "mono_domain_set";
        public static bool TryCreate_MONO(nint hModule, out PMONO_DOMAIN_SET func)
            => TryCreate(hModule, mono, out func);
    }
    #endregion



}