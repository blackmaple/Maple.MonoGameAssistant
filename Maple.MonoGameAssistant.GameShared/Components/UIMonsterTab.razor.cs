using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UIMonsterTab
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }
        private bool Fab { get; set; }
        private string? SearchContent { set; get; }
        private void OnSearch()
        {
            this.Core.OnSearchMonster(SearchContent);
        }
        private async Task OnSelected(GameMonsterDisplayDTO  gameMonster)
        {
            await this.Core.OnSelectedMonster(gameMonster);

        }
    }
}