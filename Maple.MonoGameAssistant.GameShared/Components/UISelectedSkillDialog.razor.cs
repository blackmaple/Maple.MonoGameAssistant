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

        [Parameter, EditorRequired, NotNull]
        public List<GameSkillDisplayDTO>? ListSkill_All { get; set; }
        public List<GameSkillDisplayDTO> ListSkill_Search { get; set; } = [];

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            ListSkill_Search.AddRange(ListSkill_All);
        }
        private void OnSearch()
        {
            this.ListSkill_Search.Clear();
            IEnumerable<GameSkillDisplayDTO> searchDatas = this.ListSkill_All;

            if (string.IsNullOrEmpty(SearchContent) == false)
            {
                searchDatas = searchDatas.Where(p => p.ContainsGameDisplay(SearchContent, p.DisplayCategory));
            }
            this.ListSkill_Search.AddRange(searchDatas);
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