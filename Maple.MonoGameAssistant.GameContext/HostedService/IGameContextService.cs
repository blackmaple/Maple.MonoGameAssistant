namespace Maple.MonoGameAssistant.GameContext
{
    public interface IGameContextService
    {
        ValueTask StartAsync();
        ValueTask StopAsync();
    }




}
