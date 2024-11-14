using Microsoft.Extensions.DependencyInjection;
using System.Text;
namespace Maple.MonoGameAssistant.Core
{
    public static class MonoRuntimeServiceExtensions
    {
        public static IServiceCollection AddMonoRuntimeService(this IServiceCollection services, Action<MonoRuntimeModuleView> action)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var moduleView = new MonoRuntimeModuleView();
            action.Invoke(moduleView);
            services.AddSingleton(moduleView);
            services.AddSingleton<MonoRuntimeFactory>();
            services.AddSingleton(p => p.GetRequiredService<MonoRuntimeFactory>().GetProvider());
            services.AddSingleton<MonoRuntimeContext>();
            if (MonoTaskScheduler.IsAndroidEnvironment())
            {
                services.AddSingleton<MonoTaskScheduler, MonoTaskScheduler_Android>();
            }
            else
            {
                services.AddSingleton<MonoTaskScheduler, MonoTaskScheduler_Default>();
            }
            return services.AddSingleton<MonoCollectorApiService>();
        }

        public static IServiceCollection AddMonoRuntimeService(this IServiceCollection services)
        {
            return services.AddMonoRuntimeService(static _ => { });
        }


    }
}
