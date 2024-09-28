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
        public StringNumber? NavTab { set; get; } = UIMainTabs.Tab_Default;
        public EnumGameServiceStatus Status { set; get; } = EnumGameServiceStatus.Init;

        [NotNull]
        [Inject]
        public GameCoreService? Core { set; get; }
        public async Task LoadGameResourceAsync()
        {
            await this.Core.LoadGameResourceAsync();
        }

        public void UppdateNavTabs(EnumGameServiceStatus status)
        {
            this.Status = status;
            this.StateHasChanged();
        }


    }
}