using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Windows.HookTask
{
    internal class HookTaskStateException(string msg) : MonoCommonException(msg)
    {

        [DoesNotReturn]
        public static void Throw(string msg) => throw new HookTaskStateException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string msg) => throw new HookTaskStateException(msg);

    }
}
