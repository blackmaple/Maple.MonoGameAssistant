using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.Logger
{
    /// <summary>
    /// 简单的一个日志构造器
    /// </summary>
    public sealed class MonoGameLoggerProvider : ILoggerProvider
    {

        ConcurrentDictionary<string, MonoGameLogger> CacheLoggers { get; } = new ConcurrentDictionary<string, MonoGameLogger>();
        Channel<MonoLogData> LogChannel { get; } = Channel.CreateUnbounded<MonoLogData>();

        public MonoGameLoggerProvider()
        {
            _ = Task.Run(WriteLog2FileLoopTask);
        }

        async Task WriteLog2FileLoopTask()
        {
            var sb = MonoGameLoggerExtensions.StringBuilderPool.Get();
            try
            {
                await foreach (var logData in LogChannel.Reader.ReadAllAsync().ConfigureAwait(false))
                {
                    var logTime = MonoGameLoggerExtensions.BuildLogContent(logData.LogLevel, logData.Content, sb);
                    var logPath = MonoGameLoggerExtensions.GetLogFileFullName(logData.FilePath, logData.Category, logTime);
                    await MonoGameLoggerExtensions.WriteLogFileContentAsync(logPath, sb).ConfigureAwait(false);
                }
            }
            finally
            {
                MonoGameLoggerExtensions.StringBuilderPool.Return(sb);
            }
        }

        internal void TryWriteLog2Channel(MonoLogData logData)
        {
            this.LogChannel.Writer.TryWrite(logData);
        }

        public ILogger CreateLogger(string categoryName) => CreateLoggerImp(categoryName);

        public void Dispose()
        {
            this.CacheLoggers.Clear();
            this.LogChannel.Writer.Complete();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        internal MonoGameLogger CreateLoggerImp(string categoryName) => this.CacheLoggers.GetOrAdd(categoryName, (log) => new(log, this));

    }






}
