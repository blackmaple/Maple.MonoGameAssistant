using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UILogic;

public sealed class GameCodeContext(GameHttpClient httpClient, GameSessionInfoDTO gameSessionInfoDTO)
{

    #region props

    public string? GamePID => GameSessionInfo.ObjectId;

    public string? GameName => GameSessionInfo.DisplayName;

    public ILogger Logger => HttpClient.Logger;

    public GameSessionInfoDTO GameSessionInfo { get; } = gameSessionInfoDTO;

    public GameHttpClient HttpClient { get; } = httpClient;

    public List<GameImageInfo> ImageInfos { get; } = [];

    public GameLocalCacheService LocalCacheService { get; } = new GameLocalCacheService(httpClient.Logger);
    #endregion

    #region Api

    public bool TryGetFirstGameImage(nint pointer, [MaybeNullWhen(false)] out GameImageInfo gameImageInfo)
    {
        gameImageInfo = this.ImageInfos.FirstOrDefault(p => p.RawImageInfo.Pointer == pointer);
        return gameImageInfo is not null;
    }

    public async ValueTask<bool> LoadGameImageInfosAsync(Func<MonoResultDTO, Task>? error = default)
    {
        var imageDTO = await this.HttpClient.PostEnumImagesAsync();
        if (false == imageDTO.TryGet(out var images))
        {
            error?.Invoke(imageDTO);
            return false;
        }
        var datas = images.Select(p => new GameImageInfo() { RawImageInfo = p })
            .OrderByDescending(p => p.IsGame)
            .ThenByDescending(p => p.IsLibrary)
            .ThenByDescending(p => p.IsUnity)
            .ThenByDescending(p => p.IsSystem)
            .ThenBy(p => p.RawImageInfo.Name);

        this.ImageInfos.AddRange(datas);
        return true;
    }
    public async ValueTask<IReadOnlyList<GameClassInfo>> LoadGameClassInfosAsync(GameImageInfo gameImageInfo, Func<MonoResultDTO, Task>? error = default)
    {
        if (gameImageInfo.GameClassInfos is null)
        {
            var classesDTO = await this.HttpClient.PostEnumClassesAsync(gameImageInfo.RawImageInfo.Pointer);
            if (false == classesDTO.TryGet(out var classInfoDTOs))
            {
                error?.Invoke(classesDTO);
                return [];
            }

            

            var datas = classInfoDTOs.Select(p => new GameClassInfo() { RawClassInfo = p })
                .OrderByDescending(p => p.RawClassInfo.IsRefType && p.RawClassInfo.IsStatic)
                .ThenByDescending(p => p.RawClassInfo.IsRefType && !p.RawClassInfo.IsAbstract)
                .ThenByDescending(p => p.RawClassInfo.IsValueType && !p.RawClassInfo.IsEnum)
                .ThenByDescending(p => p.RawClassInfo.IsValueType && p.RawClassInfo.IsEnum)
                .ThenByDescending(p => p.RawClassInfo.IsAbstract)
                .ThenByDescending(p => p.RawClassInfo.IsInterface)
                .ThenBy(p => p.RawClassInfo.IsGeneric)
                .ThenBy(p => p.RawClassInfo.FullName)
                .ToArray();
            gameImageInfo.GameClassInfos = datas;

        }
        return gameImageInfo.GameClassInfos;
    }
    public async ValueTask<bool> GetGameClassDetailAsync(GameClassInfo gameClassInfo, EnumMonoFieldOptions fieldOptions = EnumMonoFieldOptions.Enum, Func<MonoResultDTO, Task>? error = default)
    {

        var detailDTO = await this.HttpClient.PostEnumClassDetailAsync(gameClassInfo.RawClassInfo.Pointer, fieldOptions);
        if (false == detailDTO.TryGet(out var monoClassDetail))
        {
            error?.Invoke(detailDTO);
            return false;
        }

        GameClassInfo.FillGameClassInfo(monoClassDetail, gameClassInfo);

        return true;


    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="gameClassInfo">11212</param>
    /// <param name="loadServer">2</param>
    /// <param name="fieldOptions">3</param>
    /// <param name="error">4</param>
    /// <returns>5</returns>
    public ValueTask<bool> GetGameClassDetailAsync(GameClassInfo gameClassInfo, bool loadServer = true, EnumMonoFieldOptions fieldOptions = EnumMonoFieldOptions.Enum, Func<MonoResultDTO, Task>? error = default)
    {
        if (false == loadServer)
        {
            if (this.LocalCacheService.TryFillGameClassInfo(gameClassInfo))
            {
                return ValueTask.FromResult(true);
            }
            return ValueTask.FromResult(false);
        }
        return GetGameClassDetailAsync(gameClassInfo, fieldOptions, error);

    }

    public GameRemoteDataService CreateLoadRemoteDataService(string savePath)
    {
        return new GameRemoteDataService(this, savePath);
    }


    #endregion

}
