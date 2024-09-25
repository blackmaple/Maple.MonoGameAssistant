using DevExpress.CodeParser;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Model;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UILogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.WinForm
{
    public partial class PageClassDetail : DevExpress.XtraEditors.XtraUserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool LoadServer { set; get; } = true;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GameClassInfo? SelectedGameClassInfo { get; set; }
        UIBindingList<GameMethodInfo> BindListMethod { get; } = [];
        UIBindingList<GameParentClassInfo> BindListParentClass { get; } = [];
        UIBindingList<GameInterfaceInfo> BindListInterface { get; } = [];

        UIBindingList<GameFieldInfo> BindListMemberField { get; } = [];
        UIBindingList<GameFieldInfo> BindListStaticField { get; } = [];
        UIBindingList<GameFieldInfo> BindListConstField { get; } = [];
        UIBindingList<GameFieldInfo> BindListEnumField { get; } = [];


        public PageClassDetail()
        {
            InitializeComponent();

            this.GridMethod.DataSource = this.BindListMethod;
            this.GridParentClass.DataSource = this.BindListParentClass;
            this.GridConstField.DataSource = this.BindListConstField;
            this.GridEnumField.DataSource = this.BindListEnumField;
            this.GridMemberField.DataSource = this.BindListMemberField;
            this.GridStaticField.DataSource = this.BindListStaticField;
            this.GridInterface.DataSource = this.BindListInterface;



            this.colMethodReturnTypeName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.ViewMethod.SetGridViewRowNumber();
            this.ViewMethod.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameMethodInfo>(sender, e, colMethodReturnTypeName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawMethodInfo.ReturnType));
            this.ViewMethod.CustomRowCellEdit += ViewMethod_CustomRowCellEdit;

            this.colMethodName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colMethodParameterTypeName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.ViewParam.SetGridViewRowNumber();
            this.ViewParam.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameParameterType>(sender, e, colMethodParameterTypeName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawParameterType));
            this.ViewParam.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameParameterType, MonoParameterTypeDTO>(sender, e, colMethodParameterTypeName, rawObject => rawObject.RawParameterType);

            this.colParentClassFullName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.ViewParentClass.SetGridViewRowNumber();
            this.ViewParentClass.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameParentClassInfo>(sender, e, colParentClassFullName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawClassInfo));
            this.ViewParentClass.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameParentClassInfo, MonoClassInfoDTO>(sender, e, colParentClassFullName, rawObject => rawObject.RawClassInfo);


            this.colInterfaceFullName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.ViewInterface.SetGridViewRowNumber();
            this.ViewInterface.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameInterfaceInfo>(sender, e, colInterfaceFullName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawInterfaceInfo));
            this.ViewInterface.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameInterfaceInfo, MonoClassInfoDTO>(sender, e, colInterfaceFullName, rawObject => rawObject.RawInterfaceInfo);


            this.colMemberFieldTypeName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.ViewMemberField.SetGridViewRowNumber();
            this.ViewMemberField.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameFieldInfo>(sender, e, colMemberFieldTypeName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawFieldInfo.FieldType));
            this.ViewMemberField.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameFieldInfo, MonoClassInfoDTO>(sender, e, colMemberFieldTypeName, rawObject => rawObject.RawFieldInfo.FieldType);

            this.colStaticFieldTypeName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.ViewStaticField.SetGridViewRowNumber();
            this.ViewStaticField.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameFieldInfo>(sender, e, colStaticFieldTypeName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawFieldInfo.FieldType));
            this.ViewStaticField.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameFieldInfo, MonoClassInfoDTO>(sender, e, colStaticFieldTypeName, rawObject => rawObject.RawFieldInfo.FieldType);

            this.colEnumFieldTypeName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.ViewEnumField.SetGridViewRowNumber();
            this.ViewEnumField.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameFieldInfo>(sender, e, colEnumFieldTypeName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawFieldInfo.FieldType));
            this.ViewEnumField.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameFieldInfo, MonoClassInfoDTO>(sender, e, colEnumFieldTypeName, rawObject => rawObject.RawFieldInfo.FieldType);

            this.colConstFieldTypeName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.ViewConstField.SetGridViewRowNumber();
            this.ViewConstField.RowCellClick += (sender, e) => UIHelper.GridView_RowCellClick<GameFieldInfo>(sender, e, colConstFieldTypeName, rawObject => this.Action_OnOpenPageClassDetail(rawObject.RawFieldInfo.FieldType));
            this.ViewConstField.CustomRowCellEdit += (sender, e) => UIHelper.GridView_CustomRowCellEdit<GameFieldInfo, MonoClassInfoDTO>(sender, e, colConstFieldTypeName, rawObject => rawObject.RawFieldInfo.FieldType);


        }

        private void ViewMethod_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (sender is not GridView gv)
            {
                return;
            }
            if (gv.GetRow(e.RowHandle) is not GameMethodInfo rawObject)
            {
                return;
            }
            if (e.Column.Name == colMethodReturnTypeName.Name)
            {
                if (e.RepositoryItem is not UIClassDisplay)
                {
                    e.RepositoryItem = UIClassDisplay.Create(rawObject.RawMethodInfo.ReturnType);
                }
            }
            else if (e.Column.Name == colMethodName.Name)
            {
                if (e.RepositoryItem is not UIMethodDisplay)
                {
                    e.RepositoryItem = UIMethodDisplay.Create(rawObject.RawMethodInfo);
                }
            }





        }


        public event EventHandler? OnOpenPageCodeViewEventHandler;
        public event EventHandler? OnOpenPageOrgClassesEventHandler;
        public event Action<object?, GameClassInfo?, bool>? OnOpenPageClassDetailEventHandler;
        public void UnSelectedGameClassInfo()
        {
            this.SelectedGameClassInfo = default;
            this.BindListParentClass.Clear();
            this.BindListMethod.Clear();
            this.BindListEnumField.Clear();
            this.BindListStaticField.Clear();
            this.BindListConstField.Clear();
            this.BindListMemberField.Clear();
        }
        public void SetSelectedGameClassInfo(GameClassInfo gameClassInfo, bool loadServer = true)
        {
            this.LoadServer = loadServer;
            this.SelectedGameClassInfo = gameClassInfo;

            //var imageName = gameClassInfo.RawClassInfo.ImageName;
            //var className = gameClassInfo.RawClassInfo.FullName;
            //this.GroupDetail.Text = $@"{imageName}:{className}";


            var parentClassInfos = gameClassInfo.ParentClassInfos ?? [];
            this.BindListParentClass.ReplaceRange(parentClassInfos);
            this.TabPageParentClass.PageEnabled = parentClassInfos.Length != 0;

            var interfaceInfos = gameClassInfo.InterfaceInfos ?? [];
            this.BindListInterface.ReplaceRange(interfaceInfos);
            this.TabPageInterface.PageEnabled = interfaceInfos.Length != 0;



            var methodInfos = gameClassInfo.MethodInfos ?? [];
            this.BindListMethod.ReplaceRange(methodInfos);
            this.TabPageMethod.PageEnabled = methodInfos.Length != 0;

            var enumFieldInfos = gameClassInfo.EnumFieldInfos ?? [];
            this.BindListEnumField.ReplaceRange(enumFieldInfos);
            this.TabPageEnumField.PageEnabled = enumFieldInfos.Length != 0;

            var staticFieldInfos = gameClassInfo.StaticFieldInfos ?? [];
            this.BindListStaticField.ReplaceRange(staticFieldInfos);
            this.TabPageStaticField.PageEnabled = staticFieldInfos.Length != 0;

            var constFieldInfos = gameClassInfo.ConstFieldInfos ?? [];
            this.BindListConstField.ReplaceRange(constFieldInfos);
            this.TabPageConstField.PageEnabled = constFieldInfos.Length != 0;

            var memberFieldInfos = gameClassInfo.MemberFieldInfos ?? [];
            this.BindListMemberField.ReplaceRange(memberFieldInfos);
            this.TabPageMemberField.PageEnabled = memberFieldInfos.Length != 0;

            //if (gameClassInfo.RawClassInfo.IsEnum && this.TabPageEnumField.PageEnabled)
            //{
            //    this.TabMgr.SelectedTabPage = this.TabPageEnumField;
            //}
            //else if (this.TabPageMemberField.PageEnabled)
            //{
            //    this.TabMgr.SelectedTabPage = this.TabPageMemberField;
            //}
            //else if (this.TabPageMethod.PageEnabled)
            //{
            //    this.TabMgr.SelectedTabPage = this.TabPageMethod;
            //}
            //else if (this.TabPageStaticField.PageEnabled)
            //{
            //    this.TabMgr.SelectedTabPage = this.TabPageStaticField;
            //}
            //else if (this.TabPageParentClass.PageEnabled)
            //{
            //    this.TabMgr.SelectedTabPage = this.TabPageParentClass;
            //}
            //else if (this.TabPageConstField.PageEnabled)
            //{
            //    this.TabMgr.SelectedTabPage = this.TabPageConstField;
            //}
        }


        private void Action_OnOpenPageClassDetail(MonoClassInfoDTO classInfo)
        {
            this.OnOpenPageClassDetailEventHandler?.Invoke(this, new GameClassInfo() { RawClassInfo = classInfo }, this.LoadServer);
        }

        private void BtnShowCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OnOpenPageCodeViewEventHandler?.Invoke(this, e);
        }

        private void BtnShowOrg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OnOpenPageOrgClassesEventHandler?.Invoke(this, e);
        }
    }
}
