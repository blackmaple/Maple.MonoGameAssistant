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
    public class MonoDefaultLogger : ILogger
    {

        public static ILogger Default { get; } = new MonoDefaultLogger();

        #region Props
        protected string Category { get; }
        protected string FilePath { get; } = MonoGameLoggerExtensions.GetBaseDirectory();

        internal MonoDefaultLogger(string category = nameof(MonoDefaultLogger))
        {
            this.Category = category;
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
        public virtual void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            var sb = MonoGameLoggerExtensions.StringBuilderPool.Get();
            try
            {
                var logTime = MonoGameLoggerExtensions.BuildLogContent(logLevel, formatter(state, exception), sb);
                var logPath = MonoGameLoggerExtensions.GetLogFileFullName(this.FilePath, this.Category, logTime);
                MonoGameLoggerExtensions.WriteLogFileContent_Lock(logPath, sb);
            }
            finally
            {
                MonoGameLoggerExtensions.StringBuilderPool.Return(sb);
            }
        }
        #endregion

    }

}
