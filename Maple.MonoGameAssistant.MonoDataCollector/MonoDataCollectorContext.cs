using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.MonoDataCollector
{
    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]
    internal partial class MonoDataCollectorContext : MonoCollectorContext
    {
        public MonoDataCollectorContext(MonoRuntimeContext runtimeContext, EnumMonoCollectorTypeVersion typeVersion, ILogger logger, string apiVer = "202407222030") : base(runtimeContext, typeVersion, logger, apiVer)
        {
        }
    }
}
