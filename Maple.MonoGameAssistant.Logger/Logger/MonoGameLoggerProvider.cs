using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.Logger
{
    /// <summary>
    /// 简单的一个日志构造器
    /// </summary>
    public sealed class MonoGameLoggerProvider(MonoGameLoggerChannel loggerChannel) : ILoggerProvider
    {

        ConcurrentDictionary<string, MonoGameLogger> CacheLoggers { get; } = new ConcurrentDictionary<string, MonoGameLogger>();
        MonoGameLoggerChannel LoggerChannel { get; } = loggerChannel;


        public ILogger CreateLogger(string categoryName) => CreateLoggerImp(categoryName);

        public void Dispose()
        {
            this.LoggerChannel.Complete();
            this.CacheLoggers.Clear();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        internal MonoGameLogger CreateLoggerImp(string categoryName) => this.CacheLoggers.GetOrAdd(categoryName, (log) => new(log, this.LoggerChannel));

    }






}
