using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UICurrencyTab
    {

        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        private string? SearchContent { set; get; }
        private void OnSearch()
        {
            this.Core.OnSearchCurrency(SearchContent);
        }
        private async Task OnSelected(GameCurrencyDisplayDTO gameCurrency)
        {
            await this.Core.OnSelectedCurrency(gameCurrency);

        }
    }
}