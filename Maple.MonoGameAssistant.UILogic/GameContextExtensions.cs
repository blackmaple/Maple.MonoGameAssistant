using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.UILogic
{
    public static class GameContextExtensions
    {
        public static void AddGameContextService(this IServiceCollection services)
        {
          //  services.AddHttpClient();
            services.AddSingleton<IHttpClientFactory, NamedPipeHttpClientFactory>();
            services.AddMemoryCache();
            services.AddScoped<GameContextFactory>();

        }
    }



}
