using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UIInventoryTab
    {

        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        private string? SearchContent { set; get; }
        private void OnSearch()
        {
            this.Core.OnSearchInventory(SearchContent);
        }
        private void OnSearch(string? displayCategory)
        {
            SearchContent = displayCategory;
            this.OnSearch();
        }
        private async Task OnSelected(GameInventoryDisplayDTO gameInventory)
        {
            await this.Core.OnSelectedInventory(gameInventory);

        }
    }
}