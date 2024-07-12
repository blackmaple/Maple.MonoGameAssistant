using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UICharacterStatusDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCharacterDisplayDTO? CharacterDisplay { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCharacterStatusDTO? CharacterStatus { get; set; }



         
        private async Task OnUpdateCharacterStatus(GameValueInfoDTO gameValue)
        {
            try
            {
                gameValue.Loading = true;

                await this.Core.OnUpdateCharacteStatus(CharacterDisplay, gameValue);

                this.StateHasChanged();
            }
            finally
            {
                gameValue.Loading = false;
            }
        }

    }
}