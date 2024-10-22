using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameContext;
using Maple.MonoGameAssistant.HotKey;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;
namespace Maple.MonoGameAssistant.MonoDataCollector
{
    internal sealed partial class MonoDataCollectorService(
        ILogger<MonoDataCollectorService> logger,
        MonoRuntimeContext runtimeContext,
        MonoTaskScheduler monoTaskScheduler,
        MonoGameSettings gameSettings,
        HookWinMsgFactory hookWinMsgFactory)
        : GameContextService<MonoDataCollectorContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)
    {

        #region LoadService


        protected sealed override MonoDataCollectorContext LoadGameContext()
           => new(this.RuntimeContext, EnumMonoCollectorTypeVersion.Collector, this.Logger, "202409120900");
        protected sealed override ValueTask LoadGameDataAsync()
        {
            using (this.Logger.Running())
            {
                this.Logger.LogInformation("MonoString:{p}", MonoStringExtensions.GetMonoStringStructLayout());
                this.Logger.LogInformation("MonoArray:{p}", MonoArrayExtensions.GetMonoArrayStructLayout());
                return ValueTask.CompletedTask;
            }
        }
        #endregion






    }

}
