using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UICharacterEquipmentDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCharacterDisplayDTO? CharacterDisplay { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCharacterEquipmentDTO? CharacterEquipment { get; set; }



        private bool Loading { set; get; } = false;
        private async Task OnUpdateCharacterEquipment(GameEquipmentInfoDTO selectedData, bool remove)
        {
            try
            {
                this.Loading = true;
                await this.Core.OnUpdateCharacterEquipment(CharacterDisplay, selectedData, remove);
              
            }
            finally
            {
                this.Loading = false;
            }
        }


    }
}