using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UIInventoryDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameInventoryDisplayDTO? InventoryDisplay { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameInventoryInfoDTO? InventoryInfo { get; set; }

     
        private bool Loading { set; get; } = false;
        private async Task OnUpdateInventoryInfo()
        {
            try
            {
                this.Loading = true;
                await Task.Delay(2500);
                await this.Core.OnUpdateInventory(InventoryDisplay.DisplayCategory, InventoryInfo);
            }
            finally
            {
                this.Loading = false;
            }
        }



    }
}