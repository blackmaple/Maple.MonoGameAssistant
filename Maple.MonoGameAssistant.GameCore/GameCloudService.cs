using Microsoft.Extensions.Options;
using System.Net.Http;

namespace Maple.MonoGameAssistant.GameCore
{
    public class GameCloudService(IHttpClientFactory httpClientFactory, GameCloudConfig config)
    {
        GameCloudConfig GameCloudConfig { get; } = config;
        IHttpClientFactory HttpClientFactory { get; } = httpClientFactory;

        public HttpClient CreateHttpClient()
        {
            var client = this.HttpClientFactory.CreateClient();
            client.Timeout = TimeSpan.FromSeconds(30D);
            client.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("br"));
            client.BaseAddress = new Uri(GameCloudConfig.GameApiUrl);
            return client;
        }
    }
}