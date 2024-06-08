
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Maple.MonoGameAssistant.UILogic;





public class GameContextFactory
{
    ILoggerFactory LoggerFactory { get; }
    //  IMemoryCache ContextCache { get; }
    IHttpClientFactory HttpClientFactory { get; }
    //  HttpClient Http { get; }

    public GameContextFactory(ILoggerFactory loggerFactory, IHttpClientFactory httpClientFactory)
    {
        this.LoggerFactory = loggerFactory;
        this.HttpClientFactory = httpClientFactory;
        //   this.Http = httpClientFactory.CreateClient();
        //   this.Http.Timeout = TimeSpan.FromSeconds(5);
        //   this.ContextCache = memoryCache;
    }

    //public Task<MonoResultDTO<MonoGameInfoDTO>> TryGetGameInfoAsync(Uri gameUrl)
    //{
    //    return GameHttpClient.TryGetGameInfoAsync<MonoGameInfoDTO>(this.Http, gameUrl);
    //}
    public async Task<MonoResultDTO<GameCodeContext>> TryCreateGameCodeContext(string pipeName)
    {
        var gameUrl = new Uri("http://localhost");
        var http = this.HttpClientFactory.CreateClient(pipeName);
        http.BaseAddress = gameUrl;
        var gameSessionDTO = await GameHttpClient.TryGetGameInfoAsync<GameSessionInfoDTO>(http);
        if (false == gameSessionDTO.TryGet(out var gameSession))
        {
            http.Dispose();
            return new MonoResultDTO<GameCodeContext>() { CODE = gameSessionDTO.CODE, MSG = gameSessionDTO.MSG };
        }
        var logger = this.LoggerFactory.CreateLogger(gameSession.DisplayName ?? "Game");
        GameHttpClient gameHttpClient = new(logger, http, gameUrl);
        var gameCodeContext = new GameCodeContext(gameHttpClient, gameSession);
        return new MonoResultDTO<GameCodeContext>() { CODE = gameSessionDTO.CODE, DATA = gameCodeContext };

    }

    //public GameCodeContext CreateGameCodeContext(Uri gameUrl, MonoWebApiToken token)
    //{
    //    var logger = this.LoggerFactory.CreateLogger(token.Name);
    //    GameHttpClient gameHttpClient = new(logger, this.Http, gameUrl);
    //    var gameCodeContext = new GameCodeContext(gameHttpClient, token);
    //    return ResetGameCodeContextCache(gameCodeContext);

    //    GameCodeContext ResetGameCodeContextCache(GameCodeContext gameCodeContext)
    //    {
    //        var uid = gameCodeContext.GameUID;
    //        this.ContextCache.Remove(uid);
    //        return this.ContextCache.Set(uid, gameCodeContext);
    //    }
    //}
    //public GameCodeContext CreateGameCodeContext(GameHttpClient gameHttpClient)
    //{
    //    var gameCodeContext = new GameCodeContext(gameHttpClient, gameHttpClient.WebApiToken);
    //    return ResetGameCodeContextCache(gameCodeContext);

    //    GameCodeContext ResetGameCodeContextCache(GameCodeContext gameCodeContext)
    //    {
    //        var uid = gameCodeContext.GameUID;
    //        this.ContextCache.Remove(uid);
    //        return this.ContextCache.Set(uid, gameCodeContext);
    //    }
    //}

    //public bool TryGetGameCodeContext(string uid, [MaybeNullWhen(false)] out GameCodeContext gameCodeContext)
    //{
    //    return ContextCache.TryGetValue(uid, out gameCodeContext) && gameCodeContext is not null;
    //}




}