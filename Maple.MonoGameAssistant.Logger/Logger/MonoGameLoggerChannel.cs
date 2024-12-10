using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Maple.MonoGameAssistant.Logger
{
    public class MonoGameLoggerChannel
    {
        //BlockingCollection<MonoLogData> LogCollection { get; } = new BlockingCollection<MonoLogData>(1024);

        //public bool TryAdd(MonoLogData logData) => LogCollection.TryAdd(logData);
        //public IEnumerable<MonoLogData> ReadAll() => LogCollection.GetConsumingEnumerable();
        //public bool IsCompleted => LogCollection.IsCompleted;
        //public void Completed() => LogCollection.CompleteAdding();

        Channel<MonoLogData> LogChannel { get; } = Channel.CreateUnbounded<MonoLogData>();
        public ValueTask WriteAsync(MonoLogData logData) => LogChannel.Writer.WriteAsync(logData);
        public bool TryWrite(MonoLogData logData)
        {
            return LogChannel.Writer.TryWrite(logData);
        }

        public IAsyncEnumerable<MonoLogData> ReadAllAsync() => LogChannel.Reader.ReadAllAsync();
        public void Complete() => LogChannel.Writer.Complete();

       

    }
}
