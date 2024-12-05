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
    public sealed class MonoGameLogger(string category = nameof(MonoGameLogger)) : ILogger
    {
        public static ILogger Default { get; } = MonoGameLoggerExtensions.DefaultProvider.CreateLogger(typeof(MonoGameLogger).FullName ?? nameof(MonoGameLogger));

        #region Props
        string Category { get; } = category;
        string FilePath { get; } = MonoGameLoggerExtensions.GetBaseDirectory();
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
            MonoGameLoggerProvider.LogChannel.Writer.TryWrite(
                new MonoLogData()
                {
                    FilePath = this.FilePath,
                    Category = this.Category,
                    LogLevel = logLevel,
                    EventId = eventId,
                    Content = formatter(state, exception)
                });
        }
        #endregion

    }

}
