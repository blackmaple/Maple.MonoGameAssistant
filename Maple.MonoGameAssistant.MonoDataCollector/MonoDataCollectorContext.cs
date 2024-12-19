using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.MonoGameAssistant.MonoDataCollector
{
    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]
    internal partial class MonoDataCollectorContext
    {
        //public MonoDataCollectorContext(MonoRuntimeContext runtimeContext, EnumMonoCollectorTypeVersion typeVersion, ILogger logger, string apiVer = "202407222030") : base(runtimeContext, typeVersion, logger, apiVer)
        //{
        //}
    }
}
