using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public sealed class MetadataException(string? msg) : MonoCommonException(msg)
    {
        [DoesNotReturn]
        public static void Throw(string? msg) => throw new MetadataException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string? msg) => throw new MetadataException(msg);

    }
}
