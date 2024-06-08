namespace Maple.MonoGameAssistant.WinForm.UI
{
    partial class PageOrgClasses
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
            TabView = new DevExpress.XtraTab.XtraTabControl();
            TabPageField = new DevExpress.XtraTab.XtraTabPage();
            SplitFieldView = new DevExpress.XtraEditors.SplitContainerControl();
            gcRefFieldClassInfo = new DevExpress.XtraGrid.GridControl();
            gvRefFieldClassInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            colRefFieldClassFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            gcUseFieldClassInfo = new DevExpress.XtraGrid.GridControl();
            gvUseFieldClassInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            colUseFieldClassFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            TabPageInherit = new DevExpress.XtraTab.XtraTabPage();
            SplitInheritView = new DevExpress.XtraEditors.SplitContainerControl();
            gcParentClassInfo = new DevExpress.XtraGrid.GridControl();
            gvParentClassInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            colParentClassFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            gcDerivedClassInfo = new DevExpress.XtraGrid.GridControl();
            gvDerivedClassInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            colDerivedClassFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            TabPageMethod = new DevExpress.XtraTab.XtraTabPage();
            SplitMethodView = new DevExpress.XtraEditors.SplitContainerControl();
            gcUseMethodClassInfo = new DevExpress.XtraGrid.GridControl();
            gvUseMethodClassInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            colUseMethodClassFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            gcRefMethodClassInfo = new DevExpress.XtraGrid.GridControl();
            gvRefMethodClassInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            colRefMethodClassFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)TabView).BeginInit();
            TabView.SuspendLayout();
            TabPageField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitFieldView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SplitFieldView.Panel1).BeginInit();
            SplitFieldView.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitFieldView.Panel2).BeginInit();
            SplitFieldView.Panel2.SuspendLayout();
            SplitFieldView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcRefFieldClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvRefFieldClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcUseFieldClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvUseFieldClassInfo).BeginInit();
            TabPageInherit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitInheritView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SplitInheritView.Panel1).BeginInit();
            SplitInheritView.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitInheritView.Panel2).BeginInit();
            SplitInheritView.Panel2.SuspendLayout();
            SplitInheritView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcParentClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvParentClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcDerivedClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDerivedClassInfo).BeginInit();
            TabPageMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitMethodView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SplitMethodView.Panel1).BeginInit();
            SplitMethodView.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitMethodView.Panel2).BeginInit();
            SplitMethodView.Panel2.SuspendLayout();
            SplitMethodView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcUseMethodClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvUseMethodClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcRefMethodClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvRefMethodClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // TabView
            // 
            TabView.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            TabView.Location = new System.Drawing.Point(12, 12);
            TabView.Name = "TabView";
            TabView.SelectedTabPage = TabPageField;
            TabView.Size = new System.Drawing.Size(876, 576);
            TabView.TabIndex = 1;
            TabView.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { TabPageField, TabPageInherit, TabPageMethod });
            // 
            // TabPageField
            // 
            TabPageField.Controls.Add(SplitFieldView);
            TabPageField.Name = "TabPageField";
            TabPageField.Size = new System.Drawing.Size(874, 550);
            TabPageField.Text = "FromField";
            // 
            // SplitFieldView
            // 
            SplitFieldView.Dock = System.Windows.Forms.DockStyle.Fill;
            SplitFieldView.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            SplitFieldView.Location = new System.Drawing.Point(0, 0);
            SplitFieldView.Name = "SplitFieldView";
            // 
            // SplitFieldView.Panel1
            // 
            SplitFieldView.Panel1.Controls.Add(gcRefFieldClassInfo);
            SplitFieldView.Panel1.Text = "Panel1";
            // 
            // SplitFieldView.Panel2
            // 
            SplitFieldView.Panel2.Controls.Add(gcUseFieldClassInfo);
            SplitFieldView.Panel2.Text = "Panel2";
            SplitFieldView.Size = new System.Drawing.Size(874, 550);
            SplitFieldView.SplitterPosition = 440;
            SplitFieldView.TabIndex = 0;
            // 
            // gcRefFieldClassInfo
            // 
            gcRefFieldClassInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gcRefFieldClassInfo.Location = new System.Drawing.Point(0, 0);
            gcRefFieldClassInfo.MainView = gvRefFieldClassInfo;
            gcRefFieldClassInfo.Name = "gcRefFieldClassInfo";
            gcRefFieldClassInfo.Size = new System.Drawing.Size(440, 550);
            gcRefFieldClassInfo.TabIndex = 0;
            gcRefFieldClassInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvRefFieldClassInfo });
            // 
            // gvRefFieldClassInfo
            // 
            gvRefFieldClassInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colRefFieldClassFullName });
            gvRefFieldClassInfo.DetailHeight = 272;
            gvRefFieldClassInfo.GridControl = gcRefFieldClassInfo;
            gvRefFieldClassInfo.Name = "gvRefFieldClassInfo";
            gvRefFieldClassInfo.OptionsView.EnableAppearanceEvenRow = true;
            gvRefFieldClassInfo.OptionsView.ShowGroupPanel = false;
            gvRefFieldClassInfo.OptionsView.ShowViewCaption = true;
            gvRefFieldClassInfo.ViewCaption = "RefClassView";
            // 
            // colRefFieldClassFullName
            // 
            colRefFieldClassFullName.AppearanceHeader.Options.UseTextOptions = true;
            colRefFieldClassFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colRefFieldClassFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colRefFieldClassFullName.Caption = "FullName";
            colRefFieldClassFullName.FieldName = "RawClassInfo.FullName";
            colRefFieldClassFullName.MinWidth = 17;
            colRefFieldClassFullName.Name = "colRefFieldClassFullName";
            colRefFieldClassFullName.OptionsColumn.AllowEdit = false;
            colRefFieldClassFullName.OptionsColumn.ReadOnly = true;
            colRefFieldClassFullName.OptionsFilter.AllowFilter = false;
            colRefFieldClassFullName.Visible = true;
            colRefFieldClassFullName.VisibleIndex = 0;
            colRefFieldClassFullName.Width = 66;
            // 
            // gcUseFieldClassInfo
            // 
            gcUseFieldClassInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gcUseFieldClassInfo.Location = new System.Drawing.Point(0, 0);
            gcUseFieldClassInfo.MainView = gvUseFieldClassInfo;
            gcUseFieldClassInfo.Name = "gcUseFieldClassInfo";
            gcUseFieldClassInfo.Size = new System.Drawing.Size(424, 550);
            gcUseFieldClassInfo.TabIndex = 0;
            gcUseFieldClassInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvUseFieldClassInfo });
            // 
            // gvUseFieldClassInfo
            // 
            gvUseFieldClassInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colUseFieldClassFullName });
            gvUseFieldClassInfo.DetailHeight = 272;
            gvUseFieldClassInfo.GridControl = gcUseFieldClassInfo;
            gvUseFieldClassInfo.Name = "gvUseFieldClassInfo";
            gvUseFieldClassInfo.OptionsView.EnableAppearanceEvenRow = true;
            gvUseFieldClassInfo.OptionsView.ShowGroupPanel = false;
            gvUseFieldClassInfo.OptionsView.ShowViewCaption = true;
            gvUseFieldClassInfo.ViewCaption = "UseClassView";
            // 
            // colUseFieldClassFullName
            // 
            colUseFieldClassFullName.AppearanceHeader.Options.UseTextOptions = true;
            colUseFieldClassFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colUseFieldClassFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colUseFieldClassFullName.Caption = "FullName";
            colUseFieldClassFullName.FieldName = "RawClassInfo.FullName";
            colUseFieldClassFullName.MinWidth = 17;
            colUseFieldClassFullName.Name = "colUseFieldClassFullName";
            colUseFieldClassFullName.OptionsColumn.AllowEdit = false;
            colUseFieldClassFullName.OptionsColumn.ReadOnly = true;
            colUseFieldClassFullName.OptionsFilter.AllowFilter = false;
            colUseFieldClassFullName.Visible = true;
            colUseFieldClassFullName.VisibleIndex = 0;
            colUseFieldClassFullName.Width = 66;
            // 
            // TabPageInherit
            // 
            TabPageInherit.Controls.Add(SplitInheritView);
            TabPageInherit.Name = "TabPageInherit";
            TabPageInherit.Size = new System.Drawing.Size(874, 550);
            TabPageInherit.Text = "FromInherit";
            // 
            // SplitInheritView
            // 
            SplitInheritView.Dock = System.Windows.Forms.DockStyle.Fill;
            SplitInheritView.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            SplitInheritView.Location = new System.Drawing.Point(0, 0);
            SplitInheritView.Name = "SplitInheritView";
            // 
            // SplitInheritView.Panel1
            // 
            SplitInheritView.Panel1.Controls.Add(gcParentClassInfo);
            SplitInheritView.Panel1.Text = "Panel1";
            // 
            // SplitInheritView.Panel2
            // 
            SplitInheritView.Panel2.Controls.Add(gcDerivedClassInfo);
            SplitInheritView.Panel2.Text = "Panel2";
            SplitInheritView.Size = new System.Drawing.Size(874, 550);
            SplitInheritView.SplitterPosition = 440;
            SplitInheritView.TabIndex = 0;
            // 
            // gcParentClassInfo
            // 
            gcParentClassInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gcParentClassInfo.Location = new System.Drawing.Point(0, 0);
            gcParentClassInfo.MainView = gvParentClassInfo;
            gcParentClassInfo.Name = "gcParentClassInfo";
            gcParentClassInfo.Size = new System.Drawing.Size(440, 550);
            gcParentClassInfo.TabIndex = 0;
            gcParentClassInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvParentClassInfo });
            // 
            // gvParentClassInfo
            // 
            gvParentClassInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colParentClassFullName });
            gvParentClassInfo.DetailHeight = 272;
            gvParentClassInfo.GridControl = gcParentClassInfo;
            gvParentClassInfo.Name = "gvParentClassInfo";
            gvParentClassInfo.OptionsView.EnableAppearanceEvenRow = true;
            gvParentClassInfo.OptionsView.ShowGroupPanel = false;
            gvParentClassInfo.OptionsView.ShowViewCaption = true;
            gvParentClassInfo.ViewCaption = "RefClassView";
            // 
            // colParentClassFullName
            // 
            colParentClassFullName.AppearanceHeader.Options.UseTextOptions = true;
            colParentClassFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colParentClassFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colParentClassFullName.Caption = "FullName";
            colParentClassFullName.FieldName = "RawClassInfo.FullName";
            colParentClassFullName.MinWidth = 17;
            colParentClassFullName.Name = "colParentClassFullName";
            colParentClassFullName.OptionsColumn.AllowEdit = false;
            colParentClassFullName.OptionsColumn.ReadOnly = true;
            colParentClassFullName.OptionsFilter.AllowFilter = false;
            colParentClassFullName.Visible = true;
            colParentClassFullName.VisibleIndex = 0;
            colParentClassFullName.Width = 66;
            // 
            // gcDerivedClassInfo
            // 
            gcDerivedClassInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gcDerivedClassInfo.Location = new System.Drawing.Point(0, 0);
            gcDerivedClassInfo.MainView = gvDerivedClassInfo;
            gcDerivedClassInfo.Name = "gcDerivedClassInfo";
            gcDerivedClassInfo.Size = new System.Drawing.Size(424, 550);
            gcDerivedClassInfo.TabIndex = 0;
            gcDerivedClassInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDerivedClassInfo });
            // 
            // gvDerivedClassInfo
            // 
            gvDerivedClassInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colDerivedClassFullName });
            gvDerivedClassInfo.DetailHeight = 272;
            gvDerivedClassInfo.GridControl = gcDerivedClassInfo;
            gvDerivedClassInfo.Name = "gvDerivedClassInfo";
            gvDerivedClassInfo.OptionsView.EnableAppearanceEvenRow = true;
            gvDerivedClassInfo.OptionsView.ShowGroupPanel = false;
            gvDerivedClassInfo.OptionsView.ShowViewCaption = true;
            gvDerivedClassInfo.ViewCaption = "UseClassView";
            // 
            // colDerivedClassFullName
            // 
            colDerivedClassFullName.AppearanceHeader.Options.UseTextOptions = true;
            colDerivedClassFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colDerivedClassFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colDerivedClassFullName.Caption = "FullName";
            colDerivedClassFullName.FieldName = "RawClassInfo.FullName";
            colDerivedClassFullName.MinWidth = 17;
            colDerivedClassFullName.Name = "colDerivedClassFullName";
            colDerivedClassFullName.OptionsColumn.AllowEdit = false;
            colDerivedClassFullName.OptionsColumn.ReadOnly = true;
            colDerivedClassFullName.OptionsFilter.AllowFilter = false;
            colDerivedClassFullName.Visible = true;
            colDerivedClassFullName.VisibleIndex = 0;
            colDerivedClassFullName.Width = 66;
            // 
            // TabPageMethod
            // 
            TabPageMethod.Controls.Add(SplitMethodView);
            TabPageMethod.Name = "TabPageMethod";
            TabPageMethod.Size = new System.Drawing.Size(874, 550);
            TabPageMethod.Text = "FromMethod";
            // 
            // SplitMethodView
            // 
            SplitMethodView.Dock = System.Windows.Forms.DockStyle.Fill;
            SplitMethodView.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            SplitMethodView.Location = new System.Drawing.Point(0, 0);
            SplitMethodView.Name = "SplitMethodView";
            // 
            // SplitMethodView.Panel1
            // 
            SplitMethodView.Panel1.Controls.Add(gcUseMethodClassInfo);
            SplitMethodView.Panel1.Text = "Panel1";
            // 
            // SplitMethodView.Panel2
            // 
            SplitMethodView.Panel2.Controls.Add(gcRefMethodClassInfo);
            SplitMethodView.Panel2.Text = "Panel2";
            SplitMethodView.Size = new System.Drawing.Size(874, 550);
            SplitMethodView.SplitterPosition = 440;
            SplitMethodView.TabIndex = 2;
            // 
            // gcUseMethodClassInfo
            // 
            gcUseMethodClassInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gcUseMethodClassInfo.Location = new System.Drawing.Point(0, 0);
            gcUseMethodClassInfo.MainView = gvUseMethodClassInfo;
            gcUseMethodClassInfo.Name = "gcUseMethodClassInfo";
            gcUseMethodClassInfo.Size = new System.Drawing.Size(440, 550);
            gcUseMethodClassInfo.TabIndex = 0;
            gcUseMethodClassInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvUseMethodClassInfo });
            // 
            // gvUseMethodClassInfo
            // 
            gvUseMethodClassInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colUseMethodClassFullName });
            gvUseMethodClassInfo.DetailHeight = 272;
            gvUseMethodClassInfo.GridControl = gcUseMethodClassInfo;
            gvUseMethodClassInfo.Name = "gvUseMethodClassInfo";
            gvUseMethodClassInfo.OptionsView.EnableAppearanceEvenRow = true;
            gvUseMethodClassInfo.OptionsView.ShowGroupPanel = false;
            gvUseMethodClassInfo.OptionsView.ShowViewCaption = true;
            gvUseMethodClassInfo.ViewCaption = "RefClassView";
            // 
            // colUseMethodClassFullName
            // 
            colUseMethodClassFullName.AppearanceHeader.Options.UseTextOptions = true;
            colUseMethodClassFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colUseMethodClassFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colUseMethodClassFullName.Caption = "FullName";
            colUseMethodClassFullName.FieldName = "RawClassInfo.FullName";
            colUseMethodClassFullName.MinWidth = 17;
            colUseMethodClassFullName.Name = "colUseMethodClassFullName";
            colUseMethodClassFullName.OptionsColumn.AllowEdit = false;
            colUseMethodClassFullName.OptionsColumn.ReadOnly = true;
            colUseMethodClassFullName.OptionsFilter.AllowFilter = false;
            colUseMethodClassFullName.Visible = true;
            colUseMethodClassFullName.VisibleIndex = 0;
            colUseMethodClassFullName.Width = 66;
            // 
            // gcRefMethodClassInfo
            // 
            gcRefMethodClassInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gcRefMethodClassInfo.Location = new System.Drawing.Point(0, 0);
            gcRefMethodClassInfo.MainView = gvRefMethodClassInfo;
            gcRefMethodClassInfo.Name = "gcRefMethodClassInfo";
            gcRefMethodClassInfo.Size = new System.Drawing.Size(424, 550);
            gcRefMethodClassInfo.TabIndex = 1;
            gcRefMethodClassInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvRefMethodClassInfo });
            // 
            // gvRefMethodClassInfo
            // 
            gvRefMethodClassInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colRefMethodClassFullName });
            gvRefMethodClassInfo.DetailHeight = 272;
            gvRefMethodClassInfo.GridControl = gcRefMethodClassInfo;
            gvRefMethodClassInfo.Name = "gvRefMethodClassInfo";
            gvRefMethodClassInfo.OptionsView.EnableAppearanceEvenRow = true;
            gvRefMethodClassInfo.OptionsView.ShowGroupPanel = false;
            gvRefMethodClassInfo.OptionsView.ShowViewCaption = true;
            gvRefMethodClassInfo.ViewCaption = "UseClassView";
            // 
            // colRefMethodClassFullName
            // 
            colRefMethodClassFullName.AppearanceHeader.Options.UseTextOptions = true;
            colRefMethodClassFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colRefMethodClassFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colRefMethodClassFullName.Caption = "FullName";
            colRefMethodClassFullName.FieldName = "RawClassInfo.FullName";
            colRefMethodClassFullName.MinWidth = 17;
            colRefMethodClassFullName.Name = "colRefMethodClassFullName";
            colRefMethodClassFullName.OptionsColumn.AllowEdit = false;
            colRefMethodClassFullName.OptionsColumn.ReadOnly = true;
            colRefMethodClassFullName.OptionsFilter.AllowFilter = false;
            colRefMethodClassFullName.Visible = true;
            colRefMethodClassFullName.VisibleIndex = 0;
            colRefMethodClassFullName.Width = 66;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(TabView);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(900, 600);
            layoutControl1.TabIndex = 2;
            layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(900, 600);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = TabView;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(880, 580);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // PageOrgClasses
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "PageOrgClasses";
            Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)TabView).EndInit();
            TabView.ResumeLayout(false);
            TabPageField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitFieldView.Panel1).EndInit();
            SplitFieldView.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitFieldView.Panel2).EndInit();
            SplitFieldView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitFieldView).EndInit();
            SplitFieldView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcRefFieldClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvRefFieldClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcUseFieldClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvUseFieldClassInfo).EndInit();
            TabPageInherit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitInheritView.Panel1).EndInit();
            SplitInheritView.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitInheritView.Panel2).EndInit();
            SplitInheritView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitInheritView).EndInit();
            SplitInheritView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcParentClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvParentClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcDerivedClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDerivedClassInfo).EndInit();
            TabPageMethod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitMethodView.Panel1).EndInit();
            SplitMethodView.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitMethodView.Panel2).EndInit();
            SplitMethodView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitMethodView).EndInit();
            SplitMethodView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcUseMethodClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvUseMethodClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcRefMethodClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvRefMethodClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl TabView;
        private DevExpress.XtraTab.XtraTabPage TabPageField;
        private DevExpress.XtraTab.XtraTabPage TabPageMethod;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gcRefMethodClassInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRefMethodClassInfo;
        private DevExpress.XtraGrid.GridControl gcUseMethodClassInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUseMethodClassInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colRefMethodClassFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colUseMethodClassFullName;
        private DevExpress.XtraEditors.SplitContainerControl SplitMethodView;
        private DevExpress.XtraTab.XtraTabPage TabPageInherit;
        private DevExpress.XtraEditors.SplitContainerControl SplitFieldView;
        private DevExpress.XtraEditors.SplitContainerControl SplitInheritView;
        private DevExpress.XtraGrid.GridControl gcRefFieldClassInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRefFieldClassInfo;
        private DevExpress.XtraGrid.GridControl gcUseFieldClassInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUseFieldClassInfo;
        private DevExpress.XtraGrid.GridControl gcParentClassInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvParentClassInfo;
        private DevExpress.XtraGrid.GridControl gcDerivedClassInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDerivedClassInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colRefFieldClassFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colUseFieldClassFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colParentClassFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colDerivedClassFullName;
    }
}
