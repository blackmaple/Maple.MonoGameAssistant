using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UILogic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm
{
    public sealed partial class UIImageDisplay : RepositoryItemHyperLinkEdit
    {
        public UIImageDisplay() : base()
        {
        }


        static UIImageDisplay UI_Game { get; }
        static UIImageDisplay UI_Unity { get; }
        static UIImageDisplay UI_System { get; }
        static UIImageDisplay UI_Library { get; }

        static UIImageDisplay()
        {
            UI_Game = new UIImageDisplay();
            ((System.ComponentModel.ISupportInitialize)UI_Game).BeginInit();
            UI_Game.Buttons.Add(UIHelper.CreateEditorButton(Color.Magenta, "Game", true));
            UI_Game.EndInit();

            UI_Unity = new UIImageDisplay();
            ((System.ComponentModel.ISupportInitialize)UI_Unity).BeginInit();
            UI_Unity.Buttons.Add(UIHelper.CreateEditorButton(Color.GreenYellow, "Unity", true));
            UI_Unity.EndInit();


            UI_System = new UIImageDisplay();
            ((System.ComponentModel.ISupportInitialize)UI_System).BeginInit();
            UI_System.Buttons.Add(UIHelper.CreateEditorButton(Color.Salmon, "System", true));
            UI_System.EndInit();

            UI_Library = new UIImageDisplay();
            ((System.ComponentModel.ISupportInitialize)UI_Library).BeginInit();
            UI_Library.Buttons.Add(UIHelper.CreateEditorButton(Color.Orange, "Library", true));
            UI_Library.EndInit();



        }
        public static UIImageDisplay Create(GameImageInfo imageInfoDTO)
        {
            if (imageInfoDTO.IsSystem)
            {
                return UI_System;
            }
            if (imageInfoDTO.IsUnity)
            {
                return UI_Unity;
            }
            if (imageInfoDTO.IsLibrary)
            {
                return UI_Library;
            }
            return UI_Game;
        }

    }


}
