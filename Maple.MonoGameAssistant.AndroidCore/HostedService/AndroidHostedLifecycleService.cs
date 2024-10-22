using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidCore.GameContext;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace Maple.MonoGameAssistant.AndroidCore.HostedService
{

    public class AndroidHostedLifecycleService(ILogger<AndroidHostedLifecycleService> logger, IServiceProvider serviceProvider) : IHostedLifecycleService
    {
        public Task StartingAsync(CancellationToken cancellationToken)
        {
            using (logger.Running())
            {
                try
                {
                    var monoRuntimeFactory = serviceProvider.GetRequiredService<MonoRuntimeFactory>();
                    var init = monoRuntimeFactory.CreateMonoRuntime(out var runtimeType);
                    logger.LogInformation("{serviceName}=>{status}=>{runtimeType}", nameof(MonoRuntimeFactory), init, runtimeType);
                }
                catch (MonoRuntimeException ex)
                {
                    logger.LogError("{serviceName}=>{err}", nameof(MonoRuntimeFactory), ex.Message);
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{err}", nameof(MonoRuntimeFactory), ex);
                }
            }
            return Task.CompletedTask;

        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {

            using (logger.Running())
            {
                try
                {
                    var gameContextService = serviceProvider.GetRequiredService<IGameContextService>();
                    await gameContextService.StartAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(IGameContextService), nameof(StartedAsync), ex);
                }
            }
        }
        public async Task StartedAsync(CancellationToken cancellationToken)
        {
            using (logger.Running())
            {
                try
                {
                    var androidApiService = serviceProvider.GetRequiredService<AndroidApiService>();
                    await androidApiService.StartAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(AndroidApiService), nameof(StartAsync), ex);
                }
            }

        }

        public Task StoppingAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
        public async Task StopAsync(CancellationToken cancellationToken)
        {
            using (logger.Running())
            {
                try
                {
                    var androidApiService = serviceProvider.GetRequiredService<AndroidApiService>();
                    await androidApiService.StopAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{ex}", nameof(AndroidApiService), ex);
                }
            }

        }
        public async Task StoppedAsync(CancellationToken cancellationToken)
        {
            using (logger.Running())
            {
                try
                {
                    var gameContextService = serviceProvider.GetRequiredService<IGameContextService>();
                    await gameContextService.StopAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{err}", nameof(IGameContextService), ex);
                }
            }
        }

    }
}
