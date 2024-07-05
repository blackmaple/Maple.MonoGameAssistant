using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UICurrencyDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCurrencyDisplayDTO? CurrencyDisplay { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCurrencyInfoDTO? CurrencyInfo { get; set; }



        private async Task OnUpdateCurrency()
        {
            try
            {
                CurrencyDisplay.Loading = true;
                await this.Core.OnUpdateCurrency(CurrencyInfo);
            }
            finally
            {
                CurrencyDisplay.Loading = false;
            }
        }



    }
}