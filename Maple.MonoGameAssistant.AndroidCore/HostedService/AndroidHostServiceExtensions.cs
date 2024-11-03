using Maple.MonoGameAssistant.AndroidCore.AndroidTask;
using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidCore.GameContext;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Logger;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.CodeAnalysis;
namespace Maple.MonoGameAssistant.AndroidCore.HostedService
{

    public static class AndroidHostServiceExtensions
    {

        public static IServiceCollection AddGameContextService<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMECONTEXTSERVICE>
            (this IServiceCollection serviceDescriptors)
           where T_GAMECONTEXTSERVICE : class, IGameContextService
        {

      
            MonoTaskScheduler.SetAndroidEnvironment();
            serviceDescriptors.AddMonoRuntimeService();

            serviceDescriptors.AddSingleton<IGameContextService, T_GAMECONTEXTSERVICE>();
            serviceDescriptors.AddSingleton<IGameWebApiControllers>(p => p.GetRequiredService<IGameContextService>());
            return serviceDescriptors;
        }


        public static IHost CreateAndroidService(this AndroidApiContext androidApiContext, Action<MonoGameSettings>? settings, Action<IServiceCollection>? addService)
        {
            var app = Host.CreateEmptyApplicationBuilder(default);
            var gameSetting = new MonoGameSettings();
            settings?.Invoke(gameSetting);

            MonoGameLoggerExtensions.SetAndroidEnvironment();
            app.Services.AddLogging(p=>p.AddOnlyMonoGameLogger());

            app.Services.AddSingleton(gameSetting);
            app.Services.AddSingleton(androidApiContext);
            app.Services.AddHostedService<AndroidHostedLifecycleService>();
            app.Services.AddSingleton<AndroidTaskScheduler>();
            app.Services.AddSingleton<AndroidApiService>();
            addService?.Invoke(app.Services);
            var host = app.Build();
            return host;
        }

        public static AndroidApiContext CreateDefaultAndroidService(this AndroidApiContext androidApiContext)
        {
            
            _ = Task.Factory.StartNew(AndroidServiceTask, androidApiContext, TaskCreationOptions.LongRunning);
            return androidApiContext;

            static void AndroidServiceTask(object? obj)
            {
                if (obj is not AndroidApiContext context)
                {
                    return;
                }
                var host = context.CreateAndroidService(p => { p.GameName = "DefaultAndroidService"; }, p => { });
                host.Run();
            }
        }

    }


}
