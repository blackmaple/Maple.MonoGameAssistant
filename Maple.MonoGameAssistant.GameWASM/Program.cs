using Maple.MonoGameAssistant.GameCore;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Maple.MonoGameAssistant.GameShared;
using Masa.Blazor.Presets;
using Masa.Blazor;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<Main>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

#if DEBUG 
builder.Services.AddScoped(sp =>
{
    var http = new HttpClient
    {
        BaseAddress = new Uri("http://localhost:49009/")
    };
    return http;
});
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

#else
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

#endif
builder.Services.AddScoped<GameHttpClientService>();
builder.Services.AddScoped<GameCoreService>();


builder.Services.AddMasaBlazor(p => p.Defaults = new Dictionary<string, IDictionary<string, object?>?>()
{
    [PopupComponents.SNACKBAR] = new Dictionary<string, object?>()
    {
        [nameof(PEnqueuedSnackbars.Closeable)] = true,
        [nameof(PEnqueuedSnackbars.Position)] = SnackPosition.TopCenter
    }
});
await builder.Build().RunAsync();
