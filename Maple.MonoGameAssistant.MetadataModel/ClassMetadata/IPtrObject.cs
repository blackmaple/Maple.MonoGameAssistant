using System;

namespace Maple.MonoGameAssistant.MetadataModel.ClassMetadata
{
    public interface IPtrObject
    {
        public IntPtr Ptr { get; }
        //    public bool IsNotNull() => Ptr != IntPtr.Zero;
    }

}
