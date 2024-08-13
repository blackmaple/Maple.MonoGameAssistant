using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.DependencyInjection;

namespace Maple.MonoGameAssistant.GameCore
{
    public static class GameCoreExtensions
    {
        public static IServiceCollection AddGameCoreService(IServiceCollection services, string defApiUrl)
        {
            services.AddSingleton(new GameCloudConfig() { GameApiUrl = defApiUrl });
          
            services.AddHttpClient<GameHttpClientService>().ConfigurePrimaryHttpMessageHandler(()=> new HttpClientHandler() { AutomaticDecompression = System.Net.DecompressionMethods.Brotli }) ;
         
            return services;
        }

        public static IServiceCollection AddGameCoreService_WASM(IServiceCollection services, string defApiUrl)
        {
            services.AddSingleton(new GameCloudConfig() { GameApiUrl = defApiUrl });
            services.AddSingleton<IHttpClientFactory, GameCloudHttpClientFactory_WASM>();
            services.AddScoped(p => p.GetRequiredService<IHttpClientFactory>().CreateClient());
            services.AddScoped<GameHttpClientService>();

            return services;

        }


    }


}