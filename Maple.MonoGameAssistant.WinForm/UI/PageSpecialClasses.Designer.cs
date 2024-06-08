namespace Maple.MonoGameAssistant.WinForm.UI
{
    partial class PageSpecialClasses
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            gcClassInfo = new DevExpress.XtraGrid.GridControl();
            gvClassInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            colClassFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            colRawClassInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            BarMgr = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            bar2 = new DevExpress.XtraBars.Bar();
            SwitchShowClsses = new DevExpress.XtraBars.BarToggleSwitchItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvClassInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarMgr).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(gcClassInfo);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 21);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(900, 579);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(900, 579);
            Root.TextVisible = false;
            // 
            // gcClassInfo
            // 
            gcClassInfo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gcClassInfo.Location = new System.Drawing.Point(12, 12);
            gcClassInfo.MainView = gvClassInfo;
            gcClassInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gcClassInfo.Name = "gcClassInfo";
            gcClassInfo.Size = new System.Drawing.Size(876, 555);
            gcClassInfo.TabIndex = 1;
            gcClassInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvClassInfo });
            // 
            // gvClassInfo
            // 
            gvClassInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colClassFullName, colRawClassInfo });
            gvClassInfo.DetailHeight = 272;
            gvClassInfo.GridControl = gcClassInfo;
            gvClassInfo.Name = "gvClassInfo";
            gvClassInfo.OptionsDetail.EnableMasterViewMode = false;
            gvClassInfo.OptionsEditForm.PopupEditFormWidth = 700;
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
            colClassFullName.MinWidth = 17;
            colClassFullName.Name = "colClassFullName";
            colClassFullName.OptionsColumn.AllowEdit = false;
            colClassFullName.OptionsColumn.ReadOnly = true;
            colClassFullName.Visible = true;
            colClassFullName.VisibleIndex = 0;
            colClassFullName.Width = 66;
            // 
            // colRawClassInfo
            // 
            colRawClassInfo.Caption = "RawClassInfo";
            colRawClassInfo.FieldName = "RawClassInfo";
            colRawClassInfo.MinWidth = 17;
            colRawClassInfo.Name = "colRawClassInfo";
            colRawClassInfo.OptionsColumn.AllowEdit = false;
            colRawClassInfo.OptionsColumn.ReadOnly = true;
            colRawClassInfo.Width = 66;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gcClassInfo;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(880, 559);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // BarMgr
            // 
            BarMgr.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
            BarMgr.DockControls.Add(barDockControlTop);
            BarMgr.DockControls.Add(barDockControlBottom);
            BarMgr.DockControls.Add(barDockControlLeft);
            BarMgr.DockControls.Add(barDockControlRight);
            BarMgr.Form = this;
            BarMgr.Items.AddRange(new DevExpress.XtraBars.BarItem[] { SwitchShowClsses });
            BarMgr.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = BarMgr;
            barDockControlTop.Size = new System.Drawing.Size(900, 21);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 600);
            barDockControlBottom.Manager = BarMgr;
            barDockControlBottom.Size = new System.Drawing.Size(900, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 21);
            barDockControlLeft.Manager = BarMgr;
            barDockControlLeft.Size = new System.Drawing.Size(0, 579);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(900, 21);
            barDockControlRight.Manager = BarMgr;
            barDockControlRight.Size = new System.Drawing.Size(0, 579);
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(SwitchShowClsses) });
            bar2.OptionsBar.AllowQuickCustomization = false;
            bar2.OptionsBar.DisableClose = true;
            bar2.OptionsBar.DisableCustomization = true;
            bar2.OptionsBar.DrawBorder = false;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // SwitchShowClsses
            // 
            SwitchShowClsses.Caption = "ShowAll";
            SwitchShowClsses.Id = 0;
            SwitchShowClsses.Name = "SwitchShowClsses";
            SwitchShowClsses.CheckedChanged += SwitchShowClsses_CheckedChanged;
            // 
            // PageSpecialClasses
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "PageSpecialClasses";
            Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvClassInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarMgr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcClassInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClassInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colClassFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colRawClassInfo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager BarMgr;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarToggleSwitchItem SwitchShowClsses;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
