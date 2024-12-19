using System;

namespace Maple.MonoGameAssistant.MetadataModel.ClassMetadata
{
    public class ClassMetadataSettings
    {
        public Memory<byte> Utf8ImageName { get; }
        public Memory<byte> Utf8Namespace { get; }
        public Memory<byte> Utf8ClassName { get; }
        public Memory<byte> Utf8FullName { get; }
    }
}
