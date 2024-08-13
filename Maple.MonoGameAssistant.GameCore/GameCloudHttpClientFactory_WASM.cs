using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Options;
using System.Net.Http;

namespace Maple.MonoGameAssistant.GameCore
{
    public class GameCloudHttpClientFactory_WASM() : IHttpClientFactory
    {


        public HttpClient CreateClient(string name)
        {
            return new();
        }


    }
}