
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PG_FREE
    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PG_FREE(delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, void> ptr)
    {
        public const string common = "g_free";
        public const string il2cpp = "il2cpp_unity_g_free";
        public const string mono = "mono_unity_g_free";

        //void G_FREE (void *ptr)
        //typedef void (__cdecl *G_FREE)(void *ptr);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, void> _func = ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke(PMonoObject pMonoObject) => _func(pMonoObject);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke(nint pMonoObject) => _func(pMonoObject);

        public PG_FREE(nint ptr) : this((delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoObject, void>)ptr) { }
        public static bool TryCreate(nint hModule, string name, out PG_FREE func)
        {
            var address = WinApi.GetProcAddress(hModule, common);
            if (address != nint.Zero)
            {
                func = new(address);
                return true;
            }
            address = WinApi.GetProcAddress(hModule, name);
            if (address != nint.Zero)
            {
                func = new(address);
                return true;
            }
            func = new(&Free);
            return true;


        }


        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
        static void Free(PMonoObject pMonoObject)
        {
            //CE 这边注释了
            //Marshal.FreeHGlobal(pMonoObject);
        }
    }
    #endregion



}