using Microsoft.AspNetCore.Components;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UIDynamicHeight
    {
        [Parameter]
        public required RenderFragment ChildContent { get; set; }
    }
}