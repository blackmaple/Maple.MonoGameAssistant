namespace Maple.MonoGameAssistant.Common
{
    public interface IMapleHostedService
    {
        Task StartAsync(CancellationToken cancellationToken);
        Task StopAsync(CancellationToken cancellationToken);
    }
}
