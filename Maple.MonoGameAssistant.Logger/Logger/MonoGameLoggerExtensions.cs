using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using System.IO;

namespace Maple.MonoGameAssistant.Logger
{
    public static class MonoGameLoggerExtensions
    {
        public static MonoGameLoggerProvider DefaultProvider { get; } = new MonoGameLoggerProvider();

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

        public static bool IsAndroidEnvironment()
             => string.IsNullOrEmpty(Environment.GetEnvironmentVariable(nameof(MonoGameLogger))) == false;

        public static void SetAndroidEnvironment()
        {
            Environment.SetEnvironmentVariable(nameof(MonoGameLogger), nameof(MonoGameLogger));
        }

        public static void SetDefaultEnvironment()
        {
            Environment.SetEnvironmentVariable(nameof(MonoGameLogger), string.Empty);
        }

        public static string GetBaseDirectory()
        {

            return IsAndroidEnvironment() ? "/sdcard/Download" : Path.Combine(AppContext.BaseDirectory, nameof(MonoGameLogger));
        }
    }
}
