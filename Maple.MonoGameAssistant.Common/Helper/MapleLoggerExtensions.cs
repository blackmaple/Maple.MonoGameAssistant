using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.Common
{
    public static class MapleLoggerExtensions
    {
        public static void Info(this ILogger logger, string msg) => logger.LogInformation("{msg}", msg);

        public static void Error(this ILogger logger, string err) => logger.LogError("{err}", err);

        public static void Error(this ILogger logger, Exception ex) => logger.LogError("{err}", ex);

        public static IDisposable Running(this ILogger logger, [CallerMemberName] string msg = nameof(MapleStopwatchLogger))
        {
            return new MapleStopwatchLogger(logger, msg);
        }


        public static void DebugLine(this ILogger logger,
            [CallerFilePath] string file = nameof(MapleStopwatchLogger),
            [CallerMemberName] string msg = nameof(MapleStopwatchLogger),
            [CallerLineNumber] int line = 0)
        { 
        
        }
    }
}
