using Maple.MonoGameAssistant.GameDTO;

namespace Maple.MonoGameAssistant.GameContext
{
    public interface IGameContextService: IGameWebApiControllers
    {
        ValueTask StartAsync();
        ValueTask StopAsync();
    }




}
