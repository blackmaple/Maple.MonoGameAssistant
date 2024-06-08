using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.GameDTO;

namespace Maple.MonoGameAssistant.WebApi
{
    class WebApiDefaultService : IMapleGameService, IGameWebApiControllers
    {
        public static void Main(string[] args)
        {
            (new WebApiBaseService()).RunAsync<WebApiDefaultService>().GetAwaiter().GetResult();
        }


        public ValueTask LoadService()
        {
            return ValueTask.CompletedTask;
        }

        public ValueTask DestroyService()
        {
            return ValueTask.CompletedTask;
        }

    }

}
