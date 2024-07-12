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
            this.Core.OnSearchSwitch(SearchContent);
        }
        private async Task OnReload()
        {
            using (this.Core.ShowWait())
            { 
                await this.Core.GetListSwitchDisplayAsync();
            }
        }
        private async Task OnChange(GameSwitchDisplayDTO gameSwitchDisplay)
        {
            try
            {
                gameSwitchDisplay.Loading = true;
                await this.Core.UpdateSwitchDisplay(gameSwitchDisplay);
            }
            finally
            {
                gameSwitchDisplay.Loading = false;
            }
        }

    }
}