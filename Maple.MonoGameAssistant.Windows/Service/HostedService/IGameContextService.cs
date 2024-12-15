using Maple.MonoGameAssistant.GameDTO;

namespace Maple.MonoGameAssistant.Windows.Service.HostedService
{
    public interface IGameContextService : IGameWebApiControllers
    {
        ValueTask StartAsync();
        ValueTask StopAsync();
    }




}
