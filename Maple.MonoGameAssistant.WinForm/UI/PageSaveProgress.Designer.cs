namespace Maple.MonoGameAssistant.WinForm.UI
{
    partial class PageSaveProgress
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
            ImageProgressBar = new DevExpress.XtraEditors.ProgressBarControl();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            ClassesProgressBar = new DevExpress.XtraEditors.ProgressBarControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            ImageProgressInfo = new DevExpress.XtraLayout.LayoutControlItem();
            ClassesProgressInfo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)ImageProgressBar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClassesProgressBar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageProgressInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClassesProgressInfo).BeginInit();
            SuspendLayout();
            // 
            // ImageProgressBar
            // 
            ImageProgressBar.Location = new System.Drawing.Point(18, 46);
            ImageProgressBar.Name = "ImageProgressBar";
            ImageProgressBar.Properties.ShowTitle = true;
            ImageProgressBar.ShowToolTips = false;
            ImageProgressBar.Size = new System.Drawing.Size(695, 29);
            ImageProgressBar.StyleController = layoutControl1;
            ImageProgressBar.TabIndex = 0;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(ClassesProgressBar);
            layoutControl1.Controls.Add(ImageProgressBar);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(731, 159);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // ClassesProgressBar
            // 
            ClassesProgressBar.Location = new System.Drawing.Point(18, 108);
            ClassesProgressBar.Name = "ClassesProgressBar";
            ClassesProgressBar.Properties.ShowTitle = true;
            ClassesProgressBar.Size = new System.Drawing.Size(695, 30);
            ClassesProgressBar.StyleController = layoutControl1;
            ClassesProgressBar.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { ImageProgressInfo, ClassesProgressInfo });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(731, 159);
            Root.TextVisible = false;
            // 
            // ImageProgressInfo
            // 
            ImageProgressInfo.Control = ImageProgressBar;
            ImageProgressInfo.Location = new System.Drawing.Point(0, 0);
            ImageProgressInfo.MinSize = new System.Drawing.Size(171, 48);
            ImageProgressInfo.Name = "ImageProgressInfo";
            ImageProgressInfo.Size = new System.Drawing.Size(701, 62);
            ImageProgressInfo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            ImageProgressInfo.Text = "Please Press Start Button";
            ImageProgressInfo.TextLocation = DevExpress.Utils.Locations.Top;
            ImageProgressInfo.TextSize = new System.Drawing.Size(165, 18);
            // 
            // ClassesProgressInfo
            // 
            ClassesProgressInfo.Control = ClassesProgressBar;
            ClassesProgressInfo.Location = new System.Drawing.Point(0, 62);
            ClassesProgressInfo.MinSize = new System.Drawing.Size(171, 57);
            ClassesProgressInfo.Name = "ClassesProgressInfo";
            ClassesProgressInfo.Size = new System.Drawing.Size(701, 63);
            ClassesProgressInfo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            ClassesProgressInfo.Text = "Load Classes...";
            ClassesProgressInfo.TextLocation = DevExpress.Utils.Locations.Top;
            ClassesProgressInfo.TextSize = new System.Drawing.Size(165, 18);
            // 
            // PageSaveProgress
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl1);
            Name = "PageSaveProgress";
            Size = new System.Drawing.Size(731, 159);
            ((System.ComponentModel.ISupportInitialize)ImageProgressBar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ClassesProgressBar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageProgressInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClassesProgressInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl ImageProgressBar;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem ImageProgressInfo;
        private DevExpress.XtraEditors.ProgressBarControl ClassesProgressBar;
        private DevExpress.XtraLayout.LayoutControlItem ClassesProgressInfo;
    }
}
