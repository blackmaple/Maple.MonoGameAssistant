using Microsoft.Extensions.Hosting;

namespace Maple.MonoGameAssistant.Logger
{
    public sealed class MonoGameLoggerHostedService(MonoGameLoggerChannel loggerChannel) : BackgroundService
    {
        MonoGameLoggerChannel LoggerChannel { get; } = loggerChannel;

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //return Task.Factory.StartNew(WriteLog2FileLoopTask, this.LoggerChannel, TaskCreationOptions.LongRunning);
            return Task.Run(WriteLog2FileLoopTask, stoppingToken);
        }

        async Task WriteLog2FileLoopTask()
        {
            var sb = MonoGameLoggerExtensions.StringBuilderPool.Get();
            try
            {
                await foreach (var logData in this.LoggerChannel.ReadAllAsync().ConfigureAwait(false))
                {
                    var logTime = MonoGameLoggerExtensions.BuildLogContent(logData.LogLevel, logData.Content, logData.ThreadId, sb);
                    var logPath = MonoGameLoggerExtensions.GetLogFileFullName(logData.FilePath, logData.Category, logTime);
                    await MonoGameLoggerExtensions.WriteLogFileContentAsync(logPath, sb).ConfigureAwait(false);
                }
            }
            finally
            {
                MonoGameLoggerExtensions.StringBuilderPool.Return(sb);
            }
        }



    }
}
