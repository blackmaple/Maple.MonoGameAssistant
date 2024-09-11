using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UITask
{
    internal class UITaskStateException(string msg) : MonoCommonException(msg)
    {

        [DoesNotReturn]
        public static void Throw(string msg) => throw new UITaskStateException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string msg) => throw new UITaskStateException(msg);

    }
}
