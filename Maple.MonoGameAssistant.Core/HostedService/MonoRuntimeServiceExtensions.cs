using Microsoft.Extensions.DependencyInjection;
using Maple.MonoGameAssistant.Common;
using System.Text;
using Maple.MonoGameAssistant.Model;
namespace Maple.MonoGameAssistant.Core
{
    public static class MonoRuntimeServiceExtensions
    {
        public static IServiceCollection AddMonoRT(this IServiceCollection services )
        {

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            services.AddMapleHostedService<MonoRuntimeHostedService>();
            services.AddSingleton<MonoRuntimeFactory>();
            services.AddSingleton(p => p.GetRequiredService<MonoRuntimeFactory>().GetProvider());

            services.AddSingleton<MonoRuntimeContext>();

            return services;
        }

 
    }

}
