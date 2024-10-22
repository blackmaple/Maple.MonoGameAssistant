using Maple.MonoGameAssistant.AndroidCore.AndroidTask;
using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidCore.GameContext;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.CodeAnalysis;
namespace Maple.MonoGameAssistant.AndroidCore.HostedService
{

    public static class AndroidHostServiceExtensions
    {

        public static IServiceCollection UseGameContextService<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMECONTEXTSERVICE>
            (this IServiceCollection serviceDescriptors)
           where T_GAMECONTEXTSERVICE : class, IGameContextService
        {

          //  serviceDescriptors.AddLogging();
            serviceDescriptors.AddMonoRuntimeService();
            serviceDescriptors.AddHostedService<AndroidHostedLifecycleService>();

            serviceDescriptors.AddSingleton<IGameContextService, T_GAMECONTEXTSERVICE>();
            serviceDescriptors.AddSingleton<IGameWebApiControllers>(p => p.GetRequiredService<IGameContextService>());

            return serviceDescriptors;
        }


        public static IHost AsRunAndroidService<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMECONTEXTSERVICE>
            (AndroidApiContext androidApiContext, string? gameName)
            where T_GAMECONTEXTSERVICE : class, IGameContextService

        {
            var app = Host.CreateEmptyApplicationBuilder(default);
            var settings = new MonoGameSettings()
            {
                GameName = gameName,
            };
            app.Services.AddSingleton(settings);
            app.Services.AddSingleton(androidApiContext);
            app.Services.AddSingleton(androidApiContext.VirtualMachineContext);
            app.Services.AddSingleton<AndroidTaskScheduler>();
            app.Services.AddSingleton<AndroidApiService>();

            app.Services.UseGameContextService<T_GAMECONTEXTSERVICE>();


            var host = app.Build();
            return host;
        }


        public static IHost AsRunAndroidService(this AndroidApiContext androidApiContext, string? gameName,Action<IServiceCollection> addService)
        {
            var app = Host.CreateEmptyApplicationBuilder(default);
            var settings = new MonoGameSettings()
            {
                GameName = gameName,
            };
            app.Services.AddSingleton(settings);
            app.Services.AddSingleton(androidApiContext);
            app.Services.AddSingleton(androidApiContext.VirtualMachineContext);
            app.Services.AddSingleton<AndroidTaskScheduler>();
            app.Services.AddSingleton<AndroidApiService>();

            addService(app.Services);

            var host = app.Build();
            return host;
        }

    }


}
