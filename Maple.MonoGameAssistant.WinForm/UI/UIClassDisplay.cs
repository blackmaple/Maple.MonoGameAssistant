using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.Mvvm.Native;
using DevExpress.Utils;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm
{
    public sealed partial class UIClassDisplay : RepositoryItemHyperLinkEdit
    {

        public UIClassDisplay() : base()
        {

        }


        static UIClassDisplay UI_Enum { get; }

        static UIClassDisplay UI_Struct { get; }
        static UIClassDisplay UI_Struct_T { get; }

        static UIClassDisplay UI_Interface { get; }
        static UIClassDisplay UI_Interface_T { get; }

        static UIClassDisplay UI_Class { get; }
        static UIClassDisplay UI_Class_T { get; }

        static UIClassDisplay UI_Static_Class { get; }
        static UIClassDisplay UI_Static_Class_T { get; }

        static UIClassDisplay UI_Abstract_Class { get; }
        static UIClassDisplay UI_Abstract_Class_T { get; }

        static UIClassDisplay()
        {
            var enumButton = UIHelper.CreateEditorButton(Color.SpringGreen, "enum", true);
            var structButton = UIHelper.CreateEditorButton(Color.Magenta, "struct", true);
            var genericButton = UIHelper.CreateEditorButton(Color.Orange, "<T>", false);
            var interfaceButton = UIHelper.CreateEditorButton(Color.GreenYellow, "interface", true);
            var staticButton = UIHelper.CreateEditorButton(Color.Salmon, "static", true);
            var abstractButton = UIHelper.CreateEditorButton(Color.Salmon, "abstract", true);
            var classButton = UIHelper.CreateEditorButton(Color.SkyBlue, "class", true);

            UI_Enum = Create(enumButton);

            UI_Struct = Create(structButton);
            UI_Struct_T = Create(structButton, genericButton);

            UI_Interface = Create(interfaceButton);
            UI_Interface_T = Create(interfaceButton, genericButton);

            UI_Class = Create(classButton);
            UI_Class_T = Create(classButton, genericButton);

            UI_Static_Class = Create(staticButton);
            UI_Static_Class_T = Create(staticButton, genericButton);

            UI_Abstract_Class = Create(abstractButton);
            UI_Abstract_Class_T = Create(abstractButton, genericButton);

        }
        static UIClassDisplay Create(params EditorButton[] editorButtons)
        {
            var repItem = new UIClassDisplay();
            ((System.ComponentModel.ISupportInitialize)repItem).BeginInit();
            repItem.Buttons.AddRange(editorButtons);
            repItem.EndInit();
            return repItem;

        }

        public static UIClassDisplay Create(MonoClassInfoDTO classInfo)
        {
            if (classInfo.IsEnum)
            {
                return UI_Enum;
            }
            else if (classInfo.IsValueType)
            {
                return classInfo.IsGeneric ? UI_Struct_T : UI_Struct;
            }
            else if (classInfo.IsInterface)
            {
                return classInfo.IsGeneric ? UI_Interface_T : UI_Interface;
            }
            else
            {
                if (classInfo.IsStatic)
                {
                    return classInfo.IsGeneric ? UI_Static_Class_T : UI_Static_Class;
                }
                else if (classInfo.IsAbstract)
                {
                    return classInfo.IsGeneric ? UI_Abstract_Class_T : UI_Abstract_Class;
                }
                else
                {
                    return classInfo.IsGeneric ? UI_Class_T : UI_Class;
                }
            }
        }


    }
}
