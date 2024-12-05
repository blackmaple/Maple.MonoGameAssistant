using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using Microsoft.Win32.SafeHandles;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.Logger
{

    /// <summary>
    /// 简单的一个日志
    /// </summary>
    public sealed class MonoGameLogger : ILogger
    {
        public static ILogger Default { get; } = MonoGameLoggerExtensions.DefaultProvider.CreateLogger(typeof(MonoGameLogger).FullName ?? nameof(MonoGameLogger));

        #region Imp
        string Category { get; }
        string FilePath { get; }
        Channel<LogData> LogChannel { get; }

        public MonoGameLogger(string category = nameof(MonoGameLogger))
        {
            this.Category = category;
            this.FilePath = MonoGameLoggerExtensions.GetBaseDirectory();
            this.LogChannel = Channel.CreateUnbounded<LogData>();

            _ = Task.Run(ReadLog2FileLoop);
        }

        async Task ReadLog2FileLoop()
        {
            await foreach (var logData in this.LogChannel.Reader.ReadAllAsync().ConfigureAwait(false))
            {
                StringBuilder sb = MonoGameLoggerProvider.StringBuilderPool.Get();
                try
                {
                    var time = DateTime.Now;
                    sb.Append($"{time:yyyy-MM-dd HH:mm:ss.ffff}-");
                    sb.Append($"[{Environment.CurrentManagedThreadId:X4}]-");
                    sb.Append($"[{logData.LogLevel}]-");
                    sb.Append(logData.Content);

                    var logPath = Path.Combine(FilePath, $"{time:yyyyMMdd_HH}_{Category}.log");
                    using var streamWriter = File.AppendText(logPath);
                    foreach (var str in sb.GetChunks())
                    {
                        await streamWriter.WriteAsync(str).ConfigureAwait(false);
                    }
                    await streamWriter.WriteLineAsync().ConfigureAwait(false);
                }
                finally
                {
                    MonoGameLoggerProvider.StringBuilderPool.Return(sb);
                }

            }
        }
        void WritLog2Channel(LogData sb)
        {
            this.LogChannel.Writer.TryWrite(sb);
        }



        #endregion



        #region ILogger

        readonly struct Disposable : IDisposable
        {
            public readonly void Dispose()
            {

            }
        }
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => new Disposable();
        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            this.WritLog2Channel(new LogData() { LogLevel = logLevel, EventId = eventId, Content = formatter(state, exception) });
        }
        #endregion

    }




    class LogData
    {
        public required LogLevel LogLevel { get; set; }
        public required EventId EventId { get; set; }
        public required string Content { set; get; }
    }

}
