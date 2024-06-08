using BlazorComponent;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UIMainTabs
    {
        public static StringNumber Tab_Default => Tab_Currency;
        public static StringNumber Tab_Currency { get; } = 10;
        public static StringNumber Tab_Inventory { get; } = 20;
        public static StringNumber Tab_Character { get; } = 30;
        public static StringNumber Tab_Misc { get; } = 40;
        public static StringNumber Tab_Monster { get; } = 50;
        public static StringNumber Tab_Quest { get; } = 60;
        public static StringNumber Tab_Effect { get; } = 70;


        [NotNull]
        [CascadingParameter]
        public StringNumber? NavTab { set; get; } = 0;

    }
}