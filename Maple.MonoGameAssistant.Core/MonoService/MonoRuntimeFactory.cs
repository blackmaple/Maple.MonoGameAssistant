using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
namespace Maple.MonoGameAssistant.Core
{

    public sealed class MonoRuntimeFactory(ILogger<MonoRuntimeFactory> logger, MonoRuntimeModuleView runtimeModuleView)
    {
        Lock LockObject { get; } = new Lock();

        IMonoRuntiemProvider? MonoRuntimeService { get; set; }
        ILogger Logger { get; } = logger;
        MonoRuntimeApi RuntimeApi { get; } = new MonoRuntimeApi(logger, runtimeModuleView);
        

        public bool CreateMonoRuntime(out EnumMonoRuntimeType runtimeType)
        {
            return this.TryCreateMonoRuntime(out _, out runtimeType);
        }

        public IMonoRuntiemProvider GetProvider()
        {
            return this.MonoRuntimeService
                ?? MonoRuntimeException.Throw<IMonoRuntiemProvider>($"Mono Runtime Type is {this.RuntimeApi.RuntimeType} Not Loaded");
        }

        public bool TryCreateMonoRuntime([MaybeNullWhen(false)] out IMonoRuntiemProvider monoRuntiemProvider, out EnumMonoRuntimeType runtimeType)
         => TryCreateMonoRuntime_Imp(out monoRuntiemProvider, out runtimeType);

        bool TryCreateMonoRuntime_Imp([MaybeNullWhen(false)] out IMonoRuntiemProvider monoRuntiemProvider, out EnumMonoRuntimeType runtimeType)
        {
            lock (LockObject)
            {
                var init = this.RuntimeApi.TryLoadMonoRuntimeApi();
                if (init)
                {
                    this.MonoRuntimeService ??= RuntimeApi.RuntimeType switch
                    {
                        EnumMonoRuntimeType.MONO => GetMonoRuntime_MONO(),
                        EnumMonoRuntimeType.IL2CPP => GetMonoRuntime_IL2CPP(),
                        _ => GetMonoRuntime_ERROR(),
                    };
                }
                monoRuntiemProvider = this.MonoRuntimeService;
                runtimeType = this.RuntimeApi.RuntimeType;
                return init;
            }
        }

        MonoRuntiemProvider_MONO GetMonoRuntime_MONO()
        {

            return new MonoRuntiemProvider_MONO(this.Logger, this.RuntimeApi);
        }

        MonoRuntiemProvider_IL2CPP GetMonoRuntime_IL2CPP()
        {

            return new MonoRuntiemProvider_IL2CPP(this.Logger, this.RuntimeApi);
        }

        IMonoRuntiemProvider GetMonoRuntime_ERROR()
        {
            return MonoRuntimeException.Throw<IMonoRuntiemProvider>($"Mono Runtime Type is {this.RuntimeApi.RuntimeType} Error");
        }


    }
}
