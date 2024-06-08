using DevExpress.XtraEditors;
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
    public partial class PageOrgClasses : DevExpress.XtraEditors.XtraUserControl
    {
        UIBindingList<GameClassInfo> RefField_GameClassInfos { get; } = [];
        UIBindingList<GameClassInfo> UseField_GameClassInfos { get; } = [];

        UIBindingList<GameClassInfo> Parent_GameClassInfos { get; } = [];
        UIBindingList<GameClassInfo> Derived_GameClassInfos { get; } = [];

        UIBindingList<GameClassInfo> RefMethod_GameClassInfos { get; } = [];
        UIBindingList<GameClassInfo> UseMethod_GameClassInfos { get; } = [];



        public PageOrgClasses()
        {
            InitializeComponent();
            //TabPageField
            this.colRefFieldClassFullName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcRefFieldClassInfo.DataSource = RefField_GameClassInfos;
            this.gvRefFieldClassInfo.SetGridViewRowNumber();
            this.gvRefFieldClassInfo.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameClassInfo, MonoClassInfoDTO>(sender, e, colRefFieldClassFullName, rawObject => rawObject.RawClassInfo);
            this.gvRefFieldClassInfo.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameClassInfo>(sender, e, colRefFieldClassFullName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawClassInfo));

            this.colUseFieldClassFullName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcUseFieldClassInfo.DataSource = UseField_GameClassInfos;
            this.gvUseFieldClassInfo.SetGridViewRowNumber();
            this.gvUseFieldClassInfo.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameClassInfo, MonoClassInfoDTO>(sender, e, colUseFieldClassFullName, rawObject => rawObject.RawClassInfo);
            this.gvUseFieldClassInfo.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameClassInfo>(sender, e, colUseFieldClassFullName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawClassInfo));

            //TabPageInherit
            this.colParentClassFullName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcParentClassInfo.DataSource = Parent_GameClassInfos;
            this.gvParentClassInfo.SetGridViewRowNumber();
            this.gvParentClassInfo.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameClassInfo, MonoClassInfoDTO>(sender, e, colParentClassFullName, rawObject => rawObject.RawClassInfo);
            this.gvParentClassInfo.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameClassInfo>(sender, e, colParentClassFullName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawClassInfo));


            this.colDerivedClassFullName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcDerivedClassInfo.DataSource = Derived_GameClassInfos;
            this.gvDerivedClassInfo.SetGridViewRowNumber();
            this.gvDerivedClassInfo.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameClassInfo, MonoClassInfoDTO>(sender, e, colDerivedClassFullName, rawObject => rawObject.RawClassInfo);
            this.gvDerivedClassInfo.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameClassInfo>(sender, e, colDerivedClassFullName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawClassInfo));

            ////TabPageMethod
            this.colUseMethodClassFullName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcUseMethodClassInfo.DataSource = RefMethod_GameClassInfos;
            this.gvUseMethodClassInfo.SetGridViewRowNumber();
            this.gvUseMethodClassInfo.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameClassInfo, MonoClassInfoDTO>(sender, e, colUseMethodClassFullName, rawObject => rawObject.RawClassInfo);
            this.gvUseMethodClassInfo.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameClassInfo>(sender, e, colUseMethodClassFullName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawClassInfo));


            this.colRefMethodClassFullName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcRefMethodClassInfo.DataSource = UseMethod_GameClassInfos;
            this.gvRefMethodClassInfo.SetGridViewRowNumber();
            this.gvRefMethodClassInfo.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameClassInfo, MonoClassInfoDTO>(sender, e, colRefMethodClassFullName, rawObject => rawObject.RawClassInfo);
            this.gvRefMethodClassInfo.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameClassInfo>(sender, e, colRefMethodClassFullName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawClassInfo));


        }



        public DialogResult ShowDialog(GameClassInfo gameClassInfo, GameOrgClassesInfo gameOrgClassesInfo)
        {
            this.UseField_GameClassInfos.ReplaceRange(gameOrgClassesInfo.UseFieldClasses);
            this.RefField_GameClassInfos.ReplaceRange(gameOrgClassesInfo.RefFieldClasses);

            this.Parent_GameClassInfos.ReplaceRange(gameOrgClassesInfo.ParentClasses);
            this.Derived_GameClassInfos.ReplaceRange(gameOrgClassesInfo.DerivedClasses);

            this.RefMethod_GameClassInfos.ReplaceRange(gameOrgClassesInfo.RefMethodClasses);
            this.UseMethod_GameClassInfos.ReplaceRange(gameOrgClassesInfo.UseMethodClasses);

            //
            //this.TabView.SelectedTabPage = TabPageInherit;
            //this.TabView.SelectedTabPage = TabPageMethod;
            //this.TabView.SelectedTabPage = TabPageField;

            var args = new XtraDialogArgs
            {
                Owner = default,
                Caption = gameClassInfo.RawClassInfo.FullName,
                Buttons = [System.Windows.Forms.DialogResult.OK],
                Content = this,
                // ContentPadding = new System.Windows.Forms.Padding(10)
            };

            return XtraDialog.Show(args);

        }

        public event Action<object?, GameClassInfo?, bool>? OnOpenPageClassDetailEventHandler;

        private void Action_OnOpenPageClassDetail(MonoClassInfoDTO classInfo)
        {
            this.OnOpenPageClassDetailEventHandler?.Invoke(this, new GameClassInfo() { RawClassInfo = classInfo }, false);
        }


    }
}
