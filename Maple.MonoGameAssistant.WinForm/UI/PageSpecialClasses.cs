using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UILogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm.UI
{
    public partial class PageSpecialClasses : DevExpress.XtraEditors.XtraUserControl
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public required GameCodeContext GameCodeContext { set; get; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public required ViewMainForm ViewMainForm { set; get; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public required UIService UIService { set; get; }
        //   GameContextFactory GameContextFactory => UIService.GameContextFactory;

        UIBindingList<GameClassInfo> BindListClass { get; } = [];
        public PageSpecialClasses(ViewMainForm viewMainForm, UIService uIService) : this()
        {

            this.ViewMainForm = viewMainForm;
            this.UIService = uIService;

        }

        public event Action<object?, GameClassInfo?, bool>? OnOpenPageClassDetailEventHandler;

        public PageSpecialClasses()
        {
            InitializeComponent();

            this.colClassFullName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcClassInfo.DataSource = this.BindListClass;
            this.gvClassInfo.SetGridViewRowNumber();
            this.gvClassInfo.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameClassInfo, MonoClassInfoDTO>(sender, e, colClassFullName, rawObject => rawObject.RawClassInfo);
            this.gvClassInfo.RowCellClick += GvClassInfo_RowCellClick;

        }

        private void GvClassInfo_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (false == UIHelper.TryGetDoubleClickedRowCellObject<GameClassInfo>(sender, e, colClassFullName, out var gameClassInfo))
            {
                return;
            }
            OnOpenPageClassDetailEventHandler?.Invoke(this, gameClassInfo, false);
        }

        public DialogResult ShowDialog(Form frm, IReadOnlyList<GameClassInfo> gameClassInfos)
        {
            this.BindListClass.ReplaceRange(gameClassInfos);

            var args = new XtraDialogArgs
            {
                Owner = frm,
                Caption = "SpecialClasses",
                Content = this,
                ContentPadding = new System.Windows.Forms.Padding(10),
                Buttons = [System.Windows.Forms.DialogResult.OK, System.Windows.Forms.DialogResult.Cancel],

            };

            args.Showing += (sender, e) => this.gvClassInfo.ViewCaption = $"ClassView:({this.BindListClass.Count})";
            return XtraDialog.Show(args);

        }

        private void SwitchShowClsses_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sender is not BarToggleSwitchItem switchItem)
            {
                return;
            }
            if (switchItem.Checked)
            {
                this.BindListClass.ReplaceRange(this.GameCodeContext.LocalCacheService.GameClassInfos);
            }
            else
            {
                this.BindListClass.ReplaceRange(this.GameCodeContext.LocalCacheService.GetSpecialClasses());
            }
            this.gvClassInfo.ViewCaption = $"ClassView:({this.BindListClass.Count})";
        }
    }
}
