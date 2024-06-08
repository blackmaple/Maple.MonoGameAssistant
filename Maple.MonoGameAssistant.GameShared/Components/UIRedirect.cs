using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public class UIRedirect : ComponentBase
    {
        [NotNull]
        [Inject]
        public NavigationManager? NavigationManager { set; get; }


        [Parameter]
        public required string Url { set; get; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            NavigationManager.NavigateTo(Url, false);
        }

         

    }
}