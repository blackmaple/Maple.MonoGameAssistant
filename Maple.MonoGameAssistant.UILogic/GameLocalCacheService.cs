using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.UILogic
{

    public class GameLocalCacheService(ILogger logger)
    {
        public List<GameClassInfo> GameClassInfos { get; } = new(10240);


        #region LoadLocalJsonFile

        public async Task LoadJsonFilesAsync(Action<object?> action, string path, TaskScheduler uiScheduler, CancellationToken cancellationToken)
        {
            using (logger.Running())
            {
                await new GameLoadLocalJsonFileTask(this).LoadJsonFilesAsync(action, path, uiScheduler, cancellationToken).ConfigureAwait(false);
            }
        }

        class GameLoadLocalJsonFileTask
        {
            Channel<GameClassInfo> LoadGameClassInfoChannel { get; }
            Channel<GameAnalyzerNotifyMsg> NotifyMsgChannel { get; }
            GameLocalCacheService LocalCacheService { get; }
            List<GameClassInfo> GameClassInfos => LocalCacheService.GameClassInfos;
            public GameLoadLocalJsonFileTask(GameLocalCacheService gameLocalCacheService)
            {
                this.LocalCacheService = gameLocalCacheService;
                this.LoadGameClassInfoChannel = Channel.CreateUnbounded<GameClassInfo>();
                this.NotifyMsgChannel = Channel.CreateUnbounded<GameAnalyzerNotifyMsg>();
            }

            #region load UI progress

            async Task LoadJsonFileTask(string path, CancellationToken cancellationToken)
            {

                var jsonFiles = Directory.GetFiles(path, "*.json", SearchOption.AllDirectories);
                this.GameClassInfos.Clear();
                this.GameClassInfos.EnsureCapacity(jsonFiles.Length);
                await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_ClassCount, MsgObject = jsonFiles.Length }).ConfigureAwait(false);
                await Parallel.ForEachAsync(jsonFiles, cancellationToken, PLoadJsonFilesAsync).ConfigureAwait(false);
                await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_Complete, }).ConfigureAwait(false);
                this.GameClassInfos.Sort((x, y) =>
                {
                    int xVal = x.RawClassInfo.IsRefType && x.RawClassInfo.IsStatic ? 1 : 0;
                    int yVal = y.RawClassInfo.IsRefType && y.RawClassInfo.IsStatic ? 1 : 0;
                    if (xVal != yVal)
                    {
                        return xVal > yVal ? -1 : 1;
                    }

                    xVal = x.RawClassInfo.IsRefType && !x.RawClassInfo.IsAbstract ? 1 : 0;
                    yVal = y.RawClassInfo.IsRefType && !y.RawClassInfo.IsAbstract ? 1 : 0;
                    if (xVal != yVal)
                    {
                        return xVal > yVal ? -1 : 1;
                    }

                    xVal = x.RawClassInfo.IsValueType && !x.RawClassInfo.IsEnum ? 1 : 0;
                    yVal = y.RawClassInfo.IsValueType && !y.RawClassInfo.IsEnum ? 1 : 0;
                    if (xVal != yVal)
                    {
                        return xVal > yVal ? -1 : 1;
                    }



                    xVal = x.RawClassInfo.IsValueType && x.RawClassInfo.IsEnum ? 1 : 0;
                    yVal = y.RawClassInfo.IsValueType && y.RawClassInfo.IsEnum ? 1 : 0;
                    if (xVal != yVal)
                    {
                        return xVal > yVal ? -1 : 1;
                    }


                    xVal = x.RawClassInfo.IsAbstract ? 1 : 0;
                    yVal = y.RawClassInfo.IsAbstract ? 1 : 0;
                    if (xVal != yVal)
                    {
                        return xVal > yVal ? -1 : 1;
                    }

                    xVal = x.RawClassInfo.IsInterface ? 1 : 0;
                    yVal = y.RawClassInfo.IsInterface ? 1 : 0;
                    if (xVal != yVal)
                    {
                        return xVal > yVal ? -1 : 1;
                    }

                    xVal = x.RawClassInfo.IsGeneric ? 0 : 1;
                    yVal = y.RawClassInfo.IsGeneric ? 0 : 1;
                    if (xVal != yVal)
                    {
                        return xVal > yVal ? -1 : 1;
                    }

                    return string.Compare(x.RawClassInfo.FullName, y.RawClassInfo.FullName);


                });
                this.CompleteLoadGameClassInfo();
            }
            async ValueTask PLoadJsonFilesAsync(string jsonFile, CancellationToken cancellationToken)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_Cancel, }).ConfigureAwait(false);
                    return;
                }

                FileInfo fileInfo = new(jsonFile);
                await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_SaveClass, MsgObject = fileInfo.Name }).ConfigureAwait(false);

                using var fileStream = fileInfo.OpenRead();
                var jsonDTO = await fileStream.GetClassDetailFromStreamAsync().ConfigureAwait(false);
                if (jsonDTO is not null && jsonDTO.TryGet(out var classDetailDTO))
                {
                    var gameClassInfo = GameClassInfo.FillGameClassInfo(classDetailDTO);
                    await this.WriteLoadGameClassInfoAsync(gameClassInfo).ConfigureAwait(false);
                }

            }

            async Task LoadGameClassInfoTask(CancellationToken cancellationToken)
            {
                await foreach (var gameClassInfo in this.LoadGameClassInfoChannel.Reader.ReadAllAsync().ConfigureAwait(false))
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        await this.WriteNotifyMsgChannelAsync(new GameAnalyzerNotifyMsg() { NotifyCode = EnumGameAnalyzerNotifyCode.Notify_Cancel, });
                        return;
                    }
                    this.GameClassInfos.Add(gameClassInfo);
                }
            }
            ValueTask WriteLoadGameClassInfoAsync(GameClassInfo gameClassInfo)
            {
                return this.LoadGameClassInfoChannel.Writer.WriteAsync(gameClassInfo);
            }
            void CompleteLoadGameClassInfo() => this.LoadGameClassInfoChannel.Writer.Complete();


            ValueTask WriteNotifyMsgChannelAsync(GameAnalyzerNotifyMsg notifyMsg)
            {
                return this.NotifyMsgChannel.Writer.WriteAsync(notifyMsg);
            }
            void CompleteNotifyMsgChannel() => this.NotifyMsgChannel.Writer.Complete();
            async Task ReadNotifyMsgTask(Action<object?> action, TaskScheduler uiScheduler)
            {
                await foreach (var notifyMsg in this.NotifyMsgChannel.Reader.ReadAllAsync().ConfigureAwait(false))
                {
                    //速度过快 卡UI
                    await Task.Delay(10).ConfigureAwait(false);
                    await Task.Factory.StartNew(action, notifyMsg, CancellationToken.None, TaskCreationOptions.DenyChildAttach, uiScheduler).ConfigureAwait(false);
                }
            }
            #endregion

            public async Task LoadJsonFilesAsync(Action<object?> action, string path, TaskScheduler uiScheduler, CancellationToken cancellationToken)
            {
                var loadjsonTask = LoadJsonFileTask(path, cancellationToken);
                var addClassesTask = LoadGameClassInfoTask(cancellationToken);
                var notifyTask = ReadNotifyMsgTask(action, uiScheduler);
                await Task.WhenAll(loadjsonTask, addClassesTask).ConfigureAwait(false);
                this.CompleteNotifyMsgChannel();
                await notifyTask.ConfigureAwait(false);
            }

        }
        #endregion

        public GameClassInfo[] GetSpecialClasses()
        {
            return [.. this.GameClassInfos.Where(p => p.Special).OrderByDescending(p => p.RawClassInfo.IsStatic).ThenBy(p => p.RawClassInfo.FullName)];
        }

        public bool TryFillGameClassInfo(GameClassInfo gameClassInfo)
        {
            var datas = this.GameClassInfos.Where(p => p.RawClassInfo.TypeName == gameClassInfo.RawClassInfo.TypeName);
            Debug.Assert(datas.Count() <= 1);
            var srcClassInfo = datas.FirstOrDefault();
            if (srcClassInfo is not null)
            {
                srcClassInfo.CopyTo(gameClassInfo);
                return true;
            }

            return false;
        }

        public GameOrgClassesInfo SearchOrgClasses(GameClassInfo gameClassInfo)
        {
            var gameOrgClassesInfo = new GameOrgClassesInfo();

            foreach (var detailDTO in this.GameClassInfos)
            {
                if (GameOrgClassesInfo.ExistUseField(gameClassInfo, detailDTO))
                {
                    gameOrgClassesInfo.UseFieldClasses.Add(detailDTO);
                }
                if (GameOrgClassesInfo.ExistRefField(gameClassInfo, detailDTO))
                {
                    gameOrgClassesInfo.RefFieldClasses.Add(detailDTO);
                }
                if (GameOrgClassesInfo.ExistParent(gameClassInfo, detailDTO))
                {
                    gameOrgClassesInfo.ParentClasses.Add(detailDTO);
                }
                if (GameOrgClassesInfo.ExistDerived(gameClassInfo, detailDTO))
                {
                    gameOrgClassesInfo.DerivedClasses.Add(detailDTO);
                }
                if (GameOrgClassesInfo.ExistUseMethod(gameClassInfo, detailDTO))
                {
                    gameOrgClassesInfo.UseMethodClasses.Add(detailDTO);
                }
                if (GameOrgClassesInfo.ExistRefMethod(gameClassInfo, detailDTO))
                {
                    gameOrgClassesInfo.RefMethodClasses.Add(detailDTO);
                }
            }
            return gameOrgClassesInfo;
        }

        public Task<GameOrgClassesInfo> SearchOrgClassesAsync(GameClassInfo gameClassInfo)
        {
            return Task.Run(() => SearchOrgClasses(gameClassInfo));
        }
    }
}
