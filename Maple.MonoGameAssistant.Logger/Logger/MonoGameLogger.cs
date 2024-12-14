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
            if (logLevel == LogLevel.Error)
            {
                base.Log(logLevel, eventId, state, exception, formatter);
            }
            else if (MonoGameLoggerExtensions.IsAndroidPlatform )
            {
                //我无法理解 在安卓系统执行这个方法 有操作集合容器添加数据行为 会引发应用崩溃  T_T
                base.Log(logLevel, eventId, state, exception, formatter);
            }
            else
            {
                this.LoggerChannel.TryWrite(new MonoLogData()
                {
                    Category = this.Category,
                    FilePath = this.FilePath,
                    LogLevel = logLevel,
                    Content = formatter(state, exception),
                    ThreadId = Environment.CurrentManagedThreadId
                });
            }

        }



    }

}
