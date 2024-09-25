using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.HotKey;
using Maple.MonoGameAssistant.Logger;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
namespace Maple.MonoGameAssistant.GameContext
{

    public static class GameContextServiceExtensions
    {

        public static IServiceCollection UseGameContextService<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMECONTEXTSERVICE>(this IServiceCollection serviceDescriptors)
           where T_GAMECONTEXTSERVICE : class, IGameContextService
        {
            serviceDescriptors.AddLogging(p => p.AddOnlyMonoGameLogger());
            serviceDescriptors.AddMonoRuntimeService();
            serviceDescriptors.AddHookWinMsgFactory();
            serviceDescriptors.AddHostedService<GameContextHostedLifecycleService>();

            serviceDescriptors.AddSingleton<IGameContextService, T_GAMECONTEXTSERVICE>();
            serviceDescriptors.AddSingleton<IGameWebApiControllers>(p => p.GetRequiredService<IGameContextService>());

            return serviceDescriptors;
        }

    }


}
