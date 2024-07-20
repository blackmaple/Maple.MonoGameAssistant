using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Versioning;

namespace Maple.MonoGameAssistant.Common
{

    using unsafe CallBackEnumThreadWindows = delegate* unmanaged[Stdcall]<nint, nint, bool>;
    using unsafe CallbackWndProc = delegate* unmanaged[Stdcall]<nint, EnumWindowMessage, nint, nint, nint>;

    public partial class WinApi
    {

        public const int PROCESS_VM_READ = 0x10;
        public const int PROCESS_QUERY_INFORMATION = 0x0400;
        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("kernel32.dll", EntryPoint = "OpenProcess", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial nint OpenProcess(int dwDesiredAccess, [MarshalAsAttribute(UnmanagedType.I4)] bool bInheritHandle, int dwProcessId);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("kernel32.dll", EntryPoint = "GetModuleFileNameW", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial int GetModuleFileName(nint hModule, Span<char> buffer, int size);


        [StructLayout(LayoutKind.Explicit)]
        public unsafe struct Ref__PEB
        {
            [FieldOffset(0x18)]
            public PTR__PEB_LDR_DATA PPEB_LDR_DATA;
        }
        [StructLayout(LayoutKind.Sequential)]
        public readonly unsafe struct Ptr__PEB(nint ptr)
        {
            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ref Ref__PEB AsRef()
            {
                return ref Unsafe.AsRef<Ref__PEB>(_ptr.ToPointer());
            }

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            public readonly PTR__PEB_LDR_DATA PTR__PEB_LDR_DATA => AsRef().PPEB_LDR_DATA;
        }

        [StructLayout(LayoutKind.Explicit)]
        public readonly unsafe struct Ref__PEB_LDR_DAT
        {
            [FieldOffset(0x10)]
            public readonly REF_LIST_ENTRY InLoadOrderModuleList;
        }
        [StructLayout(LayoutKind.Sequential)]
        public readonly unsafe struct PTR__PEB_LDR_DATA(nint ptr)
        {
            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ref Ref__PEB_LDR_DAT AsRef()
            {
                return ref Unsafe.AsRef<Ref__PEB_LDR_DAT>(_ptr.ToPointer());
            }

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }
            public ref readonly REF_LIST_ENTRY InLoadOrderModuleList => ref AsRef().InLoadOrderModuleList;

        }

        [StructLayout(LayoutKind.Explicit)]
        public readonly unsafe struct REF_LIST_ENTRY
        {
            [FieldOffset(0)]
            public readonly PTR_LIST_ENTRY Flink;
            [FieldOffset(8)]
            public readonly PTR_LIST_ENTRY Blink;
        }
        public readonly unsafe struct PTR_LIST_ENTRY(nint ptr)
        {
            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            public static implicit operator nint(PTR_LIST_ENTRY obj) => obj._ptr;
            public static implicit operator PTR_LIST_ENTRY(nint ptr) => new(ptr);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PTR_LIST_ENTRY left, PTR_LIST_ENTRY right)
            {
                return left._ptr != right._ptr;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PTR_LIST_ENTRY left, PTR_LIST_ENTRY right)
            {
                return left._ptr == right._ptr;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ref REF_LIST_ENTRY AsRef()
            {
                return ref Unsafe.AsRef<REF_LIST_ENTRY>(_ptr.ToPointer());
            }
            public PTR_LIST_ENTRY Flink => AsRef().Flink;
            public PTR_LIST_ENTRY Blink => AsRef().Blink;

            public override bool Equals(object? obj)
            {
                if (obj is null)
                {
                    return false;
                }
                if (obj is PTR_LIST_ENTRY t)
                {
                    return t._ptr == _ptr;
                }
                return false;
            }
            public override int GetHashCode()
            {
                return _ptr.GetHashCode();
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe struct REF__LDR_DATA_TABLE_ENTRY
        {
            [FieldOffset(0)]
            public readonly REF_LIST_ENTRY InLoadOrderLinks;
            [FieldOffset(0x10)]
            public readonly REF_LIST_ENTRY InMemoryOrderLinks;
            [FieldOffset(0x20)]
            public readonly REF_LIST_ENTRY InInitializationOrderLinks;
            [FieldOffset(0x30)]
            public nint DllBase;
            [FieldOffset(0x38)]
            public readonly nint EntryPoint;
            [FieldOffset(0x40)]
            public readonly uint SizeOfImage;

            [FieldOffset(0x48)]
            public readonly REF_UNICODE_STRING FullDllName;
            [FieldOffset(0x58)]
            public readonly REF_UNICODE_STRING BaseDllName;

        }
        [StructLayout(LayoutKind.Sequential)]
        public readonly unsafe struct PTR__LDR_DATA_TABLE_ENTRY(nint ptr)
        {
            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;

            public static implicit operator nint(PTR__LDR_DATA_TABLE_ENTRY obj) => obj._ptr;
            public static implicit operator PTR__LDR_DATA_TABLE_ENTRY(nint ptr) => new(ptr);

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ref REF__LDR_DATA_TABLE_ENTRY AsRef()
            {
                return ref Unsafe.AsRef<REF__LDR_DATA_TABLE_ENTRY>(_ptr.ToPointer());
            }

            public ref readonly REF_UNICODE_STRING BaseDllName => ref AsRef().BaseDllName;

            public nint DllBase
            {
                get => AsRef().DllBase;
                set => AsRef().DllBase = value;
            }

        }

        [StructLayout(LayoutKind.Explicit)]
        public readonly unsafe struct REF_UNICODE_STRING
        {
            [FieldOffset(0)]
            public readonly ushort Length;
            [FieldOffset(2)]
            public readonly ushort MaximumLength;
            [FieldOffset(8)]
            public readonly nint Buffer;

            public override string ToString()
            {
                if (Length == 0 || Buffer == nint.Zero)
                {
                    return string.Empty;
                }
                var span = new ReadOnlySpan<byte>(Buffer.ToPointer(), Length);
                return System.Text.Encoding.Unicode.GetString(span);
            }
        }




        public const int ProcessBasicInformation = 0;
        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_BASIC_INFORMATION
        {
            public uint ExitStatus;
            public Ptr__PEB PebBaseAddress;
            public UIntPtr AffinityMask;
            public int BasePriority;
            public UIntPtr UniqueProcessId;
            public UIntPtr InheritedFromUniqueProcessId;
        }

        public struct PTR_PROCESS_BASIC_INFORMATION(nint ptr)
        {
            public nint _ptr = ptr;

        }

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("ntdll.dll")]
        public static partial EnumNtStatus NtQueryInformationProcess(SafeProcessHandle ProcessHandle, int ProcessInformationClass, ref PROCESS_BASIC_INFORMATION ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);




        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("user32.dll", EntryPoint = "FindWindowExW", StringMarshalling = StringMarshalling.Utf16)]
        public static partial nint FindWindowEx(nint hWndParent, nint hWndChildAfter, string? lpszClass, string? lpszWindow);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("user32.dll", EntryPoint = "GetClassNameW", StringMarshalling = StringMarshalling.Utf16)]
        public static partial int GetClassName(nint hWnd, Span<char> lpClassName, int nMaxCount);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("user32.dll", EntryPoint = "EnumThreadWindows")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public unsafe static partial bool EnumThreadWindows(uint dwThreadId, CallBackEnumThreadWindows lpEnumFunc, nint lParam);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("user32.dll", EntryPoint = "CallWindowProcW", SetLastError = false)]
        public unsafe static partial nint CallWindowProc(nint lpPrevWndFunc, nint hWnd, EnumWindowMessage Msg, nint wParam, nint lParam);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("user32.dll", EntryPoint = "DefWindowProcW", SetLastError = false)]
        public unsafe static partial nint DefWindowProc(nint hWnd, EnumWindowMessage Msg, nint wParam, nint lParam);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("user32.dll", EntryPoint = "SetWindowLongPtrW", SetLastError = false)]
        public unsafe static partial nint SetWindowLongPtr(nint hWnd, EnumWindowLongPtrIndex nIndex, nint dwNewLong);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("user32.dll", EntryPoint = "GetWindowLongPtrW", SetLastError = false)]
        public unsafe static partial nint GetWindowLongPtr(nint hWnd, EnumWindowLongPtrIndex nIndex);


        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("kernel32.dll", EntryPoint = "GetCurrentThreadId", SetLastError = false)]
        public static partial int GetCurrentThreadId();

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("kernel32.dll", EntryPoint = "GetModuleHandleW", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial nint GetModuleHandle(string lpModuleName);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("kernel32.dll", EntryPoint = "GetProcAddress", SetLastError = false, StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(AnsiStringMarshaller))]
        public static partial nint GetProcAddress(nint hModule, string lpProcName);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("kernel32.dll", EntryPoint = "LoadLibraryW", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial nint LoadLibrary(string lpLibFileName);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("kernel32.dll", EntryPoint = "VirtualProtect", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool VirtualProtect(nint lpAddress, nuint dwSize, EnumVirtualProtectType flNewProtect, out EnumVirtualProtectType lpflOldProtect);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("kernel32.dll", EntryPoint = "VirtualAlloc", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static partial nint VirtualAlloc(nint lpAddress, nuint dwSize, EnumVirtualAllocType flAllocationType, EnumVirtualProtectType flProtect);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("kernel32.dll", EntryPoint = "VirtualFree", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static partial nint VirtualFree(nint lpAddress, nuint dwSize, EnumVirtualFreeTyoe dwFreeType);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("kernel32.dll", EntryPoint = "GetSystemInfo", SetLastError = false)]
        public static partial void GetSystemInfo(nint lpSystemInfo);
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct SYSTEM_INFO
        {
            internal PROCESSOR_INFO_UNION uProcessorInfo;
            public uint dwPageSize;
            public IntPtr lpMinimumApplicationAddress;
            public IntPtr lpMaximumApplicationAddress;
            public IntPtr dwActiveProcessorMask;
            public uint dwNumberOfProcessors;
            public uint dwProcessorType;
            public uint dwAllocationGranularity;
            public ushort dwProcessorLevel;
            public ushort dwProcessorRevision;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct PROCESSOR_INFO_UNION
        {
            [FieldOffset(0)]
            internal uint dwOemId;
            [FieldOffset(0)]
            internal ushort wProcessorArchitecture;
            [FieldOffset(2)]
            internal ushort wReserved;
        }
        public enum EnumVirtualProtectType : uint
        {
            ERROR_ALREADY_EXISTS = 183,

            FILE_MAP_COPY = 0x0001,

            FILE_MAP_WRITE = 0x0002,

            FILE_MAP_READ = 0x0004,

            FILE_MAP_ALL_ACCESS = 0x0002 | 0x0004,

            PAGE_READONLY = 0x02,

            PAGE_READWRITE = 0x04,

            PAGE_WRITECOPY = 0x08,

            PAGE_EXECUTE = 0x10,

            PAGE_EXECUTE_READ = 0x20,

            PAGE_EXECUTE_READWRITE = 0x40,

            SEC_COMMIT = 0x8000000,

            SEC_IMAGE = 0x1000000,

            SEC_NOCACHE = 0x10000000,

            SEC_RESERVE = 0x4000000,

        }

        public enum EnumVirtualAllocType : uint
        {
            MEM_COMMIT = 0x00001000,
            MEM_RESERVE = 0x00002000,
        }

        public enum EnumVirtualFreeTyoe : uint
        {
            MEM_DECOMMIT = 0x00004000,
            MEM_RELEASE = 0x00008000
        }


        public static nint Free(nint lpAddress)
        {
            return VirtualFree(lpAddress, nuint.Zero, EnumVirtualFreeTyoe.MEM_RELEASE);
        }

        public static unsafe nint LhAllocateMemory(nint inEntryPoint, out uint pageSize)
        {
            var st = new SYSTEM_INFO();
            var pSystemInfo = new nint(Unsafe.AsPointer(ref st));
            GetSystemInfo(pSystemInfo);
            pageSize = st.dwPageSize;


            var iStart = Math.Max((inEntryPoint - 0x7FFFFF00L), st.lpMinimumApplicationAddress);
            var iEnd = Math.Min((inEntryPoint + 0x7FFFFF00L), st.lpMaximumApplicationAddress);

            var _sPoint = inEntryPoint;
            var _ePoint = inEntryPoint;

            while (true)
            {
                bool end = true;
                _ePoint += (nint)pageSize;
                if (_ePoint < iEnd)
                {
                    var pCache = VirtualAlloc(_ePoint, pageSize, EnumVirtualAllocType.MEM_COMMIT | EnumVirtualAllocType.MEM_RESERVE, EnumVirtualProtectType.PAGE_EXECUTE_READWRITE);
                    if (pCache != nint.Zero)
                    {
                        return pCache;
                    }
                    end = false;
                }
                _sPoint -= (nint)pageSize;
                if (_sPoint > iStart)
                {
                    var pCache = VirtualAlloc(_sPoint, pageSize, EnumVirtualAllocType.MEM_COMMIT | EnumVirtualAllocType.MEM_RESERVE, EnumVirtualProtectType.PAGE_EXECUTE_READWRITE);
                    if (pCache != nint.Zero)
                    {
                        return pCache;
                    }
                    end = false;
                }
                if (end)
                {
                    return VirtualAlloc(nint.Zero, pageSize, EnumVirtualAllocType.MEM_COMMIT | EnumVirtualAllocType.MEM_RESERVE, EnumVirtualProtectType.PAGE_EXECUTE_READWRITE);

                }
            }
        }


        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("user32.dll", EntryPoint = "PostThreadMessageW", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static partial bool PostThreadMessage(int idThread, EnumWindowMessage Msg, nint wParam, nint lParam);


        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("user32.dll", EntryPoint = "WaitMessage", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static partial bool WaitMessage();

        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("user32.dll", EntryPoint = "GetMessageW", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial int GetMessage(ref MSG lpMsg, nint hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        public const nint MessageWinHandle = 0;
        public const nint MessageThreadHandle = -1;
        public const uint WM_QUIT = 0x0012;

        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("user32.dll", EntryPoint = "PeekMessageW", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static partial bool PeekMessage(ref MSG lpMsg, nint hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
        public const uint PM_NOREMOVE = 0;
        public const uint PM_REMOVE = 1;
        public const uint PM_NOYIELD = 2;


        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("user32.dll", EntryPoint = "PostQuitMessage", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial void PostQuitMessage(int nExitCode);


        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("user32.dll", EntryPoint = "SendMessageTimeoutW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static partial bool SendMessageTimeout(nint hWnd, EnumWindowMessage uMsg, nint wParam, nint lParam, uint fuFlags, uint uTimeout, out uint lpdwResult);

        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("user32.dll", EntryPoint = "SendMessageW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
        public static partial nint SendMessage(nint hWnd, EnumWindowMessage uMsg, nint wParam, nint lParam);

        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("user32.dll", EntryPoint = "PostMessageW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static partial bool PostMessage(nint hWnd, EnumWindowMessage uMsg, nint wParam, nint lParam);


        public const uint SMTO_ABORTIFHUNG = 0x2;
        public const uint SMTO_BLOCK = 0x1;
        public const uint SMTO_NORMAL = 0x0;
        public const uint SMTO_NOTIMEOUTIFNOTHUNG = 0x8;
        public const uint SMTO_ERRORONEXIT = 0x20;
        public const int ERROR_TIMEOUT = 1460;


        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial int GetWindowThreadProcessId(nint hWnd, out int lpdwProcessId);

        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("Kernel32.dll", EntryPoint = "GetExitCodeThread", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static partial bool GetExitCodeThread(nint hThread, out uint lpExitCode);
        public const uint STILL_ACTIVE = 0x103;

        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("Kernel32.dll", EntryPoint = "OpenThread", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial nint OpenThread(uint dwDesiredAccess, [MarshalAs(UnmanagedType.I4)] bool bInheritHandle, int dwThreadId);

        public const uint THREAD_QUERY_INFORMATION = 0x40;


        [StructLayout(LayoutKind.Sequential)]
        public struct MSG
        {
            public nint hwnd;
            public uint message;
            public nint wParam;
            public nint lParam;
            public int time;
            public int pt_x;
            public int pt_y;
            public uint lPrivate;
        }

        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("Kernel32.dll", EntryPoint = "CreateThread", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static unsafe partial nint CreateThread(nint lpThreadAttributes, nint dwStackSize, delegate* unmanaged[Stdcall]<nint, int> lpStartAddress, nint lpParameter, int dwCreationFlags, out int lpThreadId);

        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("Kernel32.dll", EntryPoint = "CloseHandle", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static partial bool CloseHandle(nint hObject);

        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        [LibraryImport("Kernel32.dll", EntryPoint = "WaitForSingleObject", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial int WaitForSingleObject(nint hHandle, int dwMilliseconds = INFINITE);
        public const int WAIT_ABANDONED = 0x00000080;
        public const int WAIT_OBJECT_0 = 0x00000000;
        public const int WAIT_TIMEOUT = 0x00000102;
        public const int WAIT_FAILED = -1;
        public const int INFINITE = -1;

        //[UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
        //[LibraryImport("user32.dll", EntryPoint = "IsWindow", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        //[return: MarshalAs(UnmanagedType.I4)]
        //public static partial bool IsWindow(nint hWnd);


        [SupportedOSPlatform("windows")]
        protected static string? GetGoogleWebBrowser()
        {
            var regData = Microsoft.Win32.Registry.CurrentUser;
            var webData = regData.OpenSubKey(@"Software\Google\Update", false);
            var path = webData?.GetValue("LastInstallerSuccessLaunchCmdLine") as string;
            return path;
        }

        [SupportedOSPlatform("windows")]
        protected static string? GetEdgeWebBrowser()
        {
            var regData = Microsoft.Win32.Registry.LocalMachine;
            var webData = regData.OpenSubKey(@"SOFTWARE\Clients\StartMenuInternet\Microsoft Edge\shell\open\command", false);
            var path = webData?.GetValue(string.Empty) as string;
            return path;
        }
        public static bool RunBrowser(string url)
        {

            if (OperatingSystem.IsWindows())
            {
                var webPath = GetEdgeWebBrowser();
                if (string.IsNullOrEmpty(webPath))
                {
                    webPath = GetGoogleWebBrowser();
                }

                if (File.Exists(webPath))
                {
                    return RunWebBrowser(webPath, url);
                }
            }
            var p = System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true });
            return p is not null;
        }

        protected static bool RunWebBrowser(string path, string arg)
        {
            var psi = new System.Diagnostics.ProcessStartInfo()
            {
                FileName = path,
                UseShellExecute = true,
                Arguments = $"--app={arg}",
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
            };
            var p = System.Diagnostics.Process.Start(psi);
            return p is not null;

        }

    }
}
