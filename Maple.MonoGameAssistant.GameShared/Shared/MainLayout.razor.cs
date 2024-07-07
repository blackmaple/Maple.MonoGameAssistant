using Maple.MonoGameAssistant.GameShared.Components;
using Maple.MonoGameAssistant.GameShared.Service;
using Masa.Blazor;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Shared
{
    public partial class MainLayout
    {
        [NotNull]
        [Inject]
        public GameCoreService? Core { set; get; }
        [NotNull]
        public StringNumber? NavTab { set; get; } = UIMainTabs.Tab_Default;


        public EnumGameServiceStatus Status { set; get; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await LoadServiceDataAsync();
        }

        public async Task LoadServiceDataAsync()
        {
            Status = EnumGameServiceStatus.Init;
            Status = await this.Core.OnInitializedAsync();
        }

    }
}