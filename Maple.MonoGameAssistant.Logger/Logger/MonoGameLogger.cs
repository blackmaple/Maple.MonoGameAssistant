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
    public sealed class MonoGameLogger(string category, MonoGameLoggerChannel loggerChannel) : MonoDefaultLogger(category), ILogger
    {
        MonoGameLoggerChannel LoggerChannel { get; } = loggerChannel;

        public sealed override void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            this.LoggerChannel.TryAdd(
                new MonoLogData()
                {
                    Category = this.Category,
                    LogLevel = logLevel,
                    Content = formatter(state, exception),
                    EventId = eventId,
                    FilePath = this.FilePath,
                    ThreadId = Environment.CurrentManagedThreadId,
                });
        }
    }

}
