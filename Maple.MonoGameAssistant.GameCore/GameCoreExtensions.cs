using Microsoft.Extensions.DependencyInjection;

namespace Maple.MonoGameAssistant.GameCore
{
    public static class GameCoreExtensions
    {
        public static IServiceCollection AddGameCoreService(IServiceCollection services, string defApiUrl)
        {
            services.AddSingleton(new GameCloudConfig() { GameApiUrl = defApiUrl });
            services.AddHttpClient();
            services.ConfigureHttpClientDefaults(p => p.ConfigurePrimaryHttpMessageHandler(_ => new HttpClientHandler() { AutomaticDecompression = System.Net.DecompressionMethods.Brotli }));
            services.AddSingleton<GameCloudService>();
            services.AddScoped<GameHttpClientService>();
            return services;
        }

        public static IServiceCollection AddGameCoreService_WASM(IServiceCollection services, string defApiUrl)
        {
            services.AddSingleton(new GameCloudConfig() { GameApiUrl = defApiUrl });
            services.AddSingleton<IHttpClientFactory, WasmHttpClientFactory>();
            services.AddSingleton<GameCloudService>();
            services.AddScoped<GameHttpClientService>();
            services.AddScoped<GameHttpClientService>();

            return services;

        }

        internal class WasmHttpClientFactory : IHttpClientFactory
        {
            public HttpClient CreateClient(string name)
            {
                return new HttpClient();
            }
        }

    }


}