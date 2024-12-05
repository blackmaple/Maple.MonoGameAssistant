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
            var logFileCache = new LogFileCache();
            await using (logFileCache.ConfigureAwait(false))
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

                        var file = Path.Combine(FilePath, $"{time:yyyyMMdd_HH}_{Category}.log");
                        await logFileCache.WriteLogAsync(file, sb).ConfigureAwait(false);
                    }
                    finally
                    {
                        MonoGameLoggerProvider.StringBuilderPool.Return(sb);
                    }

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

    sealed class LogFileCache : IDisposable, IAsyncDisposable
    {

        StreamWriter? LastWriter { get; set; }
        string? LastLogFileName { get; set; }


        public void TryCloseHandle()
        {

            var lastWriter = this.LastWriter;
            if (lastWriter is not null)
            {
                this.LastWriter = null;
                lastWriter.Dispose();
            }


        }
        public ValueTask TryCloseHandleAsync()
        {

            var lastWriter = this.LastWriter;
            if (lastWriter is not null)
            {
                this.LastWriter = null;
                return lastWriter.DisposeAsync();
            }
            return ValueTask.CompletedTask;


        }
        public ValueTask DisposeAsync() => TryCloseHandleAsync();


        public void Dispose() => this.TryCloseHandle();


        public StreamWriter TryGetOrUpdate(string file)
        {
            if (this.LastLogFileName != file)
            {
                this.LastLogFileName = file;
                this.TryCloseHandle();
            }

            this.LastWriter ??= File.AppendText(file);
            return this.LastWriter;
        }

        public async Task WriteLogAsync(string file, StringBuilder sb)
        {
            var lastWriter = this.TryGetOrUpdate(file);
            foreach (var str in sb.GetChunks())
            {
                await lastWriter.WriteAsync(str).ConfigureAwait(false);
            }
            await lastWriter.WriteLineAsync().ConfigureAwait(false);
            await lastWriter.FlushAsync().ConfigureAwait(false);
        }


    }



    class LogData
    {
        public required LogLevel LogLevel { get; set; }
        public required EventId EventId { get; set; }
        public required string Content { set; get; }
    }

}
