using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.UILogic;
using Maple.MonoGameAssistant.WinForm.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm
{
    public partial class ViewMainForm : ToolbarForm
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public required UIService UIService { get; set; }
        GameContextFactory GameContextFactory => UIService.GameContextFactory;

        
        public ViewMainForm(UIService uIService) : this()
        {
            this.UIService = uIService;
        }

        public ViewMainForm()
        {
            InitializeComponent();


        }



        private void ViewMainForm_Load(object sender, EventArgs e)
        {
            ShowHomeTab();
        }



        private void TabMgr_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (e.Page.MdiChild is ViewHomeTab)
            {
                e.Page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
                e.Page.Pinned = true;
                e.Page.ShowPinButton = DevExpress.Utils.DefaultBoolean.False;

            }
        }

        private void TabMgr_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (e.Page.MdiChild is ViewHomeTab)
            {
                ShowHomeTab();
            }
        }

        public async Task ShowMsg(string msg)
        {
            this.ckflyPanel.ShowPopup();
            this.cklabel.Text = msg;
            await Task.Delay(2000);
            this.ckflyPanel.HidePopup();

        }
        public Task ShowErorr(MonoResultDTO resultDTO) => ShowMsg($"{resultDTO.CODE}:{resultDTO.MSG}");


        public async ValueTask AddWorkTab()
        {
            var args = new XtraInputBoxArgs()
            {
                Owner = this,
                Caption = "Selected Game Process",
                Editor = CreateSelectedProcessDialog(), //new TextEdit(),
                Prompt = "Selected Game Process",
                //          DefaultResponse = "http://localhost:49009",
                Buttons = [DialogResult.OK, DialogResult.Cancel]
            };
            if (XtraInputBox.Show(args) is not string pipeName)
            {
                return;
            }

            await AddGameTab(pipeName);
            //var uri = XtraInputBox.Show(this, "Game Service Uri", "AddGame", "http://localhost:49009", Buttons.OKCancel);
            //if (uri is null)
            //{
            //    return;
            //}
            //if (Uri.TryCreate(uri, new UriCreationOptions() { DangerousDisablePathAndQueryCanonicalization = true }, out var gameUri) == false)
            //{
            //    await this.ShowMsg($"Error {uri}");
            //    return;
            //}

        }
        public async ValueTask AddGameTab(string? pipeName)
        {
            if (string.IsNullOrEmpty(pipeName))
            {
                return;
            }

            using (this.ShowSplashScreen())
            {
                var monoResultDTO = await this.GameContextFactory.TryCreateGameCodeContext(pipeName);
                if (false == monoResultDTO.TryGet(out var gameCodeContext))
                {
                    _ = this.ShowErorr(monoResultDTO);
                    return;
                }

                if (await gameCodeContext.LoadGameImageInfosAsync(ShowErorr))
                {
                    var workTab = this.UIService.GetForm<ViewGameTab>();
                    workTab.GameCodeContext = gameCodeContext;
                    workTab.Show();
                }

            }

        }
        private void ShowHomeTab()
        {
            var tab = this.UIService.GetForm<ViewHomeTab>();
            tab.Show();

        }
        static SearchLookUpEdit CreateSelectedProcessDialog()
        {
            var imageEdit = new RepositoryItemPictureEdit()
            {
                NullText = string.Empty,
                SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom,

            };
            var colIcon = new GridColumn()
            {

                Caption = nameof(UIProcessInfo.ProcessIcon),
                FieldName = nameof(UIProcessInfo.ProcessIcon),
                Name = nameof(UIProcessInfo.ProcessIcon),
                ColumnEdit = imageEdit,
                Visible = true,
                VisibleIndex = 0,
                Width = 80

            };
            colIcon.OptionsColumn.AllowEdit = false;

            var colDisplayName = new GridColumn()
            {

                Caption = nameof(UIProcessInfo.DisplayName),
                FieldName = nameof(UIProcessInfo.DisplayName),
                Name = nameof(UIProcessInfo.DisplayName),
                Visible = true,
                VisibleIndex = 0,
                Width = 300,

            };
            colDisplayName.OptionsColumn.AllowEdit = false;

            //var colProcessId = new GridColumn()
            //{
            //    Caption = nameof(UIProcessInfo.Id),
            //    FieldName = nameof(UIProcessInfo.Id),
            //    Name = nameof(UIProcessInfo.Id),
            //    Visible = true,
            //    VisibleIndex = 0
            //};
            //colProcessId.OptionsColumn.AllowEdit = false;

            var gridView = new DevExpress.XtraGrid.Views.Grid.GridView();

            gridView.Columns.Clear();
            gridView.Columns.AddRange([colIcon, colDisplayName]);
            gridView.DetailHeight = 272;
            gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView.Name = "GridUIProcessInfoView";
            gridView.OptionsEditForm.PopupEditFormWidth = 700;
            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.OptionsFind.AlwaysVisible = true;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            gridView.OptionsView.EnableAppearanceEvenRow = true;
            gridView.OptionsView.ShowColumnHeaders = false;
            gridView.OptionsView.ShowGroupPanel = false;



            var editor = new SearchLookUpEdit();
            editor.Properties.PopupView = gridView;
            editor.Properties.DataSource = UIProcessInfo.GetUIProcessInfos();
            editor.Properties.DisplayMember = nameof(UIProcessInfo.DisplayName);
            editor.Properties.ValueMember = nameof(UIProcessInfo.DisplayName);
            editor.Properties.ShowClearButton = false;
            editor.Properties.NullText = "NotSelected...";
            return editor;
        }

        private async void BtnAddGame_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await AddWorkTab();
        }


 


    }
}