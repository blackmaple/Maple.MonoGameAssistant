using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UICharacterTab
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }
        private bool Fab { get; set; }
        private string? SearchContent { set; get; }
        private void OnSearch()
        {
            this.Core.OnSearchCharacter(SearchContent);
        }
        private async Task OnSelectedCharacterStatus(GameCharacterDisplayDTO gameCharacter)
        {
            await this.Core.OnSelectedCharacterStatus(gameCharacter);
        }

        private async Task OnSelectedCharacterSkill(GameCharacterDisplayDTO gameCharacter)
        {
            await this.Core.OnSelectedCharacterSkill(gameCharacter);
        }

        private async Task OnSelectedCharacterEquipment(GameCharacterDisplayDTO gameCharacter)
        {
            await this.Core.OnSelectedCharacterEquipment(gameCharacter);
        }
    }
}