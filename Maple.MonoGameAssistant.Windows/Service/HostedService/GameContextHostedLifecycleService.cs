using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace Maple.MonoGameAssistant.Windows.Service.HostedService
{

    internal class GameContextHostedLifecycleService(ILogger<GameContextHostedLifecycleService> logger, IServiceProvider serviceProvider) : IHostedLifecycleService
    {

        public Task StartAsync(CancellationToken cancellationToken)
        {
            using (logger.Running())
            {
                try
                {
                    var monoRuntimeFactory = serviceProvider.GetRequiredService<MonoRuntimeFactory>();
                    var init = monoRuntimeFactory.CreateMonoRuntime(out var runtimeType);
                    logger.LogInformation("{serviceName}=>{methodName}=>{status}=>{runtimeType}", nameof(GameContextHostedLifecycleService), nameof(StartAsync), init, runtimeType);
                }
                catch (MonoRuntimeException ex)
                {
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(GameContextHostedLifecycleService), nameof(StartAsync), ex.Message);
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(GameContextHostedLifecycleService), nameof(StartAsync), ex);
                }
            }
            return Task.CompletedTask;

        }

        public async Task StartedAsync(CancellationToken cancellationToken)
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
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(GameContextHostedLifecycleService), nameof(StartedAsync), ex);
                }
            }

        }

        public Task StartingAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
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
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(GameContextHostedLifecycleService), nameof(StoppedAsync), ex);
                }
            }
        }

        public Task StoppingAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
