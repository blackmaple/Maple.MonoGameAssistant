using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Channels;
using Maple.MonoGameAssistant.Common;
namespace Maple.MonoGameAssistant.UILogic;

public sealed class GameRemoteDataService
{

    #region 属性

    GameCodeContext GameCodeContext { get; }
    string SavePath { get; }
    IReadOnlyList<GameImageInfo> GameImageInfos { get; }

    Channel<GameImageInfo> LoadGameImageInfoChannel { get; }
    Channel<GameObjectInfo> SaveGameObjectInfoChannel { get; }
    Channel<GameAnalyzerNotifyMsg> NotifyMsgChannel { get; }
    #endregion

    public GameRemoteDataService(GameCodeContext gameCodeContext, string baseDirectory)
    {
        this.LoadGameImageInfoChannel = Channel.CreateUnbounded<GameImageInfo>();
        this.SaveGameObjectInfoChannel = Channel.CreateUnbounded<GameObjectInfo>();
        this.NotifyMsgChannel = Channel.CreateUnbounded<GameAnalyzerNotifyMsg>();

        this.GameCodeContext = gameCodeContext;
        var gameImageInfos = this.GameCodeContext.ImageInfos.Where(p => p.IsGame).ToArray();
        this.GameImageInfos = gameImageInfos;


        this.SavePath = InitSavePath(baseDirectory, gameCodeContext.GameSessionInfo, gameImageInfos);

    }


    #region Helper

    public static string MakeValidFileName(ReadOnlySpan<char> text)
    {
        StringBuilder str = new();
        var invalidFileNameChars = Path.GetInvalidFileNameChars();
        foreach (var c in text)
        {
            if (!invalidFileNameChars.Contains(c))
            {
                str.Append(c);
            }
            else
            {
                str.Append('_');
            }
        }

        return str.ToString();
    }
    static string InitSavePath(string baseDirectory, GameDisplayDTO gameInfoDTO, IReadOnlyList<GameImageInfo> gameImageInfos)
    {
        var path = Path.Combine(baseDirectory, $"0x{gameInfoDTO.ObjectId:X8}-{gameInfoDTO.DisplayName}");
        if (Directory.Exists(path))
        {
            Directory.Delete(path, true);
        }
        Directory.CreateDirectory(path);

        foreach (var image in gameImageInfos)
        {
            var imagePath = Path.Combine(path, MakeValidFileName(image.RawImageInfo.Name));
            Directory.CreateDirectory(imagePath);
        }
        return path;
    }
    static FileStream GetSaveFileStream(GameObjectInfo objectInfo, string savePath)
    {
        var rawClass = objectInfo.RawObjectInfo;
        var path = MakeValidFileName(objectInfo.ImageName);
        var jsonName = MakeValidFileName($"{rawClass.Name}.{rawClass.Pointer:X8}.json");
        var fileName = Path.Combine(savePath, path, jsonName);
        return File.Open(fileName, FileMode.Create, FileAccess.ReadWrite);
    }
    #endregion

    #region WebApi

    async ValueTask<IReadOnlyList<GameObjectInfo>> LoadGameObjectInfosAsync(GameImageInfo gameImageInfo, Func<MonoResultDTO, Task>? error = default)
    {
        var objectDTO = await this.GameCodeContext.HttpClient.PostEnumObjectsAsync(gameImageInfo.RawImageInfo.Pointer);
        if (false == objectDTO.TryGet(out var objectInfoDTOs))
        {
            error?.Invoke(objectDTO);
            return [];
        }
        return objectInfoDTOs.Select(p => new GameObjectInfo() { ImageName = gameImageInfo.RawImageInfo.Name, RawObjectInfo = p }).ToArray();
    }
    async Task<bool> TrySaveMonoClassDetailAsync(GameObjectInfo gameObjectInfo)
    {
        using var fileStream = GetSaveFileStream(gameObjectInfo, this.SavePath);
        var save = await this.GameCodeContext.HttpClient.TrySaveClassDetail2FileAsync(gameObjectInfo.RawObjectInfo.Pointer, fileStream).ConfigureAwait(false);
        return save;
    }
    #endregion

    public async Task RunAsync(Action<object?> action, TaskScheduler uiScheduler, CancellationToken cancellationToken)
    {
        using (this.GameCodeContext.Logger.Running())
        {
            await WriteAllLoadGameImageInfoAsync(this.GameImageInfos);
            var loadImageTask = LoadGameImageInfoTask(cancellationToken);
            var saveClassTask = SaveGameObjectInfoTask(cancellationToken);
            var notifyTask = ReadNotifyMsgTask(action, uiScheduler);
            await Task.WhenAll(loadImageTask, saveClassTask).ConfigureAwait(false);
            this.CompleteNotifyMsgChannel();
            await notifyTask.ConfigureAwait(false);
        }
    }


    #region Task

    ValueTask WriteLoadGameImageInfoAsync(GameImageInfo gameImageInfo)
    {
        return this.LoadGameImageInfoChannel.Writer.WriteAsync(gameImageInfo);
    }
    async ValueTask WriteAllLoadGameImageInfoAsync(IReadOnlyList<GameImageInfo> gameImageInfos)
    {
        await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_ImageCount, MsgObject = gameImageInfos.Count, }).ConfigureAwait(false);
        foreach (var gameImageInfo in gameImageInfos)
        {
            await this.WriteLoadGameImageInfoAsync(gameImageInfo).ConfigureAwait(false);
        }
        CompleteLoadGameImageInfo();
    }
    void CompleteLoadGameImageInfo() => this.LoadGameImageInfoChannel.Writer.Complete();
    async Task LoadGameImageInfoTask(CancellationToken cancellationToken)
    {
        await foreach (var gameImageInfo in this.LoadGameImageInfoChannel.Reader.ReadAllAsync().ConfigureAwait(false))
        {
            if (cancellationToken.IsCancellationRequested)
            {
                await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_Cancel, }).ConfigureAwait(false);
                return;
            }
            await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_LoadImage, MsgObject = gameImageInfo.RawImageInfo.Name, }).ConfigureAwait(false);
            var gameObjectInfos = await this.LoadGameObjectInfosAsync(gameImageInfo).ConfigureAwait(false);
            await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_AddClassCount, MsgObject = gameObjectInfos.Count }).ConfigureAwait(false);
            foreach (var gameObjectInfo in gameObjectInfos)
            {
                await this.WriteSaveGameObjectInfoAsync(gameObjectInfo).ConfigureAwait(false);
            }
        }
        this.CompleteSaveGameObjectInfoChannel();
    }

    ValueTask WriteSaveGameObjectInfoAsync(GameObjectInfo gameObjectInfo)
    {
        return this.SaveGameObjectInfoChannel.Writer.WriteAsync(gameObjectInfo);
    }
    void CompleteSaveGameObjectInfoChannel() => this.SaveGameObjectInfoChannel.Writer.Complete();
    async Task SaveGameObjectInfoTask(CancellationToken cancellationToken)
    {
        await foreach (var gameObjectInfo in this.SaveGameObjectInfoChannel.Reader.ReadAllAsync().ConfigureAwait(false))
        {
            if (cancellationToken.IsCancellationRequested)
            {
                await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_Cancel, }).ConfigureAwait(false);
                return;
            }
            await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_SaveClass, MsgObject = gameObjectInfo.RawObjectInfo.Name }).ConfigureAwait(false);
            var save = await this.TrySaveMonoClassDetailAsync(gameObjectInfo).ConfigureAwait(false);
            if (!save)
            {
                await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_Error }).ConfigureAwait(false);
                return;
            }
        }
        await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_Complete, }).ConfigureAwait(false);
    }


    ValueTask WriteNotifyMsgChannelAsync(GameAnalyzerNotifyMsg notifyMsg)
    {
        return this.NotifyMsgChannel.Writer.WriteAsync(notifyMsg);
    }
    void CompleteNotifyMsgChannel() => this.NotifyMsgChannel.Writer.Complete();
    public bool TryReadNotifyMsgChannel([MaybeNullWhen(false)] out GameAnalyzerNotifyMsg notifyMsg)
    {
        return this.NotifyMsgChannel.Reader.TryRead(out notifyMsg);
    }

    public async Task ReadNotifyMsgTask(Action<object?> action, TaskScheduler uiScheduler)
    {
        await foreach (var notifyMsg in this.NotifyMsgChannel.Reader.ReadAllAsync().ConfigureAwait(false))
        {
            await Task.Delay(10).ConfigureAwait(false);
            await Task.Factory.StartNew(action, notifyMsg, CancellationToken.None, TaskCreationOptions.DenyChildAttach, uiScheduler).ConfigureAwait(false);
        }
    }
    #endregion

}
