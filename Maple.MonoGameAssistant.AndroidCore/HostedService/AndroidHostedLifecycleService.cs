using Maple.MonoGameAssistant.AndroidCore.AndroidTask;
using Maple.MonoGameAssistant.AndroidCore.GameContext;
using Maple.MonoGameAssistant.AndroidJNI;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Channels;
namespace Maple.MonoGameAssistant.AndroidCore
{

    internal class AndroidHostedLifecycleService(ILogger<AndroidHostedLifecycleService> logger, IServiceProvider serviceProvider) : IHostedLifecycleService
    {

        public Task StartAsync(CancellationToken cancellationToken)
        {
            using (logger.Running())
            {
                try
                {
                    var monoRuntimeFactory = serviceProvider.GetRequiredService<MonoRuntimeFactory>();
                    var init = monoRuntimeFactory.CreateMonoRuntime(out var runtimeType);
                    logger.LogInformation("{serviceName}=>{methodName}=>{status}=>{runtimeType}", nameof(AndroidHostedLifecycleService), nameof(StartAsync), init, runtimeType);
                }
                catch (MonoRuntimeException ex)
                {
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(AndroidHostedLifecycleService), nameof(StartAsync), ex.Message);
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(AndroidHostedLifecycleService), nameof(StartAsync), ex);
                }
            }
            return Task.CompletedTask;

        }

        public async Task StartedAsync(CancellationToken cancellationToken)
        {
            using (logger.Running())
            {
                try
                {
                    var gameContextService = serviceProvider.GetRequiredService<IGameContextService>();
                    await gameContextService.StartAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(AndroidHostedLifecycleService), nameof(StartedAsync), ex);
                }
            }

        }

        public Task StartingAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public async Task StoppedAsync(CancellationToken cancellationToken)
        {
            using (logger.Running())
            {
                try
                {
                    var gameContextService = serviceProvider.GetRequiredService<IGameContextService>();
                    await gameContextService.StopAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(AndroidHostedLifecycleService), nameof(StoppedAsync), ex);
                }
            }
        }

        public Task StoppingAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }

    public class GameApiChannelService<TARGS>(
        JavaVirtualMachineContext virtualMachineContext,
        AndroidTaskScheduler androidTaskScheduler,

        MonoCollectorApiService monoCollectorApiService,
        IGameWebApiControllers gameWebApiControllers)
        : IAndroidTaskScheduler<JavaVirtualMachineContext>
        where TARGS : AndroidJniArgs
    {
        public JavaVirtualMachineContext Context { get; } = virtualMachineContext;
        public TaskScheduler AndroidScheduler => androidTaskScheduler;

        public Channel<TARGS> TaskChannel { get; } = Channel.CreateBounded<TARGS>(new BoundedChannelOptions(128)
        {
            FullMode = BoundedChannelFullMode.Wait
        });

        MonoCollectorApiService CollectorApiService { get; } = monoCollectorApiService;
        IGameWebApiControllers WebApiControllers { get; } = gameWebApiControllers;



        public async ValueTask ExecuteLoopAsync(CancellationToken cancellationToken)
        {

            await foreach (var args in this.TaskChannel.Reader.ReadAllAsync(cancellationToken).ConfigureAwait(false))
            {
                var json = await this.AndroidTaskAsync((p, args) => string.Empty, args).ConfigureAwait(false);
                var dto = await this.EnumImages().ConfigureAwait(false);
                await this.AndroidTaskAsync((p, args) => string.Empty, args).ConfigureAwait(false);
                //json 2 object
                //exec api
                //object 2 json
            }
        }

        //private (string action, T dto) GetGameJsonDTO<T>(JniEnvironmentContext jniEnvironmentContext, TARGS args)
        //    where T : class
        //{
        //  var   jniEnvironmentContext.JNI_ENV.ConvertStringUnicode(args.Action);
        //    jniEnvironmentContext.JNI_ENV.GetStringChars(args.Json);
        //}

        public async Task<MonoResultDTO<MonoImageInfoDTO[]>> EnumImages()
        {
            var dto = await this.CollectorApiService.EnumMonoImagesAsync().ConfigureAwait(false);
            return dto.GetOk();
        }


    }
}
