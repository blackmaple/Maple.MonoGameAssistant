using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

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

        public MonoGameLogger(string category = nameof(MonoGameLogger))
        {
            Category = category;

            var path = AppContext.BaseDirectory;
            path = Path.Combine(path, nameof(MonoGameLogger));
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            FilePath = path;

        }

        /// <summary>
        /// lock write log msg
        /// </summary>
        /// <param name="message"></param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void LogImp(string message)
        {


            var file = Path.Combine(FilePath, $"{DateTime.Now:yyyyMMdd_HH}_{Category}.log");
            using var stream = File.AppendText(file);
            stream.WriteLine(message);
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void LogImp(StringBuilder sb)
        {
            var file = Path.Combine(FilePath, $"{DateTime.Now:yyyyMMdd_HH}_{Category}.log");
            using var stream = File.AppendText(file);
            foreach (var str in sb.GetChunks())
            {
                stream.Write(str.Span);
            }
            stream.WriteLine();
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
            try
            {
                sb.Append($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffff}-");
                sb.Append($"[{Environment.CurrentManagedThreadId:x4}]-");
                sb.Append($"[{logLevel}]-");
                sb.Append($"[{Category}]-");
                sb.Append($"{formatter(state, exception)}");
                this.LogImp(sb);
            }
            finally
            {
                MonoGameLoggerProvider.StringBuilderPool.Return(sb);
            }
        }
        #endregion

    }
}
