using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Common
{
    class MapleStopwatchLogger : IDisposable
    {
        public ILogger Logger { get; }
        string Msg { get; }
        long Tick { get; }

        public MapleStopwatchLogger(ILogger logger, [CallerMemberName] string msg = nameof(MapleStopwatchLogger))
        {
            this.Logger = logger;
            this.Msg = msg;
            this.Logger.LogInformation("{msg} {start}", msg, nameof(Stopwatch.Start));
            this.Tick = Stopwatch.GetTimestamp();
        }

        public void Dispose()
        {
            var stopTick = Stopwatch.GetElapsedTime(this.Tick);
            this.Logger.LogInformation("{msg} {stop} {time}ms", this.Msg, nameof(Stopwatch.Stop), stopTick.TotalMilliseconds);
        }
    }

}
