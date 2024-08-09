using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Pages
{
    public partial class Index
    {
        [Inject]
        [NotNull]
        public NavigationManager? NavManager { set; get; }
        public string? Code { set; get; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            // 获取Uri对象
            var uri = NavManager.ToAbsoluteUri(NavManager.Uri);
            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("code", out var code))
            { 
                this.Code = code;
            }
        }

    }
}