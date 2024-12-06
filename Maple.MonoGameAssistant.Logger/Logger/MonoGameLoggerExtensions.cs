using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.Logger
{
    public static class MonoGameLoggerExtensions
    {
        internal static ObjectPool<StringBuilder> StringBuilderPool { get; } = new DefaultObjectPoolProvider().CreateStringBuilderPool();

        public static MonoGameLoggerProvider DefaultProvider { get; } = new MonoGameLoggerProvider();

        const string Android_Download = "/sdcard/Download";
        public static IServiceCollection AddMonoGameLogger(this IServiceCollection services)
        {
            services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, MonoGameLoggerProvider>());
            return services;
        }

        public static ILoggingBuilder AddMonoGameLogger(this ILoggingBuilder builder)
        {
            builder.Services.AddMonoGameLogger();
            return builder;
        }

        public static ILoggingBuilder AddSystemFilter(this ILoggingBuilder builder)
        {
            builder.AddFilter("Microsoft", LogLevel.None);
            builder.AddFilter("System", LogLevel.None);
            return builder;
        }

        public static ILoggingBuilder AddOnlyMonoGameLogger(this ILoggingBuilder builder)
        {
            builder.ClearProviders();
            builder.AddSystemFilter();
            builder.AddMonoGameLogger();
            return builder;
        }



        internal static string GetBaseDirectory()
        {

            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
            {
                if (Directory.Exists(Android_Download))
                {
                    return Android_Download;
                }
            }

            var path = Path.Combine(AppContext.BaseDirectory, nameof(MonoGameLogger));
            return Directory.Exists(path) ? path : Directory.CreateDirectory(path).FullName;

        }

        internal static DateTime BuildLogContent(LogLevel logLevel, string content, StringBuilder sb)
        {
            var time = DateTime.Now;
            sb.Clear();
            sb.Append($"{time:yyyy-MM-dd HH:mm:ss.ffff}-");
            sb.Append($"[{Environment.CurrentManagedThreadId:X4}]-");
            sb.Append($"[{logLevel}]-");
            sb.Append(content);
            return time;
        }

        internal static string GetLogFileFullName(string filePath, string category, in DateTime time)
        {
            return Path.Combine(filePath, $"{time:yyyyMMdd_HH}_{category}_{Environment.ProcessId:X4}.log");
        }

        internal static async Task WriteLogFileContentAsync(string logPath, StringBuilder sb)
        {
            var streamWriter = File.AppendText(logPath);
            await using (streamWriter.ConfigureAwait(false))
            {
                foreach (var str in sb.GetChunks())
                {
                    await streamWriter.WriteAsync(str).ConfigureAwait(false);
                }
                await streamWriter.WriteLineAsync().ConfigureAwait(false);
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        internal static void WriteLogFileContent_Lock(string logPath, StringBuilder sb)
        {
            using var streamWriter = File.AppendText(logPath);
            foreach (var str in sb.GetChunks())
            {
                streamWriter.Write(str.Span);
            }
            streamWriter.WriteLine();
        }

        internal static void WriteLogFileContent(string logPath, StringBuilder sb)
        {
            using var streamWriter = File.AppendText(logPath);
            foreach (var str in sb.GetChunks())
            {
                streamWriter.Write(str.Span);
            }
            streamWriter.WriteLine();
        }

    }
}
