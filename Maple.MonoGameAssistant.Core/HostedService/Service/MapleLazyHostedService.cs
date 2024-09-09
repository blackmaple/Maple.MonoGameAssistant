using Maple.MonoGameAssistant.Common;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Core
{
    //public sealed class MapleLazyHostedService<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T_GameService>
    //    (ILogger<MapleLazyHostedService<T_GameService>> logger, IEnumerable<IMapleHostedService> mapleHostedServices, IServiceProvider serviceProvider) : IHostedService
    //    where T_GameService : class, IMapleGameService
    //{
    //    public async Task StartAsync(CancellationToken cancellationToken)
    //    {
    //        using (logger.Running())
    //        {
    //            try
    //            {
    //                foreach (var mapleHostedService in mapleHostedServices)
    //                {
    //                    await mapleHostedService.StartAsync(cancellationToken).ConfigureAwait(false);
    //                }
    //                var gameService = serviceProvider.GetRequiredService<T_GameService>();
    //                await gameService.LoadService().ConfigureAwait(false);

    //            }
    //            catch (Exception ex)
    //            {
    //                logger.LogError("MapleLazyHostedService=>{error}", ex);
    //            }
    //        }

    //    }

    //    public async Task StopAsync(CancellationToken cancellationToken)
    //    {
    //        using (logger.Running())
    //        {
    //            try
    //            {
    //                var gameService = serviceProvider.GetRequiredService<T_GameService>();
    //                await gameService.DestroyService().ConfigureAwait(false);

    //                foreach (var mapleHostedService in mapleHostedServices)
    //                {
    //                    await mapleHostedService.StopAsync(cancellationToken).ConfigureAwait(false);
    //                }


    //            }
    //            catch (Exception ex)
    //            {
    //                logger.LogError("MapleLazyHostedService=>{error}", ex);
    //            }
    //        }

    //    }
    //}
}
