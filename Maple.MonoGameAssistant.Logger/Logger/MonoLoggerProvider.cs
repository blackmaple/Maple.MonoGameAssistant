using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Text;

namespace Maple.MonoGameAssistant.Logger
{
    /// <summary>
    /// 简单的一个日志构造器
    /// </summary>
    public sealed class MonoLoggerProvider : ILoggerProvider
    {
        internal static ObjectPool<StringBuilder> StringBuilderPool { get; } = new DefaultObjectPoolProvider().CreateStringBuilderPool();

        ConcurrentDictionary<string, MonoLogger> Loggers { get; } = new ConcurrentDictionary<string, MonoLogger>();

        public ILogger CreateLogger(string categoryName) => CreateLoggerImp(categoryName);
        public void Dispose() => Loggers.Clear();

        [MethodImpl(MethodImplOptions.Synchronized)]
        internal MonoLogger CreateLoggerImp(string categoryName) => this.Loggers.GetOrAdd(categoryName, (log) => new(log));

    }
}
