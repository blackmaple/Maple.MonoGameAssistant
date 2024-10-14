using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.WinApi;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm
{
    public class UIProcessInfo
    {
        public required string DisplayName { set; get; }
        public Icon? ProcessIcon { set; get; }
        public string? ProcessName { set; get; }
        public int ProcessId { set; get; }
        public nint MainHandle { set; get; }

        public static UIProcessInfo[] GetUIProcessInfos()
        {

            return
            [
                .. Process.GetProcesses().Select(p => new UIProcessInfo()
                {
                    ProcessId = p.Id,
                    ProcessName = p.ProcessName,
                    DisplayName = MonoJsonExtensions.GetPipeName(p),
                    MainHandle = p.MainWindowHandle,
                  
                    ProcessIcon = GetIcon(p),
                })
                .OrderByDescending(p => p.MainHandle == nint.Zero ? 0 : 1)
                .ThenByDescending(p => p.ProcessIcon is null ? 0 : 1)
            //   .ThenBy(p => p.ProcessId)
            ];


            static Icon? GetIcon(Process p)
            {

                //try
                //{
                //    if (p.MainModule is not null)
                //    {
                //        return Icon.ExtractAssociatedIcon(p.MainModule.FileName);
                //    }
                //}
                //catch { }
                //finally
                //{

                //}
                //return default;
                if (TryGetProcessMainModule(p, out var processModule))
                {
                    return Icon.ExtractAssociatedIcon(processModule.FileName);
                }
                return default;
            }
        }
        public static Task<UIProcessInfo[]> GetUIProcessInfosAsync() => Task.Run(() => GetUIProcessInfos());
        static bool TryGetProcessMainModule(Process process, [MaybeNullWhen(false)] out ProcessModule module)
        {
            module = default;
            try
            {
               
                var handle = WindowsRuntime.OpenProcess(WindowsRuntime.PROCESS_QUERY_INFORMATION | WindowsRuntime.PROCESS_VM_READ, false, process.Id);
                if (handle != nint.Zero)
                {
                    WindowsRuntime.CloseHandle(handle);
                    module = process.MainModule;
                }
                return module is not null;
            }
            catch
            {

            }
            return default;
        }
    }


}