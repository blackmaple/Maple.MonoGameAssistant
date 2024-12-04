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
        Channel<StringBuilder> LogChannel { get; }

        public MonoGameLogger(string category = nameof(MonoGameLogger))
        {
            this.Category = category;
            this.FilePath = MonoGameLoggerExtensions.GetBaseDirectory();
            this.LogChannel = Channel.CreateBounded<StringBuilder>(new BoundedChannelOptions(Environment.ProcessorCount)
            {
                FullMode = BoundedChannelFullMode.Wait
            });

            _ = Task.Run(ReadLog2FileLoop);
        }

        async Task ReadLog2FileLoop()
        {

            using var safeFileHandleWapper = new SafeFileHandleWapper();
            await foreach (var sb in this.LogChannel.Reader.ReadAllAsync().ConfigureAwait(false))
            {
                try
                {
                    var file = Path.Combine(FilePath, $"{DateTime.Now:yyyyMMdd_HH}_{Category}.log");
                    var lastFileHandle = safeFileHandleWapper.TryGetOrUpdate(file);
                    var fileStream = new FileStream(lastFileHandle, FileAccess.Write);
                    var stream = new StreamWriter(fileStream);
                    foreach (var str in sb.GetChunks())
                    {
                        await stream.WriteAsync(str).ConfigureAwait(false);
                    }
                    await stream.WriteLineAsync().ConfigureAwait(false);
                    await stream.FlushAsync().ConfigureAwait(false);
                }
                finally
                {
                    MonoGameLoggerProvider.StringBuilderPool.Return(sb);
                }

            }


        }
        void WritLog2Channel(StringBuilder sb)
        {
            this.LogChannel.Writer.TryWrite(sb);
        }


        sealed class SafeFileHandleWapper : IDisposable
        {

            SafeFileHandle? LastSafeFileHandle { get; set; }
            string? LastLogFileName { get; set; }


            public void TryCloseHandle()
            {

                var lastHandle = this.LastSafeFileHandle;
                if (lastHandle is null)
                {
                    return;
                }
                this.LastSafeFileHandle = null;
                if (lastHandle.IsInvalid == false)
                {
                    lastHandle.Close();
                }

            }

            public void Dispose()
            {
                this.TryCloseHandle();
            }

            public SafeFileHandle TryGetOrUpdate(string file)
            {
                if (this.LastLogFileName != file)
                {
                    this.LastLogFileName = file;
                    this.TryCloseHandle();
                }

                this.LastSafeFileHandle ??= File.OpenHandle(file, FileMode.Append, FileAccess.Write,FileShare.ReadWrite,FileOptions.RandomAccess);
                return this.LastSafeFileHandle;
            }


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
            StringBuilder sb = MonoGameLoggerProvider.StringBuilderPool.Get();
            sb.Append($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffff}-");
            sb.Append($"[{Environment.CurrentManagedThreadId:X4}]-");
            sb.Append($"[{logLevel}]-");
         //   sb.Append($"[{Category}]-");
            sb.Append($"{formatter(state, exception)}");
            this.WritLog2Channel(sb);
        }
        #endregion

    }
}
