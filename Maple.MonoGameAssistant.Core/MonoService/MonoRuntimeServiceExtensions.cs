using Microsoft.Extensions.DependencyInjection;
using System.Text;
namespace Maple.MonoGameAssistant.Core
{
    public static class MonoRuntimeServiceExtensions
    {
        public static IServiceCollection AddMonoRuntimeService(this IServiceCollection services)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            services.AddSingleton<MonoRuntimeFactory>();
            services.AddSingleton(p => p.GetRequiredService<MonoRuntimeFactory>().GetProvider());
            services.AddSingleton<MonoRuntimeContext>();
            services.AddSingleton<MonoTaskScheduler>();
            return services.AddSingleton<MonoCollectorApiService>();

           
        }
        


    }

}
