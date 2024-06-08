namespace Maple.MonoGameAssistant.WinForm
{
    partial class PageClassDetail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            ViewParam = new DevExpress.XtraGrid.Views.Grid.GridView();
            colMethodParameterTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            colMethodParameterName = new DevExpress.XtraGrid.Columns.GridColumn();
            GridMethod = new DevExpress.XtraGrid.GridControl();
            ViewMethod = new DevExpress.XtraGrid.Views.Grid.GridView();
            colMethodReturnTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            colMethodName = new DevExpress.XtraGrid.Columns.GridColumn();
            TabMgr = new DevExpress.XtraTab.XtraTabControl();
            TabPageMethod = new DevExpress.XtraTab.XtraTabPage();
            TabPageMemberField = new DevExpress.XtraTab.XtraTabPage();
            GridMemberField = new DevExpress.XtraGrid.GridControl();
            ViewMemberField = new DevExpress.XtraGrid.Views.Grid.GridView();
            colMemberFieldTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            colMemberFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            colMemberFieldOffset = new DevExpress.XtraGrid.Columns.GridColumn();
            TabPageEnumField = new DevExpress.XtraTab.XtraTabPage();
            GridEnumField = new DevExpress.XtraGrid.GridControl();
            ViewEnumField = new DevExpress.XtraGrid.Views.Grid.GridView();
            colEnumFieldTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            colEnumFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            colEnumFieldValue = new DevExpress.XtraGrid.Columns.GridColumn();
            TabPageStaticField = new DevExpress.XtraTab.XtraTabPage();
            GridStaticField = new DevExpress.XtraGrid.GridControl();
            ViewStaticField = new DevExpress.XtraGrid.Views.Grid.GridView();
            colStaticFieldTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            colStaticFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            colStaticFieldValue = new DevExpress.XtraGrid.Columns.GridColumn();
            TabPageConstField = new DevExpress.XtraTab.XtraTabPage();
            GridConstField = new DevExpress.XtraGrid.GridControl();
            ViewConstField = new DevExpress.XtraGrid.Views.Grid.GridView();
            colConstFieldTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            colConstFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            colConstFieldValue = new DevExpress.XtraGrid.Columns.GridColumn();
            TabPageParentClass = new DevExpress.XtraTab.XtraTabPage();
            GridParentClass = new DevExpress.XtraGrid.GridControl();
            ViewParentClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            colParentClassFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            TabPageInterface = new DevExpress.XtraTab.XtraTabPage();
            GridInterface = new DevExpress.XtraGrid.GridControl();
            ViewInterface = new DevExpress.XtraGrid.Views.Grid.GridView();
            colInterfaceFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            BarMgr = new DevExpress.XtraBars.BarManager(components);
            BarTop = new DevExpress.XtraBars.Bar();
            BtnShowCode = new DevExpress.XtraBars.BarButtonItem();
            BtnShowOrg = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)ViewParam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridMethod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewMethod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TabMgr).BeginInit();
            TabMgr.SuspendLayout();
            TabPageMethod.SuspendLayout();
            TabPageMemberField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridMemberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewMemberField).BeginInit();
            TabPageEnumField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridEnumField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewEnumField).BeginInit();
            TabPageStaticField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridStaticField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewStaticField).BeginInit();
            TabPageConstField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridConstField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewConstField).BeginInit();
            TabPageParentClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridParentClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewParentClass).BeginInit();
            TabPageInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridInterface).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewInterface).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarMgr).BeginInit();
            SuspendLayout();
            // 
            // ViewParam
            // 
            ViewParam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMethodParameterTypeName, colMethodParameterName });
            ViewParam.DetailHeight = 272;
            ViewParam.GridControl = GridMethod;
            ViewParam.Name = "ViewParam";
            ViewParam.OptionsEditForm.PopupEditFormWidth = 700;
            ViewParam.OptionsView.EnableAppearanceEvenRow = true;
            ViewParam.OptionsView.ShowGroupPanel = false;
            // 
            // colMethodParameterTypeName
            // 
            colMethodParameterTypeName.Caption = "TypeName";
            colMethodParameterTypeName.FieldName = "RawParameterType.TypeName";
            colMethodParameterTypeName.MinWidth = 22;
            colMethodParameterTypeName.Name = "colMethodParameterTypeName";
            colMethodParameterTypeName.OptionsColumn.AllowEdit = false;
            colMethodParameterTypeName.OptionsFilter.AllowFilter = false;
            colMethodParameterTypeName.Visible = true;
            colMethodParameterTypeName.VisibleIndex = 0;
            colMethodParameterTypeName.Width = 82;
            // 
            // colMethodParameterName
            // 
            colMethodParameterName.Caption = "ParameterName";
            colMethodParameterName.FieldName = "RawParameterType.ParameterName";
            colMethodParameterName.MinWidth = 22;
            colMethodParameterName.Name = "colMethodParameterName";
            colMethodParameterName.OptionsColumn.AllowEdit = false;
            colMethodParameterName.OptionsFilter.AllowFilter = false;
            colMethodParameterName.Visible = true;
            colMethodParameterName.VisibleIndex = 1;
            colMethodParameterName.Width = 112;
            // 
            // GridMethod
            // 
            GridMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            GridMethod.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.LevelTemplate = ViewParam;
            gridLevelNode1.RelationName = "ParameterTypes";
            GridMethod.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            GridMethod.Location = new System.Drawing.Point(0, 0);
            GridMethod.MainView = ViewMethod;
            GridMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridMethod.Name = "GridMethod";
            GridMethod.Size = new System.Drawing.Size(876, 530);
            GridMethod.TabIndex = 0;
            GridMethod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { ViewMethod, ViewParam });
            // 
            // ViewMethod
            // 
            ViewMethod.ChildGridLevelName = "ParameterTypes";
            ViewMethod.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMethodReturnTypeName, colMethodName });
            ViewMethod.DetailHeight = 272;
            ViewMethod.GridControl = GridMethod;
            ViewMethod.Name = "ViewMethod";
            ViewMethod.OptionsEditForm.PopupEditFormWidth = 700;
            ViewMethod.OptionsView.EnableAppearanceEvenRow = true;
            ViewMethod.OptionsView.ShowGroupPanel = false;
            // 
            // colMethodReturnTypeName
            // 
            colMethodReturnTypeName.AppearanceHeader.Options.UseTextOptions = true;
            colMethodReturnTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMethodReturnTypeName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colMethodReturnTypeName.Caption = "ReturnTypeName";
            colMethodReturnTypeName.FieldName = "RawMethodInfo.ReturnType.TypeName";
            colMethodReturnTypeName.MinWidth = 22;
            colMethodReturnTypeName.Name = "colMethodReturnTypeName";
            colMethodReturnTypeName.OptionsColumn.AllowEdit = false;
            colMethodReturnTypeName.OptionsFilter.AllowFilter = false;
            colMethodReturnTypeName.Visible = true;
            colMethodReturnTypeName.VisibleIndex = 0;
            colMethodReturnTypeName.Width = 82;
            // 
            // colMethodName
            // 
            colMethodName.AppearanceHeader.Options.UseTextOptions = true;
            colMethodName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMethodName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colMethodName.Caption = "Name";
            colMethodName.FieldName = "RawMethodInfo.Name";
            colMethodName.MinWidth = 22;
            colMethodName.Name = "colMethodName";
            colMethodName.OptionsColumn.AllowEdit = false;
            colMethodName.OptionsFilter.AllowFilter = false;
            colMethodName.Visible = true;
            colMethodName.VisibleIndex = 1;
            colMethodName.Width = 82;
            // 
            // TabMgr
            // 
            TabMgr.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            TabMgr.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            TabMgr.Location = new System.Drawing.Point(11, 10);
            TabMgr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            TabMgr.Name = "TabMgr";
            TabMgr.SelectedTabPage = TabPageMethod;
            TabMgr.Size = new System.Drawing.Size(878, 556);
            TabMgr.TabIndex = 0;
            TabMgr.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { TabPageMemberField, TabPageMethod, TabPageEnumField, TabPageStaticField, TabPageConstField, TabPageParentClass, TabPageInterface });
            // 
            // TabPageMethod
            // 
            TabPageMethod.Controls.Add(GridMethod);
            TabPageMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            TabPageMethod.Name = "TabPageMethod";
            TabPageMethod.Size = new System.Drawing.Size(876, 530);
            TabPageMethod.Text = "Methods";
            // 
            // TabPageMemberField
            // 
            TabPageMemberField.Controls.Add(GridMemberField);
            TabPageMemberField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            TabPageMemberField.Name = "TabPageMemberField";
            TabPageMemberField.Size = new System.Drawing.Size(876, 530);
            TabPageMemberField.Text = "MemberFields";
            // 
            // GridMemberField
            // 
            GridMemberField.Dock = System.Windows.Forms.DockStyle.Fill;
            GridMemberField.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridMemberField.Location = new System.Drawing.Point(0, 0);
            GridMemberField.MainView = ViewMemberField;
            GridMemberField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridMemberField.Name = "GridMemberField";
            GridMemberField.Size = new System.Drawing.Size(876, 530);
            GridMemberField.TabIndex = 1;
            GridMemberField.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { ViewMemberField });
            // 
            // ViewMemberField
            // 
            ViewMemberField.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMemberFieldTypeName, colMemberFieldName, colMemberFieldOffset });
            ViewMemberField.DetailHeight = 272;
            ViewMemberField.GridControl = GridMemberField;
            ViewMemberField.Name = "ViewMemberField";
            ViewMemberField.OptionsEditForm.PopupEditFormWidth = 700;
            ViewMemberField.OptionsView.EnableAppearanceEvenRow = true;
            ViewMemberField.OptionsView.ShowGroupPanel = false;
            // 
            // colMemberFieldTypeName
            // 
            colMemberFieldTypeName.AppearanceHeader.Options.UseTextOptions = true;
            colMemberFieldTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMemberFieldTypeName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colMemberFieldTypeName.Caption = "TypeName";
            colMemberFieldTypeName.FieldName = "RawFieldInfo.FieldType.TypeName";
            colMemberFieldTypeName.MinWidth = 22;
            colMemberFieldTypeName.Name = "colMemberFieldTypeName";
            colMemberFieldTypeName.OptionsColumn.AllowEdit = false;
            colMemberFieldTypeName.OptionsFilter.AllowFilter = false;
            colMemberFieldTypeName.Visible = true;
            colMemberFieldTypeName.VisibleIndex = 0;
            colMemberFieldTypeName.Width = 82;
            // 
            // colMemberFieldName
            // 
            colMemberFieldName.AppearanceHeader.Options.UseTextOptions = true;
            colMemberFieldName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMemberFieldName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colMemberFieldName.Caption = "FieldName";
            colMemberFieldName.FieldName = "RawFieldInfo.Name";
            colMemberFieldName.MinWidth = 22;
            colMemberFieldName.Name = "colMemberFieldName";
            colMemberFieldName.OptionsColumn.AllowEdit = false;
            colMemberFieldName.OptionsFilter.AllowFilter = false;
            colMemberFieldName.Visible = true;
            colMemberFieldName.VisibleIndex = 1;
            colMemberFieldName.Width = 82;
            // 
            // colMemberFieldOffset
            // 
            colMemberFieldOffset.AppearanceHeader.Options.UseTextOptions = true;
            colMemberFieldOffset.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMemberFieldOffset.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colMemberFieldOffset.Caption = "Offset";
            colMemberFieldOffset.DisplayFormat.FormatString = "X2";
            colMemberFieldOffset.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colMemberFieldOffset.FieldName = "RawFieldInfo.Offset";
            colMemberFieldOffset.MinWidth = 22;
            colMemberFieldOffset.Name = "colMemberFieldOffset";
            colMemberFieldOffset.OptionsColumn.AllowEdit = false;
            colMemberFieldOffset.OptionsFilter.AllowFilter = false;
            colMemberFieldOffset.Visible = true;
            colMemberFieldOffset.VisibleIndex = 2;
            colMemberFieldOffset.Width = 82;
            // 
            // TabPageEnumField
            // 
            TabPageEnumField.Controls.Add(GridEnumField);
            TabPageEnumField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            TabPageEnumField.Name = "TabPageEnumField";
            TabPageEnumField.Size = new System.Drawing.Size(876, 530);
            TabPageEnumField.Text = "EnumFields";
            // 
            // GridEnumField
            // 
            GridEnumField.Dock = System.Windows.Forms.DockStyle.Fill;
            GridEnumField.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridEnumField.Location = new System.Drawing.Point(0, 0);
            GridEnumField.MainView = ViewEnumField;
            GridEnumField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridEnumField.Name = "GridEnumField";
            GridEnumField.Size = new System.Drawing.Size(876, 530);
            GridEnumField.TabIndex = 1;
            GridEnumField.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { ViewEnumField });
            // 
            // ViewEnumField
            // 
            ViewEnumField.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colEnumFieldTypeName, colEnumFieldName, colEnumFieldValue });
            ViewEnumField.DetailHeight = 272;
            ViewEnumField.GridControl = GridEnumField;
            ViewEnumField.Name = "ViewEnumField";
            ViewEnumField.OptionsEditForm.PopupEditFormWidth = 700;
            ViewEnumField.OptionsView.EnableAppearanceEvenRow = true;
            ViewEnumField.OptionsView.ShowGroupPanel = false;
            // 
            // colEnumFieldTypeName
            // 
            colEnumFieldTypeName.AppearanceHeader.Options.UseTextOptions = true;
            colEnumFieldTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colEnumFieldTypeName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colEnumFieldTypeName.Caption = "TypeName";
            colEnumFieldTypeName.FieldName = "RawFieldInfo.FieldType.TypeName";
            colEnumFieldTypeName.MinWidth = 22;
            colEnumFieldTypeName.Name = "colEnumFieldTypeName";
            colEnumFieldTypeName.OptionsColumn.AllowEdit = false;
            colEnumFieldTypeName.OptionsFilter.AllowFilter = false;
            colEnumFieldTypeName.Visible = true;
            colEnumFieldTypeName.VisibleIndex = 0;
            colEnumFieldTypeName.Width = 82;
            // 
            // colEnumFieldName
            // 
            colEnumFieldName.AppearanceHeader.Options.UseTextOptions = true;
            colEnumFieldName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colEnumFieldName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colEnumFieldName.Caption = "FieldName";
            colEnumFieldName.FieldName = "RawFieldInfo.Name";
            colEnumFieldName.MinWidth = 22;
            colEnumFieldName.Name = "colEnumFieldName";
            colEnumFieldName.OptionsColumn.AllowEdit = false;
            colEnumFieldName.OptionsFilter.AllowFilter = false;
            colEnumFieldName.Visible = true;
            colEnumFieldName.VisibleIndex = 1;
            colEnumFieldName.Width = 82;
            // 
            // colEnumFieldValue
            // 
            colEnumFieldValue.AppearanceHeader.Options.UseTextOptions = true;
            colEnumFieldValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colEnumFieldValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colEnumFieldValue.Caption = "Value";
            colEnumFieldValue.FieldName = "RawFieldInfo.Value";
            colEnumFieldValue.MinWidth = 22;
            colEnumFieldValue.Name = "colEnumFieldValue";
            colEnumFieldValue.OptionsColumn.AllowEdit = false;
            colEnumFieldValue.OptionsFilter.AllowFilter = false;
            colEnumFieldValue.Visible = true;
            colEnumFieldValue.VisibleIndex = 2;
            colEnumFieldValue.Width = 82;
            // 
            // TabPageStaticField
            // 
            TabPageStaticField.Controls.Add(GridStaticField);
            TabPageStaticField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            TabPageStaticField.Name = "TabPageStaticField";
            TabPageStaticField.Size = new System.Drawing.Size(876, 530);
            TabPageStaticField.Text = "StaticFields";
            // 
            // GridStaticField
            // 
            GridStaticField.Dock = System.Windows.Forms.DockStyle.Fill;
            GridStaticField.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridStaticField.Location = new System.Drawing.Point(0, 0);
            GridStaticField.MainView = ViewStaticField;
            GridStaticField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridStaticField.Name = "GridStaticField";
            GridStaticField.Size = new System.Drawing.Size(876, 530);
            GridStaticField.TabIndex = 1;
            GridStaticField.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { ViewStaticField });
            // 
            // ViewStaticField
            // 
            ViewStaticField.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colStaticFieldTypeName, colStaticFieldName, colStaticFieldValue });
            ViewStaticField.DetailHeight = 272;
            ViewStaticField.GridControl = GridStaticField;
            ViewStaticField.Name = "ViewStaticField";
            ViewStaticField.OptionsEditForm.PopupEditFormWidth = 700;
            ViewStaticField.OptionsView.EnableAppearanceEvenRow = true;
            ViewStaticField.OptionsView.ShowGroupPanel = false;
            // 
            // colStaticFieldTypeName
            // 
            colStaticFieldTypeName.AppearanceHeader.Options.UseTextOptions = true;
            colStaticFieldTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colStaticFieldTypeName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colStaticFieldTypeName.Caption = "TypeName";
            colStaticFieldTypeName.FieldName = "RawFieldInfo.FieldType.TypeName";
            colStaticFieldTypeName.MinWidth = 22;
            colStaticFieldTypeName.Name = "colStaticFieldTypeName";
            colStaticFieldTypeName.OptionsColumn.AllowEdit = false;
            colStaticFieldTypeName.OptionsFilter.AllowFilter = false;
            colStaticFieldTypeName.Visible = true;
            colStaticFieldTypeName.VisibleIndex = 0;
            colStaticFieldTypeName.Width = 82;
            // 
            // colStaticFieldName
            // 
            colStaticFieldName.AppearanceHeader.Options.UseTextOptions = true;
            colStaticFieldName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colStaticFieldName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colStaticFieldName.Caption = "FieldName";
            colStaticFieldName.FieldName = "RawFieldInfo.Name";
            colStaticFieldName.MinWidth = 22;
            colStaticFieldName.Name = "colStaticFieldName";
            colStaticFieldName.OptionsColumn.AllowEdit = false;
            colStaticFieldName.OptionsFilter.AllowFilter = false;
            colStaticFieldName.Visible = true;
            colStaticFieldName.VisibleIndex = 1;
            colStaticFieldName.Width = 82;
            // 
            // colStaticFieldValue
            // 
            colStaticFieldValue.AppearanceHeader.Options.UseTextOptions = true;
            colStaticFieldValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colStaticFieldValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colStaticFieldValue.Caption = "Value";
            colStaticFieldValue.FieldName = "RawFieldInfo.Value";
            colStaticFieldValue.MinWidth = 22;
            colStaticFieldValue.Name = "colStaticFieldValue";
            colStaticFieldValue.OptionsColumn.AllowEdit = false;
            colStaticFieldValue.OptionsFilter.AllowFilter = false;
            colStaticFieldValue.Visible = true;
            colStaticFieldValue.VisibleIndex = 2;
            colStaticFieldValue.Width = 82;
            // 
            // TabPageConstField
            // 
            TabPageConstField.Controls.Add(GridConstField);
            TabPageConstField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            TabPageConstField.Name = "TabPageConstField";
            TabPageConstField.Size = new System.Drawing.Size(876, 530);
            TabPageConstField.Text = "ConstFields";
            // 
            // GridConstField
            // 
            GridConstField.Dock = System.Windows.Forms.DockStyle.Fill;
            GridConstField.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridConstField.Location = new System.Drawing.Point(0, 0);
            GridConstField.MainView = ViewConstField;
            GridConstField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridConstField.Name = "GridConstField";
            GridConstField.Size = new System.Drawing.Size(876, 530);
            GridConstField.TabIndex = 2;
            GridConstField.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { ViewConstField });
            // 
            // ViewConstField
            // 
            ViewConstField.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colConstFieldTypeName, colConstFieldName, colConstFieldValue });
            ViewConstField.DetailHeight = 272;
            ViewConstField.GridControl = GridConstField;
            ViewConstField.Name = "ViewConstField";
            ViewConstField.OptionsEditForm.PopupEditFormWidth = 700;
            ViewConstField.OptionsView.EnableAppearanceEvenRow = true;
            ViewConstField.OptionsView.ShowGroupPanel = false;
            // 
            // colConstFieldTypeName
            // 
            colConstFieldTypeName.AppearanceHeader.Options.UseTextOptions = true;
            colConstFieldTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colConstFieldTypeName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colConstFieldTypeName.Caption = "TypeName";
            colConstFieldTypeName.FieldName = "RawFieldInfo.FieldType.TypeName";
            colConstFieldTypeName.MinWidth = 22;
            colConstFieldTypeName.Name = "colConstFieldTypeName";
            colConstFieldTypeName.OptionsColumn.AllowEdit = false;
            colConstFieldTypeName.OptionsFilter.AllowFilter = false;
            colConstFieldTypeName.Visible = true;
            colConstFieldTypeName.VisibleIndex = 0;
            colConstFieldTypeName.Width = 82;
            // 
            // colConstFieldName
            // 
            colConstFieldName.AppearanceHeader.Options.UseTextOptions = true;
            colConstFieldName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colConstFieldName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colConstFieldName.Caption = "FieldName";
            colConstFieldName.FieldName = "RawFieldInfo.Name";
            colConstFieldName.MinWidth = 22;
            colConstFieldName.Name = "colConstFieldName";
            colConstFieldName.OptionsColumn.AllowEdit = false;
            colConstFieldName.OptionsFilter.AllowFilter = false;
            colConstFieldName.Visible = true;
            colConstFieldName.VisibleIndex = 1;
            colConstFieldName.Width = 82;
            // 
            // colConstFieldValue
            // 
            colConstFieldValue.AppearanceHeader.Options.UseTextOptions = true;
            colConstFieldValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colConstFieldValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colConstFieldValue.Caption = "Value";
            colConstFieldValue.FieldName = "RawFieldInfo.Value";
            colConstFieldValue.MinWidth = 22;
            colConstFieldValue.Name = "colConstFieldValue";
            colConstFieldValue.OptionsColumn.AllowEdit = false;
            colConstFieldValue.OptionsFilter.AllowFilter = false;
            colConstFieldValue.Visible = true;
            colConstFieldValue.VisibleIndex = 2;
            colConstFieldValue.Width = 82;
            // 
            // TabPageParentClass
            // 
            TabPageParentClass.Controls.Add(GridParentClass);
            TabPageParentClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            TabPageParentClass.Name = "TabPageParentClass";
            TabPageParentClass.Size = new System.Drawing.Size(876, 530);
            TabPageParentClass.Text = "ParentClasses";
            // 
            // GridParentClass
            // 
            GridParentClass.Dock = System.Windows.Forms.DockStyle.Fill;
            GridParentClass.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridParentClass.Location = new System.Drawing.Point(0, 0);
            GridParentClass.MainView = ViewParentClass;
            GridParentClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridParentClass.Name = "GridParentClass";
            GridParentClass.Size = new System.Drawing.Size(876, 530);
            GridParentClass.TabIndex = 1;
            GridParentClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { ViewParentClass });
            // 
            // ViewParentClass
            // 
            ViewParentClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colParentClassFullName });
            ViewParentClass.DetailHeight = 272;
            ViewParentClass.GridControl = GridParentClass;
            ViewParentClass.Name = "ViewParentClass";
            ViewParentClass.OptionsEditForm.PopupEditFormWidth = 700;
            ViewParentClass.OptionsView.EnableAppearanceEvenRow = true;
            ViewParentClass.OptionsView.ShowGroupPanel = false;
            // 
            // colParentClassFullName
            // 
            colParentClassFullName.AppearanceHeader.Options.UseTextOptions = true;
            colParentClassFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colParentClassFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colParentClassFullName.Caption = "FullName";
            colParentClassFullName.FieldName = "RawClassInfo.FullName";
            colParentClassFullName.MinWidth = 22;
            colParentClassFullName.Name = "colParentClassFullName";
            colParentClassFullName.OptionsColumn.AllowEdit = false;
            colParentClassFullName.OptionsFilter.AllowFilter = false;
            colParentClassFullName.Visible = true;
            colParentClassFullName.VisibleIndex = 0;
            colParentClassFullName.Width = 82;
            // 
            // TabPageInterface
            // 
            TabPageInterface.Controls.Add(GridInterface);
            TabPageInterface.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            TabPageInterface.Name = "TabPageInterface";
            TabPageInterface.Size = new System.Drawing.Size(876, 530);
            TabPageInterface.Text = "Interfaces";
            // 
            // GridInterface
            // 
            GridInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            GridInterface.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridInterface.Location = new System.Drawing.Point(0, 0);
            GridInterface.MainView = ViewInterface;
            GridInterface.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            GridInterface.Name = "GridInterface";
            GridInterface.Size = new System.Drawing.Size(876, 530);
            GridInterface.TabIndex = 2;
            GridInterface.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { ViewInterface });
            // 
            // ViewInterface
            // 
            ViewInterface.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colInterfaceFullName });
            ViewInterface.DetailHeight = 272;
            ViewInterface.GridControl = GridInterface;
            ViewInterface.Name = "ViewInterface";
            ViewInterface.OptionsEditForm.PopupEditFormWidth = 700;
            ViewInterface.OptionsView.EnableAppearanceEvenRow = true;
            ViewInterface.OptionsView.ShowGroupPanel = false;
            // 
            // colInterfaceFullName
            // 
            colInterfaceFullName.AppearanceHeader.Options.UseTextOptions = true;
            colInterfaceFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colInterfaceFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colInterfaceFullName.Caption = "FullName";
            colInterfaceFullName.FieldName = "RawInterfaceInfo.FullName";
            colInterfaceFullName.MinWidth = 22;
            colInterfaceFullName.Name = "colInterfaceFullName";
            colInterfaceFullName.OptionsColumn.AllowEdit = false;
            colInterfaceFullName.OptionsFilter.AllowFilter = false;
            colInterfaceFullName.Visible = true;
            colInterfaceFullName.VisibleIndex = 0;
            colInterfaceFullName.Width = 82;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(TabMgr);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 24);
            layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(900, 576);
            layoutControl1.TabIndex = 2;
            layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(900, 576);
            Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = TabMgr;
            layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(882, 560);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // BarMgr
            // 
            BarMgr.Bars.AddRange(new DevExpress.XtraBars.Bar[] { BarTop });
            BarMgr.DockControls.Add(barDockControlTop);
            BarMgr.DockControls.Add(barDockControlBottom);
            BarMgr.DockControls.Add(barDockControlLeft);
            BarMgr.DockControls.Add(barDockControlRight);
            BarMgr.Form = this;
            BarMgr.Items.AddRange(new DevExpress.XtraBars.BarItem[] { BtnShowCode, BtnShowOrg });
            BarMgr.MainMenu = BarTop;
            BarMgr.MaxItemId = 2;
            // 
            // BarTop
            // 
            BarTop.BarName = "Custom 2";
            BarTop.DockCol = 0;
            BarTop.DockRow = 0;
            BarTop.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            BarTop.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(BtnShowCode), new DevExpress.XtraBars.LinkPersistInfo(BtnShowOrg) });
            BarTop.OptionsBar.AllowQuickCustomization = false;
            BarTop.OptionsBar.DrawBorder = false;
            BarTop.OptionsBar.DrawDragBorder = false;
            BarTop.OptionsBar.UseWholeRow = true;
            BarTop.Text = "Custom 2";
            // 
            // BtnShowCode
            // 
            BtnShowCode.Id = 0;
            BtnShowCode.ImageOptions.Image = Properties.Resources.csharp_16x16;
            BtnShowCode.Name = "BtnShowCode";
            BtnShowCode.ItemClick += BtnShowCode_ItemClick;
            // 
            // BtnShowOrg
            // 
            BtnShowOrg.Id = 1;
            BtnShowOrg.ImageOptions.SvgImage = Properties.Resources.Family;
            BtnShowOrg.Name = "BtnShowOrg";
            BtnShowOrg.ItemClick += BtnShowOrg_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = BarMgr;
            barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            barDockControlTop.Size = new System.Drawing.Size(900, 24);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 600);
            barDockControlBottom.Manager = BarMgr;
            barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            barDockControlBottom.Size = new System.Drawing.Size(900, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            barDockControlLeft.Manager = BarMgr;
            barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            barDockControlLeft.Size = new System.Drawing.Size(0, 576);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(900, 24);
            barDockControlRight.Manager = BarMgr;
            barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            barDockControlRight.Size = new System.Drawing.Size(0, 576);
            // 
            // PageClassDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "PageClassDetail";
            Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)ViewParam).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridMethod).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewMethod).EndInit();
            ((System.ComponentModel.ISupportInitialize)TabMgr).EndInit();
            TabMgr.ResumeLayout(false);
            TabPageMethod.ResumeLayout(false);
            TabPageMemberField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridMemberField).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewMemberField).EndInit();
            TabPageEnumField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridEnumField).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewEnumField).EndInit();
            TabPageStaticField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridStaticField).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewStaticField).EndInit();
            TabPageConstField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridConstField).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewConstField).EndInit();
            TabPageParentClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridParentClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewParentClass).EndInit();
            TabPageInterface.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridInterface).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewInterface).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarMgr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabMgr;
        private DevExpress.XtraTab.XtraTabPage TabPageMethod;
        private DevExpress.XtraTab.XtraTabPage TabPageParentClass;
        private DevExpress.XtraTab.XtraTabPage TabPageMemberField;
        private DevExpress.XtraTab.XtraTabPage TabPageStaticField;
        private DevExpress.XtraTab.XtraTabPage TabPageEnumField;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewMethod;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewParentClass;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewMemberField;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewStaticField;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewEnumField;
        private DevExpress.XtraTab.XtraTabPage TabPageConstField;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewConstField;
        public DevExpress.XtraGrid.GridControl GridMethod;
        public DevExpress.XtraGrid.GridControl GridParentClass;
        public DevExpress.XtraGrid.GridControl GridMemberField;
        public DevExpress.XtraGrid.GridControl GridStaticField;
        public DevExpress.XtraGrid.GridControl GridEnumField;
        public DevExpress.XtraGrid.GridControl GridConstField;
        private DevExpress.XtraGrid.Columns.GridColumn colMethodName;
        private DevExpress.XtraGrid.Columns.GridColumn colMethodReturnTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colParentClassFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberFieldOffset;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberFieldTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colStaticFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colStaticFieldValue;
        private DevExpress.XtraGrid.Columns.GridColumn colStaticFieldTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colEnumFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colEnumFieldValue;
        private DevExpress.XtraGrid.Columns.GridColumn colEnumFieldTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colConstFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colConstFieldValue;
        private DevExpress.XtraGrid.Columns.GridColumn colConstFieldTypeName;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewParam;
        private DevExpress.XtraGrid.Columns.GridColumn colMethodParameterName;
        private DevExpress.XtraGrid.Columns.GridColumn colMethodParameterTypeName;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraTab.XtraTabPage TabPageInterface;
        public DevExpress.XtraGrid.GridControl GridInterface;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewInterface;
        private DevExpress.XtraGrid.Columns.GridColumn colInterfaceFullName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarManager BarMgr;
        private DevExpress.XtraBars.Bar BarTop;
        private DevExpress.XtraBars.BarButtonItem BtnShowCode;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem BtnShowOrg;
    }
}
