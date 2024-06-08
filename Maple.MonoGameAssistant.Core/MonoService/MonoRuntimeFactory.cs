using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
namespace Maple.MonoGameAssistant.Core
{

    internal class MonoRuntimeFactory(ILoggerFactory loggerFactory)
    {
        IMonoRuntiemProvider? MonoRuntimeService { get; set; }
        MonoRuntimeApi RuntimeApi { get; } = new MonoRuntimeApi(loggerFactory.CreateLogger<MonoRuntimeApi>());



        [MethodImpl(MethodImplOptions.Synchronized)]
        public bool CreateMonoRuntime(out EnumMonoRuntimeType runtimeType)
        {
            var init = this.RuntimeApi.TryLoadMonoRuntimeApi();
            if (init)
            {
                this.MonoRuntimeService ??= RuntimeApi switch
                {
                    { RuntimeType: EnumMonoRuntimeType.MONO } => GetMonoRuntime_MONO(),
                    { RuntimeType: EnumMonoRuntimeType.IL2CPP } => GetMonoRuntime_IL2CPP(),
                    _ => GetMonoRuntime_ERROR(),
                };
            }
            runtimeType = this.RuntimeApi.RuntimeType;
            return init;

            IMonoRuntiemProvider GetMonoRuntime_MONO()
            {
                ILogger logger = loggerFactory.CreateLogger<MonoRuntiemProvider_MONO>();
                return new MonoRuntiemProvider_MONO(logger, this.RuntimeApi);
            }

            IMonoRuntiemProvider GetMonoRuntime_IL2CPP()
            {
                ILogger logger = loggerFactory.CreateLogger<MonoRuntiemProvider_IL2CPP>();
                return new MonoRuntiemProvider_IL2CPP(logger, this.RuntimeApi);
            }

            IMonoRuntiemProvider GetMonoRuntime_ERROR()
            {
                return MonoRuntimeException.Throw<IMonoRuntiemProvider>($"Mono Runtime Type is {this.RuntimeApi.RuntimeType} Error");
            }



        }

        public IMonoRuntiemProvider GetProvider()
        {
            return this.MonoRuntimeService
                ?? MonoRuntimeException.Throw<IMonoRuntiemProvider>($"Mono Runtime Type is {this.RuntimeApi.RuntimeType} Not Loaded");
        }




    }
}
