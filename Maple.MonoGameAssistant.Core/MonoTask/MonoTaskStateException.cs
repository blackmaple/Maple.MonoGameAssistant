using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Core
{
    internal class MonoTaskStateException(string msg) : MonoCommonException(msg)
    {
        [DoesNotReturn]
        public static void Throw(string msg) => throw new MonoTaskStateException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string msg) => throw new MonoTaskStateException(msg);
    }

}
