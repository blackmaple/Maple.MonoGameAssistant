using DevExpress.Utils;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm
{
    public sealed partial class UIMethodDisplay : RepositoryItemHypertextLabel
    {
        public UIMethodDisplay() : base()
        {
        }


        static UIMethodDisplay UI_Normal { get; }
        static UIMethodDisplay UI_Static { get; }
        static UIMethodDisplay UI_Abstract { get; }

        static UIMethodDisplay UI_BaseNormal { get; }
        static UIMethodDisplay UI_BaseStatic { get; }
        static UIMethodDisplay UI_BaseAbstract { get; }


        static UIMethodDisplay UI_PublicNormal { get; }
        static UIMethodDisplay UI_PublicStatic { get; }
        static UIMethodDisplay UI_PublicAbstract { get; }

        static UIMethodDisplay UI_PublicBaseNormal { get; }
        static UIMethodDisplay UI_PublicBaseStatic { get; }
        static UIMethodDisplay UI_PublicBaseAbstract { get; }

        static UIMethodDisplay CreateUI(params (Color uiColor, string uiName)[] labels)
        {
            var ui = new UIMethodDisplay();
            ((System.ComponentModel.ISupportInitialize)ui).BeginInit();
            foreach (var (uiColor, uiName) in labels)
            {
                ui.Buttons.Add(UIHelper.CreateEditorButton(uiColor, uiName, true));
            }
            ui.EndInit();
            return ui;
        }

        static UIMethodDisplay()
        {
            UI_Normal = CreateUI();
            UI_Static = CreateUI((Color.SkyBlue, "static"));
            UI_Abstract = CreateUI((Color.SkyBlue, "abstract"));

            UI_BaseNormal = CreateUI((Color.Salmon, "base"));
            UI_BaseStatic = CreateUI((Color.SkyBlue, "static"), (Color.Salmon, "base"));
            UI_BaseAbstract = CreateUI((Color.SkyBlue, "abstract"), (Color.Salmon, "base"));

            //
            UI_PublicNormal = CreateUI((Color.SkyBlue, "public"));
            UI_PublicStatic = CreateUI((Color.SkyBlue, "static"), (Color.SkyBlue, "public"));
            UI_PublicAbstract = CreateUI((Color.SkyBlue, "abstract"), (Color.SkyBlue, "public"));

            UI_PublicBaseNormal = CreateUI((Color.SkyBlue, "public"), (Color.Salmon, "base"));
            UI_PublicBaseStatic = CreateUI((Color.SkyBlue, "static"), (Color.SkyBlue, "public"), (Color.Salmon, "base"));
            UI_PublicBaseAbstract = CreateUI((Color.SkyBlue, "abstract"), (Color.SkyBlue, "public"), (Color.Salmon, "base"));

        }
        public static UIMethodDisplay Create(MonoMethodInfoDTO methodInfoDTO)
        {
            if (methodInfoDTO.IsStatic)
            {
                if (methodInfoDTO.IsPublic)
                {
                    return methodInfoDTO.FromParent ? UI_PublicBaseStatic : UI_PublicStatic;
                }
                return methodInfoDTO.FromParent ? UI_BaseStatic : UI_Static;
                
            }
            if (methodInfoDTO.IsAbstract)
            {
                if (methodInfoDTO.IsPublic)
                {
                    return methodInfoDTO.FromParent ? UI_PublicBaseAbstract : UI_PublicAbstract;
                }
                return methodInfoDTO.FromParent ? UI_BaseAbstract : UI_Abstract;

                
            }
            if (methodInfoDTO.IsPublic)
            {
                return methodInfoDTO.FromParent ? UI_PublicBaseNormal : UI_PublicNormal;
            }
            return methodInfoDTO.FromParent ? UI_BaseNormal : UI_Normal;
           
        }

    }


}
