using Maple.MonoGameAssistant.GameCore;
using Maple.MonoGameAssistant.GameShared.Service;
using Maple.MonoGameAssistant.GameSSR;
using Maple.MonoGameAssistant.GameShared;
using Masa.Blazor;
using Masa.Blazor.Presets;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddMasaBlazor(p => 
{
    p.Defaults = new Dictionary<string, IDictionary<string, object?>?>()
    {
        [PopupComponents.SNACKBAR] = new Dictionary<string, object?>()
        {
            [nameof(PEnqueuedSnackbars.Closeable)] = true,
            [nameof(PEnqueuedSnackbars.Position)] = SnackPosition.TopCenter
        }
    };
    p.ConfigureTheme(theme =>
    {
        theme.Dark = true;
    });
});

//builder.Services.AddHttpClient<GameHttpClientService>(p => p.BaseAddress = new Uri("http://localhost:49009/"))
//    .ConfigurePrimaryHttpMessageHandler(p => new HttpClientHandler() { AutomaticDecompression = System.Net.DecompressionMethods.Brotli });
builder.Services.AddScoped<GameCoreService>();
GameCoreExtensions.AddGameCoreService(builder.Services, "http://localhost:49009/");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(Maple.MonoGameAssistant.GameShared.Main).Assembly);



app.Run();
