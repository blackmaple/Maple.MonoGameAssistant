
using DevExpress.LookAndFeel;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid.Data;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Logger;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UILogic;
using Maple.MonoGameAssistant.WinForm.UI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            WindowsFormsSettings.ForceDirectXPaint();
            UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXI.Darkness);

            Application.Run(ConfigService());
            //   Application.Exit
        }


        static ViewMainForm ConfigService()
        {
            ServiceCollection services = new();
            services.AddLogging(p => p.AddOnlyMonoGameLogger());
            services.AddGameContextService();

            services.AddSingleton<ViewMainForm>();
            services.AddTransient<ViewHomeTab>();
            services.AddTransient<ViewGameTab>();

            services.AddTransient<PageCodeEditor>();
            services.AddTransient<PageClassDetail>();
            services.AddTransient<PageSpecialClasses>();
            services.AddTransient<PageSaveProgress>();
            services.AddTransient<PageOrgClasses>();

            services.AddSingleton<UIService>();

            var serviceProvider = services.BuildServiceProvider();
            var main = serviceProvider.GetRequiredService<ViewMainForm>();

            return main;
        }
    }
}
