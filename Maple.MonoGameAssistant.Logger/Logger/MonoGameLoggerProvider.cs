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
        BlockingCollection<MonoLogData> LogCollection { get; } = new BlockingCollection<MonoLogData>(Environment.ProcessorCount);

        public MonoGameLoggerProvider()
        {
            _ = Task.Factory.StartNew(WriteLog2FileLoopTask, this, TaskCreationOptions.LongRunning);
        }

        static void WriteLog2FileLoopTask(object? obj)
        {
            if (obj is not MonoGameLoggerProvider loggerProvider)
            {
                return;
            }
            var sb = MonoGameLoggerExtensions.StringBuilderPool.Get();
            try
            {
                while (false == loggerProvider.LogCollection.IsCompleted)
                {
                    foreach (var logData in loggerProvider.LogCollection.GetConsumingEnumerable())
                    {
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

        internal void TryWriteLog2Channel(MonoLogData logData)
        {
            this.LogCollection.TryAdd(logData);
        }

        public ILogger CreateLogger(string categoryName) => CreateLoggerImp(categoryName);

        public void Dispose()
        {
            this.LogCollection.CompleteAdding();
            this.CacheLoggers.Clear();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        internal MonoGameLogger CreateLoggerImp(string categoryName) => this.CacheLoggers.GetOrAdd(categoryName, (log) => new(log, this));

    }






}
