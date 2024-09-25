using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Masa.Blazor;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UISelectedInventoryDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        private string? SearchContent { set; get; }

        [Parameter, EditorRequired, NotNull]
        public List<GameInventoryDisplayDTO>? ListItem_All { get; set; }
        public List<GameInventoryDisplayDTO> ListItem_Search { get; set; } = [];

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            ListItem_Search.AddRange(ListItem_All);
        }
        private void OnSearch()
        {
            this.ListItem_Search.Clear();
            IEnumerable<GameInventoryDisplayDTO> searchDatas = this.ListItem_All;

            if (string.IsNullOrEmpty(SearchContent) == false)
            {
                searchDatas = searchDatas.Where(p => p.ContainsGameDisplay(SearchContent, p.DisplayCategory));
            }
            this.ListItem_Search.AddRange(searchDatas);
        }

        public async Task OnSelectedData(GameInventoryDisplayDTO  inventoryDisplayDTO)
        {
            if (await this.Core.PopupService.ConfirmAsync($"Add {inventoryDisplayDTO.DisplayCategory}", $"Add {inventoryDisplayDTO.DisplayCategory}:{inventoryDisplayDTO.DisplayName}", AlertTypes.Warning))
            {
                await this.ClosePopupAsync(inventoryDisplayDTO);
            }
        }

    }
}