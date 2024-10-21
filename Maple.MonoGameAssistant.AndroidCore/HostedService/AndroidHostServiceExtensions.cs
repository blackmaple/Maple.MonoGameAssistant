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

            serviceDescriptors.AddLogging();
            serviceDescriptors.AddMonoRuntimeService();
            serviceDescriptors.AddHostedService<AndroidHostedLifecycleService>();

            serviceDescriptors.AddSingleton<IGameContextService, T_GAMECONTEXTSERVICE>();
            serviceDescriptors.AddSingleton<IGameWebApiControllers>(p => p.GetRequiredService<IGameContextService>());

            return serviceDescriptors;
        }


        public static IHost AsRunAndroidService<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMECONTEXTSERVICE>
            (JavaVirtualMachineContext javaVirtualMachineContext,string? gameName)
            where T_GAMECONTEXTSERVICE : class, IGameContextService

        {
            var app = Host.CreateEmptyApplicationBuilder(default);
            var settings = new MonoGameSettings()
            {
                GameName = gameName,
            };
            app.Services.AddSingleton(settings);
            app.Services.AddSingleton(javaVirtualMachineContext);
            app.Services.UseGameContextService<T_GAMECONTEXTSERVICE>();

           
           var host = app.Build();
            return host;
        }
    }


}
