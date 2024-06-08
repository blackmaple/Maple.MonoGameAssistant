namespace Maple.MonoGameAssistant.WinForm
{
    partial class ViewMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMainForm));
            TabMgr = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ckflyPanel = new DevExpress.Utils.FlyoutPanel();
            ckflyMgr = new DevExpress.Utils.FlyoutPanelControl();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            cklabel = new DevExpress.XtraEditors.LabelControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)TabMgr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ckflyPanel).BeginInit();
            ckflyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ckflyMgr).BeginInit();
            ckflyMgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)svgImageBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormManager1).BeginInit();
            SuspendLayout();
            // 
            // TabMgr
            // 
            TabMgr.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            TabMgr.MdiParent = this;
            TabMgr.PageAdded += TabMgr_PageAdded;
            TabMgr.PageRemoved += TabMgr_PageRemoved;
            // 
            // ckflyPanel
            // 
            ckflyPanel.Controls.Add(ckflyMgr);
            ckflyPanel.Location = new System.Drawing.Point(339, 37);
            ckflyPanel.Name = "ckflyPanel";
            ckflyPanel.OwnerControl = this;
            ckflyPanel.Size = new System.Drawing.Size(293, 66);
            ckflyPanel.TabIndex = 3;
            // 
            // ckflyMgr
            // 
            ckflyMgr.AutoSize = true;
            ckflyMgr.Controls.Add(layoutControl1);
            ckflyMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            ckflyMgr.FlyoutPanel = ckflyPanel;
            ckflyMgr.Location = new System.Drawing.Point(0, 0);
            ckflyMgr.Name = "ckflyMgr";
            ckflyMgr.Size = new System.Drawing.Size(293, 66);
            ckflyMgr.TabIndex = 0;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(svgImageBox1);
            layoutControl1.Controls.Add(cklabel);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(2, 2);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-1143, 0, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(289, 62);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // svgImageBox1
            // 
            svgImageBox1.Location = new System.Drawing.Point(8, 8);
            svgImageBox1.Name = "svgImageBox1";
            svgImageBox1.Size = new System.Drawing.Size(42, 46);
            svgImageBox1.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("svgImageBox1.SvgImage");
            svgImageBox1.TabIndex = 5;
            svgImageBox1.Text = "svgImageBox1";
            // 
            // cklabel
            // 
            cklabel.Location = new System.Drawing.Point(56, 8);
            cklabel.Name = "cklabel";
            cklabel.Size = new System.Drawing.Size(225, 46);
            cklabel.StyleController = layoutControl1;
            cklabel.TabIndex = 4;
            cklabel.Text = "Test";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2 });
            Root.Name = "Root";
            Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            Root.Size = new System.Drawing.Size(289, 62);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = cklabel;
            layoutControlItem1.Location = new System.Drawing.Point(48, 0);
            layoutControlItem1.MinSize = new System.Drawing.Size(29, 18);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(231, 52);
            layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = svgImageBox1;
            layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(48, 52);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // toolbarFormControl1
            // 
            toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            toolbarFormControl1.Manager = toolbarFormManager1;
            toolbarFormControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            toolbarFormControl1.Name = "toolbarFormControl1";
            toolbarFormControl1.Size = new System.Drawing.Size(1022, 33);
            toolbarFormControl1.TabIndex = 4;
            toolbarFormControl1.TabStop = false;
            toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            toolbarFormManager1.DockControls.Add(barDockControlTop);
            toolbarFormManager1.DockControls.Add(barDockControlBottom);
            toolbarFormManager1.DockControls.Add(barDockControlLeft);
            toolbarFormManager1.DockControls.Add(barDockControlRight);
            toolbarFormManager1.Form = this;
            toolbarFormManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 33);
            barDockControlTop.Manager = toolbarFormManager1;
            barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            barDockControlTop.Size = new System.Drawing.Size(1022, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 767);
            barDockControlBottom.Manager = toolbarFormManager1;
            barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            barDockControlBottom.Size = new System.Drawing.Size(1022, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            barDockControlLeft.Manager = toolbarFormManager1;
            barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            barDockControlLeft.Size = new System.Drawing.Size(0, 734);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1022, 33);
            barDockControlRight.Manager = toolbarFormManager1;
            barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            barDockControlRight.Size = new System.Drawing.Size(0, 734);
            // 
            // ViewMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1022, 767);
            Controls.Add(ckflyPanel);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Controls.Add(toolbarFormControl1);
            IconOptions.Image = Properties.Resources.solution_32x32;
            IsMdiContainer = true;
            Name = "ViewMainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Maple.MonoGameAssistant";
            ToolbarFormControl = toolbarFormControl1;
            Load += ViewMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)TabMgr).EndInit();
            ((System.ComponentModel.ISupportInitialize)ckflyPanel).EndInit();
            ckflyPanel.ResumeLayout(false);
            ckflyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ckflyMgr).EndInit();
            ckflyMgr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)svgImageBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager TabMgr;
        private DevExpress.Utils.FlyoutPanel ckflyPanel;
        private DevExpress.Utils.FlyoutPanelControl ckflyMgr;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LabelControl cklabel;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
    }
}