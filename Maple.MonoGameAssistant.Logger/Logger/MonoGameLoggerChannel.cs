using System.Collections.Concurrent;

namespace Maple.MonoGameAssistant.Logger
{
    public class MonoGameLoggerChannel
    {
        BlockingCollection<MonoLogData> LogCollection { get; } = new BlockingCollection<MonoLogData>(1024);

        public bool TryAdd(MonoLogData logData) => LogCollection.TryAdd(logData);
        public IEnumerable<MonoLogData> ReadAll() => LogCollection.GetConsumingEnumerable();
        public bool IsCompleted => LogCollection.IsCompleted;
        public void Completed() => LogCollection.CompleteAdding();

    }
}
