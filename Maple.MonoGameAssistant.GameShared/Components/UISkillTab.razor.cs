using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UISkillTab
    {

        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        private string? SearchContent { set; get; }
        private void OnSearch()
        {
            this.Core.OnSearchSkill(SearchContent);
        }
        private void OnSearch(string? search)
        {
            this.SearchContent = search;
            this.OnSearch();
        }
        private Task OnSelected(GameSkillDisplayDTO gameCurrency)
        {
            return Task.CompletedTask;
            //throw new NotImplementedException();
            // await this.Core.OnSelectedCurrency(gameCurrency);

        }
    }
}