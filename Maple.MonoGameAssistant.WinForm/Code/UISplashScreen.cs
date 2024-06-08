using System;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Maple.MonoGameAssistant.WinForm
{
    public sealed class UISplashScreen(Form frm) : IDisposable
    {
        static OverlayWindowOptions OverlayWindowOptions { get; } = new(opacity: 100d / 255);

        IOverlaySplashScreenHandle Handle { get; } = SplashScreenManager.ShowOverlayForm(frm, OverlayWindowOptions);

        public void Dispose()
        {
            this.Handle.Close();
        }
    }

}
