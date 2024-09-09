using Microsoft.Extensions.DependencyInjection;

namespace Maple.MonoGameAssistant.MonoCollectorApi
{
    public static class MonoCollectorApiExtensions
    {
        public static IServiceCollection AddMonoCollectorApiService(IServiceCollection services)
        {
            return services.AddSingleton<MonoCollectorApiService>();
        }

    }


}