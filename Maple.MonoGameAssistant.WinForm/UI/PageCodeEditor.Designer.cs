namespace Maple.MonoGameAssistant.WinForm
{
    partial class PageCodeEditor
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
            CodeEditor = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)CodeEditor.Properties).BeginInit();
            SuspendLayout();
            // 
            // CodeEditor
            // 
            CodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            CodeEditor.Location = new System.Drawing.Point(0, 0);
            CodeEditor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            CodeEditor.Name = "CodeEditor";
            CodeEditor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            CodeEditor.Properties.ReadOnly = true;
            CodeEditor.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            CodeEditor.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            CodeEditor.Properties.WordWrap = false;
            CodeEditor.Properties.CustomHighlightText += CodeEditor_Properties_CustomHighlightText;
            CodeEditor.Size = new System.Drawing.Size(900, 600);
            CodeEditor.TabIndex = 0;
            // 
            // PageCodeEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(CodeEditor);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "PageCodeEditor";
            Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)CodeEditor.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit CodeEditor;
    }
}
