namespace Maple.MonoGameAssistant.WinForm.UI
{
    partial class ViewGameTab
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            gcImageInfo = new DevExpress.XtraGrid.GridControl();
            gvImageInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            colImageName = new DevExpress.XtraGrid.Columns.GridColumn();
            colImageFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            gcClassInfo = new DevExpress.XtraGrid.GridControl();
            gvClassInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            colClassFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            colRawClassInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            BarMgr = new DevExpress.XtraBars.BarManager(components);
            BarTop = new DevExpress.XtraBars.Bar();
            BtnSaveImageInfos = new DevExpress.XtraBars.BarButtonItem();
            BtnLoadImageInfos = new DevExpress.XtraBars.BarButtonItem();
            BtnShowClassInfos = new DevExpress.XtraBars.BarButtonItem();
            BtnTxtFilePath = new DevExpress.XtraBars.BarEditItem();
            RepItemFilePath = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            TxtNamespace = new DevExpress.XtraBars.BarEditItem();
            RepItemText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcImageInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvImageInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarMgr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RepItemFilePath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RepItemText).BeginInit();
            SuspendLayout();
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl1.Location = new System.Drawing.Point(0, 30);
            splitContainerControl1.Name = "splitContainerControl1";
            splitContainerControl1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(gcImageInfo);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(gcClassInfo);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new System.Drawing.Size(1364, 700);
            splitContainerControl1.SplitterPosition = 343;
            splitContainerControl1.TabIndex = 0;
            // 
            // gcImageInfo
            // 
            gcImageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gcImageInfo.Location = new System.Drawing.Point(0, 0);
            gcImageInfo.MainView = gvImageInfo;
            gcImageInfo.Name = "gcImageInfo";
            gcImageInfo.Size = new System.Drawing.Size(343, 680);
            gcImageInfo.TabIndex = 0;
            gcImageInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvImageInfo });
            // 
            // gvImageInfo
            // 
            gvImageInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colImageName, colImageFileName });
            gvImageInfo.GridControl = gcImageInfo;
            gvImageInfo.Name = "gvImageInfo";
            gvImageInfo.OptionsFind.AlwaysVisible = true;
            gvImageInfo.OptionsView.EnableAppearanceEvenRow = true;
            gvImageInfo.OptionsView.ShowColumnHeaders = false;
            gvImageInfo.OptionsView.ShowGroupPanel = false;
            gvImageInfo.OptionsView.ShowViewCaption = true;
            gvImageInfo.ViewCaption = "ImageView";
            // 
            // colImageName
            // 
            colImageName.Caption = "Name";
            colImageName.FieldName = "RawImageInfo.Name";
            colImageName.MinWidth = 19;
            colImageName.Name = "colImageName";
            colImageName.OptionsColumn.AllowEdit = false;
            colImageName.OptionsColumn.ReadOnly = true;
            colImageName.Visible = true;
            colImageName.VisibleIndex = 0;
            // 
            // colImageFileName
            // 
            colImageFileName.Caption = "FileName";
            colImageFileName.FieldName = "RawImageInfo.FileName";
            colImageFileName.MinWidth = 19;
            colImageFileName.Name = "colImageFileName";
            colImageFileName.OptionsColumn.AllowEdit = false;
            colImageFileName.OptionsColumn.ReadOnly = true;
            // 
            // gcClassInfo
            // 
            gcClassInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gcClassInfo.Location = new System.Drawing.Point(0, 0);
            gcClassInfo.MainView = gvClassInfo;
            gcClassInfo.Name = "gcClassInfo";
            gcClassInfo.Size = new System.Drawing.Size(989, 680);
            gcClassInfo.TabIndex = 0;
            gcClassInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvClassInfo });
            // 
            // gvClassInfo
            // 
            gvClassInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colClassFullName, colRawClassInfo });
            gvClassInfo.GridControl = gcClassInfo;
            gvClassInfo.Name = "gvClassInfo";
            gvClassInfo.OptionsDetail.EnableMasterViewMode = false;
            gvClassInfo.OptionsEditForm.PopupEditFormWidth = 914;
            gvClassInfo.OptionsFind.AlwaysVisible = true;
            gvClassInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvClassInfo.OptionsView.EnableAppearanceEvenRow = true;
            gvClassInfo.OptionsView.ShowColumnHeaders = false;
            gvClassInfo.OptionsView.ShowGroupPanel = false;
            gvClassInfo.OptionsView.ShowViewCaption = true;
            gvClassInfo.ViewCaption = "ClassView";
            // 
            // colClassFullName
            // 
            colClassFullName.Caption = "FullName";
            colClassFullName.FieldName = "RawClassInfo.FullName";
            colClassFullName.MinWidth = 19;
            colClassFullName.Name = "colClassFullName";
            colClassFullName.OptionsColumn.AllowEdit = false;
            colClassFullName.OptionsColumn.ReadOnly = true;
            colClassFullName.Visible = true;
            colClassFullName.VisibleIndex = 0;
            // 
            // colRawClassInfo
            // 
            colRawClassInfo.Caption = "RawClassInfo";
            colRawClassInfo.FieldName = "RawClassInfo";
            colRawClassInfo.MinWidth = 19;
            colRawClassInfo.Name = "colRawClassInfo";
            colRawClassInfo.OptionsColumn.AllowEdit = false;
            colRawClassInfo.OptionsColumn.ReadOnly = true;
            // 
            // BarMgr
            // 
            BarMgr.Bars.AddRange(new DevExpress.XtraBars.Bar[] { BarTop });
            BarMgr.DockControls.Add(barDockControlTop);
            BarMgr.DockControls.Add(barDockControlBottom);
            BarMgr.DockControls.Add(barDockControlLeft);
            BarMgr.DockControls.Add(barDockControlRight);
            BarMgr.Form = this;
            BarMgr.Items.AddRange(new DevExpress.XtraBars.BarItem[] { BtnSaveImageInfos, BtnLoadImageInfos, BtnShowClassInfos, TxtNamespace, BtnTxtFilePath });
            BarMgr.MaxItemId = 5;
            BarMgr.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { RepItemText, RepItemFilePath });
            // 
            // BarTop
            // 
            BarTop.BarName = "Custom 2";
            BarTop.DockCol = 0;
            BarTop.DockRow = 0;
            BarTop.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            BarTop.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(BtnSaveImageInfos), new DevExpress.XtraBars.LinkPersistInfo(BtnLoadImageInfos), new DevExpress.XtraBars.LinkPersistInfo(BtnShowClassInfos), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width, BtnTxtFilePath, "", true, true, true, 411, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width, TxtNamespace, "", false, true, true, 215, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            BarTop.OptionsBar.AllowQuickCustomization = false;
            BarTop.OptionsBar.DisableClose = true;
            BarTop.OptionsBar.DisableCustomization = true;
            BarTop.OptionsBar.DrawBorder = false;
            BarTop.OptionsBar.DrawDragBorder = false;
            BarTop.OptionsBar.UseWholeRow = true;
            BarTop.Text = "Custom 2";
            // 
            // BtnSaveImageInfos
            // 
            BtnSaveImageInfos.Id = 0;
            BtnSaveImageInfos.ImageOptions.SvgImage = Properties.Resources.Save;
            BtnSaveImageInfos.Name = "BtnSaveImageInfos";
            BtnSaveImageInfos.ItemClick += BtnSaveImageInfos_ItemClick;
            // 
            // BtnLoadImageInfos
            // 
            BtnLoadImageInfos.Id = 1;
            BtnLoadImageInfos.ImageOptions.SvgImage = Properties.Resources.FolderOpen;
            BtnLoadImageInfos.Name = "BtnLoadImageInfos";
            BtnLoadImageInfos.ItemClick += BtnLoadImageInfos_ItemClick;
            // 
            // BtnShowClassInfos
            // 
            BtnShowClassInfos.Id = 2;
            BtnShowClassInfos.ImageOptions.SvgImage = Properties.Resources.Flow;
            BtnShowClassInfos.Name = "BtnShowClassInfos";
            BtnShowClassInfos.ItemClick += BtnShowClassInfos_ItemClick;
            // 
            // BtnTxtFilePath
            // 
            BtnTxtFilePath.Caption = "ClassPath";
            BtnTxtFilePath.Edit = RepItemFilePath;
            BtnTxtFilePath.EditValue = "";
            BtnTxtFilePath.Id = 4;
            BtnTxtFilePath.Name = "BtnTxtFilePath";
            // 
            // RepItemFilePath
            // 
            RepItemFilePath.AutoHeight = false;
            RepItemFilePath.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus) });
            RepItemFilePath.Name = "RepItemFilePath";
            RepItemFilePath.ButtonClick += RepItemFilePath_ButtonClick;
            // 
            // TxtNamespace
            // 
            TxtNamespace.Caption = "namespace";
            TxtNamespace.Edit = RepItemText;
            TxtNamespace.EditValue = "Maple.Game.GameModel";
            TxtNamespace.Id = 3;
            TxtNamespace.Name = "TxtNamespace";
            // 
            // RepItemText
            // 
            RepItemText.AutoHeight = false;
            RepItemText.Name = "RepItemText";
            RepItemText.Click += RepItemText_Click;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = BarMgr;
            barDockControlTop.Size = new System.Drawing.Size(1364, 30);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 730);
            barDockControlBottom.Manager = BarMgr;
            barDockControlBottom.Size = new System.Drawing.Size(1364, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            barDockControlLeft.Manager = BarMgr;
            barDockControlLeft.Size = new System.Drawing.Size(0, 700);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1364, 30);
            barDockControlRight.Manager = BarMgr;
            barDockControlRight.Size = new System.Drawing.Size(0, 700);
            // 
            // ViewGameTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1364, 730);
            Controls.Add(splitContainerControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "ViewGameTab";
            Text = "ViewGameTab";
            Load += ViewGameTab_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcImageInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvImageInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarMgr).EndInit();
            ((System.ComponentModel.ISupportInitialize)RepItemFilePath).EndInit();
            ((System.ComponentModel.ISupportInitialize)RepItemText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcImageInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvImageInfo;
        private DevExpress.XtraGrid.GridControl gcClassInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClassInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colImageName;
        private DevExpress.XtraGrid.Columns.GridColumn colImageFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colClassFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colRawClassInfo;
        private DevExpress.XtraBars.BarManager BarMgr;
        private DevExpress.XtraBars.Bar BarTop;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem BtnSaveImageInfos;
        private DevExpress.XtraBars.BarButtonItem BtnLoadImageInfos;
        private DevExpress.XtraBars.BarButtonItem BtnShowClassInfos;
        private DevExpress.XtraBars.BarEditItem TxtNamespace;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepItemText;
        private DevExpress.XtraBars.BarEditItem BtnTxtFilePath;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RepItemFilePath;
    }
}