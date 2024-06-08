using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.Logger
{
    public static class MonoLoggerExtensions
    {
        public static MonoLoggerProvider DefaultProvider { get; } = new MonoLoggerProvider();

        public static IServiceCollection AddMonoLogger(this IServiceCollection services)
        {
            services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, MonoLoggerProvider>());
            return services;
        }

        public static ILoggingBuilder AddMonoLogger(this ILoggingBuilder builder)
        {
            builder.Services.AddMonoLogger();
            return builder;
        }

        public static ILoggingBuilder AddSystemFilter(this ILoggingBuilder builder)
        {
            builder.AddFilter("Microsoft", LogLevel.None);
            builder.AddFilter("System", LogLevel.None);
            return builder;
        }

        public static ILoggingBuilder AddOnlyMonoLogger(this ILoggingBuilder builder)
        {
            builder.ClearProviders();
            builder.AddSystemFilter();
            builder.AddMonoLogger();
            return builder;
        }
    }
}
