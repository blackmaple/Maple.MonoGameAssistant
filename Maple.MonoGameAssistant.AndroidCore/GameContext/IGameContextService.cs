using Maple.MonoGameAssistant.GameDTO;

namespace Maple.MonoGameAssistant.AndroidCore.GameContext
{
    public interface IGameContextService : IGameWebApiControllers
    {
        ValueTask StartAsync();
        ValueTask StopAsync();
    }




}
