using Maple.MonoGameAssistant.AndroidCore.GameContext;
using Maple.MonoGameAssistant.AndroidModel;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
namespace Maple.MonoGameAssistant.AndroidCore.HostedService
{

    internal class AndroidHostedLifecycleService(ILogger<AndroidHostedLifecycleService> logger, IServiceProvider serviceProvider) : IHostedLifecycleService
    {



        public Task StartAsync(CancellationToken cancellationToken)
        {
            using (logger.Running())
            {
                try
                {
                    var monoRuntimeFactory = serviceProvider.GetRequiredService<MonoRuntimeFactory>();
                    var init = monoRuntimeFactory.CreateMonoRuntime(out var runtimeType);
                    logger.LogInformation("{serviceName}=>{methodName}=>{status}=>{runtimeType}", nameof(AndroidHostedLifecycleService), nameof(StartAsync), init, runtimeType);
                }
                catch (MonoRuntimeException ex)
                {
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(AndroidHostedLifecycleService), nameof(StartAsync), ex.Message);
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(AndroidHostedLifecycleService), nameof(StartAsync), ex);
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
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(AndroidHostedLifecycleService), nameof(StartedAsync), ex);
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
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(AndroidHostedLifecycleService), nameof(StoppedAsync), ex);
                }
            }
        }

        public Task StoppingAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
