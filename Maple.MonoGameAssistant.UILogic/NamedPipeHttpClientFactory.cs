using System.Net;

namespace Maple.MonoGameAssistant.UILogic
{
    class NamedPipeHttpClientFactory : IHttpClientFactory
    {
        public HttpClient CreateClient(string pipeName)
        {
           var namedpipes = new NamedPipesConnectionFactory(pipeName);
            var httpHandler = new SocketsHttpHandler()
            {
                ConnectCallback = namedpipes.ConnectAsync,
                AutomaticDecompression = DecompressionMethods.Brotli
            };
            var httpClient = new HttpClient(httpHandler)
            {
                BaseAddress = new Uri("http://localhost"),
            };
            httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("br"));
            httpClient.Timeout = TimeSpan.FromSeconds(5);
            return httpClient;
        }

      

    }



}
