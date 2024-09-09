using Microsoft.Extensions.DependencyInjection;
using System.Text;
namespace Maple.MonoGameAssistant.Core
{
    public static class MonoRuntimeServiceExtensions
    {
        public static IServiceCollection AddMonoRuntimeFactory(this IServiceCollection services)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            services.AddSingleton<MonoRuntimeFactory>();
            services.AddSingleton(p => p.GetRequiredService<MonoRuntimeFactory>().GetProvider());
            return services;
        }
        public static IServiceCollection AddMonoRuntimeContext(this IServiceCollection services)
        {
            services.AddSingleton<MonoRuntimeContext>();
            return services;
        }




    }

}
