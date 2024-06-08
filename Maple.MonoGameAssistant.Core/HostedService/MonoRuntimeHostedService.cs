using Maple.MonoGameAssistant.Common;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Maple.MonoGameAssistant.Core
{

    internal class MonoRuntimeHostedService(ILogger<MonoRuntimeHostedService> logger, MonoRuntimeFactory monoRuntimeFactory) : IMapleHostedService
    {

        public Task StartAsync(CancellationToken cancellationToken)
        {
            using (logger.Running())
            {
                try
                {
                    var init = monoRuntimeFactory.CreateMonoRuntime( out var runtimeType);
                    logger.LogInformation("{MonoRuntimeHostedService}=>{status}=>{runtimeType}", nameof(MonoRuntimeHostedService), init, runtimeType);
                }
                catch (MonoRuntimeException ex)
                {
                    logger.LogError("{MonoRuntimeHostedService}=>{ERROR}", nameof(MonoRuntimeHostedService), ex.Message);
                }
                catch (Exception ex)
                {
                    logger.LogError("{MonoRuntimeHostedService}=>{ERROR}", nameof(MonoRuntimeHostedService), ex);
                }
            }

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("{StopAsync}", nameof(StopAsync));
            return Task.CompletedTask;
        }
    }
}
