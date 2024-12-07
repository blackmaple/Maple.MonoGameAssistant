using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.Logger
{
    public class MonoLogData
    {
        public required string FilePath { set; get; }
        public required string Category { set; get; }
        public required LogLevel LogLevel { get; set; }
        public required EventId EventId { get; set; }
        public required string Content { set; get; }
        public required int ThreadId { set; get; }
    }

}
