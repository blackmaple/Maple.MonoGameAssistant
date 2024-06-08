using DevExpress.XtraEditors;
using Maple.MonoGameAssistant.UILogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm
{
    public partial class ViewHomeTab : DevExpress.XtraEditors.XtraForm
    {
        public required ViewMainForm ViewMainForm { set; get; }
        public required UIService UIService { set; get; }
        GameContextFactory GameContextFactory => UIService.GameContextFactory;
        UIBindingList<UIProcessInfo> BindListProcess { get; } = [];

        static ViewHomeTab()
        {
            XtraMessageBox.AllowHtmlText = true;
        }

        public ViewHomeTab(ViewMainForm viewMainForm, UIService uIService) : this()
        {
            this.MdiParent = viewMainForm;
            this.ViewMainForm = viewMainForm;
            this.UIService = uIService;

        }

        public ViewHomeTab()
        {
            InitializeComponent();
            //     this.gvProcess.RowCountChanged += (sender, e) => this.gvProcess.BestFitColumns();
            this.gcProcess.DataSource = this.BindListProcess;
            this.gvProcess.SetGridViewRowNumber();
            this.gvProcess.RowCellClick += async (sender, e) => await OpenViewGameTab(sender, e);

        }


        private async ValueTask OpenViewGameTab(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (false == UIHelper.TryGetDoubleClickedRowCellObject<UIProcessInfo>(sender, e, default, out var processInfo))
            {
                return;
            }
            if (DialogResult.OK != XtraMessageBox.Show(this, $"OpenGame <color=red>{processInfo.DisplayName}</color>", "OpenGame", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }


            if (false == System.Diagnostics.Process.GetProcessesByName(processInfo.ProcessName).Any(p => p.Id == processInfo.ProcessId))
            {
                await  this.ViewMainForm.ShowMsg($"{processInfo.DisplayName} Has Already Exited");
                this.BtnLoadProcess.PerformClick();
                return;
            }
            await this.ViewMainForm.AddGameTab(processInfo.DisplayName);
        }

        private async void ViewHomeTab_Load(object sender, EventArgs e)
        {
            await Task.Delay(500);
            BtnLoadProcess.PerformClick();
        }

        private async void BtnLoadProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (this.ShowSplashScreen())
            {
                var datas = await UIProcessInfo.GetUIProcessInfosAsync();
                this.BindListProcess.ReplaceRange(datas);
            }
        }
    }
}