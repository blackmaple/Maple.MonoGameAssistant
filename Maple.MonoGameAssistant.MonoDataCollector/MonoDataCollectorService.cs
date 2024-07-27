using Maple.GameContext;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
namespace Maple.MonoGameAssistant.MonoDataCollector
{
    internal sealed partial class MonoDataCollectorService(
    ILogger<MonoDataCollectorService> logger,
    MonoRuntimeContext runtimeContext,
    MonoGameSettings gameSettings)
    : GameService<MonoDataCollectorContext>(logger, runtimeContext, gameSettings)
    {

        #region LoadService


        protected sealed override MonoDataCollectorContext LoadGameContext()
           => new(this.RuntimeContext, EnumMonoCollectorTypeVersion.Collector, this.Logger);
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
