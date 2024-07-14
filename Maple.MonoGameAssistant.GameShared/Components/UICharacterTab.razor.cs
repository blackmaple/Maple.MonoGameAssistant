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

        private async Task OnReload()
        {
            using (this.Core.ShowWait())
            { 
                await this.Core.GetListCharacterDisplayAsync();
            }
        }

        private async Task OnSelectedCharacterStatus(GameCharacterDisplayDTO gameCharacter)
        {
            try
            {
                gameCharacter.Loading = true;
                await this.Core.OnSelectedCharacterStatus(gameCharacter);
               
            }
            finally
            {
                gameCharacter.Loading = false;
            }
        }

        private async Task OnSelectedCharacterSkill(GameCharacterDisplayDTO gameCharacter)
        {
            try
            {
                gameCharacter.Loading = true;
                await this.Core.OnSelectedCharacterSkill(gameCharacter);
            }
            finally
            {
                gameCharacter.Loading = false;
            }
        }

        private async Task OnSelectedCharacterEquipment(GameCharacterDisplayDTO gameCharacter)
        {
            try
            {
                gameCharacter.Loading = true;
                await this.Core.OnSelectedCharacterEquipment(gameCharacter);
            }
            finally
            {
                gameCharacter.Loading = false;
            }
        }
    }
}