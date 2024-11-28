using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using System.IO;

namespace Maple.MonoGameAssistant.Logger
{
    public static class MonoGameLoggerExtensions
    {
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



        public static string GetBaseDirectory()
        {
            if (Directory.Exists(Android_Download))
            {
                return Android_Download;
            }
            var path = Path.Combine(AppContext.BaseDirectory, nameof(MonoGameLogger));
            return Directory.Exists(path) ? path : Directory.CreateDirectory(path).FullName;

        }
    }
}
