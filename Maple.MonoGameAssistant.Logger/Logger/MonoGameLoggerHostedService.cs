using Microsoft.Extensions.Hosting;

namespace Maple.MonoGameAssistant.Logger
{
    public sealed class MonoGameLoggerHostedService(MonoGameLoggerChannel loggerChannel) : BackgroundService
    {
        MonoGameLoggerChannel LoggerChannel { get; } = loggerChannel;

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return Task.Factory.StartNew(WriteLog2FileLoopTask, this.LoggerChannel, TaskCreationOptions.LongRunning);
        }

        static void WriteLog2FileLoopTask(object? obj)
        {
            if (obj is not MonoGameLoggerChannel loggerChannel)
            {
                return;
            }
            var sb = MonoGameLoggerExtensions.StringBuilderPool.Get();
            try
            {
                while (false == loggerChannel.IsCompleted)
                {
                    foreach (var logData in loggerChannel.ReadAll())
                    {
                        Thread.SpinWait(1000);
                        var logTime = MonoGameLoggerExtensions.BuildLogContent(logData.LogLevel, logData.Content, sb);
                        var logPath = MonoGameLoggerExtensions.GetLogFileFullName(logData.FilePath, logData.Category, logTime);
                        MonoGameLoggerExtensions.WriteLogFileContent(logPath, sb);
                    }
                }
            }
            finally
            {
                MonoGameLoggerExtensions.StringBuilderPool.Return(sb);
            }
        }


    
    }
}
