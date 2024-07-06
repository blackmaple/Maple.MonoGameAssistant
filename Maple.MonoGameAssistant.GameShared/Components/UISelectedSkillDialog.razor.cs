using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Masa.Blazor;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UISelectedSkillDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        private string? SearchContent { set; get; }
        private void OnSearch()
        {
            this.Core.OnSearchSkill(SearchContent);
        }

        public async Task OnSelectedData(GameSkillDisplayDTO skillDisplayDTO)
        {
            if (await this.Core.PopupService.ConfirmAsync("Add Skill", $"Add Skill:{skillDisplayDTO?.DisplayName}"))
            {
                await this.ClosePopupAsync(skillDisplayDTO);
            }
        }

    }
}