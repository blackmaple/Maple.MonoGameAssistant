using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
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
        internal static ObjectPool<StringBuilder> StringBuilderPool { get; } = new DefaultObjectPoolProvider().CreateStringBuilderPool();
        internal static Channel<MonoLogData> LogChannel { get; } = Channel.CreateUnbounded<MonoLogData>();
        static MonoGameLoggerProvider()
        {
            _ = Task.Run(ReadLog2FileLoop);
        }
        static async Task ReadLog2FileLoop()
        {
            await foreach (var logData in LogChannel.Reader.ReadAllAsync().ConfigureAwait(false))
            {
                StringBuilder sb = StringBuilderPool.Get();
                try
                {
                    var time = WriteLogContent(logData.LogLevel, logData.Content, sb);
                    var logPath = Path.Combine(logData.FilePath, $"{time:yyyyMMdd_HH}_{logData.Category}_{Environment.ProcessId:X4}.log");
                    var streamWriter = File.AppendText(logPath);
                    await using (streamWriter.ConfigureAwait(false))
                    {
                        foreach (var str in sb.GetChunks())
                        {
                            await streamWriter.WriteAsync(str).ConfigureAwait(false);
                        }
                        await streamWriter.WriteLineAsync().ConfigureAwait(false);
                    }

                }
                finally
                {
                    StringBuilderPool.Return(sb);
                }

            }
        }

        public static DateTime WriteLogContent(LogLevel logLevel,string content, StringBuilder sb)
        {
            var time = DateTime.Now;
            sb.Append($"{time:yyyy-MM-dd HH:mm:ss.ffff}-");
            sb.Append($"[{Environment.CurrentManagedThreadId:X4}]-");
            sb.Append($"[{logLevel}]-");
            sb.Append(content);
            return time;
        }



        ConcurrentDictionary<string, MonoGameLogger> Loggers { get; } = new ConcurrentDictionary<string, MonoGameLogger>();
        public ILogger CreateLogger(string categoryName) => CreateLoggerImp(categoryName);
        public void Dispose() => Loggers.Clear();
        [MethodImpl(MethodImplOptions.Synchronized)]
        internal MonoGameLogger CreateLoggerImp(string categoryName) => this.Loggers.GetOrAdd(categoryName, static (log) => new(log));

    }
}
