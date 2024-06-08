using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Common
{
    public static class MapleLazyHostedServiceExtensions
    {

        public static IServiceCollection AddGameHostedService
            <[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GameService>
            (this IServiceCollection services)
            where T_GameService : class, IMapleGameService
        {
            services.AddSingleton<T_GameService>();
        //    services.AddSingleton<MapleLazyService<T_GameService>>();
            services.AddHostedService<MapleLazyHostedService<T_GameService>>();
            return services;
        }

        public static IServiceCollection AddMapleHostedService
            <[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_MapleHostedService>
            (this IServiceCollection services)
            where T_MapleHostedService: class, IMapleHostedService
        {
             services.TryAddEnumerable(ServiceDescriptor.Singleton<IMapleHostedService, T_MapleHostedService>());
            return services;
        }

    }
}
