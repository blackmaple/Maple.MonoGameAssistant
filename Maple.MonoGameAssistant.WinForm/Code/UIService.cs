
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Maple.MonoGameAssistant.UILogic;
using DevExpress.Mvvm.POCO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Drawing;
using DevExpress.Xpo.Metadata;
using System.ComponentModel;

namespace Maple.MonoGameAssistant.WinForm
{
    public class UIService(GameContextFactory gameContextFactory, IServiceProvider serviceProvider)
    {
        public GameContextFactory GameContextFactory { get; } = gameContextFactory;


        public TForm GetForm<TForm>() where TForm : Control
        {
            return serviceProvider.GetRequiredService<TForm>();
        }
    }

}
