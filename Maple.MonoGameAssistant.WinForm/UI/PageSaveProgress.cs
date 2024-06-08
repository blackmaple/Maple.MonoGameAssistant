using DevExpress.Utils.Extensions;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
using Maple.MonoGameAssistant.UILogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Maple.MonoGameAssistant.UILogic.GameCodeContext;

namespace Maple.MonoGameAssistant.WinForm.UI
{
    public partial class PageSaveProgress : DevExpress.XtraEditors.XtraUserControl
    {
        public required GameCodeContext GameCodeContext { set; get; }

        public required ViewMainForm ViewMainForm { set; get; }
        public required UIService UIService { set; get; }
        //GameContextFactory GameContextFactory => UIService.GameContextFactory;


        CancellationTokenSource? TokenSource { get; set; }
        public PageSaveProgress(ViewMainForm viewMainForm, UIService uIService) : this()
        {
            this.ViewMainForm = viewMainForm;
            this.UIService = uIService;
        }


        public PageSaveProgress()
        {
            InitializeComponent();
        }


        #region UI

        //public int ImageIndex = 0;
        //public int ImageCount = 0;
        void InitImageProgressInfo(int count)
        {

            this.ImageProgressBar.Properties.Minimum = 0;
            this.ImageProgressBar.Properties.Maximum = count;
            this.ImageProgressBar.Position = 0;

        }
        void SetImageProgresMsg(string msg)
        {
            this.ImageProgressInfo.Text = $"({this.ImageProgressBar.Position:D4}/{this.ImageProgressBar.Properties.Maximum:D4}):{msg}";
        }
        void SetImageProgressPosition()
        {
            //if (ImageCount != 0)
            //{
            //    this.ImageProgressBar.Position = Convert.ToInt32((++ImageIndex) * 100F / ImageCount);
            //}
            this.ImageProgressBar.Increment(1);

        }

        //public int ClassesIndex = 0;
        //public int ClassesCount = 0;
        void InitClassesProgressInfo(int count)
        {
            //ClassesIndex = 0;
            //ClassesCount = count;
            this.ClassesProgressBar.Properties.Minimum = 0;
            this.ClassesProgressBar.Properties.Maximum = count;
            this.ClassesProgressBar.Position = 0;
        }
        void AddClassesProgressInfo(int count)
        {

            this.ClassesProgressBar.Properties.Maximum += count;

        }
        void SetClassesProgressMsg(string msg)
        {
            this.ClassesProgressInfo.Text = $"({this.ClassesProgressBar.Position:D4}/{this.ClassesProgressBar.Properties.Maximum:D4}):{msg}";

        }
        void SetClassesProgressPosition()
        {
            this.ClassesProgressBar.Increment(1);
            //if (ClassesCount != 0)
            //{
            //    this.ClassesProgressBar.Position = Convert.ToInt32((++ClassesIndex) * 100F / ClassesCount);
            //}

        }



        void Invoke_NotifyProgressInfo(object? obj)
        {
            if (obj is GameAnalyzerNotifyMsg notifyMsg)
            {
                this.NotifyProgressInfo(notifyMsg);
            }
        }
        void NotifyProgressInfo(GameAnalyzerNotifyMsg notifyMsg)
        {
            EnumGameAnalyzerNotifyCode notifyCode = notifyMsg.NotifyCode;
            object? notifyObj = notifyMsg.MsgObject;
            if (notifyCode == EnumGameAnalyzerNotifyCode.Notify_ImageCount && notifyObj is int imageCount)
            {
                this.InitClassesProgressInfo(0);
                this.InitImageProgressInfo(imageCount);
            }
            else if (notifyCode == EnumGameAnalyzerNotifyCode.Notify_LoadImage && notifyObj is string imageName)
            {
                this.SetImageProgressPosition();
                this.SetImageProgresMsg($"Load {imageName}...");
            }
            else if (notifyCode == EnumGameAnalyzerNotifyCode.Notify_ClassCount && notifyObj is int classCount)
            {
                this.InitClassesProgressInfo(classCount);
            }
            else if (notifyCode == EnumGameAnalyzerNotifyCode.Notify_AddClassCount && notifyObj is int addclassCount)
            {
                this.AddClassesProgressInfo(addclassCount);
            }
            //else if (analyzerNotify == EnumGameAnalyzerNotifyCode.Notify_LoadClass && notifyObj is string className)
            //{
            // //   this.SetClassesProgressMsg($"Load {className}...");
            //}
            else if (notifyCode == EnumGameAnalyzerNotifyCode.Notify_SaveClass && notifyObj is string saveName)
            {
                //           this.SetClassesProgressPosition();
                this.SetClassesProgressPosition();
                this.SetClassesProgressMsg($"Save {saveName}...");
            }
            else if (notifyCode == EnumGameAnalyzerNotifyCode.Notify_Cancel)
            {
                this.SetClassesProgressMsg("Cancel...");
                this.SetImageProgresMsg("Cancel...");

            }
            else if (notifyCode == EnumGameAnalyzerNotifyCode.Notify_Complete)
            {
                this.SetClassesProgressMsg("Complete...");
                this.SetImageProgresMsg("Complete...");

            }
            else if (notifyCode == EnumGameAnalyzerNotifyCode.Notify_Error)
            {
                this.TokenSource?.Cancel();
                this.SetClassesProgressMsg("Error...");
                this.SetImageProgresMsg("Error...");
            }
        }

        #endregion

        public required string SelectedPath { set; get; }


        public DialogResult ShowDialog(Form frm, bool enumObject = true)
        {

            var args = new XtraDialogArgs
            {
                Owner = frm,
                Caption = "GameAnalyzer",
                Content = this,
                ContentPadding = new System.Windows.Forms.Padding(10),
                Buttons = [System.Windows.Forms.DialogResult.OK, System.Windows.Forms.DialogResult.Cancel],

            };

            if (enumObject)
            {
                args.Showing += EnumObject_XtraDialog_Showing;
            }
            else
            {
                this.ImageProgressInfo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                args.Showing += LoadObject_XtraDialog_Showing;
            }
            return XtraDialog.Show(args);

        }

        #region LoadObject

        private void LoadObject_XtraDialog_Showing(object? sender, XtraMessageShowingArgs e)
        {

            var sbutton = e.Buttons[System.Windows.Forms.DialogResult.OK];
            sbutton.Click += LoadObject_Button_Start;
            sbutton.Text = "Start";
            sbutton.DialogResult = DialogResult.None;
            var cbutton = e.Buttons[System.Windows.Forms.DialogResult.Cancel];
            //    cbutton.DialogResult = DialogResult.None;
            cbutton.Click += Common_Button_Cacle;
            cbutton.Text = "Cancel";

        }

        private async void LoadObject_Button_Start(object? sender, EventArgs e)
        {

            if (sender is not SimpleButton sbutton)
            {
                return;
            }
            if (sbutton.DialogResult != DialogResult.None)
            {
                return;
            }
            try
            {
                sbutton.Enabled = false;
                await LoadObjectAsync();

            }
            finally
            {
                sbutton.Enabled = true;
                sbutton.DialogResult = XtraMessageBox.Show(this, "OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sbutton.PerformClick();
            }


        }

        private async ValueTask LoadObjectAsync()
        {


            var gameLocalCacheService = this.GameCodeContext.LocalCacheService;
            this.TokenSource = new CancellationTokenSource();
            var taskScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            await gameLocalCacheService.LoadJsonFilesAsync(Invoke_NotifyProgressInfo, this.SelectedPath, taskScheduler, this.TokenSource.Token);


        }
        #endregion

        #region EnumObject

        private void EnumObject_XtraDialog_Showing(object? sender, XtraMessageShowingArgs e)
        {
            var sbutton = e.Buttons[System.Windows.Forms.DialogResult.OK];
            sbutton.Click += EnumObject_Button_Start;
            sbutton.Text = "Start";
            sbutton.DialogResult = DialogResult.None;
            var cbutton = e.Buttons[System.Windows.Forms.DialogResult.Cancel];
            cbutton.DialogResult = DialogResult.None;
            cbutton.Click += Common_Button_Cacle;
            cbutton.Text = "Cancel";
        }

        private async void EnumObject_Button_Start(object? sender, EventArgs e)
        {
            if (sender is not SimpleButton sbutton)
            {
                return;
            }
            if (sbutton.DialogResult != DialogResult.None)
            {
                return;
            }
            try
            {
                sbutton.Enabled = false;
                await EnumObjectAsync();

            }
            finally
            {
                sbutton.Enabled = true;
                sbutton.DialogResult = XtraMessageBox.Show(this, "OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sbutton.PerformClick();
            }

        }

        private async ValueTask EnumObjectAsync()
        {
            var gameLoadRemoteDataService = this.GameCodeContext.CreateLoadRemoteDataService(this.SelectedPath);
            this.TokenSource = new CancellationTokenSource();
            var taskScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            await gameLoadRemoteDataService.RunAsync(Invoke_NotifyProgressInfo, taskScheduler, this.TokenSource.Token);
        }
        #endregion

        private void Common_Button_Cacle(object? sender, EventArgs e)
        {
            if (this.TokenSource is not null && XtraMessageBox.Show(this, "Cancel?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.TokenSource?.Cancel();
                this.TokenSource = default;
            }
        }

    }
}
