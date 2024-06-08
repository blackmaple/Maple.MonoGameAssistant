using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UIMiscTab
    {

        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }


        private string? SearchContent { set; get; }
        private void OnSearch()
        {
            this.Core.OnSearchInventory(SearchContent);
        }

        private async Task<bool> OnChange(GameSwitchDisplayDTO gameSwitchDisplay)
        {
            try
            {
                gameSwitchDisplay.Loading = true;
                await Task.Delay(5000);
                return true;
            }
            finally
            {
                gameSwitchDisplay.Loading = false;
            }
        }

    }
}