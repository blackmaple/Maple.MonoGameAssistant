using DevExpress.Utils.Design;
using DevExpress.Utils.FormShadow;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.UILogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm.UI
{
    public partial class ViewGameTab : DevExpress.XtraEditors.XtraForm
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public required GameCodeContext GameCodeContext { set; get; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public required ViewMainForm ViewMainForm { set; get; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public required UIService UIService { set; get; }
        //  GameContextFactory GameContextFactory => UIService.GameContextFactory;

        UIBindingList<GameImageInfo> BindListImage { get; } = [];
        UIBindingList<GameClassInfo> BindListClass { get; } = [];
        public ViewGameTab(ViewMainForm viewMainForm, UIService uIService) : this()
        {
            this.MdiParent = viewMainForm;
            this.ViewMainForm = viewMainForm;
            this.UIService = uIService;

        }
        public ViewGameTab()
        {
            InitializeComponent();

            this.gcImageInfo.DataSource = this.BindListImage;
            this.colImageName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gvImageInfo.SetGridViewRowNumber();
            this.gvImageInfo.RowCellClick += async (sender, e) => await OnSelectedImageInfo(sender, e);
            this.gvImageInfo.CustomRowCellEdit += GvImageInfo_CustomRowCellEdit;


            this.colClassFullName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcClassInfo.DataSource = this.BindListClass;
            this.gvClassInfo.SetGridViewRowNumber();
            this.gvClassInfo.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameClassInfo, MonoClassInfoDTO>(sender, e, colClassFullName, rawObject => rawObject.RawClassInfo);
            this.gvClassInfo.RowCellClick += async (sender, e) => await OnSelectedClassInfo(sender, e);

        }


        private void GvImageInfo_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.RepositoryItem is UIImageDisplay)
            {
                return;
            }
            if (e.Column.Name != colImageName.Name)
            {
                return;
            }
            if (sender is not GridView gv)
            {
                return;
            }
            if (gv.GetRow(e.RowHandle) is not GameImageInfo gameImageInfo)
            {
                return;
            }
            e.RepositoryItem = UIImageDisplay.Create(gameImageInfo);




        }

        private async ValueTask OnSelectedImageInfo(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (false == UIHelper.TryGetDoubleClickedRowCellObject<GameImageInfo>(sender, e, colImageName, out var gameImageInfo))
            {
                return;
            }
            using (this.ShowSplashScreen())
            {
                var gameClassInfos = await this.GameCodeContext.LoadGameClassInfosAsync(gameImageInfo, this.ViewMainForm.ShowErorr);
                this.BindListClass.ReplaceRange(gameClassInfos);
                this.gvClassInfo.ViewCaption = $"{gameImageInfo.RawImageInfo.Name}:{gameClassInfos.Count}";
            }
        }

        private async ValueTask OnSelectedClassInfo(object sender, RowCellClickEventArgs e)
        {
            if (false == UIHelper.TryGetDoubleClickedRowCellObject<GameClassInfo>(sender, e, colClassFullName, out var gameClassInfo))
            {
                return;
            }
            using (this.ShowSplashScreen())
            {
                await OpenPageClassDetailAsync(gameClassInfo, true);
            }
        }

        private void ViewGameTab_Load(object sender, EventArgs e)
        {
            this.Text = $"{this.GameCodeContext.GamePID}-{this.GameCodeContext.GameName}";
            this.gvImageInfo.ViewCaption = $"{this.GameCodeContext.GameName}:{this.GameCodeContext.ImageInfos.Count}";
            this.BindListImage.AddRange(this.GameCodeContext.ImageInfos);

        }

        private async void OnOpenPageCodeView(object? sender, EventArgs e)
        {
            await this.OnOpenPageCodeViewAsync(sender, e);
        }
        private async ValueTask OnOpenPageCodeViewAsync(object? sender, EventArgs e)
        {
            if (sender is not PageClassDetail page || page.ParentForm is null)
            {
                return;
            }
            if (page.SelectedGameClassInfo is null)
            {
                return;
            }
            using (page.ParentForm.ShowSplashScreen())
            {
                await this.OpenPageCodeViewAsync(page.SelectedGameClassInfo);
            }
        }
        private async Task OpenPageCodeViewAsync(GameClassInfo gameClassInfo)
        {
            string codeView = await gameClassInfo.ShowCodeAsync();
            using var pageCodeEditor = this.UIService.GetForm<PageCodeEditor>();
            pageCodeEditor.SetCodeView(codeView.ToString());
            var args = new XtraDialogArgs
            {
                Owner = default,
                Caption = gameClassInfo.RawClassInfo.FullName,
                Buttons = [System.Windows.Forms.DialogResult.OK, System.Windows.Forms.DialogResult.Yes, System.Windows.Forms.DialogResult.Continue],
                Content = pageCodeEditor,
                ContentPadding = new System.Windows.Forms.Padding(10)
            };
            args.Showing += (s, e) =>
            {
                var button = e.Buttons[System.Windows.Forms.DialogResult.Yes];
                button.Text = "Copy";
                button.Click += (bs, be) =>
                {
                    System.Windows.Clipboard.Clear();
                    System.Windows.Clipboard.SetText(codeView);
                };

                var btnWrite = e.Buttons[System.Windows.Forms.DialogResult.Continue];
                btnWrite.Text = "Write";
                btnWrite.Click += async (bs, be) =>
                {
                    await WriteClassFileAsync(gameClassInfo.RawClassInfo.FullName??$"{DateTime.Now:yyyyMMddHHmmssffff}", codeView);
                };

            };
            XtraDialog.Show(args);


        }

        private async ValueTask WriteClassFileAsync(string fileName, string codeView)
        {
            var filePath = this.BtnTxtFilePath.EditValue as string;
            if (Directory.Exists(filePath) == false)
            {
                return;
            }

           
            var fullName = Path.Combine(filePath, $"{GameRemoteDataService.MakeValidFileName(fileName)}.cs");

            var nameSpace = this.TxtNamespace.EditValue as string;
            if (string.IsNullOrEmpty(nameSpace))
            {
                nameSpace = "Maple.Game";
            }
            var fullCodeView = @$"
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {nameSpace}
{{
    
    {codeView}

}}";
            await File.WriteAllTextAsync(fullName, fullCodeView);
        }


        private async void OnOpenPageClassDetail(object? sender, GameClassInfo? e, bool loadServer)
        {
            await OnOpenPageClassDetailAsync(sender, e, loadServer);
        }
        private async ValueTask OnOpenPageClassDetailAsync(object? sender, GameClassInfo? e, bool loadServer)
        {
            if (sender is not UserControl page || page.ParentForm is null)
            {
                return;
            }
            using (page.ParentForm.ShowSplashScreen())
            {
                await OpenPageClassDetailAsync(e, loadServer);
            }
        }
        public async ValueTask OpenPageClassDetailAsync(GameClassInfo? gameClassInfo, bool loadServer)
        {
            if (gameClassInfo is null)
            {
                return;
            }


            if (await this.GameCodeContext.GetGameClassDetailAsync(gameClassInfo, loadServer, EnumMonoFieldOptions.EnumAndConstAndStatic, this.ViewMainForm.ShowErorr) == false)
            {
                return;
            }

            using var pageClassDialog = this.UIService.GetForm<PageClassDetail>();
            pageClassDialog.SetSelectedGameClassInfo(gameClassInfo, loadServer);
            var args = new XtraDialogArgs
            {
                Owner = default,
                Caption = $"{gameClassInfo.RawClassInfo.FullName}<color=red>({(loadServer ? "Server" : "Local")})</color>",
                Content = pageClassDialog,
                AllowHtmlText = DevExpress.Utils.DefaultBoolean.True,
                ContentPadding = new System.Windows.Forms.Padding(5, 5, 5, 5)
            };
            try
            {

                pageClassDialog.OnOpenPageCodeViewEventHandler += OnOpenPageCodeView;
                pageClassDialog.OnOpenPageClassDetailEventHandler += OnOpenPageClassDetail;
                pageClassDialog.OnOpenPageOrgClassesEventHandler += OnOpenPageOrgClasses;

                XtraDialog.Show(args);
            }
            finally
            {
                pageClassDialog.OnOpenPageCodeViewEventHandler -= OnOpenPageCodeView;
                pageClassDialog.OnOpenPageClassDetailEventHandler -= OnOpenPageClassDetail;
                pageClassDialog.OnOpenPageOrgClassesEventHandler -= OnOpenPageOrgClasses;

            }


        }

        private async void OnOpenPageOrgClasses(object? sender, EventArgs e)
        {
            await OnOpenPageOrgClassesAsync(sender, e);
        }
        private async ValueTask OnOpenPageOrgClassesAsync(object? sender, EventArgs e)
        {
            if (sender is not PageClassDetail page || page.ParentForm is null)
            {
                return;
            }
            if (page.SelectedGameClassInfo is null)
            {
                return;
            }
            using (page.ParentForm.ShowSplashScreen())
            {
                await this.OpenPageOrgClasses(page.SelectedGameClassInfo);
            }

        }
        private async Task OpenPageOrgClasses(GameClassInfo gameClassInfo)
        {
            GameOrgClassesInfo gameOrgClassesInfo = await this.GameCodeContext.LocalCacheService.SearchOrgClassesAsync(gameClassInfo);
            using var pageOrgClasses = this.UIService.GetForm<PageOrgClasses>();
            try
            {
                pageOrgClasses.OnOpenPageClassDetailEventHandler += OnOpenPageClassDetail;
                pageOrgClasses.ShowDialog(gameClassInfo, gameOrgClassesInfo);

            }
            finally
            {
                pageOrgClasses.OnOpenPageClassDetailEventHandler -= OnOpenPageClassDetail;

            }

        }




        private void BtnSaveImageInfos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (this.ShowSplashScreen())
            {
                if (this.TryOpenFolderBrowserDialog(out var selectedPath))
                {
                    var page = this.UIService.GetForm<PageSaveProgress>();
                    page.GameCodeContext = this.GameCodeContext;
                    page.SelectedPath = selectedPath;
                    page.ShowDialog(this);
                }
            }

        }

        private void BtnLoadImageInfos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (this.ShowSplashScreen())
            {
                if (this.TryOpenFolderBrowserDialog(out var selectedPath))
                {
                    using var page = this.UIService.GetForm<PageSaveProgress>();
                    page.GameCodeContext = this.GameCodeContext;
                    page.SelectedPath = selectedPath;
                    page.ShowDialog(this, false);
                }
            }
        }

        private void BtnShowClassInfos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (this.GameCodeContext.Logger.Running())
            {
                using var page = this.UIService.GetForm<PageSpecialClasses>();
                try
                {
                    var datas = this.GameCodeContext.LocalCacheService.GetSpecialClasses();

                    page.OnOpenPageClassDetailEventHandler += OnOpenPageClassDetail;
                    page.GameCodeContext = this.GameCodeContext;
                    page.ShowDialog(this, datas);

                }
                finally
                {
                    page.OnOpenPageClassDetailEventHandler -= OnOpenPageClassDetail;
                }
            }
        }

        private void BtnTxtClassPath_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void RepItemText_Click(object sender, EventArgs e)
        {

        }

        private void RepItemFilePath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.TryOpenFolderBrowserDialog(out var selectedPath))
            {
                this.BtnTxtFilePath.EditValue = selectedPath;
            }
            else
            {
                this.BtnTxtFilePath.EditValue = string.Empty;
            }
        }
    }
}